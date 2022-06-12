using OpenQA.Selenium;

namespace SpecFlowProject1.Pages
{
    public class RegisterPage
    {
        private IWebDriver _driver;

        #region LOCATORS
        private By usernameFieldBy = By.Id("username");
        private By firstNameFieldBy = By.Id("firstName");
        private By lastNameFieldBy = By.Id("lastName");
        private By passwordFieldBy = By.Id("password");
        private By confirmPasswordFieldBy = By.Id("confirmPassword");
        private By registerBtnBy = By.Id("confirmPassword");
        #endregion

        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;
        }


        public bool IsPageLoaded()
        {
            var currentUrl = _driver.Url;

            if (currentUrl.Contains("/register"))
                return true;
            else
                return false;
        }

        public void Register(string loginName, string firstName, string lastName, string password, string confirmPassword)
        {
            //4.1 Enter login
            _driver.FindElement(usernameFieldBy).SendKeys(loginName);
            //4.2 Enter first name
            _driver.FindElement(firstNameFieldBy).SendKeys(firstName);
            //4.3 Enter last name
            _driver.FindElement(lastNameFieldBy).SendKeys(lastName);
            //4.4 Enter password
            _driver.FindElement(passwordFieldBy).SendKeys(password);
            //4.5 Confirm password
            _driver.FindElement(confirmPasswordFieldBy).SendKeys(confirmPassword);
            //4.6 Click register button
            _driver.FindElement(registerBtnBy).Click();
        }

        public bool IsRegirationSuccess()
        {
            var currentUrl = _driver.Url;

            if (currentUrl.Contains("/register"))
                return true;
            else
                return false;
        }
    }
}
