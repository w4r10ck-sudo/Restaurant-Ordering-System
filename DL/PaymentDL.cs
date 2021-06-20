using Restaurant_Ordering_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ordering_System.DL
{
    class PaymentDL
    {
        DbConnection dbcon;
        public PaymentDL()
        {
            dbcon = new DbConnection();
        }
        public void createpaymentInDb(paymentDTO paydto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "INSERT INTO Payment (amount, customer, status) VALUES(@Amount, @Customer, @Status);";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Amount", paydto.Amount);
                com.Parameters.AddWithValue("@Customer", paydto.Customer);
                com.Parameters.AddWithValue("@Status", paydto.Status);
                int rowAffected = com.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
        public DataTable getAllPaymentDetailsFromDb()
        {
            DataTable dt = new DataTable();
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT * FROM Payment;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                SqlDataReader reader = com.ExecuteReader();
                dt.Load(reader);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
        public int changePaymentStatusInDb(paymentDTO paydto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "UPDATE Payment SET status = @Status WHERE payment_id=@Payment;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Status", "Paid");
                com.Parameters.AddWithValue("@Payment", paydto.PaymentId);
                int rowAffected = com.ExecuteNonQuery();
                return rowAffected;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
    }
}
