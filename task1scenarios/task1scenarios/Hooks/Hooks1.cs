using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using task1scenarios.Drivers;
using TechTalk.SpecFlow;

namespace task1scenarios.Hooks
{
    [Binding]
    public class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            var options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("deviceName", "google pixel");
            options.AddAdditionalCapability("platformVersion", "15");
            options.AddAdditionalCapability("udid", "2C161FDH200BEZ");
            options.AddAdditionalCapability("app", "C:\\Users\\iray\\Downloads\\TestMultiplePlugin.apk");
            options.AddAdditionalCapability("uiautomator2ServerInstallTimeout", 180000);
            driver.Driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), options);
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
    }
}