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
    public partial class orderGUI : Form
    {
        customerBL cbl;
        foodItemBL fbl;
        cartBL cartbl;
        ordersBL obl;
        customerDTO cdto;
        foodItemDTO fdto;
        cartDTO cartdto;
        ordersDTO odto;
        public orderGUI()
        {
            InitializeComponent();
            cbl = new customerBL();
            fbl = new foodItemBL();
            cartbl = new cartBL();
            obl = new ordersBL();
            cdto = new customerDTO();
            fdto = new foodItemDTO();
            cartdto = new cartDTO();
            odto = new ordersDTO();
        }
        public void loadData()
        {
            DataTable customerdata, menudata;
            try
            {
                customerdata = cbl.getAllCustomers();
                menudata = fbl.getAllFoodItems();
                customersGridView.DataSource = customerdata;
                menuGridView.DataSource = menudata;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadCartnOrders()
        {
            DataTable cartdata, ordersdata;
            try
            {
                cartdata = cartbl.getAllCartItems();
                ordersdata = obl.getAllOrders();
                cartGridView.DataSource = cartdata;
                ordersGridView.DataSource = ordersdata;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderGUI_Load(object sender, EventArgs e)
        {
            loadData();
            loadCartnOrders();
        }

        private void btn_select_customer_Click(object sender, EventArgs e)
        {
            SessionBL.setCustomerInSession(customersGridView.CurrentRow.Cells[0].Value.ToString());
            new outputFormGUI("Customer successfully selected!").ShowDialog();
            loadCartnOrders();
        }

        private void orderGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            SessionBL.setCustomerInSession("");
        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            if(SessionBL.getCustomerFromSession() != "")
            {
                cartdto.Fooditem = menuGridView.CurrentRow.Cells[0].Value.ToString();
                cartdto.Qty = item_quantity.Value.ToString();
                try
                {
                    cartbl.createCartItem(cartdto).ShowDialog();
                    loadCartnOrders();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                new outputFormGUI("Please Select a Customer First..!").ShowDialog();
            }
        }

        private void btn_update_citem_Click(object sender, EventArgs e)
        {
            if (cartGridView.RowCount > 0)
            {
                cartdto.cartId = cartGridView.CurrentRow.Cells[0].Value.ToString();
                cartdto.Qty = citem_qty.Value.ToString();
                try
                {
                    cartbl.updateCartItem(cartdto).ShowDialog();
                    loadCartnOrders();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                new outputFormGUI("Please insert atleast one fooditem!\nOR\nSelect a customer having cart items!").ShowDialog();
            }
        }

        private void btn_remove_citem_Click(object sender, EventArgs e)
        {
            if (cartGridView.RowCount > 0)
            {
                cartdto.cartId = cartGridView.CurrentRow.Cells[0].Value.ToString();
                try
                {
                    cartbl.deleteCartItem(cartdto).ShowDialog();
                    loadCartnOrders();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                new outputFormGUI("Please insert atleast one fooditem!\nOR\nSelect a customer having cart items!").ShowDialog();
            }
        }

        private void btn_place_order_Click(object sender, EventArgs e)
        {
            if (cartGridView.RowCount > 0)
            {
                List<ordersDTO> odto = new List<ordersDTO>();
                ordersDTO orderdto = new ordersDTO();
                orderdto.Status = "InProgress";
                try
                {
                    foreach (DataGridViewRow dr in cartGridView.Rows)
                    {
                        orderdto.Fooditem = dr.Cells[1].Value.ToString();
                        fdto.Name = orderdto.Fooditem;
                        fdto = fbl.GetfoodItem(fdto);
                        int price = Convert.ToInt16(fdto.Price);
                        int qty = Convert.ToInt16(dr.Cells[4].Value.ToString());
                        orderdto.Waiter = dr.Cells[2].Value.ToString();
                        orderdto.Customer = dr.Cells[3].Value.ToString();
                        orderdto.Price = (price * qty).ToString();
                        odto.Add(orderdto);
                    }
                    obl.createOrder(odto).ShowDialog();
                    cartbl.deleteAllCartItems();
                    loadCartnOrders();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                new outputFormGUI("Please insert atleast one fooditem!\nOR\nSelect a customer having cart items!").ShowDialog();
            }
        }

        private void btn_cancel_order_Click(object sender, EventArgs e)
        {
            if (ordersGridView.RowCount > 0)
            {
                odto.Status = "Cancelled";
                try
                {
                    obl.updateOrder(odto).ShowDialog();
                    loadCartnOrders();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                new outputFormGUI("Please place atleast one order!\nOR\nSelect a customer having Orders!").ShowDialog();
            }
        }

        private void btn_serve_order_Click(object sender, EventArgs e)
        {
            if (ordersGridView.RowCount > 0)
            {
                if (ordersGridView.CurrentRow.Cells[5].Value.ToString() == "Prepared")
                {
                    odto.Status = "Served";
                    try
                    {
                        obl.updateOrder(odto).ShowDialog();

                        loadCartnOrders();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    new outputFormGUI("Order is not prepared yet!").ShowDialog();
                }
            }
            else
            {
                new outputFormGUI("Please place atleast one order!\nOR\nSelect a customer having Orders!").ShowDialog();
            }
        }
    }
}
