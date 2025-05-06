using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1scrool.Drivers;
using task1scrool.utility;

namespace task1scrool.StepDefinitions
{
    [Binding]
    public class steps: convert
    {
        //[Given(@"find start element")]
        //public void GivenFindStartElement()
        //{
        //    ScrollToElement();
        //    //Driver.driver.FindElement(By.XPath($"{GetXPath("about")}")).Click();
        //    Driver.driver.Navigate().Back();
        //    Thread.Sleep(1000);  
        //}
        [Given(@"find start element""([^""]*)""")]
        public void GivenFindStartElement(string p0)
        {
            ScrollToElement(p0);
            Driver.driver.Navigate().Back();
        }


        [When(@"element in the middle")]
        public void WhenElementInTheMiddle()
        {
            ScrollToElement("HIControlsPlugin");
            Driver.driver.Navigate().Back();
            ScrollToElement("TinnitusPlugin");
            Driver.driver.Navigate().Back();
            ScrollToElement("PrepareAssistLivePlugin");
            Driver.driver.Navigate().Back();
            ScrollToElement("HIControlsPlugin");
            Driver.driver.Navigate().Back();
            ScrollToElementByXPathupordown($"{GetXPath("integration")}");
            //Driver.driver.FindElement(By.XPath($"{GetXPath("integration")}")).Click();
            Driver.driver.Navigate().Back();
            Thread.Sleep(1000);
        }

        [Then(@"find random positioned element")]
        public void ThenFindRandomPositionedElement()
        {
            ScrollToElementByXPathupordown($"{GetXPath("readprivacypolicy")}");
            Driver.driver.Navigate().Back();
            Thread.Sleep(1000);
        }

    }
}
