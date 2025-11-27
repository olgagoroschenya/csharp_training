
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class CreationContactTest:TestBase
    {

        [Test]
        public void CreationContactTests()
        {
            ContactData contact = new ContactData("Petr", "Petrov", 75698456, "petr@mail.ru", new DateTime(2001, 02, 02));
            contact.Nickname = "test";
            contact.Email2 = "petr2@mail.ru";
            contact.Fax = 589624;
            contact.Company = "ASDf";

            app.ContactHelper.CreateContact(contact);
           // app.navigationHelper.OpenHomePage();
            //app.Auth.Login(new AccountData("admin", "secret"));
            //app.navigationHelper.GoToAddNewPage();
            
           // app.ContactHelper.FillContactForm(contact);
            //app.ContactHelper.SubmitContactCreation();
            //app.ContactHelper.GoToHomePage();
            //app.Logout.Logout();
        }

    }
}
