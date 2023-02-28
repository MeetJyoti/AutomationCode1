using AutomationIC.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();

// Login Page
LoginPage LoginPageObj = new LoginPage();
LoginPageObj.LoginActions(driver);


//Home PAge
HomePage homePageObj = new HomePage();
homePageObj.HomePageActions(driver);


//Create New TM object
TMPage TMpageObj = new TMPage();
TMpageObj.TMrecord(driver);