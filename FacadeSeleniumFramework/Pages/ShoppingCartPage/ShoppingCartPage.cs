
namespace FacadeSeleniumFramework.Pages.ShoppingCartPage
{
    public class ShoppingCartPage : BasePage<ShoppingCartPageMap, ShoppingCartPageValidator>
    {
        public void ClickCheckoutButton()
        {
            this.Map.CheckOut.Click();
        }
    }
}
