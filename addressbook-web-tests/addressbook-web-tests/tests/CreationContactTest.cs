
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebAddressbookTests
{
    [TestFixture]
    public class CreationContactTest: AuthTestBase
    {

        [Test]
        public void CreationContactTests()
        {
            ContactData contact = new ContactData("Petr", "Petrov");
            contact.Mobile_telephone = "75698456";
            contact.Email = "petr@mail.ru";
            contact.Nickname = "test";
            contact.Email2 = "petr2@mail.ru";
            contact.Fax = 589624;
            contact.Company = "ASDf";

            List<ContactData> oldContact = app.ContactHelper.GetContactList();

            app.ContactHelper.CreateContact(contact);

            List<ContactData> newContact = app.ContactHelper.GetContactList();
            oldContact.Add(contact);
            oldContact.Sort();
            newContact.Sort();
            Assert.AreEqual(oldContact, newContact);
            //app.Logout.Logout();
        }

    }
}
