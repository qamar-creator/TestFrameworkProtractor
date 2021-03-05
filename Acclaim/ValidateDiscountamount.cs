using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;
using OpenQA.Selenium.Support.UI;
using Protractor;
 

namespace Acclaim
{
    [TestClass]
    public class UnitTest1
    {
        
        public static IWebDriver driver { get; set; }
        private NgWebDriver ngDriver { get; set; }
        private WebDriverWait WaitTime;
        SETUP setup = new SETUP();
        [TestMethod]
        public void Adduser()

        {
            setup.TestMethodLogin();

           
        }

        [TestMethod]

        public void edituser()
        {
            setup.TestMethodfillLogin();
        }

    }
}
 