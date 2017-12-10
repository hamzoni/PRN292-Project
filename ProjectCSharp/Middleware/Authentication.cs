using ProjectCSharp.Controller;
using ProjectCSharp.DAL;
using ProjectCSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp
{
    class Authentication
    {
        public MainController ctrl;
        public Account account { get; set; }

        public Authentication()
        {
            account = new Account();
        }

        public void loginSuccess()
        {
            ctrl.landing();
        }
    }
}
