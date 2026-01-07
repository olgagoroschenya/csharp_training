using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected LoginHelper loginHelper;
        //protected LogoutHelper logoutHelper;
        public NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        protected IWebDriver driver;
        protected StringBuilder verificationErrors;
        protected string baseURL;
        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        public void SetupTest()
        {
           
            
            verificationErrors = new StringBuilder();

        }
        private ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/addressbook/addressbook/";
            loginHelper = new LoginHelper(this);
            //logoutHelper = new LogoutHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }
        //  ~ApplicationManager()
        
        [TearDown]
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
            Assert.AreEqual("", verificationErrors.ToString());
        }

        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated)
            { 
            ApplicationManager newInstance = new ApplicationManager();
                
                newInstance.NavigationHelper.OpenHomePage();
                app.Value = newInstance;
            }
            return app.Value;
        }

        public IWebDriver Driver 
        {
            get { return driver; }
        }
       
       
        public LoginHelper Auth 
        { get {return loginHelper;} }

       // public LogoutHelper Logout 
       // { get {return logoutHelper;} }

        public NavigationHelper NavigationHelper 
        { get {return navigationHelper;} }

        public GroupHelper GroupHelper 
        { get {return groupHelper;} }

        public ContactHelper ContactHelper 
        { get {return contactHelper;} }

        
    }
}
