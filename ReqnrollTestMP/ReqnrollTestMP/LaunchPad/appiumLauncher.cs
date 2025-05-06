using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Service.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollTestMP.LaunchPad
{
    public class appiumLauncher
    {
        public static AppiumLocalService appiumService;

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
        }
        public static void StopAppiumServer()
        {

            if (appiumService != null && appiumService.IsRunning)
            {

                appiumService.Dispose(); 
                
                Console.WriteLine("Appium server stopped");
            }
            else
            {
                Console.WriteLine("Appium server is not running");
            }
        }
    }
}