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
    class SchoolBusDriver
    {
        //schoolbuspage element ids
        private static String regionDropdownXpathID = ".//*[@id='selectedDistrictsIds']";
        private static String inspectorsDropdownXpathID = ".//*[@id='selectedInspectorsIds']";
        private static String citiesDropdownXpathID = ".//*[@id='selectedCitiesIds']";
        private static String schooldistrictsDropdownXpathID = ".//*[@id='selectedSchoolDistrictsIds']";
        private static String ownerDropdownXpathID = ".//*[@id='ownerId']";
        private static String registrationDropdownXpathID = ".//*[@id='key']";
        private static String timeperiodDropdownXpathID = ".//*[@id='nextInspection']";
        private static String searchButtonXpathID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[2]/div/button";
       
    
        private IWebElement el;

        static void Main(string[] args)
        {
           //
           DriverSetUp d = new DriverSetUp();
            
            GetSchoolBusHomePage gsb = new GetSchoolBusHomePage(d.setUpHeadlessStuff());
            GetAdministrationUserManagementPage aum = new GetAdministrationUserManagementPage(d.GetDriver());
            //GetOwnersPage gop = new GetOwnersPage(d.GetDriver());
            //GetSchoolBusesPage sbp = new GetSchoolBusesPage(d.setupstuff());
            //sbp.SelectRegionDropDown(d.setupstuff(),".//*[@id='selectedDistrictsIds']");
           // sbp.ClickOnSearchButton(driver, searchButtonXpathID);
        }
    }
}
 