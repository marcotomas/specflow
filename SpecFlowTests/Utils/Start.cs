using SpecFlowPages;
using SpecResults;
using SpecResults.Json;
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
            Reporters.FixedRunTime = System.DateTime.MinValue;
            Reporters.Add(new JsonReporter());
            ApprovalTests.IntializeApprovalTests();
        }

        [AfterScenario]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}
