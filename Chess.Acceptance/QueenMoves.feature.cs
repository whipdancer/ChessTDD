﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Chess.Acceptance
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class QueenMovementFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "QueenMoves.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Queen Movement", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Queen Movement")))
            {
                Chess.Acceptance.QueenMovementFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A queen in her beginning position on an empty board")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Queen Movement")]
        public virtual void AQueenInHerBeginningPositionOnAnEmptyBoard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A queen in her beginning position on an empty board", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3",
                        "4",
                        "5",
                        "6",
                        "7",
                        "8"});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "WQ",
                        "",
                        "",
                        "",
                        ""});
#line 4
 testRunner.When("there is a chess board set up as", ((string)(null)), table1, "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "Y"});
            table2.AddRow(new string[] {
                        "1",
                        "1"});
            table2.AddRow(new string[] {
                        "2",
                        "1"});
            table2.AddRow(new string[] {
                        "3",
                        "1"});
            table2.AddRow(new string[] {
                        "5",
                        "1"});
            table2.AddRow(new string[] {
                        "6",
                        "1"});
            table2.AddRow(new string[] {
                        "7",
                        "1"});
            table2.AddRow(new string[] {
                        "8",
                        "1"});
            table2.AddRow(new string[] {
                        "4",
                        "2"});
            table2.AddRow(new string[] {
                        "4",
                        "3"});
            table2.AddRow(new string[] {
                        "4",
                        "4"});
            table2.AddRow(new string[] {
                        "4",
                        "5"});
            table2.AddRow(new string[] {
                        "4",
                        "6"});
            table2.AddRow(new string[] {
                        "4",
                        "7"});
            table2.AddRow(new string[] {
                        "4",
                        "8"});
            table2.AddRow(new string[] {
                        "3",
                        "2"});
            table2.AddRow(new string[] {
                        "2",
                        "3"});
            table2.AddRow(new string[] {
                        "1",
                        "4"});
            table2.AddRow(new string[] {
                        "5",
                        "2"});
            table2.AddRow(new string[] {
                        "6",
                        "3"});
            table2.AddRow(new string[] {
                        "7",
                        "4"});
            table2.AddRow(new string[] {
                        "8",
                        "5"});
#line 14
 testRunner.Then("the piece at (4,1) should have exactly the following moves", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Queens in their beginning positions when all pieces are present")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Queen Movement")]
        public virtual void QueensInTheirBeginningPositionsWhenAllPiecesArePresent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Queens in their beginning positions when all pieces are present", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3",
                        "4",
                        "5",
                        "6",
                        "7",
                        "8"});
            table3.AddRow(new string[] {
                        "BR",
                        "BKn",
                        "BB",
                        "BK",
                        "BQ",
                        "BB",
                        "BKn",
                        "BR"});
            table3.AddRow(new string[] {
                        "BP",
                        "BP",
                        "BP",
                        "BP",
                        "BP",
                        "BP",
                        "BP",
                        "BP"});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table3.AddRow(new string[] {
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "WP",
                        "WP"});
            table3.AddRow(new string[] {
                        "WR",
                        "WKn",
                        "WB",
                        "WQ",
                        "WK",
                        "WB",
                        "WKn",
                        "WR"});
#line 39
 testRunner.When("there is a chess board set up as", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "Y"});
#line 49
 testRunner.Then("the piece at (4,1) should have exactly the following moves", ((string)(null)), table4, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "Y"});
#line 51
 testRunner.And("the piece at (5,8) should have exactly the following moves", ((string)(null)), table5, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A queen with a capture opportunity")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Queen Movement")]
        public virtual void AQueenWithACaptureOpportunity()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A queen with a capture opportunity", ((string[])(null)));
#line 54
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3",
                        "4",
                        "5",
                        "6",
                        "7",
                        "8"});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "BQ",
                        "",
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "WQ",
                        "",
                        "",
                        "",
                        ""});
#line 55
 testRunner.When("there is a chess board set up as", ((string)(null)), table6, "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "Y"});
            table7.AddRow(new string[] {
                        "1",
                        "1"});
            table7.AddRow(new string[] {
                        "2",
                        "1"});
            table7.AddRow(new string[] {
                        "3",
                        "1"});
            table7.AddRow(new string[] {
                        "5",
                        "1"});
            table7.AddRow(new string[] {
                        "6",
                        "1"});
            table7.AddRow(new string[] {
                        "7",
                        "1"});
            table7.AddRow(new string[] {
                        "8",
                        "1"});
            table7.AddRow(new string[] {
                        "4",
                        "2"});
            table7.AddRow(new string[] {
                        "4",
                        "3"});
            table7.AddRow(new string[] {
                        "4",
                        "4"});
            table7.AddRow(new string[] {
                        "4",
                        "5"});
            table7.AddRow(new string[] {
                        "4",
                        "6"});
            table7.AddRow(new string[] {
                        "4",
                        "7"});
            table7.AddRow(new string[] {
                        "4",
                        "8"});
            table7.AddRow(new string[] {
                        "3",
                        "2"});
            table7.AddRow(new string[] {
                        "2",
                        "3"});
            table7.AddRow(new string[] {
                        "1",
                        "4"});
            table7.AddRow(new string[] {
                        "5",
                        "2"});
            table7.AddRow(new string[] {
                        "6",
                        "3"});
            table7.AddRow(new string[] {
                        "7",
                        "4"});
            table7.AddRow(new string[] {
                        "8",
                        "5"});
#line 65
 testRunner.Then("the piece at (4,1) should have exactly the following moves", ((string)(null)), table7, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A queen surrounded by enemy pieces")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Queen Movement")]
        public virtual void AQueenSurroundedByEnemyPieces()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A queen surrounded by enemy pieces", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "1",
                        "2",
                        "3",
                        "4",
                        "5",
                        "6",
                        "7",
                        "8"});
            table8.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "BQ",
                        "",
                        "",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "",
                        "",
                        "BB",
                        "BB",
                        "BP",
                        "",
                        "",
                        ""});
            table8.AddRow(new string[] {
                        "",
                        "",
                        "BR",
                        "WQ",
                        "BR",
                        "",
                        "",
                        ""});
#line 90
 testRunner.When("there is a chess board set up as", ((string)(null)), table8, "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "X",
                        "Y"});
            table9.AddRow(new string[] {
                        "3",
                        "1"});
            table9.AddRow(new string[] {
                        "5",
                        "1"});
            table9.AddRow(new string[] {
                        "3",
                        "2"});
            table9.AddRow(new string[] {
                        "4",
                        "2"});
            table9.AddRow(new string[] {
                        "5",
                        "2"});
#line 100
 testRunner.Then("the piece at (4,1) should have exactly the following moves", ((string)(null)), table9, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion