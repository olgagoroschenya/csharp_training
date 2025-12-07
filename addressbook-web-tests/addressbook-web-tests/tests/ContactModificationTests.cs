using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace WebAddressbookTests
{ 
    [TestFixture]
    public class ContactModificationTests:TestBase

    {
     [Test]
     public void ModificateContact()
     {
            ContactData newDataContact = new ContactData("Petr", "Petrov", 75698456, "petr@mail.ru", new DateTime(2001, 02, 02));
            newDataContact.Nickname = "test";
            newDataContact.Email2 = "petr2@mail.ru";
            newDataContact.Fax = 589624;
            newDataContact.Company = null;

            app.ContactHelper.ModificateContact(1, newDataContact);
     }

    }
}
