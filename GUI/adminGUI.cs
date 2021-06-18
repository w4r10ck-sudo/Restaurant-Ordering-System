using Restaurant_Ordering_System.BL;
using Restaurant_Ordering_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System.GUI
{
    public partial class adminGUI : Form
    {
        userDTO userdto = new userDTO();
        adminBL adminbl = new adminBL();
        public adminGUI()
        {
            InitializeComponent();
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_username.Text) && !string.IsNullOrEmpty(txt_email.Text) && !string.IsNullOrEmpty(txt_pass.Text) &&
                !string.IsNullOrEmpty(txt_contact.Text) && !string.IsNullOrEmpty(txt_salary.Text) && !string.IsNullOrEmpty(txt_role.Text))
            {
                if (Regex.Match(txt_username.Text, "^[a-zA-Z0-9_]*$").Success)
                {
                    userdto.Username = txt_username.Text;
                    userdto.Email = txt_email.Text;
                    userdto.Password = txt_pass.Text;
                    userdto.Contact = txt_contact.Text;
                    userdto.Salary = txt_salary.Text;
                    userdto.Role = txt_role.Text;
                    userdto.Status = "active";
                    try
                    {
                        adminbl.createUser(userdto).ShowDialog();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the feilds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabcontrol1.SelectedTab == viewusertab)
            {
                DataTable dt;
                try
                {
                    dt = adminbl.getAllUsers();
                    if(dt != null)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No record exists", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void adminGUI_Load(object sender, EventArgs e)
        {
            userDTO udto;
            try
            {
                udto = adminbl.getAdminData();
                if (udto != null)
                {
                    show_username.Text = udto.Username;
                    show_email.Text = udto.Email;
                    show_contact.Text = udto.Contact;
                    show_salary.Text = udto.Salary;
                    show_role.Text = udto.Role;
                    show_status.Text = udto.Status;
                }
                else
                {
                    new outputFormGUI("Something went wrong!").ShowDialog();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_update_username.Text) && !string.IsNullOrEmpty(txt_update_email.Text) && !string.IsNullOrEmpty(txt_update_password.Text) &&
                !string.IsNullOrEmpty(txt_update_contact.Text) && !string.IsNullOrEmpty(txt_update_salary.Text) && !string.IsNullOrEmpty(txt_update_role.Text))
            {
                if (Regex.Match(txt_update_username.Text, "^[a-zA-Z0-9_]*$").Success)
                {
                    userdto.Username = txt_update_username.Text;
                    userdto.Email = txt_update_email.Text;
                    userdto.Password = txt_update_password.Text;
                    userdto.Contact = txt_update_contact.Text;
                    userdto.Salary = txt_update_salary.Text;
                    userdto.Role = txt_update_role.Text;
                    try
                    {
                        adminbl.updateUser(userdto).ShowDialog();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the feilds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_search.Text))
            {
                if (Regex.Match(txt_search.Text, "^[a-zA-Z0-9_]*$").Success)
                {
                    userdto.Username = txt_search.Text;
                    try
                    {
                        userDTO udto = adminbl.finduser(userdto);
                        if (udto != null)
                        {
                            txt_update_username.Text = udto.Username;
                            txt_update_email.Text = udto.Email;
                            txt_update_password.Text = udto.Password;
                            txt_update_contact.Text = udto.Contact;
                            txt_update_salary.Text = udto.Salary;
                            txt_update_role.Text = udto.Role;
                            lb_status.Text += udto.Status;
                        }
                        else
                        {
                            new outputFormGUI("Something went wrong!").ShowDialog();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the feilds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_block_unblock_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_update_username.Text))
            {
                userdto.Username = txt_update_username.Text;
                try
                {
                    adminbl.block_unblock_user(userdto);
                    new outputFormGUI("Success").ShowDialog();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in updatetab.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.ResetText();
                if (ctrl is ComboBox)
                    ctrl.ResetText();
            }
            lb_status.Text = "Status: ";
        }
    }
}