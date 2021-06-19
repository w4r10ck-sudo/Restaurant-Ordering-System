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
    public partial class foodItemGUI : Form
    {
        foodItemDTO fooddto;
        foodItemBL foodbl;
        public foodItemGUI()
        {
            InitializeComponent();
            fooddto = new foodItemDTO();
            foodbl = new foodItemBL();
        }

        private bool validate_input(string name, string price, string desc, string cat)
        {
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(price)
                && !string.IsNullOrWhiteSpace(desc) && !string.IsNullOrWhiteSpace(cat))
                return true;
            return false;
        }
        private bool check_input_format(string name, string price, string desc)
        {
            if (Regex.Match(name, "^[a-zA-Z0-9_ ]*$").Success && Regex.Match(price, @"^\d+(,\d{1,2})?$").Success
                && Regex.Match(desc, "^[a-zA-Z0-9_. ]*$").Success)
                return true;
            return false;
        }
        private void loadData()
        {
            DataTable dt;
            try
            {
                dt = foodbl.getAllCategories();
                dataGridView1.DataSource = dt;
                if (txt_foodcat_create.Items.Count > 0 || txt_foodcat_update.Items.Count > 0)
                {
                    txt_foodcat_create.Items.Clear();
                    txt_foodcat_update.Items.Clear();
                }
                foreach (DataRow row in dt.Rows)
                {
                    string name = row["name"].ToString();
                    txt_foodcat_create.Items.Add(name);
                    txt_foodcat_update.Items.Add(name);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            if (validate_input(txt_foodname_create.Text, txt_foodprice_create.Text, txt_fooddesc_create.Text, txt_foodcat_create.Text))
            {
                if (check_input_format(txt_foodname_create.Text, txt_foodprice_create.Text, txt_fooddesc_create.Text))
                {
                    fooddto.Name = txt_foodname_create.Text;
                    fooddto.Price = txt_foodprice_create.Text;
                    fooddto.Description = txt_fooddesc_create.Text;
                    fooddto.Category = txt_foodcat_create.Text;
                    try
                    {
                        foodbl.createfoodItem(fooddto).ShowDialog();
                        loadData();
                        txt_foodname_create.ResetText();
                        txt_foodprice_create.ResetText();
                        txt_fooddesc_create.ResetText();
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
                MessageBox.Show("Please fill all feilds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            foodItemDTO fooditemdto = new foodItemDTO();
            fooditemdto.Name = txt_foodname_search.Text;
            try
            {
                fooditemdto = foodbl.GetfoodItem(fooditemdto);
                if (fooditemdto != null)
                {
                    txt_foodname_update.Text = fooditemdto.Name;
                    txt_foodprice_update.Text = fooditemdto.Price;
                    txt_fooddesc_update.Text = fooditemdto.Description;
                    txt_foodcat_update.SelectedIndex = txt_foodcat_update.Items.IndexOf(fooditemdto.Category);
                }
                else
                {
                    new outputFormGUI("Something went Wrong..!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (validate_input(txt_foodname_update.Text, txt_foodprice_update.Text, txt_fooddesc_update.Text, txt_foodcat_update.Text))
            {
                if (check_input_format(txt_foodname_update.Text, txt_foodprice_update.Text, txt_fooddesc_update.Text))
                {
                    fooddto.Name = txt_foodname_update.Text;
                    fooddto.Price = txt_foodprice_update.Text;
                    fooddto.Description = txt_fooddesc_update.Text;
                    fooddto.Category = txt_foodcat_update.Text;
                    try
                    {
                        foodbl.updatefoodItem(fooddto).ShowDialog();
                        loadData();
                        txt_foodname_update.ResetText();
                        txt_foodprice_update.ResetText();
                        txt_fooddesc_update.ResetText();
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
                MessageBox.Show("Please fill all feilds!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_foodname_del.Text))
            {
                fooddto.Name = txt_foodname_del.Text;
                try
                {
                    foodbl.deletefoodItem(fooddto).ShowDialog();
                    loadData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                new outputFormGUI("Please Enter a valid food Item name..!");
            }
        }
    }
}
