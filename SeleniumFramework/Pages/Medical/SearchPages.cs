using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.Extensions;
using SeleniumFramework.PageActions.Medical;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.Pages.Medical
{
    public class SearchPages : SearchPageActions
    {
        readonly IWebDriver driver;

        public SearchPages(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


    }
}
