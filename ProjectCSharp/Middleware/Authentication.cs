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
        private MainController ctrl;
        public Account account { get; set; }

        public Authentication(MainController ctrl)
        {
            this.ctrl = ctrl;
            // fake login
            //account = new Account();
            //account.username = "A";
            //account.password = "123";

            // account = DataModel.accMdl.search(account);
        }

        public void loginSuccess()
        {
            ctrl.landing();
        }
    }
}
