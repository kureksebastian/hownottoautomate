using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApp.Automation.Interfaces;
using SampleApp.Automation.POM;

namespace HowNotToAutomate.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ICanLoginWithCorrectCredentialsBadWay()
        {
            IApp app = new App();
            ILoginWindow loginPage = new LoginWindow();
            IWindow adminMainWindow = new AdminMainWindow();
            IWindow userMainWindow = new MainWindow();

            string login = GetTestParameter("login");
            string password = GetTestParameter("password");
            string isAdminParameter = GetTestParameter("isAdmin");
            
            //Step 1
            app.Launch();

            //Step 2
            loginPage.LoginTextBox.Text = login;
            loginPage.PasswordTextBox.Text = password;
            bool isAdmin = bool.Parse(isAdminParameter);
            if (isAdmin)
            {
                loginPage.AdminLoginButton.Click();
                WaitFor(() => adminMainWindow.IsLoaded, timeToWaitInSeconds: 5);
                Assert.IsTrue(adminMainWindow.IsLoaded);
            }
            else
            {
                loginPage.LoginButton.Click();
                WaitFor(() => userMainWindow.IsLoaded, timeToWaitInSeconds: 5);
                Assert.IsTrue(userMainWindow.IsLoaded);
            }

            Assert.IsTrue(loginPage.Login("correctLogin", "correctPassword", true), "I cannot login with given credentials");
        }
        
        [TestMethod]
        public void ICanLoginWithCorrectCredentialsGoodWay()
        {
            IApp app = new App();
            ILoginWindow loginPage = new LoginWindow();

            //Step 1
            app.Launch();

            //Step 2
            Assert.IsTrue(loginPage.Login("correctLogin", "correctPassword", "Admin"), "I cannot login with given credentials");
        }

        private void WaitFor(Func<bool> action, int timeToWaitInSeconds)
        {
            throw new NotImplementedException();
        }

        private string GetTestParameter(string v)
        {
            throw new NotImplementedException();
        }

    }
}
