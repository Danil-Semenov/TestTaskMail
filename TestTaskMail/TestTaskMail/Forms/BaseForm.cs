using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestTaskMail.Elements;
using TestTaskMail.Utils;

namespace TestTaskMail.Forms
{
    public abstract class BaseForm
    {
        protected static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        protected BaseElement Element;
        protected string Name;

        protected BaseForm(BaseElement element, string name)
        {
            Element = element;
            Name = name;
        }

        public bool IsDisplayed()
        {
            Logger.Info($"{Name} called the method IsDisplayed ");
            return Element.IsDisplayed();
        }

        public bool PageTextIsDisplayed(string text)
        {
            Logger.Info($"{Name} called the method PageTextIsDisplayed ");
            return Waiting.TextIsDisplayed(By.XPath($"//*[contains(text(),'{text}')]"));
        }

    }
}
