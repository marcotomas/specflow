using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SpecFlowPages.Pages
{
    public class NavBarNavigation
    {
        public static void ClickUserName()
        {
           
            var specFlowClickButton = Driver.Instance.FindElement(By.Id("userMenuDropdown"));
            specFlowClickButton.Click();
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(3000));
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy((By.Id("logoutForm"))));

        }

        public static void ClickLogoutButton()
        {
           
            var specFlowClickButton = Driver.Instance.FindElement(By.Id("logoutForm"));
            specFlowClickButton.Click();
        }
    }
}
