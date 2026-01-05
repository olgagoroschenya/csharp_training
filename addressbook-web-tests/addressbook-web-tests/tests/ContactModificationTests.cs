
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WebAddressbookTests
{ 
    [TestFixture]
    public class ContactModificationTests:AuthTestBase

    {
     [Test]
     public void ModificateContact()
     {
            ContactData newDataContact = new ContactData("P", "Pet", 75698456, "petr@mail.ru", new DateTime(2001, 02, 02));
            newDataContact.Nickname = "test";
            newDataContact.Email2 = "petr2@mail.ru";
            newDataContact.Fax = 589624;
            newDataContact.Company = null;

            List<ContactData> oldContact = app.ContactHelper.GetContactList();

            app.ContactHelper.ModificateContact(1, newDataContact);

            List<ContactData> newContact = app.ContactHelper.GetContactList();
            oldContact[0].First_name = newDataContact.First_name;
            oldContact.Sort();
            newContact.Sort();
            Assert.AreEqual(oldContact, newContact);
        }

    }
}
