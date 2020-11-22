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
                var screenshot = Driver.TakeScreenshot();
                screenshot.SaveAsFile("C:\\Users\\abhishek.kulkarni\\My Folder\\Practice\\PracticeTest\\Tests\\Screenshot\\Screenshot.JPG", ScreenshotImageFormat.Jpeg);


            }
            Driver.Close();
            Driver.Quit();
        }
    }
}
