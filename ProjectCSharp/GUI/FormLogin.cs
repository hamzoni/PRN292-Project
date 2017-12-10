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

namespace ProjectCSharp
{
    partial class FormLogin : Form
    {
        public Account account { get; set; }
        public Authentication auth;

        public FormLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            auth = new Authentication();
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
                auth.account = acc;
                auth.loginSuccess();

                new FormMain().ShowDialog();

                this.Hide();
            }
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister(this);
            register.ShowDialog();
        }

    }
}
