using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V108.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationIC.Pages;
using NUnit.Framework;

namespace AutomationIC.Utilities
{
    public class CommonDriver
    {

        public static IWebDriver driver;

        [SetUp]
        public void LoginStepsTest()
        {
            driver = new ChromeDriver();
            // Login Page
            LoginPage LoginPageObj = new LoginPage();
            LoginPageObj.LoginActions(driver);

        }
    }
}