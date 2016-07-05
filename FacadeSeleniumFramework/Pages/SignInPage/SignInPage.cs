namespace FacadeSeleniumFramework.Pages.SignInPage
{
    public class SignInPage : BasePage<SignInPageMap, SignInPageValidator>
    {
        public void Login()
        {
            this.Map.EmailField.SendKeys("fringsmax1@gmail.com");
            this.Map.PasswordField.SendKeys("200789");
            this.Map.SignInButton.Click();
        }
    }
}
