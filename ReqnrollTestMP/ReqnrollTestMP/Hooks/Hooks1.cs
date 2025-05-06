using Allure.Net.Commons;
using OpenQA.Selenium;

using ReqnrollTestMP.LaunchPad;
using NUnit.Framework;


namespace ReqnrollTestMP.Hooks
{

    [Binding]

    public class Hooks1
    {
        private readonly ScenarioContext _scenarioContext;

        public Hooks1(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        // For additional details on Reqnroll hooks see https://go.reqnroll.net/doc-hooks

        [BeforeScenario()]
        public void BeforeScenarioWithTag()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://go.reqnroll.net/doc-hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
            appiumLauncher.StartAppiumServer();
            capabilities.capability();
        }

        //[BeforeScenario(Order = 1)]
        //public void FirstBeforeScenario()
        //{
        //    // Example of ordering the execution of hooks
        //    // See https://go.reqnroll.net/doc-hooks#hook-execution-order

        //    //TODO: implement logic that has to run before executing each scenario
        //}

       
        public static void getScrShot()
        {

            var outcome = TestContext.CurrentContext.Result.Outcome.Status;

            if (outcome == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                try
                {
                    // Take screenshot
                    var screenshot = ((ITakesScreenshot)driverLaunch.Driver).GetScreenshot();

                    // Save with .png manually
                    string screenshotPath = Path.Combine(
                        Path.GetTempPath(),
                        $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:yyyyMMdd_HHmmss}.png"
                    );

                    // Save as PNG without using ScreenshotImageFormat
                    screenshot.SaveAsFile(screenshotPath);

                    // Attach to Allure
                    AllureApi.AddAttachment("Failure Screenshot", "image/png", screenshotPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed to capture screenshot: " + ex.Message);
                }

            }
        }
       
        [AfterScenario]
        public void CaptureScreenshot()
        {
            if (_scenarioContext.TestError != null) // Only on failure
            {
                var scenarioName = _scenarioContext.ScenarioInfo.Title.Replace(" ", "");
                getScrShot();
            }
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            driverLaunch.Driver.Quit();
            appiumLauncher.StopAppiumServer();
        }

    }
}
