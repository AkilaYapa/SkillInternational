﻿using DatabaseProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkillInternationalWinFormApp
{
    public partial class LoginForm : Form
    {
        DBAccess objDBAccess = new DBAccess();
        DataTable LoginTable = new DataTable();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetMyForm();  
        }

        private void ResetMyForm()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string query = "Select * from Logins where username='"+ username + "' AND password='"+ password + "'";
            objDBAccess.readDatathroughAdapter(query, LoginTable);

            if (LoginTable.Rows.Count>0)
            {
                this.Hide();
                RegisterForm form1 = new RegisterForm();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                ResetMyForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          DialogResult result = MessageBox.Show("Are you sure, Do you really want to Exit...?","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
