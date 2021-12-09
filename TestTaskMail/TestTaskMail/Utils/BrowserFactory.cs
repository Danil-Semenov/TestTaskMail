using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskMail.Utils
{
    public static class BrowserFactory
    {
        private static IWebDriver Driver;
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static IWebDriver GetDriver()
        {
            Logger.Info($"GetDriver");
            if (Driver != null)
                return Driver;
            switch (Config.Browser.ToLower())
            {
                case "chrome":
                    var optionChromeDriver = new ChromeOptions();
                    optionChromeDriver.AddArguments($"--lang={Config.Localization}");
                    Driver = new ChromeDriver(optionChromeDriver);
                    Driver.Manage().Window.Maximize();
                    break;
                case "firefox":
                    var optionFirefoxDriver = new FirefoxOptions();
                    optionFirefoxDriver.AddArguments($"--lang={Config.Localization}");
                    Driver = new FirefoxDriver(optionFirefoxDriver);
                    Driver.Manage().Window.Maximize();
                    break;
                default:
                    Logger.Error("Browser not found");
                    throw new ArgumentOutOfRangeException("Browser", "Browser not found");
            }

            return Driver;
        }


        public static void NullDriver()
        {
            Driver = null;
        }
    }
}
