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
    class cartDL
    {
        DbConnection dbcon;
        public cartDL()
        {
            dbcon = new DbConnection();
        }
        public void createcartItemInDb(cartDTO cartdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "INSERT INTO Cart (food_id, waiter, customer, qty) VALUES(@Food, @Waiter, @Customer, @Qty);";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Food", cartdto.Fooditem);
                com.Parameters.AddWithValue("@Waiter", cartdto.Waiter);
                com.Parameters.AddWithValue("@Customer", cartdto.Customer);
                com.Parameters.AddWithValue("@Qty", cartdto.Qty);
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
        public DataTable getAllcartItemsFromDb()
        {
            DataTable dt = new DataTable();
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT Cart.cart_id, FoodItem.name as food, Users.username as waiter, Customer.name as customer FROM Cart INNER JOIN FoodItem ON Cart.food_id = FoodItem.food_id INNER JOIN Users ON Cart.waiter = Users.user_id INNER JOIN Customer ON Cart.customer = Customer.customer_id WHERE Cart.customer = @Customer;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Customer", Session.CustomerId);
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
        public int updatecartItemInDb(cartDTO cartdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "UPDATE FoodItem SET qty = @QTY WHERE cart_id = @Cartid;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@QTY", cartdto.Qty);
                com.Parameters.AddWithValue("@Cartid", cartdto.cartId);
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
        public int deletecartItemFromDb(cartDTO cartdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "Delete FROM Cart WHERE cart_id = @Cartid;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Cartid", cartdto.cartId);
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
