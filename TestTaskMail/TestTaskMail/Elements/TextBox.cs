using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestTaskMail.Elements
{
    public class TextBox : BaseElement
    {
        public TextBox(By locator, string name) : base(locator, name)
        {
        }

        public void SendText(string text)
        {
            FindElement().SendKeys(text);
        }
    }
}
