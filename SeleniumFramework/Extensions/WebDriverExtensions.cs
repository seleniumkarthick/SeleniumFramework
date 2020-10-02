using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.TestBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.Extensions
{
    public class WebDriverExtensions : BaseTest
    {
        private IWebDriver driver;

        public WebDriverExtensions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void waitPageLoad()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public string getTitle()
        {
            return driver.Title;
        }

        public string getUrl()
        {
            return driver.Url;
        }

    }
}
