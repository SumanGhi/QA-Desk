
using NUnit.Framework;
using QA_desk.Pages;

namespace QA_desk.Tests
{
    internal class LoginTest : Setup
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            LoginPage login = new(WebDriver);
            login.LoginWithValidCred()
                .VerifySuccessfullLogin();
        }
    }
}
