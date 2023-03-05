using AutomationIC.Pages;
using AutomationIC.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationIC.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employees_Test: CommonDriver
    {



        //Home PAge
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        

        

        [Test, Order(1)]

        public void CreateEmployeeTest() 
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.CreateEmployee(driver);


        }
        [Test, Order(2)]
        public void EmployeeEditTest() 
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmployee(driver);


        }
        [Test, Order(3)]
        public void EmployeeDeleteTest()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }
        [TearDown]
        public void shutdownEmployeeTest() 
        { 
            driver.Quit();
        }








    }
}
