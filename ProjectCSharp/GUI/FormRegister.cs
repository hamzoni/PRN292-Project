using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ProjectCSharp.Entities;
using ProjectCSharp.Utility;
using ProjectCSharp.DAL;

namespace ProjectCSharp
{
    partial class FormRegister : Form
    {
        public Account account;
        public FormLogin login;

        public FormRegister()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtRePass.PasswordChar = '*';
        }

        public FormRegister(FormLogin login)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            txtRePass.PasswordChar = '*';
            this.login = login;
        }

        //function check user name
        public bool validate()
        {
            bool c1 = txtUsername.Text.Length != 0;
            bool c2 = txtPassword.Text.Length != 0;

            return c1 && c2;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!validate())
            {
                MSG.error(null, null);
                return;
            }

            MSG.success(null, null);

            Account acc = new Account();
            acc.username = txtUsername.Text;
            acc.password = txtPassword.Text;

            DataModel.accMdl.insert(acc);

            login.autofill(acc);
            Hide();
        }
    }
}
