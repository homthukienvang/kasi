using System.Configuration;
using System.Linq;
namespace Extensions
{
    public class GlobalSession
    {
        private static int _fileCount = 5;
        private static long _fileSize = 10000000;
        public static string BaseApiUrl = ConfigurationManager.AppSettings["BaseApiUrl"];
        public static string UpdateUrl = ConfigurationManager.AppSettings["UpdateUrl"];
        public static string Updater = ConfigurationManager.AppSettings["Updater"]??"updater";

        // TTL (theo ngày) cho tệp dữ liệu bài học sau khi được tải về.
        // Why: cho phép cấu hình mà không cần build lại app.
        // Fallback 60 ngày khi key thiếu hoặc giá trị không hợp lệ (<=0).
        public static int DownloadFileTtlByDays = ParseTtlDays(ConfigurationManager.AppSettings["DownloadFileTtlByDays"], 60);

        private static int ParseTtlDays(string raw, int fallback)
        {
            return int.TryParse(raw, out var days) && days > 0 ? days : fallback;
        }

        public static int FileCount
        {
            get
            {
                return _fileCount;
            }
        }

        public static long FileSize
        {
            get
            {
                return _fileSize;
            }
        }
    }
}