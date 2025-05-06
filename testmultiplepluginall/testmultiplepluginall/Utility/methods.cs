using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace testmultiplepluginall.Utility
{
    public class methods
    {
        public void ScrollToElement(string elementText)
        {
            //  AndroidElement PermissionElement = DriverFactory.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().text(\"WebView\"))"));
            AndroidElement Element = driver.Driver.FindElement(MobileBy.AndroidUIAutomator($"new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"{elementText}\"))"));
            Element.Click();

            Thread.Sleep(3000);
        }
        public static void click(string a)
        {
            AndroidElement Element = driver.Driver.FindElement(By.XPath(a));
            Element.Click();
        }
        public static string menupage(string a)
        {
            string xpath = $"//android.widget.TextView[@text=\"{a}\"]";
            return xpath; 
        }
    }
}
