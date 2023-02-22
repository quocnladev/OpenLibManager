﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystem.Includes;
using LibrarySystem.Properties;
using System.IO;

namespace LibrarySystem
{
    public partial class frmLogin : Form
    {
        Form1 frm;
        public frmLogin(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        SQLConfig config = new SQLConfig(); 
        string sql;


        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `tbluser` WHERE User_name= '" + UsernameTextBox.Text + "' and Pass = sha1('" + PasswordTextBox.Text + "')";
            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {
                MessageBox.Show("Chào mừng bạn đến với Open Library");
                frm.enabled_menu();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại. Vui lòng liên hệ với admin", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
