using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using testmultiplepluginall.Utility;

namespace testmultiplepluginall.POM
{
    public class aboutPluginPage
    {
        //        using OpenQA.Selenium;
        //using OpenQA.Selenium.Appium;
        //using OpenQA.Selenium.Appium.Android;

        //public class LoginPage
        //{
        //    private AndroidDriver<AndroidElement> driver;

        //    public LoginPage(AndroidDriver<AndroidElement> driver)
        //    {
        //        this.driver = driver;
        //    }

        //    private AndroidElement Username => driver.FindElementById("com.example:id/username");
        //    private AndroidElement Password => driver.FindElementById("com.example:id/password");
        //    private AndroidElement LoginButton => driver.FindElementById("com.example:id/login");

        //    public void Login(string username, string password)
        //    {
        //        Username.Clear();
        //        Username.SendKeys(username);

        //        Password.Clear();
        //        Password.SendKeys(password);

        //        LoginButton.Click();
        //    }
        //}


        public static AndroidElement XPath(string a)
        {
            string link = $"//android.widget.TextView[@text=\"{a}\"]/ancestor::android.view.ViewGroup/following-sibling::android.view.ViewGroup/android.widget.TextView | //android.widget.TextView[@text=\"{a}\"]/ancestor::android.view.ViewGroup/following-sibling::android.view.ViewGroup/descendant::android.widget.TextView[2]";

            string body = $"//android.widget.TextView[@text=\"{a}\"]/following-sibling::android.widget.TextView";

            string buttons = $"//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.About.Pages.AboutPage.{a}Button\"]";

            string headers = "//android.view.View/preceding-sibling::android.view.ViewGroup";

            List<By> locators = new List<By>
    {
        By.XPath(link),
        By.XPath(body),
        By.XPath(buttons),
        By.XPath(headers)
    };

            foreach (By locator in locators)
            {
                var elements = driver.Driver.FindElements(locator);
                if (elements.Count > 0)
                {
                    return elements[0]; // Return the first matching element
                }
            }

            // If no elements are found with any locator, throw an exception
            throw new NoSuchElementException($"Element with label '{a}' not found using any known locator strategy.");
        }

    }
}
 //       public static string XPath(string a)
 //       {


//           string link = $"//android.widget.TextView[@text=\"{a}\"]/ancestor::android.view.ViewGroup/following-sibling::android.view.ViewGroup/android.widget.TextView | //android.widget.TextView[@text=\"{a}\"]/ancestor::android.view.ViewGroup/following-sibling::android.view.ViewGroup/descendant::android.widget.TextView[2]";

//           string body = $"//android.widget.TextView[@text=\"{a}\"]/following-sibling::android.widget.TextView";


//           string buttons = $"//android.widget.Button[@resource-id=\"com.ReSound.TestMultiplePlugins:id/ReSound.App.Legolas.Plugins.About.Pages.AboutPage.{a}Button\"]";


//           string headers = "//android.view.View/preceding-sibling::android.view.ViewGroup";
//           List<By> locators = new List<By>
//       {
//           By.XPath(link),
//           By.XPath(body),
//           By.XPath(buttons),
//           By.XPath(headers)
//       };

//           foreach (By locator in locators)
//           {
//               AndroidElement elements = driver.Driver.FindElements(locator);
//               if (elements.Count > 0)
//               {
//                   return locator;
//               }
//           }

//           return null; // or throw exception if no locator matches
//       }
//          // throw new NoSuchElementException($"Element with label '{label}' not found using any known locator strategy.");
//       }

//}
