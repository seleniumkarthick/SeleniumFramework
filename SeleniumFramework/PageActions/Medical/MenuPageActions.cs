﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumFramework.TestBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumFramework.PageActions.Medical
{
    public class MenuPageActions : BaseTest
    {
        [FindsBy(How = How.LinkText, Using = "Downloads")]
        public IWebElement download;

        [FindsBy(How = How.LinkText, Using = "Projects")]
        public IWebElement project;

        [FindsBy(How = How.LinkText, Using = "Support")]
        public IWebElement support;

        [FindsBy(How = How.XPath, Using = "//h1")]
        public IWebElement heading;

    }

}
