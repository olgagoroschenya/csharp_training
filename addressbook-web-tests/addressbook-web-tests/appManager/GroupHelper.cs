using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class GroupHelper: HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base(manager)
        {

        }
        //Выделение вспомогательного метода, который включает в себя повторяющиеся действия создания группы (в GroupCreationTest).
        //Фактически этот метод содержит в себе вспомогательные методы ниже InitNewGroupCreation, FillGroupForm, SubmitGroupCreation
        //ReturnToGroupsPage

        public GroupHelper CreateGroup(GroupData group)
        {
            manager.NavigationHelper.GoToGroupsPage();
            InitNewGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            return this;
        }

        //Выделение вспомогательного метода, который включает в себя методы удаления группы
        public GroupHelper RemoveGroups(int p)
        {
            manager.NavigationHelper.GoToGroupsPage();
            SelectGroup(36);
            RemoveGroup();
            ReturnToGroupsPage();
            return this;
        }
        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.NavigationHelper.GoToGroupsPage();
            SelectGroup(36);
            InitGroupModification();
            FillGroupForm(newData);
            SubmitGroupModification();
            ReturnToGroupsPage();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
           //By locator = By.Name("group_name");
            //string text = group.Name;
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }

       

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper ReturnToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
            return this;
        }

     

        //Методы для удаления группы

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }
        
        public GroupHelper SelectGroup(int index)
        {
            if (IsGroupExists())
            {
                driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            }
            else 
            {
                GroupData newGroup = new GroupData("group3");
                //CreateGroup(newGroup);

                manager.NavigationHelper.GoToGroupsPage();
                InitNewGroupCreation();
                FillGroupForm(newGroup);
                SubmitGroupCreation();
                ReturnToGroupsPage();
                driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
               // return this;
            }
                //driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
                //driver.FindElement(By.Name("selected[]")).Click();
                //driver.FindElement(By.XPath("//div[@id='content']/form/input[5]")).Click();
                return this;
        }

        public bool IsGroupExists()
        {
            int index = 36;
            return IsElementPresent(By.XPath("(//input[@name='selected[]'])[" + index + "]"));
        }
    }
}
//(By.Name("selected[]")) //div[@id='content']/form/span[3]/input /html/body/div/div[4]/form/span[1]/input