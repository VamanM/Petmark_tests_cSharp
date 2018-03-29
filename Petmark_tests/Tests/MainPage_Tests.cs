using NUnit.Framework;
using Petmark_tests.Pages;
using Petmark_tests.ParametersFiles;
using System.Threading;

namespace Petmark_tests.Tests
{
    [TestFixture]
    class MainPage_Tests : BaseClass
    {
        public MainPage_Tests() : base(BrowserType.Chrome) { }

        [Test]
        public void SuccessfulLogin()
        {
            Driver.Url = HostName.Address;
            LoginPage login = new LoginPage(Driver);
            HomePage homePage = new HomePage(Driver);
            KFIPage kfiPage = new KFIPage(Driver);
            Thread.Sleep(10000);
        }
    }
}
