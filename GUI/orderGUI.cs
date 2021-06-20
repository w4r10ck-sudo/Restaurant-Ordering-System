using Restaurant_Ordering_System.BL;
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
    public partial class orderGUI : Form
    {
        customerBL cbl;
        foodItemBL fbl;
        cartBL cartbl;
        public orderGUI()
        {
            InitializeComponent();
            cbl = new customerBL();
            fbl = new foodItemBL();
            cartbl = new cartBL();
        }
        public void loadData()
        {
            DataTable customerdata, menudata, cartdata, ordersdata;
            try
            {
                customerdata = cbl.getAllCustomers();
                menudata = fbl.getAllFoodItems();
                cartdata = cartbl.getAllCartItems();
                customersGridView.DataSource = customerdata;
                menuGridView.DataSource = menudata;
                cartGridView.DataSource = cartdata;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderGUI_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
