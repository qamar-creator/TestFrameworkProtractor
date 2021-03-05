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
   
    public  class SETUP
    {
         
        public static IWebDriver driver;
        
        public   void TestMethodLogin()
        {
            driver = new ChromeDriver();  
            string url = ConfigurationManager.AppSettings.Get("url");
            //setting up the protractor pakcages
            var chromOptions = new ChromeOptions();
           //chromOptions.AddArgument("-no-sandbox");
             chromOptions.AddArgument("headless");

            PropertiesCollection.ngdriver = new NgWebDriver(driver);
            PropertiesCollection.ngdriver.Navigate().GoToUrl(url);
        }


        
        public  void TestMethodfillLogin()
        {
            
               
            CustomControls.Entertext( PageObjects.productprice(), ConfigurationManager.AppSettings.Get("price"), propertytype.Model); 
            CustomControls.Entertext( PageObjects.discountonproduct(), ConfigurationManager.AppSettings.Get("discount"), propertytype.Model);
            string acualresultofsavedamount = Calculations.calculatesavedamount(ConfigurationManager.AppSettings.Get("price"), ConfigurationManager.AppSettings.Get("discount"));
            Console.WriteLine("The calculated saved amount from test is " + " " + acualresultofsavedamount);           
            string savedamount= CustomeControlGets.GettextfromLabel(PageObjects.savedAmount(), propertytype.CssSelector);
            Console.WriteLine("The saved ammount refelected from application is"+ " "+savedamount);
            Assertions.assertionequals(acualresultofsavedamount, savedamount);
            string Amountafterdiscount = CustomeControlGets.Geettextfromtextbox("afterDiscount", propertytype.Model);
            Console.WriteLine("This is the amount to be paidis    "+Amountafterdiscount);
            
           
           
        }
    }
}

