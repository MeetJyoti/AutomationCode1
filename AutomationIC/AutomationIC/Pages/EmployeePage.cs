using AutomationIC.Utilities;
using NuGet.Frameworks;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationIC.Pages
{
    public class EmployeePage : CommonDriver
    {

        public void CreateEmployee(IWebDriver driver)
        {

            IWebElement CreateEmployeeRecord = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            CreateEmployeeRecord.Click();

            IWebElement Name = driver.FindElement(By.Id("Name"));
            Name.SendKeys("Ronaldo");

            IWebElement UserName = driver.FindElement(By.Id("Username"));
            UserName.SendKeys("CR7");

            IWebElement EnterRecordEditContactbutton = driver.FindElement(By.Id("ContactDisplay"));
            EnterRecordEditContactbutton.SendKeys("Madrird 07");

            //IWebElement EditContactbutton = driver.FindElement(By.Id("EditContactButton"));
            //EditContactbutton.Click();
            //Thread.Sleep(2000);

            //IWebElement FirstName = driver.FindElement(By.Id("FirstName"));
            //FirstName.SendKeys("Cristiano");

            //IWebElement LastName = driver.FindElement(By.Id("LastName"));
            //LastName.SendKeys("Ronaldo");

            //IWebElement PreferedName = driver.FindElement(By.Id("PreferedName"));
            //PreferedName.SendKeys("CR");

            //IWebElement Phone = driver.FindElement(By.Id("Phone"));
            //Phone.SendKeys("0707070707");

            //IWebElement Mobile = driver.FindElement(By.Id("Mobile"));
            //Mobile.SendKeys("8879737621");

            //IWebElement Email = driver.FindElement(By.Id("email"));
            //Email.SendKeys("ronaldo@gmail.com");

            //IWebElement Address = driver.FindElement(By.Id("autocomplete"));
            //Address.SendKeys("Portugal Palace, 07 Sector");

            //IWebElement Street = driver.FindElement(By.Id("Street"));
            //Street.SendKeys("P9");

            //IWebElement City = driver.FindElement(By.Id("City"));
            //City.SendKeys("Madrid");

            //IWebElement PostCode = driver.FindElement(By.Id("Postcode"));
            //PostCode.SendKeys("1546");

            //IWebElement Country = driver.FindElement(By.Id("Country"));
            //Country.SendKeys("Spain");

            //IWebElement SubmitButton = driver.FindElement(By.Id("submitButton"));
            //SubmitButton.Click();

            ////////

            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("MeetShah@2");

            IWebElement ReTypepassword = driver.FindElement(By.Id("RetypePassword"));
            ReTypepassword.SendKeys("MeetShah@2");
            
            Assert.That(password.Text == ReTypepassword.Text, "Please Retype Password Correctly");
            /////

            Thread.Sleep(1000);
            IWebElement IsAdminCheckBox = driver.FindElement(By.Id("IsAdmin"));
            IsAdminCheckBox.Click();

            IWebElement Vehicle = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            Vehicle.SendKeys("GTR");

            //IWebElement Groups = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
            //Groups.Click();
            //Thread.Sleep(1000);

            ////*[@id="groupList_listbox"]
            //IWebElement SelectGroups = driver.FindElement(By.XPath("//*[@id=\"groupList_listbox\"]/"));
            //SelectGroups.Click();
            //Thread.Sleep(1000);

            IWebElement SaveRecord = driver.FindElement(By.Id("SaveButton"));
            SaveRecord.Click();
            Thread.Sleep(1000);

            IWebElement backToList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList.Click();
            Thread.Sleep(1000);


            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();
            Thread.Sleep(1000);

            IWebElement NewRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(NewRecord.Text == "Ronaldo", "New Record Not Created");
        
        
        }

        public void EditEmployee(IWebDriver driver)
        {
            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();
            Thread.Sleep(1000);
         

            IWebElement EditRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            EditRecord.Click();
            Thread.Sleep(1000);

            IWebElement EditName= driver.FindElement(By.Id("Name"));
            EditName.Clear();
            EditName.SendKeys("Messi");

            IWebElement EditUserName = driver.FindElement(By.Id("Username"));
            EditUserName.Clear();
            EditUserName.SendKeys("LM10");

            IWebElement EditContact = driver.FindElement(By.Id("ContactDisplay"));
            EditContact.Clear();
            EditContact.SendKeys("Argentina Rosario");

            IWebElement EditPassword = driver.FindElement(By.Id("Password"));
            EditPassword.Clear();
            EditPassword.SendKeys("LionelMessi@10");

            IWebElement EditReTypePassword = driver.FindElement(By.Id("RetypePassword"));
            EditReTypePassword.Clear();
            EditReTypePassword.SendKeys("LionelMessi@10");

            Assert.That(EditPassword.Text == EditReTypePassword.Text, "Password is not matchable");

            IWebElement EditVehicle = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[7]/div/span[1]/span/input"));
            EditVehicle.Clear();
            EditVehicle.SendKeys("LionelMessi@10");

            IWebElement EditSave = driver.FindElement(By.Id("SaveButton"));
            EditSave.Click();

            IWebElement backToList = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backToList.Click();
            Thread.Sleep(2000);

            IWebElement RecordFindlastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            RecordFindlastPage.Click();
            Thread.Sleep(1000);

            IWebElement EditedRecord= driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            
            Assert.That(EditedRecord.Text == "Messi", "Record is not been created");



        }
        public void DeleteEmployee(IWebDriver driver)
        {


            IWebElement lastPage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            lastPage.Click();
            Thread.Sleep(1000);

            IWebElement DeleteRecord = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            DeleteRecord.Click();
            Thread.Sleep(1000);

            IAlert deleteAlert = driver.SwitchTo().Alert();
            deleteAlert.Accept();

            

        }







    }
}
