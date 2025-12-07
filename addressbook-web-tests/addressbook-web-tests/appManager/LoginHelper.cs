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
            //By locator = By.Name("user");
            //string text = account.Username;
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

       
    }
}
