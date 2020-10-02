using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.TestBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.PageActions.Medical
{
    public class SearchPageActions : BaseTest
    {
        [FindsBy(How = How.LinkText, Using = "Downloads")]
        public IWebElement download;

        [FindsBy(How = How.LinkText, Using = "Projects")]
        public IWebElement project;

        [FindsBy(How = How.LinkText, Using = "Support")]
        public IWebElement support;

    }
}
