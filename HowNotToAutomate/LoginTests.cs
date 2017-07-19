using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApp.Automation.Interfaces;
using SampleApp.Automation.POM;
using System.Diagnostics;
using System.Threading;

namespace HowNotToAutomate.Tests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
        public void CanLoginBadWay()
        {
            IApp app = new App();
            ILoginWindow loginWindow = new LoginWindow();
            IWindow adminMainWindow = new AdminMainWindow();
            IWindow userMainWindow = new MainWindow();
            
            string login = GetTestParameter("login");
            string password = GetTestParameter("password");
            
            app.Launch();

            loginWindow.LoginTextBox.Text = login;
            loginWindow.PasswordTextBox.Text = password;
            bool isAdmin = login.ToLower() == "admin";
            if (isAdmin)
            {
                loginWindow.AdminLoginButton.Click();
                DateTime start = DateTime.Now;
                while(!adminMainWindow.IsLoaded && (DateTime.Now-start).TotalSeconds < 5)
                {
                    Thread.Sleep(100);
                }
                Assert.IsTrue(adminMainWindow.IsLoaded,"Admin Window was not loaded");
            }
            else
            {
                loginWindow.LoginButton.Click();
                DateTime start = DateTime.Now;
                while (!userMainWindow.IsLoaded && (DateTime.Now - start).TotalSeconds < 5)
                {
                    Thread.Sleep(100);
                }
                
                Assert.IsTrue(userMainWindow.IsLoaded);
            }
        }
        
        [TestMethod]
        public void CanLoginGoodWay()
        {
            IApp app = new App();
            ILoginWindow loginPage = new LoginWindow();

            string login = GetTestParameter("login");
            string password = GetTestParameter("password");

            //Step 1
            app.Launch();

            //Step 2
            Assert.IsTrue(loginPage.Login(login, password), "I cannot login with given credentials");
        }

        private string GetTestParameter(string v)
        {
            throw new NotImplementedException();
        }

    }
}
