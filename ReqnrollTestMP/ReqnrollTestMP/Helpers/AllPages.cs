using OpenQA.Selenium.Appium.Interfaces;
using ReqnrollTestMP.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReqnrollTestMP.LaunchPad;
namespace ReqnrollTestMP.Helpers
{
    public class AllPageAccess
    {

        private readonly Dictionary<string, object> _pages;

        public AllPageAccess()
        {

            var driver = driverLaunch.Driver;
        //    _pages = new Dictionary<string, object>
        //{

        //    //{ "AboutPlugin", new AboutPlugin(driver) },
        //     { "AboutPlugin", (b) => new AboutPlugin(driver, b) },
        //        {"AcceptTermsAndConditions",new AcceptTermsAndConditions(driver) },
        //         {"BluetoothPermissionPlugin",new BluetoothPermissionPlugin(driver) }
        //};
            Dictionary<string, Func<string, object>> _pages = new()
{
    { "AboutPlugin", (b) => new AboutPlugin(driver, b) },
    { "AcceptTermsAndConditions", (_) => new AcceptTermsAndConditions(driver) },
    { "BluetoothPermissionPlugin", (_) => new BluetoothPermissionPlugin(driver) }
};

        }
    }
}

