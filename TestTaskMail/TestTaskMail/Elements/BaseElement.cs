using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestTaskMail.Utils;

namespace TestTaskMail.Elements
{
    public abstract class BaseElement
    {
        protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        protected By Locator;
        protected string Name;

        protected BaseElement(By locator, string name)
        {
            Locator = locator;
            Name = name;
        }

        protected IWebElement FindElement()
        {
            Logger.Info($"{Name} called the method FindElement ");
            return Waiting.GetElement(Locator);
        }

        protected IReadOnlyCollection<IWebElement> FindElements()
        {
            Logger.Info($"{Name} called the method FindElement ");
            return Waiting.GetElements(Locator);
        }


        public void Click()
        {
            Logger.Info($"{Name} called the method Click ");
            FindElement().Click();
        }

        public bool IsDisplayed()
        {
            Logger.Info($"{Name} called the method IsDisplayed ");
            return FindElements().Count > 0;
        }

        public string GetAttribute(string attribute)
        {
            Logger.Info($"{Name} called the method GetAttribute ");
            return FindElement().GetAttribute(attribute);
        }

        public void ClearContent()
        {
            Logger.Info($"{Name} called the method ClearContent ");
            FindElement().Clear();
        }

        public string GetText()
        {
            Logger.Info($"{Name} called the method GetText ");
            return FindElement().Text;
        }
    }
}
