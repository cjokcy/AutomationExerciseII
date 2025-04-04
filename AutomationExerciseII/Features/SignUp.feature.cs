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
namespace AutomationExerciseII.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class A_UserSignUpFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "A_User SignUp", "A short summary of the feature", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "SignUp.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute(Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupBehavior.EndOfClass)]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("TestCase1_User registers and deletes an account")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "A_User SignUp")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Register")]
        public async System.Threading.Tasks.Task TestCase1_UserRegistersAndDeletesAnAccount()
        {
            string[] tagsOfScenario = new string[] {
                    "Register"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TestCase1_User registers and deletes an account", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 8
    await testRunner.GivenAsync("the user navigates to the \"https://automationexercise.com\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 9
    await testRunner.WhenAsync("the user clicks on the signup/login link", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "name",
                            "email"});
                table1.AddRow(new string[] {
                            "Test Test",
                            "aem002@test.com"});
#line 10
    await testRunner.AndAsync("the user enters valid details on the signup form", ((string)(null)), table1, "And ");
#line hidden
#line 13
    await testRunner.AndAsync("the user clicks on the \"Signup\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 14
    await testRunner.ThenAsync("\"ENTER ACCOUNT INFORMATION\" should be visible", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
                global::Reqnroll.Table table2 = new global::Reqnroll.Table(new string[] {
                            "First Name",
                            "Last Name",
                            "Company",
                            "Address",
                            "Address2",
                            "Country",
                            "State",
                            "City",
                            "Zip code",
                            "Mobile Number",
                            "Password",
                            "DOB"});
                table2.AddRow(new string[] {
                            "Test",
                            "Test",
                            "Testing ltd",
                            "123 Street",
                            "Apt 4B",
                            "USA",
                            "NY",
                            "New York",
                            "10001",
                            "1404111111",
                            "password123",
                            "31, March, 1990"});
#line 15
    await testRunner.WhenAsync("I fill in the address details:", ((string)(null)), table2, "When ");
#line hidden
#line 18
    await testRunner.AndAsync("the user clicks on the \"Create Account\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 19
    await testRunner.ThenAsync("\"ACCOUNT CREATED!\" should be visible", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 20
    await testRunner.WhenAsync("the user clicks on the \"Continue\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 21
    await testRunner.ThenAsync("\"Logged in as Test Test\" should be visible", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 22
    await testRunner.WhenAsync("the user clicks on the \"Delete Account\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 23
    await testRunner.ThenAsync("\"ACCOUNT DELETED!\" should be visible", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("TestCase5_User attempts to register with an already existing email")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "A_User SignUp")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Duplicate")]
        public async System.Threading.Tasks.Task TestCase5_UserAttemptsToRegisterWithAnAlreadyExistingEmail()
        {
            string[] tagsOfScenario = new string[] {
                    "Duplicate"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("TestCase5_User attempts to register with an already existing email", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 27
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 28
    await testRunner.GivenAsync("the user navigates to the \"https://automationexercise.com\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 29
    await testRunner.WhenAsync("the user clicks on the signup/login link", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
                global::Reqnroll.Table table3 = new global::Reqnroll.Table(new string[] {
                            "name",
                            "email"});
                table3.AddRow(new string[] {
                            "Test Test",
                            "aem001@test.com"});
#line 30
    await testRunner.AndAsync("the user enters valid details on the signup form", ((string)(null)), table3, "And ");
#line hidden
#line 33
    await testRunner.AndAsync("the user clicks on the \"Signup\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 34
    await testRunner.ThenAsync("\"Email Address already exist!\" should be visible", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
