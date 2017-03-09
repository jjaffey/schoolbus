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
    public class GetAdministrationUserManagementPage
    {

        private static String AdministrationPageCssSelectorID = "a[id = 'admin-dropdown'][class = 'dropdown-toggle'][role='button'][linkText = 'Administration']";
        private static String AdministrationPageXPathSelectorID = "html/body/div[1]/div/div[1]/nav/nav/div/ul[1]/li[5]/a";
        private static String UserManagementMenuItemCssSelectorID = "a[linkText = 'User Management']";
        private static String UserManagementPageDistrictButtonCssSelectorID = "button[id = 'selectedDistrictsIds'][class = 'dropdown-toggle btn btn-default'][title = 'Districts']";
        private static String UserManagementPageSurnameTextFieldCssSelectorID = "input[id = 'surname'][class = 'form-control']";
        private static String UserManagementPageSearchButtonCssSelectorID = "button[id = 'search-button'][class = 'btn btn-primary'][type = 'button']";
        private static String UserManagementPageAddUserButtonCssSelectorID = "span[class = 'glyphicon glyphicon-plus']";
        private static String UserManagementPageDistrictListCssSelectorID = "input[value = '15'][type = 'checkbox']";//vancouver island
        private static String AddUserModalGivenNameCssSelectorID = "input[id = 'givenName']";
        private static String AddUserModalSurNameCssSelectorID = "input[id = 'surname']";
        private static String AddUserModaluseridCssSelectorID = "input[id = 'smUserIdName']";
        private static String AddUserModalemailCssSelectorID = "input[id = 'email']";
        private static String AddUserModalDistrictButtonCssSelectorID = "button[id = 'districtId']";
        private static String AddUserModalDistrictMenuItemCssSelectorID = "a[linkText = 'Vancouver Island']";

        public GetAdministrationUserManagementPage(IWebDriver driver)
        {
            LoadUserManagementPage(driver);

        }//end constructor

        public static void LoadUserManagementPage(IWebDriver driver)
        {
            
            driver.Navigate().GoToUrl("https://tstsm.th.gov.bc.ca/schoolbus/#/users");
            //getAdministrationPageUserManagementMenuItem(driver,UserManagementMenuItemCssSelectorID);
            clickUserManagementDistrictButton(driver, UserManagementPageDistrictButtonCssSelectorID);
            clickUserManagementDistrictDropdownList(driver,UserManagementPageDistrictListCssSelectorID);
            //populateUserManagementSurNameTextbox(driver, UserManagementPageSurnameTextFieldCssSelectorID);//add clark to surname text box
            //clickUserManagementSearchButton(driver, UserManagementPageSearchButtonCssSelectorID);
            AddUsertoUserManagementPage(driver, UserManagementPageAddUserButtonCssSelectorID);
            populateTextBox(driver,AddUserModalGivenNameCssSelectorID, "Joseph");

        }
        /*
        public static void getAdministrationPageUserManagementMenuItem(IWebDriver driver, String UserManagementMenuItemCssSelectorID)
        {
            clickOnAdministratonPage(driver, AdministrationPageCssSelectorID);
            clickOnUserManagementMenuItem(driver, UserManagementMenuItemCssSelectorID);

        }
        
        public static void clickOnAdministratonPage(IWebDriver driver, String AdministrationPageXPathSelectorID)
        {
           // IWebElement adminbutton = driver.FindElement(By.CssSelector(AdministrationPageCssSelectorID));//click administration button
            IWebElement adminbuttonel = WebDriverUtilities.GetWebDriverWait(driver, AdministrationPageXPathSelectorID);
            adminbuttonel.Click();
        }*/

        public static void clickOnUserManagementMenuItem(IWebDriver driver, String UserManagementMenuItemCssSelectorID)
        {
            IWebElement usermanagementitem = driver.FindElement(By.CssSelector(UserManagementMenuItemCssSelectorID));//click administration button
            usermanagementitem.Click();
        }

        public static void clickUserManagementDistrictButton(IWebDriver driver, String UserManagementPageDistrictButtonCssSelectorID)
        {
           IWebElement usermanagementEl= WebDriverUtilities.GetWebDriverWaitCssSelector(driver, UserManagementPageDistrictButtonCssSelectorID);
            //IWebElement usermanagementitem = driver.FindElement(By.CssSelector(UserManagementMenuItemCssSelectorID));//click administration button
           usermanagementEl.Click();

        }

        public static void clickUserManagementDistrictDropdownList(IWebDriver driver, String UserManagementPageDistrictListCssSelectorID)
        {
            IWebElement districtEl = WebDriverUtilities.GetWebDriverWaitCssSelector(driver, UserManagementPageDistrictButtonCssSelectorID);
            //IWebElement usermanagementitem = driver.FindElement(By.CssSelector(UserManagementMenuItemCssSelectorID));//click administration button
            districtEl.Click();

        }

        public static void populateUserManagementSurNameTextbox(IWebDriver driver, String UserManagementPageSurnameTextFieldCssSelectorID)
        {
            IWebElement surnameEl = WebDriverUtilities.GetWebDriverWaitCssSelector(driver, UserManagementPageSurnameTextFieldCssSelectorID);
            surnameEl.Click();
            surnameEl.SendKeys("Clark");

        }

        //UserManagementPageSearchButtonCssSelectorID
        public static void clickUserManagementSearchButton(IWebDriver driver, String UserManagementPageSearchButtonCssSelectorID)
        {
            IWebElement searchEl = WebDriverUtilities.GetWebDriverWaitCssSelector(driver, UserManagementPageSearchButtonCssSelectorID);
            searchEl.Click();

        }

        public static void AddUsertoUserManagementPage(IWebDriver driver, String UserManagementPageAddUserButtonCssSelectorID)
        {
            IWebElement adduserEl = WebDriverUtilities.GetWebDriverWaitCssSelector(driver, UserManagementPageAddUserButtonCssSelectorID);
            adduserEl.Click();

        }

        
        public static IWebDriver  populateTextBox(IWebDriver driver, String elemID, String textToEnter)
        {
            IWebElement textBoxElement = WebDriverUtilities.GetWebDriverWaitCssSelector(driver, AddUserModalGivenNameCssSelectorID);
            textBoxElement.Click();
            textBoxElement.SendKeys(textToEnter);
            return driver;
            
        }

       

        public static void populateAddUserModal(IWebDriver driver)
        {
            populateTextBox(driver, AddUserModalGivenNameCssSelectorID, "Joe");
            populateTextBox(driver, AddUserModalSurNameCssSelectorID, "Jaffey");
            populateTextBox(driver, AddUserModaluseridCssSelectorID, "JAJAFFEY");
            populateTextBox(driver, AddUserModalemailCssSelectorID, "jjaffey@shaw.ca");
            populateDistrictDropdownList(driver);

        }

        public static void populateDistrictDropdownList(IWebDriver driver)
        {
            WebDriverUtilities.clickButton(driver, AddUserModalDistrictButtonCssSelectorID);//district button
            WebDriverUtilities.selectItemFromList(driver, AddUserModalDistrictMenuItemCssSelectorID);//district menu item vancouver island
        }


    }//end class
}//end namespace
