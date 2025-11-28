using System;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTest:TestBase
    {
        [Test]
        public void GroupCreationTests()
        {
           GroupData group = new GroupData("group1");
            group.Header = "testGroup";
            group.Footer = "csharpTest";

           
            app.GroupHelper.CreateGroup(group);
           // app.Logout.Logout();
       }
        [Test]
         public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.GroupHelper.CreateGroup(group);
            app.Logout.Logout();
        }

             
    }
}
