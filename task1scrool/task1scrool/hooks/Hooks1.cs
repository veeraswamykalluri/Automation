using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using task1scrool.Drivers;
using TechTalk.SpecFlow;

namespace task1scrool.hooks
{
    [Binding]
    public sealed class Hooks1
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
            var appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("platformName", "Android");

            appOptions.AddAdditionalCapability("deviceName", "google pixel");
            appOptions.AddAdditionalCapability("platformVersion", "15");
            appOptions.AddAdditionalCapability("udid", "2C161FDH200BEZ");
            appOptions.AddAdditionalCapability("app", "C:\\Users\\iray\\Downloads\\TestMultiplePlugins.apk");
            appOptions.AddAdditionalCapability("uiautomator2ServerInstallTimeout", 180000);
            //  appOptions.AddAdditionalCapability("automationName", "UiAutomator2");
            // appOptions.AddAdditionalCapability("newCommandTimeout", 300);
            //  appOptions.AddAdditionalCapability("appium:host", "http://localhost:4723");


            Driver.driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), appOptions);
        }

       

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.driver.Dispose();
        }
    }
}