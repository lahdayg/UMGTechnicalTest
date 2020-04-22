using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using UmgTechnicalTest.PageObject;

namespace UmgTechnicalTest.StepDefinitions
{
    [Binding]
    public class CreateNewAccountSteps
    {
        IWebDriver driver;
        CreateNewAccountPage createNewAccountPage;

        public CreateNewAccountSteps()
        {
            createNewAccountPage = new CreateNewAccountPage();
        }


        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            createNewAccountPage.NavigateToWebsite(url);
        }
        
        [When(@"I click on Sign up")]
        public void WhenIClickOnSignUp()
        {
            createNewAccountPage.ClickOnSignUpInHomePage();
        }
        
        [When(@"I enter the Username ""(.*)""")]
        public void WhenIEnterTheUsername(string username)
        {
            createNewAccountPage.EnterUsername(username);
        }

        [When(@"I enter the Email ""(.*)""")]
        public void WhenIEnterTheEmail(string email)
        {
            createNewAccountPage.EnterEmail(email);
        }

        [When(@"I enter Password ""(.*)""")]
        public void WhenIEnterPassword(string password)
        {
            createNewAccountPage.EnterPassword(password);
        }

        [When(@"I click on Sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            createNewAccountPage.ClickOnSignUpButton();
        }

        [Then(@"I am logged in with my username displayed")]
        public void ThenIAmLoggedInWithMyUsernameDisplayed()
        {

            //IWebElement element = driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(3) > li:nth-child(4) > a"));
            //String strng = element.GetCssValue("username");
            //Assert.IsTrue(strng.Contains("username"));
            Thread.Sleep(5000);
            Assert.That(createNewAccountPage.IsUserLogInDisplayed);
        }



    }
}
