using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlowTests.ModelTest;
using SpecFlowPages.Pages;
using SpecFlowPages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecFlowTests.AcceptanceTests
{
    [Binding]
    public class LoginSteps : SpecFlowTests.Utils.Start
    {
        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            
        }
        
        [When(@"I fill in the following form")]
        public void WhenIFillInTheFollowingForm(Table table)
        {
            var credentials = table.CreateInstance<Credentials>();
            LoginNavigate.InsertUsername(credentials.Username);
            LoginNavigate.InsertPassword(credentials.Password);
        }
        
        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            LoginNavigate.ClickButtonLogin();
        }
        
        [Then(@"I should be at the home page")]
        public void ThenIShouldBeAtTheHomePage()
        {
            var currentUrl = Driver.Instance.Url;
            Assert.AreEqual(ConstantsUtils.UrlIndex, currentUrl);
        }
    }
}
