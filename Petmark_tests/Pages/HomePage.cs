using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Petmark_tests.Pages
{
    public class HomePage
    {
        public HomePage(RemoteWebDriver driver) => BaseClass.Driver = driver;

        private IWebElement KFIButton => BaseClass.Driver.FindElementById("createKFI");
        private IWebElement AiPButton => BaseClass.Driver.FindElementById("createAiP");
        private IWebElement FullAppButton => BaseClass.Driver.FindElementById("createApp");

        public void CreateKFI() => KFIButton.Click();
        public void CreateAiP() => AiPButton.Click();
        public void CreateFullApp() => FullAppButton.Click();

    }
}
