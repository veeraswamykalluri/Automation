using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollTestMP.POM
{
    
    public class AcceptTermsAndConditions
    {
        private readonly AppiumDriver driver;
        private readonly string _b;

        public AcceptTermsAndConditions(AppiumDriver driver, string b)
        {
            this.driver = driver;
            _b = b;
        }
        public static string AcceptTermsAndConditionselements(string a,string b)
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

      
        }
    }


