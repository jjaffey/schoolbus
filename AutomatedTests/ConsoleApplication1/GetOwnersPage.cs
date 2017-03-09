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
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium.Support;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Remote;




namespace ConsoleApplication1
{
   public class GetOwnersPage
    {

        private String ownerElementID = "html/body/div[1]/div/div[1]/nav/nav/div/ul[1]/li[3]/a";
        private String RegionXpathID = "html/body/div[1]/div/div[2]/div/div/div[1]/div/div[1]/div/div[1]/button";
        private String InspectorsXpathID = "html/body/div[1]/div/div[2]/div/div[2]/div[1]/div/div[1]/div/div[2]/button";
        private String InspectorRobinWindelsXpathID = "html/body/div[1]/div/div[2]/div/div/div[1]/div/div[1]/div/div[2]/div/ul/li[2]/div/label/input";
        private String OwnersXpathID = "html/body/div[1]/div/div[2]/div/div/div[1]/div/div[1]/div/div[3]/button";
        private String EditOwnersButtonSmusXpathID = "html/body/div[1]/div/div[2]/div/div/div[2]/table/tbody/tr[9]/td[5]/div/a";
        private String hideInactiveXpathID = "html/body/div[1]/div/div[2]/div/div/div[1]/div/div[1]/div/label/input";
        private String DistrictVancouverIslandXpathID = "html/body/div[1]/div/div[2]/div/div/div[1]/div/div[1]/div/div[1]/div/ul/li[24]/div/label/input";
        private String OwnerListSmusXpathID = "html/body/div[1]/div/div[2]/div/div/div[1]/div/div[1]/div/div[3]/div/ul/li[11]/a";
        private String AddOwnerButtonXpathID = "html/body/div[1]/div/div[2]/div/div/div[2]/table/thead/tr/th[5]/button";
        private String AddOwnerPopUpBoxNameFieldXpathID = "html/body/div[2]/div/div[2]/div/div/div[2]/form/div/input";
        private String SearchButtonXpathID = "html/body/div[1]/div/div[2]/div/div/div[1]/div/div[1]/div/button";
        private String AddOwnerPopupBoxSaveButtonXpathID = "html/body/div[2]/div/div[2]/div/div/div[3]/span/button[2]";
        private String HeaderElementXpathID = "html/body/div[1]/div/div[2]/div/div[1]/h1";
        private String EditOwnerButtonCssSelectorID = "span[class = 'glyphicon glyphicon-edit']";
        private String AdminisstationPageCssSelectorID = "a[id = 'admin-dropdown']";
        private String UserManagementMenuItemCssSelectorID = "a[linkText = 'User Management']";
        private String UserManagementPageRegionButtonCssSelectorID = "button[id = 'selectedDistrictsIds'][class = 'dropdown-toggle btn btn-default'][title = 'Vancouver Island']";
        private String UserManagementPageSurnameTextFieldCssSelectorID = "input[id = 'surname'][class = 'form-control']";
        private String UserManagementPageSearchButtonCssSelectorID = "button[id = 'search-button'][class = 'btn btn-primary'][type = 'button']";
        private String UserManagementPageAddUserButtonCssSelectorID = "span[class = 'glyphicon glyphicon-plus']";


        public GetOwnersPage(IWebDriver driver)
        {
            LoadOwnersPage(driver);
            SelectRegionButton(driver, RegionXpathID);
            SelectInspectorsButton(driver, InspectorsXpathID);
            SelectOwnersButton(driver, OwnersXpathID);
            //ClickOnAddOwnerButton(driver, AddOwnerButtonXpathID);
            // PopulateAddOwnerPopUpBoxNameField(driver, AddOwnerPopUpBoxNameFieldXpathID);


        }//end constructor

        public static void LoadOwnersPage(IWebDriver driver)
        {
            //driver.GetPage("https://tstsm.th.gov.bc.ca/schoolbus/#/owners");
            driver.Navigate().GoToUrl("https://tstsm.th.gov.bc.ca/schoolbus/#/owners");

        }

        //model for rest of dropdowns on this page..dropdown of checkboxes
        public void SelectRegionButton(IWebDriver driver, String RegionXpathID)
        {
            IWebElement regionelement = WebDriverUtilities.GetWebDriverWait(driver, RegionXpathID);
            regionelement.Click();//button
            // IWebElement ddl = new WebDriverWait(driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementExists(By.XPath("DistrictVancouverIslandXpathID")));
            //
            // IWebElement regionel = driver.FindElement(By.XPath(DistrictVancouverIslandXpathID));
            IWebElement regionel = driver.FindElement(By.CssSelector("input[value='15'][type='checkbox']"));//vancouver island

            //IWebElement regelement = WebDriverUtilities.GetWebDriverWait(driver, "html/body/div[1]/div/div[2]/div/div[1]/div/div[1]/div[1]/div/div[1]/div/ul/li[23]/div/label/input");
            if (!regionel.Selected)
            {
                regionel.Click();
            }
            regionelement.Click();//button

            // ClickOnSearchButton(driver);

            //scroll to top so inspector button is visible
            //

            //WebDriverUtilities.ScrollIntoView(driver, regionelement);
            /*
                        //IWebElement element = driver.FindElement(By.XPath("RegionXpathID"));
                        Actions actions = new Actions(driver);
                        actions.MoveToElement(regionelement);
                        actions.Perform();
                        regionelement.Click();*/
        }

        public void SelectInspectorsButton(IWebDriver driver, String InspectorsXpathID)
        {
            IWebElement inspectorelement = WebDriverUtilities.GetWebDriverWait(driver, InspectorsXpathID);
            inspectorelement.Click();

            //find header element
            // IWebElement headerelement = new WebDriverWait(driver, TimeSpan.FromSeconds(90)).Until(ExpectedConditions.ElementExists(By.XPath("HeaderElementXpathID")));

            //



            // IWebElement inspectorelement = new WebDriverWait(driver, TimeSpan.FromSeconds(90)).Until(ExpectedConditions.ElementExists(By.XPath("InspectorsXpathID")));
            //IWebElement inspectorelement = driver.FindElement(By.XPath("InspectorsXpathID"));//Robin Windels from list
            //    inspectorelement.Click();



            // IWebElement insp = WebDriverUtilities.GetWebDriverWait(driver, InspectorRobinWindelsXpathID);
            // WebDriverUtilities.ScrollIntoView(driver, inspectorelement);

            IWebElement inspectorCB = driver.FindElement(By.CssSelector("input[value='43'][type='checkbox']"));//Robin Windels from list
            //IWebElement inspectorCB = driver.FindElement(By.XPath("InspectorRobinWindelsXpathID"));//Robin Windels from list
            if (!inspectorCB.Selected)
            {
                inspectorCB.Click();
            }
            inspectorelement.Click();


        }


        public void SelectOwnersButton(IWebDriver driver, String OwnersXpathID)
        {
            //IWebElement inspectorelement = WebDriverUtilities.GetWebDriverWait(driver, OwnersXpathID);
            //inspectorelement.Click();
            // IWebElement ownerbutton = driver.FindElement(By.XPath("OwnersXpathID"));//SMUS from List
            IWebElement ownerbutton = driver.FindElement(By.CssSelector("button[id='ownerId'][class='dropdown-toggle btn btn-default'][role='button'][type='button']"));//smus
            ownerbutton.Click();
            //click search
            IWebElement owner = driver.FindElement(By.LinkText("SMUS"));//SMUS from List
            owner.Click();
        }

        public void ClickOnAddOwnerButton(IWebDriver driver, String AddOwnerButtonXpathID)
        {
            IWebElement addownerelement = WebDriverUtilities.GetWebDriverWait(driver, AddOwnerButtonXpathID);
            addownerelement.Click();
            PopulateAddOwnerPopUpBoxNameField(driver, AddOwnerPopUpBoxNameFieldXpathID);

        }

        public void PopulateAddOwnerPopUpBoxNameField(IWebDriver driver, String AddOwnerPopUpBoxNameFieldXpathID)
        {
            IWebElement addownernameelement = WebDriverUtilities.GetWebDriverWait(driver, AddOwnerPopUpBoxNameFieldXpathID);
            addownernameelement.Click();
            //add owner name
            addownernameelement.SendKeys("Joe Jaffey");
            //click on save button
            IWebElement addownersavebutton = WebDriverUtilities.GetWebDriverWait(driver, AddOwnerPopupBoxSaveButtonXpathID);
            addownersavebutton.Click();

        }


        public void SelectHideInactiveCheckBox(IWebDriver driver, String hideInactiveXpathID)
        {
            IWebElement hideelement = WebDriverUtilities.GetWebDriverWait(driver, hideInactiveXpathID);
            if (!hideelement.Selected)
            {
                hideelement.Click();
            }
        }

        public void ClickOnSearchButton(IWebDriver driver)
        {
            IWebElement searchbutton = WebDriverUtilities.GetWebDriverWait(driver, SearchButtonXpathID);
            searchbutton.Click();
        }

        public void EditSchoolbusOwner(IWebDriver driver)
        {
            SelectOwnersButton(driver, OwnersXpathID);


        }

        public void clickOnOwnerEditButton(IWebDriver driver)
        {
            String StrOwnerPage;
            StrOwnerPage = "https://tstsm.th.gov.bc.ca/schoolbus/#/owners";
            String currentURL = driver.Url;

            if (currentURL != StrOwnerPage)
            {
                driver.Navigate().GoToUrl("https://tstsm.th.gov.bc.ca/schoolbus/#/owners");
            }
            IWebElement editowner = driver.FindElement(By.CssSelector(EditOwnerButtonCssSelectorID));//edit owner button
            editowner.Click();
        }



        

    }//end class

}

