using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using ReqnrollTestMP.LaunchPad;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;
using static System.Collections.Specialized.BitVector32;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;


namespace ReqnrollTestMP.POM
{
    public class AboutPlugin
    {
        //private readonly AppiumDriver driver;
        //private readonly string _b;



        //public AboutPlugin(AppiumDriver driver, string b)
        //{
        //    this.driver = driver;
        //    _b = b;
        //}
        public static string elementsInAboutPlugin(string a,string b) 
        {
           
                switch (a)
                {
                    case "body":
                        return $"//android.widget.TextView[@text=\"{b}\"]/parent::android.view.ViewGroup/child::android.widget.TextView[2]";

                    case "link":
                        return $"//android.widget.TextView[@text=\"{b}\"]/ancestor::android.view.ViewGroup/following-sibling::android.view.ViewGroup/android.widget.TextView | //android.widget.TextView[@text=\"{b}\"]/ancestor::android.view.ViewGroup/following-sibling::android.view.ViewGroup/descendant::android.widget.TextView[2]";

                    case "Backbutton":
                        return $"//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.About.Pages.AboutPage.{b}Button\"]";
                    case "headers":
                        return "//android.view.View/preceding-sibling::android.view.ViewGroup";

                default:
                        throw new ArgumentException($"No XPath defined for plugin: {a}");
                }
            }

           
        public  static  void ExecutionInAboutPlugin(string a, string b)
        {

            var element = driverLaunch.Driver.FindElement(By.XPath(elementsInAboutPlugin(a,b)));


            if (element.Displayed)
            {
                string actualText = element.Text;
                Console.WriteLine(actualText);
                element.Click();

                // Optional: Assert it matches expected text
                //Assert.AreEqual(b, actualText, $"Expected '{b}', but found '{actualText}'");
            }
            else
            {
                throw new Exception("Element is not displayed on the screen.");
            }
        }



    }
}


