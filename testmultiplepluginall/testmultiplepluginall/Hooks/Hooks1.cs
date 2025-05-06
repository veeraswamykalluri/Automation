using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using testmultiplepluginall.Utility;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Appium.Service.Options;
using OpenQA.Selenium.Appium.Service;
using testmultiplepluginall.Hooks;

namespace testmultiplepluginall.Hooks
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario()]
        public void start()
        {
            setup.StartAppiumServer();
           
        }
       

            //[BeforeScenario(Order = 1)]
            //public void FirstBeforeScenario()
            //{
            //    Example of ordering the execution of hooks
            //    See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
            //}

            [AfterScenario]
            public void AfterScenario()
            {
                driver.Driver.Quit();
            
                //TODO: implement logic that has to run after executing each scenario
            }
        [AfterTestRun]
        public static void TearDown()
        {
            setup.StopAppiumServer();
        }

    }
}
