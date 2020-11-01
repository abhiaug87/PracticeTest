using System.IO;

namespace Tests.Utilities
{
    public static class CommonConstants
    {
        public static class DriverSettings
        {
           public static string filepath = Path.GetFileNameWithoutExtension("chromedriver.exe");
            //public static string BinaryLocationChrome = @"C:\Users\abhishek.kulkarni\My Folder\Practice\PracticeTest\Tests\Drivers\chromedriver_win32";
            public static string BinaryLocationChrome = filepath;

            public static string ChromeBrowser = "Chrome";
            public static int DefaultWaitTime = 3000;
        }

        public static class ApplicationSettings
        {
            public static string BaseUrl = "https://au.unleashedsoftware.com/v2/Account/LogOn";
            public static string Url = "https://www.asb.co.nz/";
        }
    }
}
