using NUnit.Framework;
using System;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests:TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("bb");
            newData.Header = "nn";
            newData.Footer = "mm";


            app.GroupHelper.Modify(1, newData);
        }
    }
}
