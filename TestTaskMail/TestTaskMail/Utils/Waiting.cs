using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskMail.Utils
{
    public static class Waiting
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        private static WebDriverWait WaitDriver;

        public static WebDriverWait GetWaitDriver()
        {
            Logger.Info($"GetWaitDriver");
            if (WaitDriver != null)
                return WaitDriver;
            WaitDriver = new WebDriverWait(BrowserFactory.GetDriver(), TimeSpan.FromSeconds(Config.DefoltTimeout));
            return WaitDriver;
        }

        public static bool ElementIsVisible(By locator)
        {
            Logger.Info($"Checking the visibility of an element with a locator {locator}");
            try
            {
                GetWaitDriver().Until(
                    SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch
            {
                Logger.Error($"Element with locator {locator} not visible");
                return false;
            }
        }

        public static IWebElement GetElement(By locator)
        {
            Logger.Info($"Looking for an element with a locator {locator}");
            try
            {
                return GetWaitDriver()
                    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
            }
            catch
            {
                Logger.Error($"Element with locator {locator} not found");
                return null;
            }
        }

        public static IReadOnlyCollection<IWebElement> GetElements(By locator)
        {
            Logger.Info($"Looking for an elements with a locator {locator}");
            try
            {
                return GetWaitDriver()
                    .Until(x => x.FindElements(locator));
            }
            catch
            {
                Logger.Error($"Elements with locator {locator} not found");
                return new List<IWebElement>();
            }
        }

        public static IAlert GetAlert()
        {
            Logger.Info($"Looking for alert");
            try
            {
                return GetWaitDriver()
                    .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());
            }
            catch
            {
                Logger.Error($"Alert not found");
                return null;
            }
        }

        public static bool TextIsDisplayed(By locator)
        {
            Logger.Info($"Called the method TextIsDisplayed ");
            try
            {
                GetWaitDriver().Until(
                    SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
