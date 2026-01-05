using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests:AuthTestBase
    {
        [Test]
        public void RemoveContactTest()
        {
            List<ContactData> oldContact = app.ContactHelper.GetContactList();
            app.ContactHelper.RemoveContact(1);
            List<ContactData> newContact = app.ContactHelper.GetContactList();
            oldContact.RemoveAt(0);
            Assert.AreEqual(oldContact, newContact);
        }
    }
}
