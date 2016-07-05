using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace FacadeSeleniumFramework.Pages.ItemPage
{
    public class ItemPageValidator : BasePageValidator<ItemPageMap>
    {
        public void Price(string expectedPrice)
        {
            //5 000 грн.
            Assert.AreEqual<string>(expectedPrice, this.Map.Price.Text);
        }
    }
}
