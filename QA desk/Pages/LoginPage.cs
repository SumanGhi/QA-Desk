
using OpenQA.Selenium;
using QA_desk.Assertions;
using QA_desk.Objects;

namespace QA_desk.Pages
{
    public class LoginPage : LoginObject
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        public LoginVerify LoginWithValidCred()
        {
            UserName.SendKeys("demoadmin");
            Password.SendKeys("demopass12"+ Keys.Enter);
            Thread.Sleep(3000);
            return new LoginVerify(webDriver);
        }
    }
}
