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
        public TextBox LoginTextBox { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public TextBox PasswordTextBox { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Button LoginButton { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Button AdminLoginButton { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Login(string login, string password, bool isAdmin)
        {
            throw new NotImplementedException();
        }
    }
}
