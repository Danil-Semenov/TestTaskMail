using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskMail.Elements
{
    public class Button : BaseElement
    {
        public Button(By locator, string name) : base(locator, name)
        {
        }

        public bool IsClickable(string text)
        {
            Logger.Info($"{Name} called the method IsClickable ");
            return FindElement().Enabled;
        }
    }
}
