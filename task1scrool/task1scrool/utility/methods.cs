using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1scrool.Drivers;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Appium.Android;

namespace task1scrool.utility
{
    public class convert
    {

        public static Dictionary<string, string> xpathDictionary; // Dictionary to store XPaths

        // Constructor to Load Data into Dictionary
        public convert()
        {
            string filePath = "C:\\Users\\iray\\source\\repos\\task1scrool\\task1scrool\\Support\\xpath.json";
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
        public void Scrollandclickelement(string xpath)
        {
            try
            {

                WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(60));

                var elements = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
               
                // Alternatively, for Appium on Android, you could use the following approach:
                var scrollCommand = "new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView((" +
                               "new UiSelector().xpath(\"" + xpath + "\"));";
                Driver.driver.FindElement(MobileBy.AndroidUIAutomator(scrollCommand));
                Console.WriteLine("XPath .");
                elements.Click();

            }
            catch (NoSuchElementException ex)
            {
                throw new Exception("Element not found: " + xpath, ex);
            }
        }
        public void Scrolling(string path)
        {
            const int maxScrollAttempts = 10;
            bool elementFound = false;

            // First attempt: Scroll down
            elementFound = ScrollAndFindElement(path, ScrollDirection.Forward, maxScrollAttempts);

            // If not found, scroll up
            if (!elementFound)
            {
                elementFound = ScrollAndFindElement(path, ScrollDirection.Backward, maxScrollAttempts);
            }

            if (!elementFound)
            {
                throw new Exception($"Element not found after {maxScrollAttempts * 2} scroll attempts");
            }
        }

        private bool ScrollAndFindElement(string xpath, ScrollDirection direction, int maxAttempts)
        {
            for (int attempt = 0; attempt < maxAttempts; attempt++)
            {
                try
                {
                    var element = Driver.driver.FindElement(By.XPath(xpath));
                    if (element.Displayed)
                    {
                        element.Click();
                        return true;
                    }
                }
                catch (NoSuchElementException)
                {
                    // Element not found in current view
                }

                // Scroll based on direction
                var scrollCommand = direction == ScrollDirection.Forward
                    ? "new UiScrollable(new UiSelector().scrollable(true)).scrollForward();"
                    : "new UiScrollable(new UiSelector().scrollable(true)).scrollBackward();";

                Driver.driver.FindElement(MobileBy.AndroidUIAutomator(scrollCommand));
            }
            return false;
        }

        public enum ScrollDirection
        {
            Forward,
            Backward
        }

        public void randomscroll(string path)
        {


            var scrool = "new UiScrollable(new UiSelector().scrollable(true)).scrollIntoView(new UiSelector().text(\"" + path + "\"));";
            Driver.driver.FindElement(MobileBy.AndroidUIAutomator(scrool)); 
        }
        public void ScrollDown()
        {
            var size = Driver.driver.Manage().Window.Size;

            int startX = size.Width / 2;
            int startY = (int)(size.Height * 0.75);
            int endY = (int)(size.Height * 0.25);

            new TouchAction(Driver.driver)
                .Press(startX, startY)
                .Wait(500) // wait duration for smooth scroll
                .MoveTo(startX, endY)
                .Release()
                .Perform();

            Console.WriteLine("Scrolled down.");
        }
        public void ScrollUp()
        {
            var size = Driver.driver.Manage().Window.Size;

            int startX = size.Width / 2;
            int startY = (int)(size.Height * 0.25);
            int endY = (int)(size.Height * 0.75);

            new TouchAction(Driver.driver)
                .Press(startX, startY)
                .Wait(500) // wait duration for smooth scroll
                .MoveTo(startX, endY)
                .Release()
                .Perform();

            Console.WriteLine("Scrolled Up.");
        }
        /*public void ScrollAndClickElementByXPath(string xpath)
        {
            try
            {
                bool isElementFound = false;
                int maxScrollAttempts = 5; // You can adjust based on your app's behavior

                for (int attempt = 0; attempt < maxScrollAttempts; attempt++)
                {
                    try
                    {
                        // Try to locate the element with explicit wait
                        WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(5));
                        var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));

                        // If found, click it
                        element.Click();
                        Console.WriteLine($"Element found and clicked on attempt #{attempt + 1}");
                        isElementFound = true;
                        break; // Exit loop since element is found
                    }
                    catch (WebDriverTimeoutException)
                    {
                        // Element not found yet, attempt to scroll
                        Console.WriteLine($"Element not found on attempt #{attempt + 1}, scrolling...");

                        // General scroll (adjust direction and ratio as needed)
                        ScrollDown();
                    }
                }

                if (!isElementFound)
                {
                    throw new NoSuchElementException($"Element with XPath '{xpath}' not found after {maxScrollAttempts} scroll attempts.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while scrolling and clicking: {ex.Message}", ex);
            }
        }
        */
        string previouspage = Driver.driver.PageSource; // Get the initial page source

        public void upordown()
        {
            string currentPage = Driver.driver.PageSource;

            if (currentPage == previouspage) // Compare current and previous pages
            {
                ScrollUp();
                currentPage = Driver.driver.PageSource; // Refresh currentPage after scrolling

                if (currentPage == previouspage)
                {
                    ScrollDown();
                }
            }

            previouspage = currentPage; // Update previous page at the end
        }
        public void ScrollToElementByXPath(string xpath)
        {
            string previousPage = "";
            string currentPage = Driver.driver.PageSource;

            while (currentPage != previousPage) // Continue until pages stop changing
            {
                try
                {
                    var element = Driver.driver.FindElement(By.XPath(xpath));
                    if (element.Displayed) // Check if the element is now visible
                    {
                        element.Click();
                        Console.WriteLine("Element found!");
                        return; // Exit once the element is visible
                    }
                }
                catch (NoSuchElementException)
                {
                    // Element not found yet, continue scrolling
                }

                previousPage = currentPage; // Store current page source
                ScrollDown(); // Scroll down and check again
                currentPage = Driver.driver.PageSource; // Get new page source after scrolling
            }

            Console.WriteLine("Element not found after scrolling through all pages.");
        }
        public void ScrollToElementByXPathupordown(string xpath)
        {
            string previousPage = "";
            string currentPage = Driver.driver.PageSource;
            bool scrollDown = true; 

            while (currentPage != previousPage || scrollDown) 
            {
                try
                {
                    var element = Driver.driver.FindElement(By.XPath(xpath));
                    if (element.Displayed)
                    {
                        element.Click();
                        Console.WriteLine("Element found and clicked!");
                        return;
                    }
                }
                catch (NoSuchElementException)
                {
                   
                }

                if (currentPage == previousPage) 
                {
                    if (scrollDown)
                    {
                        scrollDown = false;
                        Console.WriteLine("Page unchanged. Switching to scroll up.");
                    }
                    else 
                    {
                        Console.WriteLine("Element not found after scrolling both directions.");
                        break;
                    }
                }
                else
                {
                    previousPage = currentPage; 
                }

                if (scrollDown)
                {
                    ScrollDown(); 
                }
                else
                {
                    ScrollUp();
                }

                currentPage = Driver.driver.PageSource; 
            }

            Console.WriteLine("Element not found after scrolling.");
        }
        public void ScrollToElement(string elementText)
        {
            //  AndroidElement PermissionElement = DriverFactory.driver.FindElement(MobileBy.AndroidUIAutomator("new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().text(\"WebView\"))"));
            AndroidElement Element = Driver.driver.FindElement(MobileBy.AndroidUIAutomator($"new UiScrollable(new UiSelector().scrollable(true).instance(0)).scrollIntoView(new UiSelector().textContains(\"{elementText}\"))"));
            Element.Click();

            Thread.Sleep(3000);
        }
    }
}
