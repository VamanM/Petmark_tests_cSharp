using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using Petmark_tests.Utils;
using System;
using System.Threading;

namespace Petmark_tests.Pages
{
    public class KFIPage
    {
        public KFIPage(RemoteWebDriver driver) => BaseClass.Driver = driver;

        private IWebElement KFITitlePage => BaseClass.Driver.FindElementById("");
        private IWebElement NumbersOfApplicants(int Number) => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement FirstNameField => BaseClass.Driver.FindElementById("");
        private IWebElement SurnameField => BaseClass.Driver.FindElementById("");
        private IWebElement ResidentialMortgage => BaseClass.Driver.FindElementById("");
        private IWebElement BuyToLetMortgage => BaseClass.Driver.FindElementById("");
        private IWebElement PurchaseMortgage => BaseClass.Driver.FindElementById("");
        private IWebElement RemortgageMortgage => BaseClass.Driver.FindElementById("");
        private IWebElement LocationDropDown => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement ServiceProvidedDropDown => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement ServiceProvidedFirstOption => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement ContinueButton => BaseClass.Driver.FindElementByClassName("");
        private IWebElement KFIMainPageTittle => BaseClass.Driver.FindElementById("");
        private IWebElement PurchasePrice => BaseClass.Driver.FindElementByClassName("");
        //private IWebElement ConcessionaryPriceYes => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement ConcessionaryPriceNo => BaseClass.Driver.FindElementByCssSelector("");
        //private IWebElement TrueMarketValue => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement ProductTypeRB => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement ProductCodeRB => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement ProductCodeLable => BaseClass.Driver.FindElementById("");
        private IWebElement ProductTypeDDL => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement ProductNameDDL => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement AmountToBorrow => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement YearsForBorrow => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement MonthsBorrow => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement RepaymentType => BaseClass.Driver.FindElementByCssSelector("");
        //private IWebElement InterestAmount => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement FeesSection => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement MortgageValuationReport => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement SubmittingViaAMortgageClub => BaseClass.Driver.FindElementByCssSelector("");
        private IWebElement TotalFees => BaseClass.Driver.FindElementByCssSelector("");


        private void SelectNumbersOfApplicants(String Number)
        {
            UtilsMethods.WaitTextToBePresentInElement(KFITitlePage, "");
            NumbersOfApplicants(Convert.ToInt32(Number)).Click();
        }

        private void AddFirstName() => FirstNameField.SendKeys(UtilsMethods.RandomString(10));
        private void AddSurname() => SurnameField.SendKeys(UtilsMethods.RandomString(10));

        private void SelectMortgageType(String MortgageType)
        {
            if (MortgageType == "")
                ResidentialMortgage.Click();
            else if (MortgageType == "")
                BuyToLetMortgage.Click();
        }

        private void SelectPurchaseOrRemortgage(String PurchaseOrRemortgage)
        {
            if (PurchaseOrRemortgage == "")
                PurchaseMortgage.Click();
            else if (PurchaseOrRemortgage == "")
                RemortgageMortgage.Click();
        }

        private void AddLocation() => LocationDropDown.SendKeys("");

        private void AddServiceProvided()
        {
            ServiceProvidedDropDown.Click();
            Thread.Sleep(500);
            ServiceProvidedFirstOption.Click();
        }

        private void ClickContinueButton() => ContinueButton.Click();
        private void AddPurchasePrice(String Price)
        {
            UtilsMethods.WaitTextToBePresentInElement(KFIMainPageTittle, "");
            PurchasePrice.SendKeys(Price);
        }

        private void SelectConcessionaryPriceOption() => ConcessionaryPriceNo.Click();

        private void SelectProductType()
        {
            Thread.Sleep(1000);
            ProductCodeRB.Click();
            ProductCodeLable.SendKeys("Test1");
        }

        private void InsertAmountToBorrow(String ReportType) => AmountToBorrow.SendKeys(ReportType);
        private void InsertYearsForBorrow(String ReportType) => YearsForBorrow.SendKeys(ReportType);
        private void InsertMonthsBorrow(String ReportType) => MonthsBorrow.SendKeys(ReportType);
        private void SelectRepaymentType(String ReportType) => RepaymentType.SendKeys(ReportType);
        private void ClickFeesSection() => FeesSection.Click();
        private void SelectMortgageValuationReportType(String ReportType) => MortgageValuationReport.SendKeys(ReportType);
        private void SelectMortgageClub(String Respose) => SubmittingViaAMortgageClub.SendKeys(Respose);
        private void InsertTotalFees(String TotalFees) => SubmittingViaAMortgageClub.SendKeys(TotalFees);




        public void KFIBuilder(String ApplicantsNumber, String MortgageType, String PurchaseOrRemortgage, String Price, String AmountToBorrow, String YearsForBorrow, String MonthsBorrow, String RepaymentType, String ReportType, String MortgageClubResponse, String TotalFees)
        {
            SelectNumbersOfApplicants(ApplicantsNumber);
            AddFirstName();
            AddSurname();
            SelectMortgageType(MortgageType);
            SelectPurchaseOrRemortgage(PurchaseOrRemortgage);
            AddLocation();
            AddServiceProvided();
            ClickContinueButton();
            AddPurchasePrice(Price);
            SelectConcessionaryPriceOption();
            SelectProductType();
            InsertAmountToBorrow(AmountToBorrow);
            InsertYearsForBorrow(YearsForBorrow);
            InsertMonthsBorrow(MonthsBorrow);
            SelectRepaymentType(RepaymentType);
            ClickFeesSection();
            SelectMortgageValuationReportType(ReportType);
            SelectMortgageClub(MortgageClubResponse);
            InsertTotalFees(TotalFees);
        }

        //public void KFIBuilder(String ApplicantsNumber, String FirstName, String Surname, String MortgageType, String PurchaseOrRemortgage, String Location, String ServiceProvided, String Price, String Option, String TypeOrCode, String ProductType, String ProductName)
        //{
        //    KFIBuilder(ApplicantsNumber, FirstName, Surname, MortgageType, PurchaseOrRemortgage, Location, ServiceProvided, Price, Option);
        //    SelectProductType(TypeOrCode, ProductType, ProductName);
        //}
        //public void KFIBuilder(String ApplicantsNumber, String FirstName, String Surname, String MortgageType, String PurchaseOrRemortgage, String Location, String ServiceProvided, String Price, String Option, String TypeOrCode, String Code)
        //{
        //    KFIBuilder(ApplicantsNumber, FirstName, Surname, MortgageType, PurchaseOrRemortgage, Location, ServiceProvided, Price, Option);
        //    SelectProductType(TypeOrCode, Code);
        //}






    }
}
