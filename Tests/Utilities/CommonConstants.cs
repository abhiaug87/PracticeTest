using NUnit.Framework;
using System.IO;

namespace Tests.Utilities
{
    public static class CommonConstants
    {
        public static class DriverSettings
        {
            public static string filepath = Path.GetFileNameWithoutExtension("chromedriver.exe"); // Copy the chromedriver folder from git & pasteit under "C:\Users\yourusername\AppData\Local\Temp" for the web browser to initiate
            //public static string BinaryLocationChrome = @"C:\Users\abhishek.kulkarni\AppData\Local\Temp";
            public static string BinaryLocationChrome = filepath;

            public static string ChromeBrowser = "Chrome";
            public static int DefaultWaitTime = 3000;
        }

        public class ApplicationSettings
        {
            public static string BaseUrl = "https://au.unleashedsoftware.com/v2/Account/LogOn";
            public static string Url = "https://www.asb.co.nz/";
            public static string XS = "https://subscription1.xero-test.com/subscription/list";
        }
    }
}
