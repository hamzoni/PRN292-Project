using ProjectCSharp.Controller;
using ProjectCSharp.DAL;
using ProjectCSharp.Entities;
using ProjectCSharp.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjectCSharp.GUI
{
    partial class FormProfile : Form
    {
        public MainController ctrl;
        private Account acc;
        private bool editMode = false;

        public FormProfile()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.acc = new Account();
        }

        public FormProfile(MainController ctrl)
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.ctrl = ctrl;
            this.acc = ctrl.auth.account;
        }

        private void btn_editsubmit_Click(object sender, EventArgs e)
        {

            if (editMode)
            {
                // change button UI
                btn_editsubmit.Text = "Saved!";
                timeout(updateBtnText, 1);

                // save data
                acc.username = input_username.Text;
                acc.password = input_password.Text;
                // DataModel.accMdl.update(acc);
            }
            else
            {
                btn_editsubmit.Text = "Submit";
            }

            editMode = !editMode;
            input_username.Enabled = editMode;
            input_password.Enabled = editMode;
        }

        public void updateBtnText()
        {
            btn_editsubmit.Text = "Edit";
        }

        public void timeout(Action f, int s)
        {
            
            Thread t = new Thread(new ThreadStart(() =>
            {
                Thread.Sleep(s * 1000);
                f();
            }));
            t.Start();
;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool cf = MSG.confirm("This action is irreversible. Are you sure to continue?", "Delete account");
            if (cf)
            {
                return;
            }
        }

    }
}
