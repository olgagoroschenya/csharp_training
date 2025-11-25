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
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitNewGroupCreation();
            FillGroupForm(new GroupData("group1", "testGroup", "csharpTest"));
            SubmitGroupCreation();
            ReturnToGroupsPage();
            Logout();
        }

             
    }
}
