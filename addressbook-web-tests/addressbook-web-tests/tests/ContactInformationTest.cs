using NUnit.Framework;
using System;
using System.Collections.Generic;

using System;

namespace WebAddressbookTests
{     
    [TestFixture]
    public class ContactInformationTest : AuthTestBase
    {
        [Test]
        public void TestContactInformation()
        {
            ContactData fromTable = app.ContactHelper.GetContactInformationFromTable(0);
            ContactData fromForm = app.ContactHelper.GetContactInformationFromEditForm(0);

            Assert.AreEqual(fromTable, fromForm);
            Assert.AreEqual(fromTable.Address, fromForm.Address);
            Assert.AreEqual(fromTable.AllPhones, fromForm.AllPhones);
        }
    }
}
