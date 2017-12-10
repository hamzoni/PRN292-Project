using ProjectCSharp.Controller;
using ProjectCSharp.DAL;
using ProjectCSharp.Entities;
using ProjectCSharp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp
{
    class Authentication
    {
        // remember file for auto login
        public static string rmfn = "autologin.x";

        public MainController ctrl;
        public Account account { get; set; }

        public Authentication(MainController ctrl)
        {
            this.ctrl = ctrl;
            ctrl.auth = this;
        }

        public static void setRememberToken(int id)
        {
            string token = Encryptor.Encrypt(id.ToString());
            FileIO.write(rmfn, token);
        }

        public static object getRememberToken()
        {
            string token = FileIO.read(rmfn);
            if (token == null) return null;
            return Encryptor.Decrypt(token);
        }
    }
}
