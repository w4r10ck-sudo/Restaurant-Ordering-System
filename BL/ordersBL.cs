using Restaurant_Ordering_System.DL;
using Restaurant_Ordering_System.DTO;
using Restaurant_Ordering_System.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System.BL
{
    class ordersBL
    {
        ordersDL odl = new ordersDL();
        public Form createOrder(List<ordersDTO> odtos)
        {
            try
            {
                odl.createOrderInDb(odtos);
                return new outputFormGUI("Success");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable getAllOrders()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = odl.getAllOrdersFromDb();
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Form updateOrder(ordersDTO odto)
        {
            try
            {
                int num = odl.updateOrderStatusInDb(odto); ;
                if (num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "It seems that Order does not exist\n OR \n No record have been changed";
                    return new outputFormGUI(msg);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
