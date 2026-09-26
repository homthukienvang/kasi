using System.Reflection;
using System.Windows.Forms;

namespace DXWindows.Helper
{
    public static class AppConstants
    {
        public const string TeamViewPath = "https://www.ultraviewer.net/vi/download.html";

        public static readonly string ProcessToEnd = Assembly.GetExecutingAssembly().GetName().Name;
        public static readonly string PostProcess = Application.StartupPath + @"\" + ProcessToEnd + ".exe";
    }
}
