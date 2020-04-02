using Tests.Steps;
using System.Linq;
using TechTalk.SpecFlow;

namespace Tests.Utilities
{
    [Binding]
    public class Hooks : BaseClass
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Chrome"))
            {
                Driver = DriverFactory.InitiateWebDriver(CommonConstants.DriverSettings.ChromeBrowser);
            }
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
