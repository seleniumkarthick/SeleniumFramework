using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.TestBase;
using System;

namespace SeleniumFramework.TestCases.Medical
{

    [TestFixture]
    [Parallelizable]
    class MenuTests : BaseTest
    {
        public MenuTests()
        {
            getDriver();
            driver.Url = medical_url;
        }

        [Test]
        public void verifySupport()
        {

            logger = extent.CreateTest("verifySupport");

            menuPageObj.ClikSupports();

            string actual = menuPageObj.getHeading();

            Assert.AreEqual(actual, "Getting Help");

            logger.Log(Status.Pass, "verifySupport passed");
            
        }

        [Test]
        public void verifyDownload()
        {
          
            logger = extent.CreateTest("verifyDownload");
    
            menuPageObj.ClikDownload();
         
            string actual = menuPageObj.getHeading();
          
            Assert.AreEqual(actual, "Downloads");
           
            logger.Log(Status.Pass, "verifyDownload passed");
        
        }


        [Test]
        public void verifyProject()
        {
           
            logger = extent.CreateTest("verifyProject");
          
            menuPageObj.ClikProjects();
          
            string actual = menuPageObj.getHeading();

            Assert.AreEqual(actual, "Seleniums Projects");
          
            logger.Log(Status.Pass, "verifyProject passed");
        
        }


    }
}
