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
    class ordersDL
    {
        DbConnection dbcon;
        public ordersDL()
        {
            dbcon = new DbConnection();
        }
        public void createOrderInDb(List<ordersDTO> odto_list)
        {
            try
            {
                int rowAffected = 0;
                dbcon.Con.Open();
                foreach (ordersDTO odto in odto_list)
                {
                    string queryString = "INSERT INTO Orders (waiter, customer, food_item, price, status) VALUES((SELECT user_id FROM Users WHERE username = @Waiter), (SELECT customer_id FROM Customer WHERE name = @Customer), (SELECT food_id FROM FoodItem WHERE name = @Food), @Price, @Status);";
                    SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                    com.Parameters.AddWithValue("@Waiter", odto.Waiter);
                    com.Parameters.AddWithValue("@Customer", odto.Customer);
                    com.Parameters.AddWithValue("@Food", odto.Fooditem);
                    com.Parameters.AddWithValue("@Price", odto.Price);
                    com.Parameters.AddWithValue("@Status", odto.Status);
                    rowAffected = com.ExecuteNonQuery();
                }
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
        public DataTable getAllOrdersFromDb()
        {
            DataTable dt = new DataTable();
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT Orders.order_id, Users.username as waiter, Customer.name as customer, FoodItem.name as food, Orders.price, Orders.status FROM Orders INNER JOIN Users ON Orders.waiter = Users.user_id INNER JOIN Customer ON Orders.customer = Customer.customer_id INNER JOIN FoodItem ON Orders.food_item = FoodItem.food_id  WHERE Orders.customer = @Customer AND Orders.status = @Status OR Orders.status = @Status2;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Customer", Session.CustomerId);
                com.Parameters.AddWithValue("@Status", "InProgress");
                com.Parameters.AddWithValue("@Status2", "Prepared");
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
        public int updateOrderStatusInDb(ordersDTO odto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "UPDATE Orders SET status = @Status WHERE customer=@Customer AND status != @Status1 AND status != @status2;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Status", odto.Status);
                com.Parameters.AddWithValue("@Customer", Session.CustomerId);
                com.Parameters.AddWithValue("@Status1", odto.Status);
                com.Parameters.AddWithValue("@Status2", "Served");
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
