using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        {
        }

        public ContactHelper CreateContact(ContactData contact)
        {
            manager.NavigationHelper.GoToAddNewPage();
            FillContactForm(contact);
            SubmitContactCreation();
            GoToHomePage();
            return this;
        }
        public ContactHelper RemoveContact(int p)
        {
            SelectContact(1);
            DeleteContact();
            GoToHomePage();
            return this;
        }

      

        public ContactHelper ModificateContact(int y, ContactData newDataContact)
        {
            SelectContact(1);
            EditContact();
            FillContactForm(newDataContact);
            UpdateContact();
            GoToHomePage();
            return this;
        }

        public ContactHelper EditContact()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }

        public ContactHelper UpdateContact()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            contactCache = null;
            return this;
        }

       
        public ContactHelper FillContactForm(ContactData contact)
        {
            Type(By.Name("firstname"), contact.First_name);
            Type(By.Name("middlename"), contact.Middle_name);
            Type(By.Name("lastname"), contact.Last_name);
            Type(By.Name("nickname"), contact.Nickname);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Address);
            Type(By.Name("home"), contact.Home_telephone);
            Type(By.Name("mobile"), contact.Mobile_telephone);
            Type(By.Name("work"), contact.Work_telephone);
            Type(By.Name("fax"), contact.Fax.ToString());
            Type(By.Name("email"), contact.Email);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("email3"), contact.Email3);
            Type(By.Name("byear"), contact.Birthday.Year.ToString());

            // driver.FindElement(By.Name("firstname")).Click();
            //driver.FindElement(By.Name("firstname")).Clear();
            //driver.FindElement(By.Name("firstname")).SendKeys(contact.First_name);

            // driver.FindElement(By.Name("middlename")).Click();
            //driver.FindElement(By.Name("middlename")).Clear();
            //driver.FindElement(By.Name("middlename")).SendKeys(contact.Middle_name);

            //driver.FindElement(By.Name("lastname")).Click();
            //driver.FindElement(By.Name("lastname")).Clear();
            //driver.FindElement(By.Name("lastname")).SendKeys(contact.Last_name);

            //driver.FindElement(By.Name("nickname")).Click();
            //driver.FindElement(By.Name("nickname")).Clear();
            //driver.FindElement(By.Name("nickname")).SendKeys(contact.Nickname);

            //driver.FindElement(By.Name("photo")).Click();
            //driver.FindElement(By.Name("photo")).Clear();
            //driver.FindElement(By.Name("photo")).SendKeys("C:\\fakepath\\photo.png");

            // driver.FindElement(By.Name("title")).Click();
            //driver.FindElement(By.Name("title")).Clear();
            //driver.FindElement(By.Name("title")).SendKeys(contact.Title);

            // driver.FindElement(By.Name("company")).Click();
            //driver.FindElement(By.Name("company")).Clear();
            //driver.FindElement(By.Name("company")).SendKeys(contact.Company);

            //driver.FindElement(By.Name("address")).Click();
            //driver.FindElement(By.Name("address")).Clear();
            //driver.FindElement(By.Name("address")).SendKeys(contact.Address);

            // driver.FindElement(By.Name("home")).Click();
            //driver.FindElement(By.Name("home")).Clear();
            //driver.FindElement(By.Name("home")).SendKeys(contact.Home_telephone.ToString());

            // driver.FindElement(By.Name("mobile")).Click();
            // driver.FindElement(By.Name("mobile")).Clear();
            //driver.FindElement(By.Name("mobile")).SendKeys(contact.Mobile_telephone.ToString());

            // driver.FindElement(By.Name("work")).Click();
            //driver.FindElement(By.Name("work")).Clear();
            //driver.FindElement(By.Name("work")).SendKeys(contact.Work_telephone.ToString());

            //driver.FindElement(By.Name("fax")).Click();
            //driver.FindElement(By.Name("fax")).Clear();
            // driver.FindElement(By.Name("fax")).SendKeys(contact.Fax.ToString());

            //driver.FindElement(By.Name("email")).Click();
            //driver.FindElement(By.Name("email")).Clear();
            //driver.FindElement(By.Name("email")).SendKeys(contact.Email);

            // driver.FindElement(By.Name("email2")).Click();
            //driver.FindElement(By.Name("email2")).Clear();
            //driver.FindElement(By.Name("email2")).SendKeys(contact.Email2);

            // driver.FindElement(By.Name("email3")).Click();
            //driver.FindElement(By.Name("email3")).Clear();
            //driver.FindElement(By.Name("email3")).SendKeys(contact.Email3);

            // driver.FindElement(By.Name("bday")).Click();
            // new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(contact.Birthday.Day.ToString());
            //driver.FindElement(By.XPath("//option[@value='1']")).Click();

            //driver.FindElement(By.Name("bmonth")).Click();
            //new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(contact.Birthday.Month.ToString());
            // driver.FindElement(By.XPath("//option[@value='January']")).Click();
          
            //driver.FindElement(By.Name("byear")).Click();
            //driver.FindElement(By.Name("byear")).Clear();
            //driver.FindElement(By.Name("byear")).SendKeys(contact.Birthday.Year.ToString());

            //driver.FindElement(By.Name("aday")).Click();
            //  new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("1");
            // driver.FindElement(By.XPath("//div[@id='content']/form/select[3]/option[3]")).Click();
            // driver.FindElement(By.Name("amonth")).Click();
            // new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("January");
            //  driver.FindElement(By.XPath("//div[@id='content']/form/select[4]/option[2]")).Click();
            //  driver.FindElement(By.Name("ayear")).Click();
            //  driver.FindElement(By.Name("ayear")).Clear();
            // driver.FindElement(By.Name("ayear")).SendKeys("2034");
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//form/input[20]")).Click();
            contactCache = null;
            return this;
        }

        public ContactHelper GoToHomePage()
        {
            driver.FindElement(By.LinkText("home page")).Click();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            if (IsContactExists())
            {
               return this;
            }
            else 
            {
                ContactData newContact = new ContactData("Olga", "Gor");
                CreateContact(newContact);
               
                driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            }

                return this;
        }

        public bool IsContactExists()
        {
            int index = 1;
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return true;
           
        }

        public ContactHelper DeleteContact()
        {
            driver.FindElement(By.Name("delete")).Click();
            contactCache = null;
            return this;
        }

        public ContactHelper AddToGroup()
        {
            driver.FindElement(By.Name("to_group")).Click();
            new SelectElement(driver.FindElement(By.Name("to_group"))).SelectByText("d");
            driver.FindElement(By.XPath("//form[2]/div[4]/select/option[2]")).Click();
            driver.FindElement(By.Name("add")).Click();
            return this;
        }
        public ContactHelper GoToGroupPage()
        {
            driver.FindElement(By.LinkText("group page \"d\"")).Click();
            return this;
        }

        private List<ContactData> contactCache = null;
        public List<ContactData> GetContactList()
        {
            if (contactCache == null)
            { 
            contactCache = new List<ContactData>();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("td.center"));
                foreach (IWebElement element in elements)
                {
                    contactCache.Add(new ContactData(element.Text));
                }
            }
            return new List<ContactData> (contactCache);
        }

        public ContactData GetContactInformationFromTable(int index)
        {
            IList<IWebElement> cells = driver.FindElements(By.Name("entry"))[index].FindElements(By.TagName("td"));
            string lastName = cells[1].Text;
            string firstName = cells[2].Text;
            string address = cells[3].Text;
            string allPhones = cells[5].Text;

            return new ContactData(firstName, lastName)
            {
                Address = address,
                AllPhones = allPhones
            };
        }

        public ContactData GetContactInformationFromEditForm(int index)
        {

            EditContact();
            string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
            string lastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
            string address = driver.FindElement(By.Name("address")).GetAttribute("value");
            string homePhone = driver.FindElement(By.Name("home")).GetAttribute("value");
            string mobilePhone = driver.FindElement(By.Name("mobile")).GetAttribute("value");
            string workPhone = driver.FindElement(By.Name("work")).GetAttribute("value");

            return new ContactData(firstName, lastName)
            {
                Address = address,
                Home_telephone = homePhone,
                Mobile_telephone = mobilePhone,
                Work_telephone = workPhone
            };
            
        }
    }
}
//div[@id = 'content']