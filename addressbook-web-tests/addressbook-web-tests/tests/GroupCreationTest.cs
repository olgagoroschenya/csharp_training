using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTest:AuthTestBase
    {
        [Test]
        public void GroupCreationTests()
        {
           GroupData group = new GroupData("group2");
            group.Header = "testGroup";
            group.Footer = "csharpTest";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.CreateGroup(group);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

        }
        [Test]
         public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.CreateGroup(group);
            
            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

        }
       
        //Этот тест будет не пройден, тк действительно группа, содержащая ' не будет создана, поэтому при проверке 
        //количества групп это количество всегда будет разным
        [Test]
        public void BadNameGroupCteationTest()
        {
            GroupData group = new GroupData("s's");
            group.Header = "";
            group.Footer = "";

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();

            app.GroupHelper.CreateGroup(group);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            oldGroups.Add(group);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

        }


    }
}
