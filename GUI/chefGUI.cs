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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System.GUI
{
    public partial class chefGUI : Form
    {
        ordersBL obl;
        ordersDTO odto;
        public chefGUI()
        {
            InitializeComponent();
            obl = new ordersBL();
            odto = new ordersDTO();
        }
        private void loadData()
        {
            try
            {
                ordersGridView.DataSource = obl.getAllOrdersforKitchen();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_prepared_Click(object sender, EventArgs e)
        {
            if(ordersGridView.RowCount > 0)
            {
                odto.Customer = ordersGridView.CurrentRow.Cells[2].Value.ToString();
                try
                {
                    obl.prepareOrder(odto).ShowDialog();
                    loadData();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                new outputFormGUI("No orders to prepare!").ShowDialog();
            }
        }

        private void chefGUI_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
