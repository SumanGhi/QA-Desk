using OpenQA.Selenium;

namespace QA_desk.Objects
{
    public class LoginObject : BasePage
    {
        public LoginObject(IWebDriver driver) : base(driver)
        {

        }

        //userName
        protected IWebElement UserName => waitUntilElementIsVisible("//input[@id='emailOrUsername']");
        //password
        protected IWebElement Password => waitUntilElementIsVisible("//input[@id='password']");
        //dashboard
        protected IWebElement Dashboard => waitUntilElementIsVisible("//div[@class='lw-heading']");


    }
}
