using NUnit.Framework;
using System;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests:TestBase
    {
        [Test]
        public void RemoveContactTest()
        {
            app.ContactHelper.RemoveContact();
        }
    }
}
