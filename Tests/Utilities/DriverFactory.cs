﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Tests.Utilities
{
    public class DriverFactory
    {
        public static IWebDriver InitiateWebDriver(string browser)
        {
            IWebDriver driver = null;
            if (browser.Equals(CommonConstants.DriverSettings.ChromeBrowser))
            {
                driver = new ChromeDriver(CommonConstants.DriverSettings.BinaryLocationChrome);
            }

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(CommonConstants.DriverSettings.DefaultWaitTime);
            driver.Manage().Window.Maximize();
            return driver;
        }

    }
}
