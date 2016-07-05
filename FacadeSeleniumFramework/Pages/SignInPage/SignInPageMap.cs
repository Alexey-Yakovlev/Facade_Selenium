using OpenQA.Selenium;

namespace FacadeSeleniumFramework.Pages.SignInPage
{
    public class SignInPageMap : BasePageElementMap
    {
        public IWebElement EmailField
        {
            get
            {
                return this.browser.FindElement(By.XPath("//input[@id='loginemail']"));
            }
        }
        public IWebElement PasswordField
        {
            get
            {
                return this.browser.FindElement(By.XPath("//input[@id='loginpassword']"));
            }
        }
        public IWebElement SignInButton
        {
            get
            {
                return this.browser.FindElement(By.XPath("//button[contains(text(),'Log Me In')]"));
            }
        }
    }
}
