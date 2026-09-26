using Newtonsoft.Json;
namespace DXWindows.Helper
{
    public static class StringExtension
    {
        public static T Cast<T>(this string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
