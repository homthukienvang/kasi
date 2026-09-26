using System;
using System.IO;
using System.Net;
using System.Text;
using Extensions;
using Newtonsoft.Json.Linq;

namespace WebApplication.Helper
{
    /// <summary>
    /// Upload file lên OneDrive qua Microsoft Graph API.
    /// Xác thực bằng App Registration (Client Credentials).
    /// Cấu hình trong Web.config: OneDrive:TenantId, ClientId, ClientSecret, DriveId, FolderPath.
    /// </summary>
    public static class OneDriveHelper
    {
        private const string TokenUrl = "https://login.microsoftonline.com/{0}/oauth2/v2.0/token";
        private const string GraphBase = "https://graph.microsoft.com/v1.0";
        private const int ChunkSize = 5 * 1024 * 1024; // 5MB mỗi chunk

        private static string GetAccessToken()
        {
            var url = string.Format(TokenUrl, GlobalSession.OneDriveTenantId);
            var body = string.Format(
                "client_id={0}&client_secret={1}&scope=https://graph.microsoft.com/.default&grant_type=client_credentials",
                Uri.EscapeDataString(GlobalSession.OneDriveClientId),
                Uri.EscapeDataString(GlobalSession.OneDriveClientSecret));

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                var response = client.UploadString(url, body);
                return JObject.Parse(response)["access_token"].ToString();
            }
        }

        public static string UploadFile(Stream stream, string originalFileName, string contentType)
        {
            var token = GetAccessToken();
            var fileName = DateTime.UtcNow.ToString("yyyy-MM-dd-HH-mm-ss") + "_" + Path.GetFileName(originalFileName);
            var folderPath = GlobalSession.OneDriveFolderPath.Trim('/');
            var uploadSessionUrl = string.Format(
                "{0}/drives/{1}/items/root:/{2}/{3}:/createUploadSession",
                GraphBase, GlobalSession.OneDriveDriveId, folderPath, Uri.EscapeDataString(fileName));

            // Tạo upload session
            var sessionJson = "{\"item\":{\"@microsoft.graph.conflictBehavior\":\"rename\"}}";
            string uploadUrl;
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.Authorization] = "Bearer " + token;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var result = client.UploadString(uploadSessionUrl, "POST", sessionJson);
                uploadUrl = JObject.Parse(result)["uploadUrl"].ToString();
            }

            // Upload file theo từng chunk
            var fileBytes = ReadAllBytes(stream);
            var totalSize = fileBytes.Length;
            string fileId = null;

            for (int offset = 0; offset < totalSize; offset += ChunkSize)
            {
                var length = Math.Min(ChunkSize, totalSize - offset);
                var request = (HttpWebRequest)WebRequest.Create(uploadUrl);
                request.Method = "PUT";
                request.ContentLength = length;
                request.Headers["Content-Range"] = string.Format("bytes {0}-{1}/{2}", offset, offset + length - 1, totalSize);
                request.ContentType = contentType;

                using (var reqStream = request.GetRequestStream())
                    reqStream.Write(fileBytes, offset, length);

                using (var response = (HttpWebResponse)request.GetResponse())
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
                    {
                        var json = JObject.Parse(reader.ReadToEnd());
                        fileId = json["id"]?.ToString();
                    }
                }
            }

            if (fileId == null)
                throw new Exception("OneDrive upload thất bại: không nhận được file ID.");

            // Tạo sharing link public (anonymous, view)
            var createLinkUrl = string.Format("{0}/drives/{1}/items/{2}/createLink", GraphBase, GlobalSession.OneDriveDriveId, fileId);
            var linkBody = "{\"type\":\"view\",\"scope\":\"anonymous\"}";
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.Authorization] = "Bearer " + token;
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                var result = client.UploadString(createLinkUrl, "POST", linkBody);
                var link = JObject.Parse(result)["link"]?["webUrl"]?.ToString();
                if (string.IsNullOrEmpty(link))
                    throw new Exception("OneDrive: không tạo được sharing link.");
                return link;
            }
        }

        private static byte[] ReadAllBytes(Stream stream)
        {
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}
