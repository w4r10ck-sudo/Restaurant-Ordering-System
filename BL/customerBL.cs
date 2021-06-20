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
    class customerBL
    {
        customerDL cdl = new customerDL();
        public Form createCustomer(customerDTO cdto)
        {
            cdto.Name = cdto.Name.ToLower();
            try
            {
                cdl.createCustomerInDb(cdto);
                return new outputFormGUI("Success");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public customerDTO GetCustomer(customerDTO cdto)
        {
            try
            {
                cdto = cdl.getCustomerFromDb(cdto);
                if (!object.ReferenceEquals(null, cdto))
                    return cdto;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return null;
        }
        public DataTable getAllCustomers()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = cdl.getAllCustomersFromDb();
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Form updateCustomer(customerDTO cdto)
        {
            try
            {
                int num = cdl.updateCustomerInDb(cdto);
                if (num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "It seems that customer does not exist\n OR \n No record have been changed";
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
