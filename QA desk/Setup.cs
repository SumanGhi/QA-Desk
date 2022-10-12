using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace QA_desk
{
    public class Setup
    {
        public IWebDriver WebDriver;
        [SetUp]
        public void BeforeTest()
        {
            WebDriver = new ChromeDriver();
            WebDriver.Manage().Window.Maximize();
            WebDriver.Navigate().GoToUrl("https://qa-desk-demo.livelyworks.net/#!/login");
        }
        [TearDown]
        public void AfterTest()
        {
            WebDriver.Quit();
        }
    }
}
