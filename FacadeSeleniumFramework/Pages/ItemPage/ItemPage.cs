
using OpenQA.Selenium.Support.UI;
using System.Threading;
namespace FacadeSeleniumFramework.Pages.ItemPage
{
    public class ItemPage : BasePage<ItemPageMap, ItemPageValidator>
    {
        public ItemPage()
            : base("http://www.prodirectsoccer.com/")
        {
        }

        public void ClickBuyNowButton()
        {
            this.Map.BuyNowButton.Click();
        }

        public void ChooseSize()
        {
            var mySelect = new SelectElement(this.Map.SizeDropDown);
            mySelect.SelectByText("5");
        }
        public void GoToShoppingCart()
        {
            this.Map.Basket.Click();
        }


        public override void Navigate(string part)
        {
            //products/Nike-Team-Training-Ball-Football-Balls-Yellow-Yellow-Purple-61857.aspx?
            base.Navigate(part);
        }
    }
}
