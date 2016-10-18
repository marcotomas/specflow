using SpecFlowPages;
using TechTalk.SpecFlow;

namespace SpecFlowTests.Utils
{
    public class Start : Driver
    {
        [BeforeScenario]
        public void Setup()
        {
           Initialize();
           Instance.Navigate().GoToUrl(BaseAddress);
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
