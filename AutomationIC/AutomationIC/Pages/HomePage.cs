using AutomationIC.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationIC.Pages
{
    public class HomePage
    {
        public void HomePageActions(IWebDriver driver)
        {
            Wait.WaitToBeClicakble(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/a", 5);
            IWebElement admindropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admindropdown.Click();

           
            Wait.WaitToBeClicakble(driver, "XPath", "/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a", 5);
            IWebElement TimeandMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));
            TimeandMaterial.Click();
            


        }

    }

}
