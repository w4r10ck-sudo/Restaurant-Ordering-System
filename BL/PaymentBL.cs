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
    class PaymentBL
    {
        PaymentDL paydl = new PaymentDL();
        public Form createPayment(paymentDTO paydto)
        {
            try
            {
                paydl.createpaymentInDb(paydto);
                return new outputFormGUI("Success");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable getAllPayments()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = paydl.getAllPaymentDetailsFromDb();
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Form updatePayment(paymentDTO paydto)
        {
            try
            {
                int num = paydl.changePaymentStatusInDb(paydto);
                if (num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "It seems that Payment does not exist\n OR \n No record have been changed";
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
