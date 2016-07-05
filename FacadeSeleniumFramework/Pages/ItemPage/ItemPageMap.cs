using OpenQA.Selenium;

namespace FacadeSeleniumFramework.Pages.ItemPage
{
    public class ItemPageMap : BasePageElementMap
    {
        public IWebElement BuyNowButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//button[@class='button buy-online']"));
            }
        }

        public IWebElement SizeDropDown
        {
            get
            {
                return this.browser.FindElement(By.Id("size"));
            }
        }

        public IWebElement Price
        {
            get
            {
                return this.browser.FindElement(By.ClassName("price"));
            }
        }

        public IWebElement Basket
        {
            get
            {
                return this.browser.FindElement(By.ClassName("basket-price"));
            }
        }
    }
}
