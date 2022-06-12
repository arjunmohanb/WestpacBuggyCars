using OpenQA.Selenium;
using SpecFlowProject1.Pages;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    public sealed class RatingSteps
    {
        private IWebDriver _driver;

        private RatingPage _ratingPage;

        public RatingSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        public readonly ScenarioContext _scenarioContext2;
    }
}
