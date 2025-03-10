using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TurnupPortalBha.Utilities;

namespace TurnupPortalBha.Pages
{
    public class EmployeePage
    {
       // public IWebElement goToLastPageButton, saveButton, savedCode, newDescription, editedCode, codeInputField, descriptionInputField, priceInputField;
        public void CreateEmployeeRecord(IWebDriver driver)
        {
            try
            {
            // Click on Create New button
            IWebElement createNewButton = driver.FindElement(By.XPath("(//div[@id='container']//a)[1]"));
                createNewButton.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Create New Button has not been found");
            }

           
        }

        //*********Edit the employee record**********
        public void EditEmplpyeeRecord(IWebDriver driver,string code)
            {

        }

        //********Delete the employee record********      
        public void DeleteEmployeeRecord(IWebDriver driver)
        {   
        }
    }
    }

