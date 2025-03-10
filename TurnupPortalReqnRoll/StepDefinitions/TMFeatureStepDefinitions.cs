using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using TurnupPortalBha.Pages;
using TurnupPortalBha.Utilities;

namespace TurnupPortalReqnRoll.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        TMPage tMPageobj = new TMPage();

        [BeforeScenario]
        public void SetupSteps()
        {

            //Open browser
            driver = new ChromeDriver();
        }

        [Given("I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            //Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);                     

        }

        [Given("I navigated to the Time and Material page")]
        public void GivenINavigatedToTheTimeAndMaterialPage()
        {
            //Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.NavigateToTMPage(driver);
        }

        [When("I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            //Create Time record
            //TM_Page object initialization and definition
            tMPageobj.CreateTimeRecord(driver);
        }

        [Then("The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string savedCode=tMPageobj.GetCode(driver);
            string newDescription = tMPageobj.GetDescription(driver);

            Assert.That(savedCode == "CodeBha001", "**Actual code and expected code do not match**");
            Assert.That(newDescription == "This is a description for Bha001", "**Actual description and expected description do not match**");

        }

        [When("I update the {string} and {string} on an existing time record")]
        public void WhenIUpdateTheOnAnExistingTimeRecord(string code, string description)
        {
            tMPageobj.EditTimeRecord(driver, code, description);

        }

        [Then("The record should have the updated {string} and {string}")]
        public void ThenTheRecordShouldHaveTheUpdated(string code,string description)
        {
            string editedCode = tMPageobj.GetEditedCode(driver);
            Assert.That(editedCode == code, "**Expected edited code does not match with the Actual edited code**");
            string editedDescription = tMPageobj.GetEditedDescription(driver);
            Assert.That(editedDescription == description, "**Expected edited description does not match with the Actual edited description**");
        }
        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
