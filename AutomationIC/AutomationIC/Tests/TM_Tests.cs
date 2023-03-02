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
    public class TM_Tests : CommonDriver
    {
        [SetUp]
        public void LoginStepsTest()
        {
             driver = new ChromeDriver();
            // Login Page
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);


            //Home PAge
            HomePage homePageObj = new HomePage();
            homePageObj.HomePageActions(driver);

        }
        [Test]
        public void CreateTMTest()
        {
            //Create New TM object
            TMPage TMpageObj = new TMPage();
            TMpageObj.TMrecord(driver);


        }
        [Test]
        public void EditTMTest()
        { 
            //EDIT TM
            TMPage TMpageObj = new TMPage();
            TMpageObj.EditButton(driver);
        }
        [Test]
        public void DeleteTMTest()
        {

            //Delete TM
            TMPage TMpageObj = new TMPage();
            TMpageObj.DeleteButton(driver);
        }
        [TearDown]
        public void CloseTest()
        {
            driver.Close();

        }












    }
}
