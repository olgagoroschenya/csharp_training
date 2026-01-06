using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupRemovalTest:AuthTestBase
    {
               
        [Test]
        public void GroupRemovalTests()
        {
            List<GroupData> oldGroups = app.GroupHelper.GetGroupList();
            GroupData toBeRemoved = oldGroups[0];

            app.GroupHelper.RemoveGroups(1);

            List<GroupData> newGroups = app.GroupHelper.GetGroupList();

            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData group in newGroups)
            {
                Assert.AreNotEqual(group.Id, toBeRemoved.Id);
            }
        }

    }
}
