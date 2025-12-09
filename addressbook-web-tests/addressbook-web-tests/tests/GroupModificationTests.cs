using NUnit.Framework;
using System;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests:AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("bb");
            newData.Header = null;
            newData.Footer = null;


            app.GroupHelper.Modify(1, newData);
        }
    }
}
