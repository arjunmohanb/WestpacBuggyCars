using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Pages
{
    [Binding]
    public sealed class RatingPage
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public RatingPage(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

            [Given(@"the user is in MAKE page")]
            public void GivenTheUserIsInMAKEPage()
            {
                ScenarioContext.Current.Pending();
            }

            [Given(@"the user is logged in")]
            public void GivenTheUserIsLoggedIn()
            {
                ScenarioContext.Current.Pending();
            }

            [When(@"the user add a comment and press vote")]
            public void WhenTheUserAddACommentAndPressVote()
            {
                ScenarioContext.Current.Pending();
            }

            [Then(@"the comment should be displayed")]
            public void ThenTheCommentShouldBeDisplayed()
            {
                ScenarioContext.Current.Pending();
            }

            [Then(@"the vote count should be updated")]
            public void ThenTheVoteCountShouldBeUpdated()
            {
                ScenarioContext.Current.Pending();
            }

        }
    }
