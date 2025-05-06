using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollTestMP.POM
{
    internal class BluetoothPermissionPlugin
    {
        private readonly AppiumDriver driver;

        public BluetoothPermissionPlugin(AppiumDriver driver)
        {
            this.driver = driver;
        }

        public By LoginButton => By.XPath("//android.widget.Button[@text='Login']");
        public By LoginButtogn => By.C
    }
}
