using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowPages;
using SpecFlowPages.Pages;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class Logout : Steps
    {
        [Given(@"Before Log in the web site")]
        public void GivenBeforeLogInTheWebSite(Table table)
        {
            Given("I am at the login page");
            When("I fill in the following form", table);
            When("I click the login button");
            Then("I should be at the home page");
        }
        
        [When(@"I press in user name")]
        public void WhenIPressInUserName()
        {
            NavBarNavigation.ClickUserName();
            
        }
        
        [When(@"I press logout button")]
        public void WhenIPressLogoutButton()
        {
            NavBarNavigation.ClickLogoutButton();
        }
        
        [Then(@"I should be at the login page")]
        public void ThenIShouldBeAtTheLoginPage()
        {
            var currentUrl = Driver.Instance.Url;
            Assert.AreEqual(ConstantsUtils.Url, currentUrl);
        }
    }
}
