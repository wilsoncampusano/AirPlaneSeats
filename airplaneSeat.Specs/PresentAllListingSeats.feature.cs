﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18444
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace airplaneSeat.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("PresentAllListingSeats")]
    public partial class PresentAllListingSeatsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "PresentAllListingSeats.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "PresentAllListingSeats", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("a list with reserved seats")]
        public virtual void AListWithReservedSeats()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("a list with reserved seats", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Seat number",
                        "Passanger"});
            table1.AddRow(new string[] {
                        "1",
                        "Ross"});
            table1.AddRow(new string[] {
                        "2",
                        "N/O"});
            table1.AddRow(new string[] {
                        "3",
                        "Belisle"});
            table1.AddRow(new string[] {
                        "4",
                        "Krakov"});
            table1.AddRow(new string[] {
                        "5",
                        "N/O"});
            table1.AddRow(new string[] {
                        "6",
                        "N/O"});
            table1.AddRow(new string[] {
                        "7",
                        "Soo"});
            table1.AddRow(new string[] {
                        "8",
                        "Green"});
            table1.AddRow(new string[] {
                        "9",
                        "Garcia"});
            table1.AddRow(new string[] {
                        "10",
                        "Levin"});
            table1.AddRow(new string[] {
                        "11",
                        "N/O"});
            table1.AddRow(new string[] {
                        "12",
                        "Johnson"});
#line 4
 testRunner.Given("the following listing of seats in db", ((string)(null)), table1, "Given ");
#line 18
 testRunner.When("I search for a list of all passanger", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Seat number",
                        "Passanger"});
            table2.AddRow(new string[] {
                        "1",
                        "Ross"});
            table2.AddRow(new string[] {
                        "2",
                        "N/O"});
            table2.AddRow(new string[] {
                        "3",
                        "Belisle"});
            table2.AddRow(new string[] {
                        "4",
                        "Krakov"});
            table2.AddRow(new string[] {
                        "5",
                        "N/O"});
            table2.AddRow(new string[] {
                        "6",
                        "N/O"});
            table2.AddRow(new string[] {
                        "7",
                        "Soo"});
            table2.AddRow(new string[] {
                        "8",
                        "Green"});
            table2.AddRow(new string[] {
                        "9",
                        "Garcia"});
            table2.AddRow(new string[] {
                        "10",
                        "Levin"});
            table2.AddRow(new string[] {
                        "11",
                        "N/O"});
            table2.AddRow(new string[] {
                        "12",
                        "Johnson"});
#line 19
 testRunner.Then("the result shoulb be", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
