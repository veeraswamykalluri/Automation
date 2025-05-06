using OpenQA.Selenium.Appium.Service.Options;
using OpenQA.Selenium.Appium.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;
using testmultiplepluginall.Utility;

namespace testmultiplepluginall.Hooks
{
    public class setup
    {

        private static AppiumLocalService appiumService;

        public static void StartAppiumServer()
        {
            if (appiumService == null || !appiumService.IsRunning)
            {
                var options = new OptionCollector()
                .AddArguments(new KeyValuePair<string, string>("--log-level", "debug"));
                appiumService = new AppiumServiceBuilder()
                   .UsingPort(4723)
                   .WithArguments(options) // Set debug level
                   .WithLogFile(new FileInfo("appium.log"))
                   .Build();
                appiumService.Start();
                Console.WriteLine("server started");
            }
      

      
            var options = new AppiumOptions();
            options.AddAdditionalCapability("platformName", "Android");
            options.AddAdditionalCapability("deviceName", "google pixel");
            options.AddAdditionalCapability("platformVersion", "15");
            options.AddAdditionalCapability("udid", "RZCR90DL9KX");
            options.AddAdditionalCapability("app", "C:\\Users\\iray\\Downloads\\TestMultiplePlugin.apk");
            options.AddAdditionalCapability("uiautomator2ServerInstallTimeout", 180000);
            driver.Driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4723/wd/hub"), options);
        }
        public static void StopAppiumServer()
        {
            if (appiumService != null && appiumService.IsRunning)
            {
                appiumService.Dispose(); // or appiumService.Stop();
                Console.WriteLine("Appium server stopped");
            }
            else
            {
                Console.WriteLine("Appium server is not running");
            }
        }

    }
}