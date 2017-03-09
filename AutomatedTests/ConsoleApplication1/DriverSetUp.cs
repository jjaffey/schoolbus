using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;



namespace ConsoleApplication1
{
    class DriverSetUp
    {
        private IWebDriver driver;

        public DriverSetUp()
        {
        }

        public IWebDriver setupstuff()
        {
            driver = new InternetExplorerDriver(@"C:\DropBox\visual studio\drivers");
            driver.Navigate().GoToUrl("https://tstsm.th.gov.bc.ca/schoolbus/ ");
            return driver;
        }

        public NHtmlUnit setUpHeadlessStuff()
        {
            IWebDriver NHtmlUnitDriver = new NHtmlUnit.WebClient();
            return NHtmlUnitDriver;

        }

        public IWebDriver GetDriver()
        {
            return driver;
        }

        public void driveTearDown()
        {

        }

    }
}

