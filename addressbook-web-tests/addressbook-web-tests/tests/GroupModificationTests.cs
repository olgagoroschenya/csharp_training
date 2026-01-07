using NUnit.Framework;
using System;
using System.Collections.Generic;

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

            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();
            GroupData oldData = oldGroups[0];

            app.GroupHelper.Modify(1, newData);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
            foreach (GroupData group in newGroups)
            {
                if (group.Id == oldData.Id)
                {
                    Assert.AreEqual(newData.Name, group.Name);
                }
                
            }
        }
    }
}
