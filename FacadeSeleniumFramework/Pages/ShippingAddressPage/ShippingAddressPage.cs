

namespace FacadeSeleniumFramework.Pages.ShippingAddressPage
{
    public class ShippingAddressPage : BasePage<ShippingAddressPageMap, ShippingAddressPageValidator>
    {
        public void ClickProceedButton()
        {
            this.Map.ProceedToPayment.Click();
        }

        public void FillShippingInfo(ClientInfo clientInfo)
        {
            this.Map.FirstName.Clear();
            this.Map.FirstName.SendKeys(clientInfo.FirstName);
        }
    }
}
