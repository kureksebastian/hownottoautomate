using Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Automation.Interfaces
{
    public interface ILoginWindow
    {
        TextBox LoginTextBox { get; set; }
        TextBox PasswordTextBox { get; set; }
        Button LoginButton { get; set; }
        Button AdminLoginButton { get; set; }

        //void ClickButton(string buttonName);
        //void SetText(string text, string textBoxName);
        //string GetText(string textBoxName);
        

        bool Login(string login, string password);
    }
}
