using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading;


namespace WebAddressbookTests
{
    public class TestBase
    {
        protected ApplicationManager app;
       

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
            app.NavigationHelper.OpenHomePage();
           
        }

        [TearDown]
        public void TeardownTest()
        { 
            app.Stop();
        }
    }
}
