using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{

    [Binding]
    public class MyTestsSteps
    {
        private readonly IWebDriver _webDriver;

        public MyTestsSteps()
        {
            _webDriver = new ChromeDriver();
        }

        [Given(@"I have a browser open with the BBC homepage displayed")]
        public void GivenIHaveABrowserOpenWithTheBBCHomepageDisplayed()
        {
            _webDriver.Navigate().GoToUrl("http://www.bbc.co.uk");
        }

        [When(@"I click on the weather link in the title bar")]
        public void WhenIClickOnTheWeatherLinkInTheTitleBar()
        {
            IWebElement weatherLink = _webDriver.FindElement(By.CssSelector(".orb-nav-weather a"));
            weatherLink.Click();
        }

        [Then(@"the weather page is displayed")]
        public void ThenTheWeatherPageIsDisplayed()
        {
            // If this was dynamic HTML, we would create a web driver wait and 
            // use wait.Until to poll until the found or a specified time expires.

            Assert.AreEqual("https://www.bbc.co.uk/weather", _webDriver.Url);
        }
    }
}
