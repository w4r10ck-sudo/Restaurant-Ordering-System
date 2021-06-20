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
    public partial class ordershistoryGUI : Form
    {
        ordersBL obl = new ordersBL();
        public ordershistoryGUI()
        {
            InitializeComponent();
        }

        private void ordershistoryGUI_Load(object sender, EventArgs e)
        {
            try
            {
                ordersGridView.DataSource = obl.getAllOrdersHistory();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
