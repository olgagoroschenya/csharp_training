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
        
        [Test]
        public void TestContactDetailInformation()
        {
            ContactData fromDetails = app.ContactHelper.GetContactInformationFromDetails(0);
            ContactData fromForm = app.ContactHelper.GetContactInformationFromEditForm(0);

            Assert.AreEqual(fromDetails, fromForm);
            //Assert.AreEqual(fromDetails.Address, fromForm.Address);
            Assert.AreEqual(fromDetails.AllPhones, fromForm.AllPhones);
        }
    }
}
