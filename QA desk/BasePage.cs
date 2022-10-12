using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QA_desk
{
    public class BasePage
    {
        public IWebDriver webDriver;
        public WebDriverWait waitElement;
        public BasePage(IWebDriver driver)
        {
            webDriver = driver;
            waitElement = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
        public IWebElement waitUntilElementIsVisible(string Identifier)
        {
            return waitElement.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(Identifier)));
        }
    }
}
