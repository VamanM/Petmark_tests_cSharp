using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Petmark_tests.Pages
{
    public class LoginPage
    {
        public LoginPage(RemoteWebDriver driver) => BaseClass.Driver = driver;

        private IWebElement UsernameField => BaseClass.Driver.FindElementById("");
        private IWebElement PasswordField => BaseClass.Driver.FindElementById("");
        private IWebElement LoginButton => BaseClass.Driver.FindElementById("");
        private IWebElement SuccesLoginMessage => BaseClass.Driver.FindElementById("");
        private IWebElement ErrorLoginMessage => BaseClass.Driver.FindElementById("");

        public void Login(string username, string password)
        {
            UsernameField.SendKeys(username);
            PasswordField.SendKeys(password);
            LoginButton.Click();
        }

        public string GetSuccesLoginMessage()
        {
            return SuccesLoginMessage.GetAttribute("");
        }

        public string GetErrorLoginMessage() => ErrorLoginMessage.Text;
    }
}
