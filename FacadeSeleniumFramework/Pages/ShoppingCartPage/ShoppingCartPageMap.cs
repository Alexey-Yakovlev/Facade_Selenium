using OpenQA.Selenium;

namespace FacadeSeleniumFramework.Pages.ShoppingCartPage
{
    public class ShoppingCartPageMap : BasePageElementMap
    {
        public IWebElement CheckOut
        {
            get
            {
                return this.browser.FindElement(By.XPath("//a[@class='button']"));
            }
        }
    }
}
