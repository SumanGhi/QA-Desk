using NUnit.Framework;
using OpenQA.Selenium;
using QA_desk.Objects;

namespace QA_desk.Assertions
{
    public class LoginVerify : LoginObject
    {
        public LoginVerify(IWebDriver driver): base(driver)
        {

        }
        public void VerifySuccessfullLogin()
        {
            Assert.That(Dashboard.Displayed, Is.True, "Cannot login");
            Console.WriteLine("Successfully logged in");
        }

    }
}
