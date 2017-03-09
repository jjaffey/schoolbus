using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using NUnit.Framework;
using OpenQA.Selenium;


namespace ConsoleApplication1
{
    class GetSchoolBusHomePage
    {

        private static String HomeXpathId = ".//*[@id='top-nav']/div/ul[1]/li[1]/a";
        private static String SchoolBusesXpathID = ".//*[@id='top-nav']/div/ul[1]/li[2]/a";
        private static String OwnersXpathId = ".//*[@id='top-nav']/div/ul[1]/li[3]/a";
        private static String NotificatonsXpathID = ".//*[@id='top-nav']/div/ul[1]/li[4]/a";
        private static String AdministrationXpathID = ".//*[@id='admin-dropdown']";

        public GetSchoolBusHomePage(IWebDriver driver)
        {
            loadinhomepage(driver);

        }//end constructor


        public static void loadinhomepage(IWebDriver driver)
        {
           driver.Navigate().GoToUrl("https://tstsm.th.gov.bc.ca/schoolbus/ ");
           // driver.GetPage("https://tstsm.th.gov.bc.ca/schoolbus/ ");
        }

        public static void clickOnHomeLink(IWebDriver driver)
        {
            IWebElement homeEl = WebDriverUtilities.GetWebDriverWait(driver, HomeXpathId);
            homeEl.Click();
        }

        public static void clickOnSchoolBusesLink(IWebDriver driver)
        {
            IWebElement sbEl = WebDriverUtilities.GetWebDriverWait(driver, SchoolBusesXpathID);
            sbEl.Click();
        }

        public static void clickOnOwnersLink(IWebDriver driver)
        {
            IWebElement ownersEl = WebDriverUtilities.GetWebDriverWait(driver, OwnersXpathId);
            ownersEl.Click();
        }

        public static void clickOnNotificationsLink(IWebDriver driver)
        {
            IWebElement notificationsEl = WebDriverUtilities.GetWebDriverWait(driver, NotificatonsXpathID);
            notificationsEl.Click();
        }

        public static void clickOnAdministrationLink(IWebDriver driver)
        {
            IWebElement administrationEl = WebDriverUtilities.GetWebDriverWait(driver, AdministrationXpathID);
            administrationEl.Click();
        }

        }//end class

    }//end namespace 
