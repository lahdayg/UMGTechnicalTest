Feature: CreateNewAccount
	In order for me to use the website
	I need to register and create a New Account

@mytag
Scenario: Creating a New Account
	Given I navigate to "https://angularjs.realworld.io/"
	When I click on Sign up
	And I enter the Username "username"
	And I enter the Email "email"
	And I enter Password "L0nd0n123@"
	And I click on Sign up button
	Then I am logged in with my username displayed
	
