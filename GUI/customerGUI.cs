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
    public partial class customerGUI : Form
    {
        customerBL cbl;
        customerDTO cdto;
        public customerGUI()
        {
            InitializeComponent();
            cbl = new customerBL();
            cdto = new customerDTO();
        }
        private void loadData()
        {
            DataTable dt;
            try
            {
                dt = cbl.getAllCustomers();
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void customerGUI_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_name_create.Text) && !string.IsNullOrWhiteSpace(txt_contact_create.Text))
            {
                if (Regex.Match(txt_name_create.Text, "^[a-zA-Z ]*$").Success && Regex.Match(txt_contact_create.Text, @"^\d+(,\d{1,2})?$").Success)
                {
                    cdto.Name = txt_name_create.Text;
                    cdto.Contact = txt_contact_create.Text;
                    try
                    {
                        cbl.createCustomer(cdto).ShowDialog();
                        loadData();
                        txt_name_create.ResetText();
                        txt_contact_create.ResetText();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill both feilds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_search.Text))
            {
                if (Regex.Match(txt_search.Text, @"^\d+(,\d{1,2})?$").Success)
                {
                    cdto = new customerDTO();
                    cdto.Contact = txt_search.Text;
                    try
                    {
                        cdto = cbl.GetCustomer(cdto);
                        if (cdto != null)
                        {
                            txt_name_update.Text = cdto.Name;
                        }
                        else
                        {
                            new outputFormGUI("User not Found..!").ShowDialog();
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill the contact in feild!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_search.Text) && !string.IsNullOrWhiteSpace(txt_name_update.Text))
            {
                if (Regex.Match(txt_name_update.Text, "^[a-zA-Z ]*$").Success && Regex.Match(txt_search.Text, @"^\d+(,\d{1,2})?$").Success)
                {
                    cdto = new customerDTO();
                    cdto.Contact = txt_search.Text;
                    cdto.Name = txt_name_update.Text;
                    try
                    {
                        cbl.updateCustomer(cdto).ShowDialog();
                        loadData();
                        txt_search.ResetText();
                        txt_name_update.ResetText();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong input format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill both feilds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
