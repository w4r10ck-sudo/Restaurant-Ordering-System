using Restaurant_Ordering_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System.GUI
{
    public partial class managerGUI : Form
    {
        public managerGUI()
        {
            InitializeComponent();
        }
        public managerGUI(userDTO udto)
        {
            InitializeComponent();
            show_username.Text = udto.Username;
            show_email.Text = udto.Email;
            show_contact.Text = udto.Contact;
            show_salary.Text = udto.Salary;
            show_role.Text = udto.Role;
            show_status.Text = udto.Status;
        }
        private void managerGUI_Load(object sender, EventArgs e)
        {/*
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
            */
        }
        }
}
