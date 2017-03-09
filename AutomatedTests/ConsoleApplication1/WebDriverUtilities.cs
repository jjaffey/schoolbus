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
using OpenQA.Selenium.Support.PageObjects;







namespace ConsoleApplication1
{

    public class WebDriverUtilities
    {
        
        public  WebDriverUtilities()
        {
        }//end constructor




        public static IWebElement GetWebDriverWait(IWebDriver driver, String elementID)
        {
             WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(elementID)));
            return element;

           
           
        }

        public static IWebElement AddImplicitWait(IWebDriver driver, String elementID)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(elementID)));
            return element;
        }


        public static IWebElement GetWebDriverWaitCssSelector(IWebDriver driver, String elementID)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(elementID)));
            return element;
        }

        public static IWebElement findElementByXpath(IWebDriver driver, String elementID)
        {
            IWebElement element = driver.FindElement(By.XPath(elementID));
            return element;
        }

        public static void clickButton(IWebDriver driver, String elemID)
        {
            IWebElement buttonel = WebDriverUtilities.GetWebDriverWaitCssSelector(driver, elemID);
            buttonel.Click();
        }

        public static void selectItemFromList(IWebDriver driver, String elemID)
        {
            IWebElement menuListItemEl = WebDriverUtilities.GetWebDriverWaitCssSelector(driver, elemID);
            menuListItemEl.Click();
        }

        public static void ScrollIntoView(IWebDriver driver, IWebElement idin)
        {
           // String BaseWindow = driver.CurrentWindowHandle;
          //  ScriptManager.RegisterStartupScript(Page, this.GetType(), "ScrollPage", "window.scroll(0,0);", true);
            //IWebElement element = driver.FindElement(By.XPath(idin));
           ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", idin);
           // ((IJavaScriptExecutor)driver).ExecuteScript(window(BaseWindow).scrollBy(250,0),"");
            System.Threading.Thread.Sleep(500);
        }


    }//end class

}//end namespace