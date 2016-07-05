using FacadeSeleniumFramework.Pages.ItemPage;
using FacadeSeleniumFramework.Pages.ShippingAddressPage;
using FacadeSeleniumFramework.Pages.ShoppingCartPage;
using FacadeSeleniumFramework.Pages.SignInPage;
using System;
using System.Linq;


namespace FacadeSeleniumFramework
{
    public class PurchaseFacade
    {
        private ItemPage itemPage;
        private ShippingAddressPage shippingAddressPage;
        private SignInPage signInPage;
        private ShoppingCartPage shoppingCartPage;

        public ItemPage ItemPage 
        {
            get
            {
                if (itemPage == null)
                {
                    itemPage = new ItemPage();
                }
                return itemPage;
            }
        }

        public SignInPage SignInPage
        {
            get
            {
                if (signInPage == null)
                {
                    signInPage = new SignInPage();
                }
                return signInPage;
            }
        }

        public ShippingAddressPage ShippingAddressPage
        {
            get
            {
                if (shippingAddressPage == null)
                {
                    shippingAddressPage = new ShippingAddressPage();
                }
                return shippingAddressPage;
            }
        }

        public ShoppingCartPage ShoppingCartPage
        {
            get
            {
                if (shoppingCartPage == null)
                {
                    shoppingCartPage = new ShoppingCartPage();
                }
                return shoppingCartPage;
            }
        }

        public void ProceedToPayment(string item, string itemPrice, ClientInfo clientInfo)
        {
            this.ItemPage.Navigate(item);
            this.ItemPage.Validate().Price(itemPrice);
            this.ItemPage.ChooseSize();
            this.ItemPage.ClickBuyNowButton();
            this.ItemPage.GoToShoppingCart();
            this.ShoppingCartPage.ClickCheckoutButton();
            this.SignInPage.Login();
            this.ShippingAddressPage.FillShippingInfo(clientInfo);
            this.ShippingAddressPage.ClickProceedButton();
        }
    }
}
