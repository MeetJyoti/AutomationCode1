using AutomationIC.Pages;
using AutomationIC.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace AutomationIC.StepDefinitions
{
    [Binding]
    public class TMFeautreStepDefinitions : CommonDriver

    {
        LoginPage LoginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage TMpageObj = new TMPage();

        [Given(@"I logged into Turnup Portal")]
        public void GivenILoggedIntoTurnupPortal()
        {
            driver = new ChromeDriver();

            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to Time and Material Page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObj.HomePageActionsTM(driver);
        }

        [When(@"I create a new Time and Material Record")]
        public void ThenICreateANewTimeAndMaterialRecord()
        {
            TMpageObj.TMrecord(driver);
        }

        [Then(@"The record should be successfully created")]
        public void ThenTheRecordShouldBeSuccessfullyCreated()
        {

            string newcode = TMpageObj.GetCode(driver);

            Assert.That(newcode == "Knight", "Actual Code and expected code does not match");


        }

        [When(@"I update '([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string Description)
        {
            TMpageObj.EditButton(driver, Description);
        }

        [Then(@"The record should have the updtaed '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdtaed(string Description)
        {
            var newDescription = TMpageObj.EditedDescription(driver);

            Assert.That(newDescription == Description, "Actual Code and expected code does not match");
        }

    }
}
