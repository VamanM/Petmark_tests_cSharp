using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;

namespace Petmark_tests
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE,
        Safari,
        Opera
    }

    [TestFixture]
    public class BaseClass
    {
        public static RemoteWebDriver Driver { get; set; }

        private BrowserType _browserType;
        public BaseClass(BrowserType browser) => _browserType = browser;

        [SetUp]
        public void Initialize()
        {
            ChooseDriverInstance(_browserType);
            Driver.Manage().Window.Maximize(); // Maximizes Browser
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60); // Set implicit wait timeouts to 20 secs
        }

        [TearDown]
        public void Cleanup()
        {
            Driver?.Quit();
        }

        private void ChooseDriverInstance(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    // With the block code below we can run the test in chrome headless(without UI view) for more performance
                    //ChromeOptions option = new ChromeOptions();
                    //option.AddArgument("--headless");
                    //driver = new ChromeDriver(option);
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.IE:
                    Driver = new InternetExplorerDriver();
                    break;
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver();
                    break;
                case BrowserType.Safari:
                    Driver = new SafariDriver();
                    break;
                case BrowserType.Opera:
                    Driver = new OperaDriver();
                    break;
            }
        }
    }
}
