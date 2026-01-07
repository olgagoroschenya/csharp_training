using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class LoginHelper : HelperBase
    {
     
        public LoginHelper(ApplicationManager manager) : base(manager)
        { }
               public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                { 
                return;
                }
                Logout();
            }
            //By locator = By.Name("user");
            //string text = account.Username;
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        public void Logout()
        {
            if (IsLoggedIn())
            { driver.FindElement(By.LinkText("Logout")).Click(); }
        }
        public bool IsLoggedIn()
        {
            return IsElementPresent(By.LinkText("Logout"));
        }
        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn() && GetLoggetUserName() == account.Username;
              
        }

        public string GetLoggetUserName()
        {
            string text = driver.FindElement(By.XPath("/html/body/div/div[1]/form/a")).
                 FindElement(By.XPath("/html/body/div/div[1]/form/b")).Text;
            return text.Substring(1, text.Length - 2);
        }
    }
}
//return IsLoggedIn() && driver.FindElement(By.LinkText("Logout")).FindElement(By.TagName("b")).Text ==
//  "(" + account.Username + ")";/html/body/div/div[1]/form/a /html/body/div/div[1]/form/b