using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace SpecFlowPages.Pages
{
    public class LoginNavigate
    {
        public static void InsertUsername(string username)
        { 
            var specFlowPlusButton = Driver.Instance.FindElement(By.Id("Username"));
            specFlowPlusButton.SendKeys(username);
        }

        public static void InsertPassword(string password)
        {
            var specFlowPlusButton = Driver.Instance.FindElement(By.Id("Password"));
            specFlowPlusButton.SendKeys(password);
        }

        public static void ClickButtonLogin()
        {
            var specFlowClickButton = Driver.Instance.FindElement(By.TagName("Button"));
            specFlowClickButton.Click();
        }
    }
}
