using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecFlowProject1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;

        private RegisterPage _registerPage;
        private LandingPage _landingPage;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext["driver"] as IWebDriver;
            _registerPage = new RegisterPage(_driver);
            _landingPage = new LandingPage(_driver);
        }

        [Given(@"User in the registration page")]
        public void GivenUserInTheRegistrationPage()
        {
            //1. Navigate launch site
            _landingPage.Load();

            //2. Click on registration button
            _landingPage.GotoRegiter();

            //3. check whteher i am in register page
            Assert.IsTrue(_registerPage.IsPageLoaded(), message: "[ERROR] User not in registation page"); 

            //4. register
            _registerPage.Register(loginName: "arjun", firstName: "Arjun", lastName: "Mohan", password: "arjun@123", confirmPassword: "arjun@123");
        }


        

        [When(@"User register")]
        public void WhenUserRegister()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"User should able to login the system")]
        public void ThenUserShouldAbleToLoginTheSystem()
        {
            //ScenarioContext.Current.Pending();
        }


        [Then(@"User registration should be successful")]
        public void ThenUserRegistrationShouldBeSuccessful()
        {
            bool isSuccess = _registerPage.IsRegirationSuccess();
            Assert.IsTrue(isSuccess, message: "[ERROR] Registration not success");
        }

    }
}
