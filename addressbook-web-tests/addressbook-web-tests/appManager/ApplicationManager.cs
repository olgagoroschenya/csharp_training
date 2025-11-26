using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected LoginHelper loginHelper;
        protected LogoutHelper logoutHelper;
        public NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        protected IWebDriver driver;
        protected StringBuilder verificationErrors;
        protected string baseURL;
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/addressbook/";
            verificationErrors = new StringBuilder();

        }
        public ApplicationManager()
        {
            loginHelper = new LoginHelper(driver);
            logoutHelper = new LogoutHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);
        }
       
        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth 
        { get {return loginHelper;} }

        public LogoutHelper Logout 
        { get {return logoutHelper;} }

        public NavigationHelper NavigationHelper 
        { get {return navigationHelper;} }

        public GroupHelper GroupHelper 
        { get {return groupHelper;} }

        public ContactHelper ContactHelper 
        { get {return contactHelper;} }
    }
}
