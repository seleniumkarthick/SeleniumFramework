using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumFramework.TestBase;
using System;

namespace SeleniumFramework.TestCases.Medical
{
    [TestFixture]
    [Parallelizable]
    class SerachTests : BaseTest
    {
        public SerachTests()
        {
            getDriver();
            driver.Url = medical_url;
        }

        [Test]
        public void verifyAboutUs()
        {
           
            logger = extent.CreateTest("verifyAboutUs");
     
            menuPageObj.ClikSupports();
    
            string actual = driver.FindElement(By.XPath("//h1")).Text;
        
            Assert.AreEqual(actual, "Getting Help");
 
            logger.Log(Status.Pass, "Title verifyAboutUs");
        

        }

        [Test]
        public void verifyFaq()
        {
        
            logger = extent.CreateTest("verifyAboutUs");
    
            menuPageObj.ClikDownload();
         
            string actual = driver.FindElement(By.XPath("//h1")).Text;
     
            Assert.AreEqual(actual, "Downloads");
    
            logger.Log(Status.Pass, "Title verifyAboutUs");
       

        }


        [Test]
        public void verifyContactUs()
        {

  
            logger = extent.CreateTest("verifyAboutUs");
   
            menuPageObj.ClikProjects();
   
            string actual = driver.FindElement(By.XPath("//h1")).Text;

            Assert.AreEqual(actual, "Selenium Projects");

            logger.Log(Status.Pass, "Title verifyAboutUs");


        }



    }
}
