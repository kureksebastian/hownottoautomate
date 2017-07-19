using SampleApp.Automation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controls;

namespace SampleApp.Automation.POM
{
    public class LoginWindow : ILoginWindow
    {
        //Get Controls using framework (i.e. White, Selenium etc)
        public TextBox LoginTextBox { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TextBox PasswordTextBox { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Button LoginButton { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Button AdminLoginButton { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Login(string login, string password)
        {
            LoginTextBox.Text = login;
            PasswordTextBox.Text = password;
            if (login.ToLower().Equals("admin"))
            {
                AdminLoginButton.Click();
            }
            else
            {
                LoginButton.Click();
            }
            //Rest of the logic goes here
            return true;
        }
    }
}
