using AutomationIC.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Thread.Sleep(1000);
            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span", 5);
            IWebElement Dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            Dropdown.Click();


            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"TypeCode_listbox\"]/li[2]", 5);
            IWebElement Time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            Time.Click();
            //*[@id="TimeMaterialEditForm"]/div/div[1]/div/span[1]/span/span[1]

            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("Knight");

            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("Omega");

            //IWebElement Price = driver.FindElement(By.Id("Price"));
            //Price.SendKeys("100");

            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceTextbox.SendKeys("100");

            Wait.WaitToBeClicakble(driver, "Id", "SaveButton", 5);
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();

            //Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);
            Thread.Sleep(2000);
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPage.Click();

            Thread.Sleep(2000);
            IWebElement NewCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(NewCode.Text == "Knight", "Actual Code and expected code does not match");



            //*[@id="tmsGrid"]/div[4]/a[4]/span

        }

        public void EditButton(IWebDriver driver)

        {

            Thread.Sleep(2000);
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPage.Click();
           

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]", 5);
            IWebElement Editrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Editrecord.Click();

            IWebElement EditDescription = driver.FindElement(By.Id("Description"));
            EditDescription.Clear();
            EditDescription.SendKeys("WhiteDeath");
            

            
            IWebElement EditSaveButton = driver.FindElement(By.Id("SaveButton"));
            EditSaveButton.Click();

            Thread.Sleep(2000);
            IWebElement LastPageEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPageEdit.Click();
            
           


        }
        public void DeleteButton(IWebDriver driver)
        {


            //Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 5);
            Thread.Sleep(2000);
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            LastPage.Click();

            Wait.WaitToBeClicakble(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]", 5);
            IWebElement Delete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            Delete.Click();

            IAlert deleteAlert = driver.SwitchTo().Alert();
            deleteAlert.Accept();

            


        }



    }
}
