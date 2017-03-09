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
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using NUnit.Framework;
using OpenQA.Selenium;


namespace ConsoleApplication1
{
    public class GetSchoolBusesPage
    {
        private static String regionDropdownXpathID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[1]/button";
        private static String inspectorsDropdownXpathID = "html/body/div/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[2]/button";
        private static String citiesDropdownXpathID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[3]/button";
        private static String schooldistrictsDropdownXpathID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[4]/button";
        private static String ownerDropdownXpathID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[5]/button";
        private static String registrationDropdownXpathID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[6]/span/span/button";
        private static String registrationSearchBoxXpathID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[6]/span/input";
        private static String timeperiodDropdownXpathID = ".//*[@id='nextInspection']";
        private static String searchButtonXpathID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[2]/div/button";

        public GetSchoolBusesPage(IWebDriver driver)
        {
            loadinschoolbuspage(driver);
            //SelectRegionDropDown(driver, ".//*[@id='selectedDistrictsIds']");
           // SelectInspectorsDropDown(driver, inspectorsDropdownXpathID);
            //SelectCitiesButton(driver, citiesDropdownXpathID);
            //
           // SelectOwnerButton(driver, ownerDropdownXpathID);
            SelectRegistrationButton(driver, registrationDropdownXpathID);
            ClickOnSearchButton(driver, searchButtonXpathID);

        }

        public static void loadinschoolbuspage(IWebDriver driver)
        {
            GetSchoolBusHomePage.clickOnSchoolBusesLink(driver);

        }
        //model for rest of dropdowns on this page..dropdown of checkboxes
        public void SelectRegionDropDown(IWebDriver driver, String elID)
        {
            IWebElement regionelement = WebDriverUtilities.GetWebDriverWait(driver, elID);
            regionelement.Click();//button
            String elemID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[1]/div/ul/li[15]/div/label/input";

            IWebElement ddl = WebDriverUtilities.GetWebDriverWait(driver, elemID);
            ddl.Click();//button


           // IWebElement ddl = driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[1]/div/ul/li[15]/div/label/input"));
           // ddl.Click();

            //IWebElement regelement = WebDriverUtilities.GetWebDriverWait(driver, "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[1]/div/ul/li[23]/div/label/input");
            if (!ddl.Selected)
            {
                ddl.Click();
            }

            // SelectElement region = new SelectElement(regionelement);
            // region.SelectByIndex(2);
        }

        public void SelectInspectorsDropDown(IWebDriver driver, String elID)
        {
            IWebElement inspectorelement = WebDriverUtilities.GetWebDriverWait(driver, elID);
            inspectorelement.Click();

            String inspelid = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[2]/div/ul/li[1]/div/label/input";
            IWebElement insp = WebDriverUtilities.GetWebDriverWait(driver, inspelid);
            insp.Click();


           // IWebElement insp = driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[2]/div/ul/li[1]/div/label/input"));
           // insp.Click();

        }

        public void SelectHideInactiveCheckBox(IWebDriver driver, String elID)
        {
            IWebElement hideelement = WebDriverUtilities.GetWebDriverWait(driver, elID);
            if (!hideelement.Selected)
            {
                hideelement.Click();
            }
        }

        public void SelectCitiesButton(IWebDriver driver, String elID)
        {
            IWebElement citiesEl = WebDriverUtilities.GetWebDriverWait(driver, elID);
            citiesEl.Click();

            String citEl = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[3]/div/ul/li[624]/div/label/input";
            IWebElement elcity = WebDriverUtilities.GetWebDriverWait(driver, citEl);
            elcity.Click();

            //IWebElement citycb = driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[3]/div/ul/li[624]/div/label/input")); //victoria xpath
           // citycb.Click();

        }

        public void SelectSchoolDistrictsButton(IWebDriver driver, String elID)
        {
            IWebElement schoolDistrictEl = WebDriverUtilities.GetWebDriverWait(driver, elID);
            schoolDistrictEl.Click();

           String  sdid = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[4]/div/ul/li[30]/div/label/input";
           IWebElement schooldistrictcb = WebDriverUtilities.GetWebDriverWait(driver, sdid);
           schooldistrictcb.Click();

            //IWebElement schooldistrictcb = driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[4]/div/ul/li[30]/div/label/input")); //school district 63 xpath
            //schooldistrictcb.Click();

        }

        public void SelectOwnerButton(IWebDriver driver, String elID)
        {
            IWebElement ownerEl = WebDriverUtilities.GetWebDriverWait(driver, elID);
            ownerEl.Click();

            String ownel = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[5]/div/ul/li[7]/a";
            IWebElement owner = WebDriverUtilities.GetWebDriverWait(driver, ownel);
            owner.Click();
           // IWebElement owner = driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[5]/div/ul/li[7]/a")); //school district 63 xpath
           // owner.Click();

        }

        public void SelectRegistrationButton(IWebDriver driver, String elID)
        {
            IWebElement registraionEl = WebDriverUtilities.GetWebDriverWait(driver, elID);
            registraionEl.Click();

            String regID = "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[6]/span/span/div/ul/li[1]/a";
            IWebElement registration = WebDriverUtilities.GetWebDriverWait(driver, regID);
            registration.Click();

            //IWebElement registration = driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[6]/span/span/div/ul/li[1]/a")); //select registration from list
           // registration.Click();
            //double click method
            // Actions act = new Actions(driver);
            //act.DoubleClick(driver.FindElement(By.XPath("//table//tr[2]//td[@class='dxgv'][1]"))).Build().Perform();
           //fill in registration number in search box
            IWebElement registrationSearchBox = WebDriverUtilities.GetWebDriverWait(driver, registrationSearchBoxXpathID);
            registrationSearchBox.Click();
            registrationSearchBox.SendKeys("49184262");//registration number of school bus
        }

        public void SelectJustReinspectionsCheckBox(IWebDriver driver, String elID)
        {
            IWebElement reinspectionselement = WebDriverUtilities.GetWebDriverWait(driver, elID);
            if (!reinspectionselement.Selected)
            {
                reinspectionselement.Click();
            }
        }
        public void ClickOnSearchButton(IWebDriver driver, String elID)
        {
            IWebElement searchbutton = WebDriverUtilities.GetWebDriverWait(driver, elID);
            searchbutton.Click();
        }


        /*
        public WebDriver SelectProjectTypeDropDown(WebDriver driver, String projecttype) {
            new WebDriverWait(driver, 30)
                    .until(ExpectedConditions.visibilityOfElementLocated(By.id("ctl00_MainContent_projectType")));

            Select projtype = new Select(driver.findElement(By.id("ctl00_MainContent_projectType")));
            projtype.selectByVisibleText(projecttype);
            return driver;

        public WebDriver SelectInDesignCheckBox(WebDriver driver) {

            WebElement myDynamicElement = (new WebDriverWait(driver, 15))
                    .until(ExpectedConditions.presenceOfElementLocated(By.id("ctl00_MainContent_InDesign")));
            myDynamicElement = driver.findElement(By.id("ctl00_MainContent_InDesign"));
            if (!myDynamicElement.isSelected()) {

                myDynamicElement.click();
            }
            return driver;
         * */
    }

}


