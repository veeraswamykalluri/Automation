﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ReqnrollTestMP.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AcceptTermsandConditions")]
    public partial class AcceptTermsandConditionsFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "AcceptTermsandConditions", "A short summary of the feature", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "AcceptTermsandConditions.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation for closebutton on the AcceptTermsAndConditions page")]
        public async System.Threading.Tasks.Task ValidationForClosebuttonOnTheAcceptTermsAndConditionsPage()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validation for closebutton on the AcceptTermsAndConditions page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 7
 await testRunner.GivenAsync("app is launched", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 8
 await testRunner.WhenAsync("click \"AcceptTermsAndConditionsPlugin\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 9
 await testRunner.AndAsync("I click on \"close\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 10
 await testRunner.ThenAsync("App navigates to \"mainpage\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation for Terms and conditions and privacy policy links on the AcceptTermsAn" +
            "dConditions page")]
        [NUnit.Framework.TestCaseAttribute("Privacy policy", "privacy policy page", null)]
        [NUnit.Framework.TestCaseAttribute("Terms and conditions", "Terms and conditions page", null)]
        public async System.Threading.Tasks.Task ValidationForTermsAndConditionsAndPrivacyPolicyLinksOnTheAcceptTermsAndConditionsPage(string linkName, string message, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("link name", linkName);
            argumentsOfScenario.Add("message", message);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validation for Terms and conditions and privacy policy links on the AcceptTermsAn" +
                    "dConditions page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 13
 await testRunner.GivenAsync("app is launched", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 14
 await testRunner.WhenAsync("click \"AcceptTermsAndConditionsPlugin\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 15
 await testRunner.AndAsync(string.Format("I click on \"{0}\"", linkName), ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 16
 await testRunner.ThenAsync(string.Format("App navigates to \"{0}\"", message), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 17
 await testRunner.WhenAsync("I click on \"close\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 18
 await testRunner.ThenAsync("App navigates to \"mainpage\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation for body on the AcceptTermsAndConditions page")]
        public async System.Threading.Tasks.Task ValidationForBodyOnTheAcceptTermsAndConditionsPage()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validation for body on the AcceptTermsAndConditions page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 24
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 25
 await testRunner.GivenAsync("app is launched", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 26
 await testRunner.WhenAsync("click \"AcceptTermsAndConditionsPlugin\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 27
 await testRunner.ThenAsync("App should display body under terms and condition on AcceptTermsAndConditions pag" +
                        "e", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation for enable of continue on the AcceptTermsAndConditions page")]
        public async System.Threading.Tasks.Task ValidationForEnableOfContinueOnTheAcceptTermsAndConditionsPage()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validation for enable of continue on the AcceptTermsAndConditions page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 29
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 30
 await testRunner.GivenAsync("app is launched", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 31
 await testRunner.WhenAsync("click \"AcceptTermsAndConditionsPlugin\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 32
 await testRunner.AndAsync("Unmark the \"checkbox\" if marked", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 33
 await testRunner.ThenAsync("App not enables the \"continue\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation for Click event on continue in the AcceptTermsAndConditions page")]
        public async System.Threading.Tasks.Task ValidationForClickEventOnContinueInTheAcceptTermsAndConditionsPage()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validation for Click event on continue in the AcceptTermsAndConditions page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 35
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 36
 await testRunner.GivenAsync("app is launched", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 37
 await testRunner.WhenAsync("click \"AcceptTermsAndConditionsPlugin\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 38
 await testRunner.AndAsync("Mark on the \"checkbox\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 39
 await testRunner.AndAsync("App enables the \"continue\" button to click", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 40
 await testRunner.AndAsync("I click on \"continue\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 41
 await testRunner.ThenAsync("App navigates to the \"Main page\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Validation for back button not exist on the AcceptTermsAndConditions page")]
        public async System.Threading.Tasks.Task ValidationForBackButtonNotExistOnTheAcceptTermsAndConditionsPage()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Validation for back button not exist on the AcceptTermsAndConditions page", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 44
 await testRunner.GivenAsync("app is launched", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 45
 await testRunner.WhenAsync("click \"AcceptTermsAndConditionsPlugin\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 46
 await testRunner.ThenAsync("App not having the \"backbutton\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify back button is enables")]
        [NUnit.Framework.TestCaseAttribute("Privacy policy", "back button", null)]
        [NUnit.Framework.TestCaseAttribute("Terms and conditions", "back button", null)]
        public async System.Threading.Tasks.Task VerifyBackButtonIsEnables(string linkName, string element, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("link name", linkName);
            argumentsOfScenario.Add("element", element);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Verify back button is enables", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 49
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 50
  await testRunner.GivenAsync("app is launched", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 51
  await testRunner.WhenAsync("click \"AcceptTermsAndConditionsPlugin\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 52
  await testRunner.AndAsync(string.Format("I click on \"{0}\"", linkName), ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 53
  await testRunner.ThenAsync(string.Format("I should see  \"{0}\"", element), ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
