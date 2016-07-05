using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace FacadeSeleniumFramework.Pages.ShippingAddressPage
{
    public class ShippingAddressPageMap : BasePageElementMap
    {
   
        public IWebElement FirstName
        {
            get
            {
                this.WaitForBillingAddress();
                return this.browser.FindElement(By.XPath("//input[@id='myName']"));
            }
        }

        public IWebElement ProceedToPayment
        {
            get
            {
                return this.browser.FindElement(By.XPath("//button[text()='Proceed to Payment']"));
            }
        }

        private void WaitForBillingAddress()
        {
            this.browserWait.Until<IWebElement>((d) => { return d.FindElement(By.XPath("//h2[contains(text(),'Billing Address')]")); });
        }
    }
}
