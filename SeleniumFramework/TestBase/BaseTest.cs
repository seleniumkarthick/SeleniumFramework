using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using SeleniumFramework.Extensions;
using SeleniumFramework.Pages.Medical;
using SeleniumFramework.TestCases.Medical;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SeleniumFramework.TestBase
{
    public class BaseTest : DriverFactory
    {
      
        public static ExtentHtmlReporter reporter;
        public static ExtentReports extent;
        public ExtentTest logger;

        public static int x = 1;

        public MenuPages menuPageObj;
        public static WebElementExtensions webElementExtensionsObj;
        public static WebDriverExtensions webDriverExtensionsObj;

        public string medical_url= "https://www.selenium.dev/";

        [OneTimeSetUp]
        public void BeforeSetup()
        {
            if (x == 1)
            {
               
                string date = DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss");
                string baseDirPath = getCurrentProjectDir()+"\\Reports\\" + date +"\\test" ;

                reporter = new ExtentHtmlReporter(baseDirPath);
                extent = new ExtentReports();
                extent.AttachReporter(reporter);
               
            }
            
            x++;

        }


        [SetUp]
        [Obsolete]
        public void Init()
        {

            menuPageObj =new MenuPages(driver);
            webElementExtensionsObj = new WebElementExtensions(driver);
            webDriverExtensionsObj = new WebDriverExtensions(driver);

        }

        [OneTimeTearDown]
        public void Cleanup()
        {
            driver.Quit();
            extent.Flush();
        }


        [TearDown]
        public void AfterClass()
        {

            //StackTrace details for failed Testcases
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var errorMsg = TestContext.CurrentContext.Result.Message;
            var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";


            var errorMessage = TestContext.CurrentContext.Result.Message;
            if (status == TestStatus.Failed)
            {
                logger.Log(Status.Fail, "Title failed");
                logger.Log(Status.Fail, stackTrace+errorMsg);
                logger.Log(Status.Fail, "Snapshot below: " + logger.AddScreenCaptureFromPath(getFailedScreenShotPath()));
            }
           
        }

    }
}
