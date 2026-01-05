using NUnit.Framework;
using System;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests:AuthTestBase
    {
        [Test]
        public void RemoveContactTest()
        {
            app.ContactHelper.RemoveContact(1);
        }
    }
}
