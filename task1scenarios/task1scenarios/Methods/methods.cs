using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1scenarios.Drivers;
using task1scenarios.POM;
using task1scenarios.Methods;
using task1scenarios.POM;
using static task1scenarios.POM.AboutPluginPage;

namespace task1scenarios.Methods
{

    public class convert
    {
        public static Dictionary<string, string> xpathDictionary; // Dictionary to store XPaths

        // Constructor to Load Data into Dictionary
        public convert()
        {
            string filePath = "C:\\Users\\iray\\source\\repos\\task1scenarios\\task1scenarios\\utilities\\tsconfig1.json";
            string jsonString = File.ReadAllText(filePath);
            var xpaths = JObject.Parse(jsonString);

            // Store data in the dictionary
            xpathDictionary = new Dictionary<string, string>();
            foreach (var item in xpaths)
            {
                xpathDictionary[item.Key] = item.Value.ToString();
            }

            Console.WriteLine("XPath data loaded into dictionary.");
        }

        // Method to Get XPath from Dictionary
        public string GetXPath(string element)
        {
            if (xpathDictionary.ContainsKey(element))
            {
                return xpathDictionary[element];
            }
            else
            {

                Console.WriteLine($"XPath for '{element}' not found.");
                return null;
            }

        }

        public void click(string element)
        {
            AndroidElement Element = driver.Driver.FindElementByXPath($"{GetXPath(element)}");
            Element.Click();
        }
       

    }
}
