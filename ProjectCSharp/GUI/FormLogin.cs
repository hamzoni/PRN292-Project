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
using ProjectCSharp.Entities;
using ProjectCSharp.DAL;
using System.Threading;

namespace ProjectCSharp
{
    partial class FormLogin : Form
    {
        public Account account { get; set; }
        private bool isLogout;
        private bool stopAutoLogin;

        public FormLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        public FormLogin(bool isLogout, bool stopAutoLogin)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            this.isLogout = isLogout;
            this.stopAutoLogin = stopAutoLogin;
        }

        public void autofill(Account acc)
        {
            txtUsername.Text = acc.username;
            txtPassword.Text = acc.password;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            acc.username = txtUsername.Text;
            acc.password = txtPassword.Text;

            if (DataModel.accMdl.login(acc))
            {
                acc = DataModel.accMdl.search(acc);
                if (checkbox_autologin.Checked)
                {
                    Authentication.setRememberToken(acc.id);
                }
                login(acc, false);
            }
        }

        private void checkAutologin()
        {
            object token = Authentication.getRememberToken();
            if (token == null) return;

            int accountID = Int32.Parse(token.ToString());
            Account acc = DataModel.accMdl.searchByID(accountID);
            if (acc != null) login(acc, true);
        }

        private void login(Account acc, bool isAuto)
        {
            FormMain form = new FormMain();
            form.ctrl.auth.account = acc;
            form.ctrl.landing(isAuto);
            form.Show();

            Hide();
            Dispose(false);
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister(this);
            register.ShowDialog();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            if (stopAutoLogin)
            {
                Authentication.removeRememberToken();
            }
            if (!isLogout)
            {
                checkAutologin();
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
