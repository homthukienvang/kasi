using Model;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace DXWindows
{
    public static class Globals
    {
        // parameterless constructor required for static class
        static Globals() { } // default value

        // public get, and private set for strict access control
        public static Client Userlogin { get; private set; }

        // GlobalInt can be changed only via this method
        public static void SetUserlogin(Client user)
        {
            Userlogin = user;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");
            Application.Run(new frmLogin());
        }

        //// FOR TEST PLAY HTML FILE
        //[STAThread]
        //static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);

        //    // Create a minimal test Lesson so frmViewWeb_Load can use LessonId and Name
        //    var testLesson = new Lesson { LessonId = 1, Name = "Test Lesson" };

        //    // Set FilePath (and optionally FolderPath, AllowPrint) before showing the form
        //    var frm = new frmViewWeb
        //    {
        //        FilePath = @"C:\Users\Administrator\Downloads\Telegram Desktop\Nông trại thông minh V8\STEMPLUS-Nong-trai-thong-minh-V2-HTML5-v8.html",
        //        FolderPath = @"C:\Users\Administrator\Downloads\Telegram Desktop\Nông trại thông minh V8",
        //        CurrentLesson = testLesson,
        //        AllowPrint = false
        //    };
        //    frm.Show();

        //    Application.Run(frm);
        //}
    }
}