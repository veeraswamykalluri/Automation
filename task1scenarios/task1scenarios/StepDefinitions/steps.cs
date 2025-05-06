using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using task1scenarios.Drivers;
using task1scenarios.Methods;
using task1scenarios.POM;


namespace task1scenarios.StepDefinitions
{
    [Binding]
    public class steps : convert
    {

        [Given(@"I launch the plugin app")]
        public void GivenILaunchThePluginApp()
        {
           Thread.Sleep(1000);  
        }

        [Given(@"I scroll Down and launch plugin '([^']*)'")]
        public void GivenIScrollDownAndLaunchPlugin(string AboutPlugin)
        {
            click(AboutPlugin);
            Thread.Sleep(1000);
        }
      
        private static object CreatePageInstance(string pageName)
        {
            // Replace with actual logic to create the correct page object
            switch (pageName.ToLower())
            {
                case "aboutpluginpage":
                    return new AboutPluginPage();
                case "settingspage":
                    return new EnableBluetoothPluginPage();
                default:
                    throw new ArgumentException($"Page '{pageName}' is not recognized.");
            }
        }
        [Then(@"verify '([^'])' is '([^'])' on '([^']*)'$")]
        public void ThenVerifyIsOnThePage(string elementName, string isDisplayed, string pageName)
        {
            var page = CreatePageInstance(pageName);
            bool expectedVisibility = isDisplayed.ToLower() == "displayed";
            try
            {
                if (expectedVisibility)
                    WaitForElementToBeVisible(pageName, elementName);

                else
                    switch (isDisplayed)
                    {
                        case "enabled":
                            Assert.AreEqual(page.AboutPluginPage.FindElement(elementName).Text, "1");
                            break;
                        case "disabled":
                            Assert.AreEqual(page.FindElement(elementName).Text, "0");
                            break;
                        case "enable":
                            Assert.AreEqual(page.FindElement(elementName).Enabled.ToString(), "True");
                            break;
                        case "disable":
                            Assert.AreEqual(page.FindElement(elementName).Enabled.ToString(), "False");
                            break;
                        default:
                            WaitForElementToBeNotVisible(page, elementName, 5);
                            break;
                    }
            }
            catch (ElementVisibilityException e)
            {
                Console.WriteLine(e.Message);
                Assert.Fail(e.Message);
            }
        }

        private void WaitForElementToBeNotVisible(object page, string elementName, int v)
        {
            throw new NotImplementedException();
        }

        private void WaitForElementToBeVisible(string pageName, string elementName)
        {
            throw new NotImplementedException();
        }

        [When(@"I press '([^']*)' on '([^']*)'")]
        public void WhenIPressOn(string back, string headerPage)
        {
            Thread.Sleep(1000);
        }

        

        [Given(@"I scroll '([^']*)' and launch plugin '([^']*)'")]
        public void GivenIScrollAndLaunchPlugin(string down, string bluetoothPermissionPlugin)
        {
            throw new PendingStepException();
        }

        [Given(@"I press '([^']*)' on '([^']*)'")]
        public void GivenIPressOn(string ok, string bluetoothPermissionPluginPage)
        {
            throw new PendingStepException();
        }

        [Given(@"I '([^']*)' permission request")]
        public void GivenIPermissionRequest(string gRANT)
        {
            throw new PendingStepException();
        }

        [Given(@"Go to native settings")]
        public void GivenGoToNativeSettings()
        {
            throw new PendingStepException();
        }

        [When(@"I press '([^']*)' button on Settings Page and Turn '([^']*)' bluetooth")]
        public void WhenIPressButtonOnSettingsPageAndTurnBluetooth(string bluetooth, string oN)
        {
            throw new PendingStepException();
        }

        [When(@"I relaunch the plugin app")]
        public void WhenIRelaunchThePluginApp()
        {
            throw new PendingStepException();
        }

        [When(@"I scroll '([^']*)' and launch plugin '([^']*)'")]
        public void WhenIScrollAndLaunchPlugin(string down, string enableBluetoothPlugin)
        {
            throw new PendingStepException();
        }

        [Then(@"verify plugin is completed")]
        public void ThenVerifyPluginIsCompleted()
        {
            throw new PendingStepException();
        }

        [When(@"I turn '([^']*)' Bluetooth")]
        public void WhenITurnBluetooth(string oFF)
        {
            throw new PendingStepException();
        }

        [When(@"I press '([^']*)' button on Settings Page")]
        public void WhenIPressButtonOnSettingsPage(string bluetooth)
        {
            throw new PendingStepException();
        }

        [Then(@"Verify if '([^']*)' permission is '([^']*)'")]
        public void ThenVerifyIfPermissionIs(string bluetooth, string gRANT)
        {
            throw new PendingStepException();
        }

        [When(@"Go to native settings")]
        public void WhenGoToNativeSettings()
        {
            throw new PendingStepException();
        }

       
    }
}
