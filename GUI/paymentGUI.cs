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
    public partial class paymentGUI : Form
    {
        paymentDTO paydto;
        PaymentBL paybl;
        public paymentGUI()
        {
            InitializeComponent();
            paydto = new paymentDTO();
            paybl = new PaymentBL();
        }
        public void loadData()
        {
            DataTable dt;
            try
            {
                dt = paybl.getAllPayments();
                paymentGridView.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void paymentGUI_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (paymentGridView.RowCount > 0)
            {
                paydto.Status = paymentGridView.CurrentRow.Cells[3].Value.ToString();
                if (paydto.Status == "Unpaid")
                {
                    paydto.PaymentId = paymentGridView.CurrentRow.Cells[0].Value.ToString();
                    try
                    {
                        paybl.updatePayment(paydto).ShowDialog();
                        loadData();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    new outputFormGUI("Already Paid!").ShowDialog();
                }
            }
            else
            {
                new outputFormGUI("No Payments!").ShowDialog();
            }
        }
    }
}
