using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace UmgTechnicalTest.Utilities
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver driver;


        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // Driver = new FirefoxDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Driver.Quit();
        }
    }
}
