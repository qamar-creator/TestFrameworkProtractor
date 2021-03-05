using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;
namespace Acclaim
{
    class PageObjects
    {
        public static string productprice()
        {
            string Modelforprice = "productPrice";

            return Modelforprice;

        }


        public static string discountonproduct()
        {
            string Modelfordiscount = "discountPercent";

            return Modelfordiscount;
        }


        public static string savedAmount()
        {

            string ModelsavedAmount = "#savedAmount";
            return ModelsavedAmount;
        }
    }
}