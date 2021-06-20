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
    class customerDL
    {
        DbConnection dbcon;
        public customerDL()
        {
            dbcon = new DbConnection();
        }
        public void createCustomerInDb(customerDTO cdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "INSERT INTO Customer (name, contact) VALUES(@Name, @Contact);";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Name", cdto.Name);
                com.Parameters.AddWithValue("@Contact", cdto.Contact);
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
        public customerDTO getCustomerFromDb(customerDTO cdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT name FROM Customer WHERE contact=@Contact;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Contact", cdto.Contact);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    cdto.Name = reader["name"].ToString();
                    return cdto;
                }
                return null;
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
        public DataTable getAllCustomersFromDb()
        {
            DataTable dt = new DataTable();
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT * FROM Customer;";
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
        public int updateCustomerInDb(customerDTO cdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "UPDATE Customer SET name = @Name WHERE contact = @Contact;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Name", cdto.Name);
                com.Parameters.AddWithValue("@Contact", cdto.Contact);
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
