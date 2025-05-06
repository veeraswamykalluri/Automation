
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ReqnrollTestMP.LaunchPad;
using OpenQA.Selenium;

namespace ReqnrollTestMP.Helpers
{
    public class controls
    {
        public static void safeClick(string elementText)

        {
            var element = driverLaunch.Driver.FindElement(MobileBy.AndroidUIAutomator($"new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"{elementText}\"))"));
            element.Click();
            Thread.Sleep(3000);
        }
        public static void close()
        {
            var elment = driverLaunch.Driver.FindElement(MobileBy.AndroidUIAutomator("//android.view.ViewGroup//android.widget.Button[contains(@content-desc, 'Close')]"));
            elment.Click();
        }
    }
}