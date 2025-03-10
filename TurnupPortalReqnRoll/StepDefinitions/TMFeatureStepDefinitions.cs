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

        [Given("I logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            //Open browser
            driver = new ChromeDriver();

            //Login Page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginActions(driver);                     

        }

        [When("I navigated to the Time and Material page")]
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
        [When("I update the {string} on an existing time record")]
        public void WhenIUpdateTheOnAnExistingTimeRecord(string code)
        {
            tMPageobj.EditTimeRecord(driver, code);

        }

        [Then("The record should have the updated {string}")]
        public void ThenTheRecordShouldHaveTheUpdated(string code)
        {
            string editedCode = tMPageobj.GetEditedCode(driver);
            Assert.That(editedCode == code, "**Expected edited code does not match with the Actual edited code**");
        }

    }
}
