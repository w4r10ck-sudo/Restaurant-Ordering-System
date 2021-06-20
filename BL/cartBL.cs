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
    class cartBL
    {
        cartDL cdl = new cartDL();
        public Form createCartItem(cartDTO cdto)
        {
            try
            {
                cdl.createcartItemInDb(cdto);
                return new outputFormGUI("Success");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable getAllCartItems()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdl.getAllcartItemsFromDb();
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Form updateCartItem(cartDTO cdto)
        {
            try
            {
                int num = cdl.updatecartItemInDb(cdto);
                if (num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "It seems that Cart Item does not exist\n OR \n No record have been changed";
                    return new outputFormGUI(msg);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Form deleteCartItem(cartDTO cdto)
        {
            try
            {
                int num = cdl.deletecartItemFromDb(cdto);
                if (num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "It seems that Cart Item does not exist\n OR \n No record have been deleted";
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
