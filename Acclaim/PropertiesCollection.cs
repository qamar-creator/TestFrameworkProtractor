﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;

namespace Acclaim
{

    enum propertytype
    {
        Model,
        Repeater,
        Id,
        Name,
        CssSelector,
        Class,
        XPath,
        LinkText
    }

    class PropertiesCollection
    {


        //Auto implemented property


        public static NgWebDriver ngdriver { get; set; }

        
    }

}