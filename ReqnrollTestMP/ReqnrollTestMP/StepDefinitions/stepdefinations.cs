using System;
using Reqnroll;
using ReqnrollTestMP.POM;
using ReqnrollTestMP.Helpers;
using Allure.Net.Commons;

namespace ReqnrollTestMP.StepDefinitions
{
    [Binding]
    public class stepdefinations
    {
        [Given("app is launched")]
        public void GivenAppIsLaunched()
        {
           Thread.Sleep(1000);  
        }

        [When("click {string}")]
        public void WhenClick(string aboutPlugin)
        {
        controls.safeClick (aboutPlugin);   
        }
        

        [Then("It should display {string} in {string}")]
        public void ThenItShouldDisplayIn(string body, string p1)
        {
            AboutPlugin.ExecutionInAboutPlugin(body, p1);
        }
        [When("I click on {string}")]
        public void WhenIClickOn(string close)
        {
            controls.safeClick(close);
        }

        [Then("App navigates to {string}")]
        public void ThenAppNavigatesTo(string mainpage)
        {
            throw new PendingStepException();
        }

       
      

        [Then("App should display body under terms and condition on AcceptTermsAndConditions page")]
        public void ThenAppShouldDisplayBodyUnderTermsAndConditionOnAcceptTermsAndConditionsPage()
        {
            throw new PendingStepException();
        }

        [When("Unmark the {string} if marked")]
        public void WhenUnmarkTheIfMarked(string checkbox)
        {
            throw new PendingStepException();
        }

        [Then("App not enables the {string} button")]
        public void ThenAppNotEnablesTheButton(string @continue)
        {
            throw new PendingStepException();
        }

        [When("Mark on the {string}")]
        public void WhenMarkOnThe(string checkbox)
        {
            throw new PendingStepException();
        }

        [When("App enables the {string} button to click")]
        public void WhenAppEnablesTheButtonToClick(string @continue)
        {
            throw new PendingStepException();
        }

       

        [Then("App navigates to the {string}")]
        public void ThenAppNavigatesToThe(string p0)
        {
            throw new PendingStepException();
        }

        [Then("App not having the {string}")]
        public void ThenAppNotHavingThe(string backbutton)
        {
            throw new PendingStepException();
        }

        [Then("I should see  {string}")]
        public void ThenIShouldSee(string p0)
        {
            throw new PendingStepException();
        }

    }
}