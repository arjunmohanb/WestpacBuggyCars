using OpenQA.Selenium;

namespace SpecFlowProject1.Pages
{
    public class LandingPage
    {
        private IWebDriver _driver;

        #region LOCATORS
        private By registerBtnBy = By.XPath("//a[text()='Register']");
        #endregion

        public LandingPage(IWebDriver driver)
        {
            _driver = driver;
        }


        public bool IsPageLoaded()
        {
            var currentUrl = _driver.Url;

            if (currentUrl.Equals("https://buggy.justtestit.org/"))
                return true;
            else
                return false;
        }

        public void GotoRegiter()
        {
            _driver.FindElement(registerBtnBy).Click();
        }

        public void Load()
        {
            _driver.Navigate().GoToUrl("https://buggy.justtestit.org/");
        }
    }
}
