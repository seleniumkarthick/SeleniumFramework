using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Extensions;
using SeleniumFramework.PageActions.Medical;
using SeleniumFramework.TestBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.Pages.Medical
{
    public class MenuPages : BaseTest
    {
        
        public MenuPages(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.LinkText, Using = "Downloads")]
        IWebElement download;

        [FindsBy(How = How.LinkText, Using = "Projects")]
        IWebElement project;

        [FindsBy(How = How.LinkText, Using = "Support")]
        IWebElement support;

        [FindsBy(How = How.XPath, Using = "//h1")]
        IWebElement heading;


        public void ClikDownload()
        {
            download.Click();
        }

        public void ClikProjects()
        {
            webDriverExtensionsObj.waitPageLoad();
            project.Click();
        }

        public void ClikSupports()
        {
            support.Click();
        }

        public string getHeading()
        {
           return heading.Text;
        }
    }
}
