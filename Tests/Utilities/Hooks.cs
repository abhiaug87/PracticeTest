using Tests.Steps;
using System.Linq;
using TechTalk.SpecFlow;
using System;
using System.Drawing.Imaging;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System.IO;
using System.Diagnostics;
using System.Drawing;

namespace Tests.Utilities
{
    [Binding]
    public class Hooks : BaseClass
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Chrome"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.ChromeBrowser);
            }
        }

    [AfterScenario]
        public void AfterScenario()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string pathfile = Path.Combine(TestContext.CurrentContext.WorkDirectory + @"\\Screenshot", "Screenshot.JPG" +"_" +
                      DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)"));
                var screenshot = Driver.TakeScreenshot();
                screenshot.SaveAsFile(pathfile, ScreenshotImageFormat.Jpeg);
            }
            Driver.Close();
            Driver.Quit();
        }
    }
}
