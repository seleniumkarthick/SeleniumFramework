using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.Extensions
{
    public class WebElementExtensions
    {

        private IWebDriver driver;

        public WebElementExtensions(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void switchToAlert()
        {
            driver.SwitchTo().Alert();
        }


    }
}
