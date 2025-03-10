using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TurnupPortalBha.Pages
{
    public class HomePage
    {
        public void NavigateToTMPage(IWebDriver driver)
        { 
            //Click on Administration tab
            IWebElement administrationTab = driver.FindElement(By.XPath("(//a[@class='dropdown-toggle'])[1]"));
            administrationTab.Click();

            //Click on Time and Materials tab
            IWebElement timeAndMaterialsTab = driver.FindElement(By.XPath("(//ul[@class='dropdown-menu']//a)[3]"));
            timeAndMaterialsTab.Click();

           
        }

        public void NavigateToEmployeePage(IWebDriver driver)
        {
            try
            {
                //Click on Administration tab
                IWebElement administrationTab = driver.FindElement(By.XPath("(//a[@class='dropdown-toggle'])[1]"));
                administrationTab.Click();

                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText("Employees")));
                //Click on Employee tab
                IWebElement employeeOption = driver.FindElement(By.LinkText("Employees"));
                employeeOption.Click();
            }
            catch(Exception ex)
            {
                Assert.Fail("Turnup portal page is not displayed" + ex.Message);
            }

        }
    }
}
