using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using TestTaskMail.Elements;

namespace TestTaskMail.Forms
{
    public class LoginPage : BaseForm

    {
        private static Logo MailLogo => new Logo(By.XPath("//div[@id='mailbox']"), "MailLogo");
        private static TextBox LoginTextBox => new TextBox(By.XPath("//input[contains(@class,'email-input')]"), "LoginTextBox");
        private static TextBox PasswordTextBox => new TextBox(By.XPath("//input[contains(@class,'password-input')]"), "PasswordTextBox");
        private static Button LoginButton => new Button(By.XPath("//button[contains(@data-testid,'password')]"), "LoginButton");
        public LoginPage() : base(MailLogo, "LoginPage") { }
        public void Login(string login,string password)
        {
            LoginTextBox.SendText(login);
            LoginButton.Click();
            PasswordTextBox.SendText(password);
            LoginButton.Click();
        }
    }
}
