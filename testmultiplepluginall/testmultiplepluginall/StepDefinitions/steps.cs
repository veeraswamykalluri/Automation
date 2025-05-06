using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testmultiplepluginall.Utility;
using testmultiplepluginall.POM;


namespace testmultiplepluginall.StepDefinitions
{
    [Binding]
    public class steps
    {
        [Given(@"I launch the plugin app")]
        public void GivenILaunchThePluginApp()
        {
            Thread.Sleep(1000);
        }

        [Given(@"I scroll Down and launch plugin '([^']*)'")]
        public void GivenIScrollDownAndLaunchPlugin(string AboutPlugin)
        {
            methods.click(methods.menupage(AboutPlugin));
        }

        [Then(@"verify '([^']*)' is '([^']*)' on '([^']*)'")]
        public void ThenVerifyIsOn(string p0, string isdisplayed, string aboutPluginPage)
        {
            //string xpath = $"//android.widget.TextView[@text=\"{p0}\"]/following-sibling::android.widget.TextView";
            //AndroidElement element = driver.Driver.FindElementByXPath(xpath);
            //Assert.IsTrue(driver.Driver.FindElement(By.Id(xpath)).Displayed);
            //Thread.Sleep(1000);
            POM.aboutPluginPage.XPath(p0);
        }

       

       

        [When(@"I press '([^']*)' on '([^']*)'")]
        public void WhenIPressOn(string back, string headerPage)
        {
            
        }

       

    }
}
