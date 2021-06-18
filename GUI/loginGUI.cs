using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Restaurant_Ordering_System.DTO;
using Restaurant_Ordering_System.BL;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Restaurant_Ordering_System
{
    public partial class Form1 : Form
    {
        loginDTO logindto = new loginDTO();
        loginBL loginbl = new loginBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(txt_password.Text))
            {
                if (Regex.Match(txt_username.Text, "^[a-zA-Z0-9_]*$").Success)
                {
                    logindto.Username = txt_username.Text;
                    logindto.Password = txt_password.Text;
                    try
                    {
                        loginbl.verifyUser(logindto).ShowDialog();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                }
                else
                {
                    MessageBox.Show("Wrong username format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill both feilds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
