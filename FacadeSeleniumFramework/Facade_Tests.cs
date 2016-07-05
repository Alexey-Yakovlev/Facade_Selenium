using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FacadeSeleniumFramework
{
    [TestClass]
    public class Facade_Tests
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }

        [TestMethod]
        public void Purchase_Football_Ball()
        {
            string itemUrl = "products/Nike-Team-Training-Ball-Football-Balls-Yellow-Yellow-Purple-61857.aspx?";
            string itemPrice = "£8.00";
            ClientInfo currentClientInfo = new ClientInfo()
            {
                FirstName = "Max Khimiy"
            };
            new PurchaseFacade().ProceedToPayment(itemUrl, itemPrice, currentClientInfo);
        }
    }
}
