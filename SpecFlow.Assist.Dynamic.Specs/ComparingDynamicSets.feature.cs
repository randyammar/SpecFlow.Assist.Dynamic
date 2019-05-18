// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlow.Assist.Dynamic.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Comparing dynamic sets against tables")]
    public partial class ComparingDynamicSetsAgainstTablesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ComparingDynamicSets.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Comparing dynamic sets against tables", "\tIn order to easier and slicker do assertions\n\tAs a SpecFlow developer\n\tI want to" +
                    " be able to compare a list of dynamic items against a table", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Comparing against an identical table should match")]
        public virtual void ComparingAgainstAnIdenticalTableShouldMatch()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Comparing against an identical table should match", null, ((string[])(null)));
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table15.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table15.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
            table15.AddRow(new string[] {
                        "Gustav",
                        "1",
                        "2010-03-19",
                        "0.84"});
            table15.AddRow(new string[] {
                        "Arvid",
                        "1",
                        "2010-03-19",
                        "0.85"});
#line 8
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table15, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table16.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table16.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
            table16.AddRow(new string[] {
                        "Gustav",
                        "1",
                        "2010-03-19",
                        "0.84"});
            table16.AddRow(new string[] {
                        "Arvid",
                        "1",
                        "2010-03-19",
                        "0.85"});
#line 14
 testRunner.When("I compare the set to this table", ((string)(null)), table16, "When ");
#line 20
 testRunner.Then("no set comparison exception should have been thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 1 column name differ")]
        public virtual void NotMatchingWhen1ColumnNameDiffer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not matching when 1 column name differ", null, ((string[])(null)));
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table17.AddRow(new string[] {
                        "Marcus"});
            table17.AddRow(new string[] {
                        "Albert"});
            table17.AddRow(new string[] {
                        "Gustav"});
            table17.AddRow(new string[] {
                        "Arvid"});
#line 23
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table17, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "N"});
            table18.AddRow(new string[] {
                        "Marcus"});
            table18.AddRow(new string[] {
                        "Albert"});
            table18.AddRow(new string[] {
                        "Gustav"});
            table18.AddRow(new string[] {
                        "Arvid"});
#line 29
 testRunner.When("I compare the set to this table", ((string)(null)), table18, "When ");
#line 35
 testRunner.Then("an set comparision exception should be thrown with 2 differences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 36
  testRunner.And("one set difference should be on the \'Name\' field of the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
  testRunner.And("one set difference should be on the \'N\' column of the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 2 header differ")]
        public virtual void NotMatchingWhen2HeaderDiffer()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not matching when 2 header differ", null, ((string[])(null)));
#line 39
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table19.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table19.AddRow(new string[] {
                        "Albert",
                        "3"});
            table19.AddRow(new string[] {
                        "Gustav",
                        "1"});
            table19.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 40
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table19, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Namn",
                        "Ålder"});
            table20.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table20.AddRow(new string[] {
                        "Albert",
                        "3"});
            table20.AddRow(new string[] {
                        "Gustav",
                        "1"});
            table20.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 46
 testRunner.When("I compare the set to this table", ((string)(null)), table20, "When ");
#line 52
 testRunner.Then("an set comparision exception should be thrown with 4 differences", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
  testRunner.And("one set difference should be on the \'Name\' field of the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
  testRunner.And("one set difference should be on the \'Age\' field of the instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
  testRunner.And("one set difference should be on the \'Namn\' column of the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
  testRunner.And("one set difference should be on the \'Ålder\' column of the table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when the number of rows are more in the table")]
        public virtual void NotMatchingWhenTheNumberOfRowsAreMoreInTheTable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Not matching when the number of rows are more in the table", null, ((string[])(null)));
#line 58
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table21.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table21.AddRow(new string[] {
                        "Albert",
                        "3"});
#line 59
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table21, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age"});
            table22.AddRow(new string[] {
                        "Marcus",
                        "39"});
            table22.AddRow(new string[] {
                        "Albert",
                        "3"});
            table22.AddRow(new string[] {
                        "Arvid",
                        "1"});
#line 63
 testRunner.When("I compare the set to this table", ((string)(null)), table22, "When ");
#line 68
 testRunner.Then("an set comparison exception should be thrown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
  testRunner.And("the error message for different rows should expect 3 rows for table and 2 rows fo" +
                    "r instance", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Differences on 1 value in 1 row should throw exceptions")]
        public virtual void DifferencesOn1ValueIn1RowShouldThrowExceptions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Differences on 1 value in 1 row should throw exceptions", null, ((string[])(null)));
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table23.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table23.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
#line 72
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table23, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table24.AddRow(new string[] {
                        "Hugo",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table24.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
#line 76
 testRunner.When("I compare the set to this table", ((string)(null)), table24, "When ");
#line 80
 testRunner.Then("an set comparision exception should be thrown with 1 difference", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
  testRunner.And("1 difference should be on row 1 on property \'Name\' for the values \'Marcus\' and \'H" +
                    "ugo\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Differences on 2 value in 2 different row should throw exceptions")]
        public virtual void DifferencesOn2ValueIn2DifferentRowShouldThrowExceptions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Differences on 2 value in 2 different row should throw exceptions", null, ((string[])(null)));
#line 83
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table25.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table25.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "0.03"});
#line 84
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table25, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table26 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table26.AddRow(new string[] {
                        "Hugo",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table26.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
#line 88
 testRunner.When("I compare the set to this table", ((string)(null)), table26, "When ");
#line 92
 testRunner.Then("an set comparision exception should be thrown with 2 difference", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
  testRunner.And("1 difference should be on row 1 on property \'Name\' for the values \'Marcus\' and \'H" +
                    "ugo\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
  testRunner.And("2 difference should be on row 2 on property \'LengthInMeters\' for the values \'0.03" +
                    "\' and \'1.03\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Differences on 4 value on 1 row should throw exceptions")]
        public virtual void DifferencesOn4ValueOn1RowShouldThrowExceptions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Differences on 4 value on 1 row should throw exceptions", null, ((string[])(null)));
#line 96
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table27 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table27.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table27.AddRow(new string[] {
                        "Albert",
                        "3",
                        "2008-01-24",
                        "1.03"});
#line 97
 testRunner.Given("I create a set of dynamic instances from this table", ((string)(null)), table27, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table28 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "Age",
                        "Birth date",
                        "Length in meters"});
            table28.AddRow(new string[] {
                        "Marcus",
                        "39",
                        "1972-10-09",
                        "1.96"});
            table28.AddRow(new string[] {
                        "Hugo",
                        "2",
                        "2010-01-24",
                        "0.03"});
#line 101
 testRunner.When("I compare the set to this table", ((string)(null)), table28, "When ");
#line 105
 testRunner.Then("an set comparision exception should be thrown with 4 difference", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
  testRunner.And("1 difference should be on row 2 on property \'Name\' for the values \'Marcus\' and \'H" +
                    "ugo\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
  testRunner.And("2 difference should be on row 2 on property \'Age\' for the values \'3\' and \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
  testRunner.And("3 difference should be on row 2 on property \'BirthDate\' for the values \'2008-01-2" +
                    "4 12:00AM\' and \'2010-01-24 12:00AM\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
  testRunner.And("4 difference should be on row 2 on property \'LengthInMeters\' for the values \'1.03" +
                    "\' and \'0.03\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion