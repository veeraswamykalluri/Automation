using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using task1scenarios.Drivers;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium;
using task1scenarios.Methods;

namespace task1scenarios.POM
{
    public class AboutPluginPage
    {
      
        public static void links(string a, string b, string c)
        {

            string xpath = $"//android.widget.TextView[@text=\"{a}\"]/ancestor::android.view.ViewGroup/following-sibling::android.view.ViewGroup/android.widget.TextView | //android.widget.TextView[@text=\"{a}\"]/ancestor::android.view.ViewGroup/following-sibling::android.view.ViewGroup/descendant::android.widget.TextView[2]";
            AndroidElement element = driver.Driver.FindElementByXPath(xpath) ;
            Assert.IsTrue(driver.Driver.FindElement(By.Id(xpath)).Displayed);
            //string appiumElementId = element.Id;
            //Console.WriteLine(appiumElementId);
            //bool elementfound = driver.Driver.FindElementsByXPath(xpath).Count > 0;

            //if (elementfound)
            //{
            //    Assert.Pass("found element");
            //}
            //else { Assert.Fail(); }

            //if (WaitForElement(driver.Driver, xpath))
            //{
            //    Console.WriteLine("✅ Element found after waiting.");
            //    Assert.Pass();
            //}
            //else
            //{
            //    Console.WriteLine("❌ Element NOT found within timeout.");
            //    Assert.Fail();  
            //}
        }
        public static void body(string a, string b, string c)
        {

            string xpath = $"//android.widget.TextView[@text=\"{a}\"]/following-sibling::android.widget.TextView";
            AndroidElement element = driver.Driver.FindElementByXPath(xpath);
            Assert.IsTrue(driver.Driver.FindElement(By.Id(xpath)).Displayed);
            //isexist(driver.Driver,element);
        }


        public static void buttons(string a, string b, string c)
            {

                string button = $"//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.About.Pages.AboutPage.{a}Button\"]";
            AndroidElement element = driver.Driver.FindElementByXPath(button);
           // isexist(driver.Driver,button);
        }

        public static void headers(string a, string b, string c)
            {

                string header = "//android.view.View/preceding-sibling::android.view.ViewGroup";
            AndroidElement element = driver.Driver.FindElementByXPath(header);
            //isexist(driver.Driver,header);

        }
        public static void click(string a, string b)
            {
                AndroidElement Element = driver.Driver.FindElementByXPath($"//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.About.Pages.AboutPage.{a}Button\"]");
                Element.Click();
            }
        //public static void isexist(string a)
        //{

        //    if (driver.Driver.) // Replace with the actual element identifier
        //    {
        //        Console.WriteLine("Test Passed: Element found in Page Source");
        //        Assert.Pass();
        //    }
        //    else
        //    {
        //        Assert.Fail("Test Failed: Element not found in Page Source");
        //    }
        //public static bool IsElementPresent(AndroidDriver<AndroidElement> driver, string xpath)
        //{
        //    var elements = driver.FindElementsByXPath(xpath);
        //    return elements.Count > 0;
        //}
        //public static bool IsElementExist(AndroidDriver<AndroidElement> driver, string xpath)
        //{
        //    return driver.FindElementsByXPath(xpath).Count > 0;
        //}
     

//public static bool WaitForElement(AndroidDriver<AndroidElement> driver, string xpath)
//    {
//        try
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
//            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(xpath)));
               
//            return true; // Element found

//        }
//        catch (WebDriverTimeoutException)
//        {
                
//            return false; // Element not found within timeout
//        }
//    }

        public static void WaitForElementToBeVisible(string page, string elementName)
        {
            var automationId = driver.Driver.FindElementsByXPath(elementName);
            var wait = new WebDriverWait(driver.Driver, TimeSpan.FromSeconds(30));
            try
            {
                wait.Until(_ =>
                {
                    try
                    {
                        var foundElements = driver.Driver.FindElementsByXPath(elementName);
                        return foundElements.Any(e => e.Displayed && e.Enabled);
                    }
                    catch (NoSuchElementException)
                    {
                        return false;
                    }
                });

            }
            catch (WebDriverTimeoutException)
            {
               
            }
        }
        public static AndroidElement FindElement(string element)
        {
            try
            {
                return driver.Driver.FindElementByXPath($"{(element)}");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine($"Element '{element}' not found: {e.Message}");
                return null; // Return null if element is not found
            }
        }


    }
}
    