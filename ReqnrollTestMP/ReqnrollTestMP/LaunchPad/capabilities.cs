using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollTestMP.LaunchPad
{
 
    public class capabilities

    {
        public static void capability()
        {
            //string apkPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestMultiplePlugins.apk");
            string apkPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "resource", "TestMultiplePlugins.apk");
            var options = new AppiumOptions();
            options.PlatformName = "Android";
            options.AutomationName = "UiAutomator2";
            options.DeviceName="google pixel";
            options.PlatformVersion = "13";
            options.App = apkPath;
            options.AddAdditionalAppiumOption("Udid", "RZCR90DL9KX");
            //options.AddAdditionalAppiumOption("app", @"");
            options.AddAdditionalAppiumOption("Uiautomator2ServerInstallTimeout", 180000);
           driverLaunch.Driver = new AndroidDriver(new Uri("http://localhost:4723"), options);
        //C: \Users\iray\source\repos\Automation\ReqnrollTestMP\ReqnrollTestMP\resource\TestMultiplePlugins.apk


        }
    }
}
