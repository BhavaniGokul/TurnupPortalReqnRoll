using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using TurnupPortalBha.Pages;
using TurnupPortalBha.Utilities;

namespace TurnupPortalReqnRoll.StepDefinitions 
{
    [Binding]
    public class EmployeeFeatureStepDefinitions : CommonDriver
    {
        //Home page object initialization and definition
        HomePage homePageObj = new HomePage();

        //Employee page object initialization and definition
        EmployeePage employeePageObj = new EmployeePage();

        [BeforeScenario]
        public void SetupSteps()
        {

            //Open browser
            driver = new ChromeDriver();
        }

        [Given("I navigated to Employee page")]
        public void GivenINavigatedToEmployeePage()
        {
            
            homePageObj.NavigateToEmployeePage(driver);
        }

        [When("I create a new employee record")]
        public void WhenICreateANewEmployeeRecord()
        {
            employeePageObj.CreateEmployeeRecord(driver);
        }

        [Then("The employee record should be created successfully")]
        public void ThenTheEmployeeRecordShouldBeCreatedSuccessfully()
        {
           // string savedCode = tMPageobj.GetCode(driver);
            //string newDescription = tMPageobj.GetDescription(driver);

            //Assert.That(savedCode == "CodeBha001", "**Actual code and expected code do not match**");
        }
        [AfterScenario]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
