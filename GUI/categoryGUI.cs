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
    public partial class categoryGUI : Form
    {
        categoryDTO catdto;
        categoryBL catbl;
        public categoryGUI()
        {
            InitializeComponent();
            catdto = new categoryDTO();
            catbl = new categoryBL();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txt_cat_create.Text) && !string.IsNullOrWhiteSpace(txt_cat_createdesc.Text))
            {
                if (Regex.Match(txt_cat_create.Text, "^[a-zA-Z0-9_ ]*$").Success && Regex.Match(txt_cat_createdesc.Text, "^[a-zA-Z0-9_. ]*$").Success)
                {
                    catdto.Name = txt_cat_create.Text;
                    catdto.Description = txt_cat_createdesc.Text;
                    try
                    {
                        catbl.createCategory(catdto).ShowDialog();
                        loadData();
                        txt_cat_create.ResetText();
                        txt_cat_createdesc.ResetText();
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
        private void loadData()
        {
            DataTable dt;
            try
            {
                dt = catbl.getAllCategories();
                dataGridView1.DataSource = dt;
                if (txt_catlist_del.Items.Count > 0 || txt_catlist_update.Items.Count > 0)
                {
                    txt_catlist_del.Items.Clear();
                    txt_catlist_update.Items.Clear();
                }
                foreach (DataRow row in dt.Rows)
                {
                    string name = row["name"].ToString();
                    txt_catlist_del.Items.Add(name);
                    txt_catlist_update.Items.Add(name);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void categoryGUI_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_cat_update.Text) && !string.IsNullOrWhiteSpace(txt_cat_updatedesc.Text) && txt_catlist_update.SelectedIndex != -1)
            {
                if (Regex.Match(txt_cat_update.Text, "^[a-zA-Z0-9_ ]*$").Success && Regex.Match(txt_cat_updatedesc.Text, "^[a-zA-Z0-9_. ]*$").Success)
                {
                    catdto.Name = txt_cat_update.Text;
                    catdto.Description = txt_cat_updatedesc.Text;
                    categoryDTO catdto2 = new categoryDTO();
                    catdto2.Name = txt_catlist_update.Text;
                    try
                    {
                        catbl.updateCategory(catdto, catdto2).ShowDialog();
                        loadData();
                        txt_cat_update.ResetText();
                        txt_cat_updatedesc.ResetText();
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

        private void txt_catlist_update_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_catlist_update.SelectedIndex != -1)
            {
                categoryDTO categorydto = new categoryDTO();
                categorydto.Name = txt_catlist_update.Text;
                try
                {
                    categorydto = catbl.GetCategory(categorydto);
                    if (categorydto != null)
                    {
                        txt_cat_update.Text = categorydto.Name;
                        txt_cat_updatedesc.Text = categorydto.Description;
                    }
                    else
                    {
                        new outputFormGUI("Something went Wrong..!");
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(txt_catlist_del.SelectedIndex != -1)
            {
                catdto.Name = txt_catlist_del.Text;
                try
                {
                    catbl.deleteCategory(catdto).ShowDialog();
                    loadData();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                new outputFormGUI("Please select a category first..!");
            }
        }
    }

    }

