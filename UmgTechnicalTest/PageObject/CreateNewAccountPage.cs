using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UmgTechnicalTest.Utilities;

namespace UmgTechnicalTest.PageObject
{
    class CreateNewAccountPage
    {
        IWebDriver driver;

        IWebElement signUp => driver.FindElement(By.XPath("//a[contains(text(),'Sign up')]"));

        IWebElement usernameInput => driver.FindElement(By.XPath("//input[@placeholder ='Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//input[@placeholder ='Email']"));

        IWebElement passwordInput => driver.FindElement(By.XPath("//input[@placeholder ='Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[@class='btn btn-lg btn-primary pull-xs-right ng-binding']"));

        IWebElement userLogIn => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(3) > li:nth-child(4) > a"));




        public void ClickOnSignUpInHomePage()
        {
            signUp.Click();
        }

        public void EnterUsername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            usernameInput.SendKeys("username" + randomInt);

            //usernameInput.SendKeys(username);
        }

        public void EnterEmail(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            emailInput.SendKeys("email" + randomInt + "@gmail.com");
            //emailInput.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            passwordInput.SendKeys(password);
        }

        public void ClickOnSignUpButton()
        {
            signUpButton.Click();
        }

        public CreateNewAccountPage()
        {
            driver = Hooks1.driver;
        }

        public bool IsUserLogInDisplayed()

        {
            return userLogIn.Displayed;
        }


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
