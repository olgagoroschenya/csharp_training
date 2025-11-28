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
        app.ContactHelper.ModificateContact();
     }

    }
}
