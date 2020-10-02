using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using System.IO;

namespace SeleniumFramework.TestBase
{
    public class DriverFactory
    {
        public IWebDriver driver;

        public IWebDriver getDriver()
        {

            string browser = "chrome";
            Boolean browserStack = false;

            string browserstack_user = "karthickkumar15";
            string browserstack_pass = "278oHcHgmLKVbpUzs8NK";

            if (browserStack == true)
            {

                if (browser.Equals("chrome"))
                {

                    ChromeOptions capability = new ChromeOptions();
                    capability.AddAdditionalCapability("os", "Windows", true);
                    capability.AddAdditionalCapability("os_version", "10", true);
                    capability.AddAdditionalCapability("browser", "Chrome", true);
                    capability.AddAdditionalCapability("browser_version", "84.0", true);
                    capability.AddAdditionalCapability("browserstack.local", "false", true);
                    capability.AddAdditionalCapability("browserstack.selenium_version", "3.14.0", true);
                    capability.AddAdditionalCapability("browserstack.user", browserstack_user, true);
                    capability.AddAdditionalCapability("browserstack.key", browserstack_pass, true);

                    driver = new RemoteWebDriver(
                         new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
                    );
                  
                }
                else if (browser.Equals("firefox"))
                {


                    FirefoxOptions capability = new FirefoxOptions();
                    capability.AddAdditionalCapability("os", "Windows", true);
                    capability.AddAdditionalCapability("os_version", "10", true);
                    capability.AddAdditionalCapability("browser", "Firefox", true);
                    capability.AddAdditionalCapability("browser_version", "latest", true);
                    capability.AddAdditionalCapability("browserstack.local", "false", true);
                    capability.AddAdditionalCapability("browserstack.selenium_version", "3.10.0", true);
                    capability.AddAdditionalCapability("browserstack.user", browserstack_user, true);
                    capability.AddAdditionalCapability("browserstack.key", browserstack_pass, true);


                    driver = new RemoteWebDriver(
                         new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
                    );
                   
                }
                else if (browser.Equals("ie"))
                {

                    InternetExplorerOptions capability = new InternetExplorerOptions();
                    capability.AddAdditionalCapability("os", "Windows", true);
                    capability.AddAdditionalCapability("os_version", "10", true);
                    capability.AddAdditionalCapability("browser", "IE", true);
                    capability.AddAdditionalCapability("browser_version", "11.0", true);
                    capability.AddAdditionalCapability("browserstack.local", "false", true);
                    capability.AddAdditionalCapability("browserstack.selenium_version", "3.5.2", true);
                    capability.AddAdditionalCapability("browserstack.user", browserstack_user, true);
                    capability.AddAdditionalCapability("browserstack.key", browserstack_pass, true);

                    driver = new RemoteWebDriver(
                         new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
                    );
                   
                }
                else if (browser.Equals("edge"))
                {

                    EdgeOptions capability = new EdgeOptions();
                    capability.AddAdditionalCapability("os", "Windows");
                    capability.AddAdditionalCapability("os_version", "10");
                    capability.AddAdditionalCapability("browser", "Edge");
                    capability.AddAdditionalCapability("browser_version", "84.0");
                    capability.AddAdditionalCapability("browserstack.local", "false");
                    capability.AddAdditionalCapability("browserstack.selenium_version", "3.5.2");
                    capability.AddAdditionalCapability("browserstack.user", browserstack_user);
                    capability.AddAdditionalCapability("browserstack.key", browserstack_pass);

                    driver = new RemoteWebDriver(
                     new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
                     );
                   
                }
            }
            else
            {
                driver = new ChromeDriver();
            }

            return driver;

        }


        public String getCurrentProjectDir()
        {
            // This will get the current WORKING directory (i.e. \bin\Debug)
            string workingDirectory = Environment.CurrentDirectory;
            // or: Directory.GetCurrentDirectory() gives the same result

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
         
            return projectDirectory;
        }


        public string getFailedScreenShotPath()
        {
            string date = DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss");
            string filePath = getCurrentProjectDir() + "\\FailedScreenshots\\" + date + ".png";

            Screenshot file = ((ITakesScreenshot)driver).GetScreenshot();
            file.SaveAsFile(filePath, ScreenshotImageFormat.Png);

            return filePath;
        }

    }
}
