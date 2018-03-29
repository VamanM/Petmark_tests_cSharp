using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;

namespace Petmark_tests.Utils
{
    public static class UtilsMethods
    {
        public static void WaitElementToBeClickable(IWebElement webelement)
        {
            WebDriverWait wait = new WebDriverWait(BaseClass.Driver, TimeSpan.FromMinutes(1));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(webelement));
        }

        public static void WaitTextToBePresentInElement(IWebElement webelement, string text)
        {
            WebDriverWait wait = new WebDriverWait(BaseClass.Driver, TimeSpan.FromMinutes(1));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.TextToBePresentInElement(webelement, text));
        }

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }



    }
}
