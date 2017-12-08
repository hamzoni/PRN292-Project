using ProjectCSharp.DAL;
using ProjectCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp
{
    public class Authentication
    {
        private FormMain main;
        public Account account { get; set; }

        public Authentication(FormMain main)
        {
            this.main = main;
        }

        public void showLoginDialog()
        {
            FormLogin login = new FormLogin(this);
            login.ShowDialog();
        }

        public void loginSuccess()
        {
            main.landing();
        }
    }
}
