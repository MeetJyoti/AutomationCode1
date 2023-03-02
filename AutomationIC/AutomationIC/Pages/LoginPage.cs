using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomationIC.Utilities;

namespace AutomationIC.Pages
{
    public class LoginPage
    {
        public void LoginActions(IWebDriver driver)
        {
            // Open Chrome browser
          
            driver.Manage().Window.Maximize();

            // Launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // Identify the username textbox and enter valid username
            Wait.WaitToBeClicakble(driver, "Id", "UserName", 5);
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // Identify the password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // Identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
           

        }
    }
}
