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

            IWebElement admindropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admindropdown.Click();

            IWebElement TimeandMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul[1]/li[5]/ul/li[3]/a"));
            TimeandMaterial.Click();
            Thread.Sleep(2000);


        }

    }

}
