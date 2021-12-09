using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskMail.Utils
{
    public static class DriverUtil
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static void OpenUrl(string url)
        {
            Logger.Info($"OpenUrl");
            BrowserFactory.GetDriver().Navigate().GoToUrl(url);
        }

        public static void EndWork()
        {
            Logger.Info($"EndWork");
            BrowserFactory.GetDriver().Quit();
            BrowserFactory.NullDriver();
        }

        public static void SwitchToFrame(string locator)
        {
            BrowserFactory.GetDriver().SwitchTo().Frame(locator);
        }

        public static void SwitchToDefaultContent()
        {
            BrowserFactory.GetDriver().SwitchTo().ParentFrame();
        }
    }
}
