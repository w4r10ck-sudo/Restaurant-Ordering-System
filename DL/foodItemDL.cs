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
    class foodItemDL
    {
        DbConnection dbcon;
        public foodItemDL()
        {
            dbcon = new DbConnection();
        }
        public void createFoodItemInDb(foodItemDTO fooddto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "INSERT INTO FoodItem (name, price, description, category) VALUES(@Name, @Price, @Description, (SELECT category_id FROM Category WHERE name=@Category));";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Name", fooddto.Name);
                com.Parameters.AddWithValue("@Price", fooddto.Price);
                com.Parameters.AddWithValue("@Description", fooddto.Description);
                com.Parameters.AddWithValue("@Category", fooddto.Category);
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
        public DataTable getAllFoodItemsFromDb()
        {
            DataTable dt = new DataTable();
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT FoodItem.name, FoodItem.price, FoodItem.description, Category.name as category FROM FoodItem INNER JOIN Category ON FoodItem.category = Category.category_id;";
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
        public foodItemDTO getFoodItemFromDb(foodItemDTO fooddto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT FoodItem.name, FoodItem.price, FoodItem.description, Category.name as category FROM FoodItem INNER JOIN Category ON FoodItem.category = Category.category_id WHERE FoodItem.name = @Name; ";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Name", fooddto.Name);
                SqlDataReader reader = com.ExecuteReader();
                fooddto = new foodItemDTO();
                if (reader.HasRows)
                {
                    reader.Read();
                    fooddto.Name = reader["name"].ToString();
                    fooddto.Price = reader["price"].ToString();
                    fooddto.Description = reader["description"].ToString();
                    fooddto.Category = reader["category"].ToString();
                }
                return fooddto;
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
        public int updateFoodItemInDb(foodItemDTO fooddto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "UPDATE FoodItem SET name = @Name, price = @Price, description = @Description, category = (SELECT category_id FROM Category WHERE name = @Category) WHERE name = @Name;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Name", fooddto.Name);
                com.Parameters.AddWithValue("@Price", fooddto.Price);
                com.Parameters.AddWithValue("@Description", fooddto.Description);
                com.Parameters.AddWithValue("@Category", fooddto.Category);
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
        public int deleteFoodItemFromDb(foodItemDTO fooddto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "Delete FROM FoodItem WHERE name = @Name;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Name", fooddto.Name);
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
