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
    public class TM_Tests : CommonDriver
    {


        //Page Object Initialization - Common Class  
        HomePage homePageObj = new HomePage();
        TMPage TMpageObj = new TMPage();
       

    
        [Test, Order(1)]
        public void CreateTMTest()
        {


        //Home PAge
        
            homePageObj.HomePageActionsTM(driver);
        //Create New TM object
            TMpageObj.TMrecord(driver);


        }
        [Test, Order(2)]
        public void EditTMTest()
        {
            //EDIT TM
            homePageObj.HomePageActionsTM(driver);
            TMpageObj.EditButton(driver);
        }
        [Test, Order(3)]
        public void DeleteTMTest()
        {

            //Delete TM
            homePageObj.HomePageActionsTM(driver);
            TMpageObj.DeleteButton(driver);
        }
        [TearDown]
        public void CloseTest()
        {
            driver.Close();

        }












    }
}
