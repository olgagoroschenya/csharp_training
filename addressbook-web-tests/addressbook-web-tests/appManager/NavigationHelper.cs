using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
            public string baseURL = "http://localhost/addressbook/addressbook/";
        

        public NavigationHelper(ApplicationManager manager, string baseURL): base(manager)
        {
                 
            this.baseURL = baseURL;
        }
        public void OpenHomePage()
        {
            if (driver.Url == baseURL)
            { return; }
            driver.Navigate().GoToUrl(baseURL);
            
        }
        public void GoToGroupsPage()
        {
            if (driver.Url == baseURL + "group.php" && IsElementPresent(By.Name("new")))
                { return; }
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void GoToAddNewPage()
        {
            if (driver.Url == baseURL + "edit.php" && IsElementPresent(By.Name("submit")))
            { return; }

            driver.FindElement(By.LinkText("add new")).Click();
        }
    }
}
