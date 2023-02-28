using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationIC.Pages
{
    public class TMPage
    {
        public void TMrecord(IWebDriver driver)
        {


            IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateNew.Click();
            Thread.Sleep(2000);

            IWebElement Dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            Dropdown.Click();

            IWebElement Time = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]"));
            Time.Click();

            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("Meet");

            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("VMS");

            //IWebElement Price = driver.FindElement(By.Id("Price"));
            //Price.SendKeys("100");

            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("100");

            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(1000);

            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPage.Click();
            Thread.Sleep(3000);

            driver.Close();



        }

    }
}
