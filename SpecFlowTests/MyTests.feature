Feature: MyTests

# BDD test written in Gherkin using SpecFlow, Selenium and Web Driver. (and NUnit)
# https://joebuschmann.com/getting-started-with-selenium-specflow-and-dot-net/

# Install SpecFlow Visual Studio Extension to get template and generate feature file
# Specify your tests within the feature file in Gherkin syntax and business language
# Generate and populate your steps
# Use Page Objects for clarity and to promote reuse.

Scenario: Check the weather
	Given I have a browser open with the BBC homepage displayed
	When I click on the weather link in the title bar
	Then the weather page is displayed
