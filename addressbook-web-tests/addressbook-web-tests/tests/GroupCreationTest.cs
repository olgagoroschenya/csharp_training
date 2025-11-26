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
            app.NavigationHelper.OpenHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.NavigationHelper.GoToGroupsPage();
            app.GroupHelper.InitNewGroupCreation();
            app.GroupHelper.FillGroupForm(new GroupData("group1", "testGroup", "csharpTest"));
            app.GroupHelper.SubmitGroupCreation();
            app.GroupHelper.ReturnToGroupsPage();
            app.Logout.Logout();
        }

             
    }
}
