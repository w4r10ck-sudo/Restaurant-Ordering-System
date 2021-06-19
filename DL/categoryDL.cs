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
    class categoryDL
    {
        DbConnection dbcon;
        public categoryDL()
        {
            dbcon = new DbConnection();
        }
        public void createCategoryInDb(categoryDTO catdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "INSERT INTO Category (name, description) VALUES(@Name, @Description);";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Name", catdto.Name);
                com.Parameters.AddWithValue("@Description", catdto.Description);
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
        public DataTable getAllCatFromDb()
        {
            DataTable dt = new DataTable();
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT * FROM Category;";
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
        public categoryDTO getCategoryFromDb(categoryDTO catdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT description FROM Category WHERE name=@Name;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Name", catdto.Name);
                SqlDataReader reader = com.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    catdto.Description = reader["description"].ToString();
                }
                return catdto;
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
        public int updateCategoryInDb(categoryDTO catdto1, categoryDTO catdto2)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "UPDATE Category SET name = @Name, description = @Description WHERE name = @RealName;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Name", catdto1.Name);
                com.Parameters.AddWithValue("@Description", catdto1.Description);
                com.Parameters.AddWithValue("@RealName", catdto2.Name);
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
        public int deleteCatFromDb(categoryDTO catdto)
        {
            try
            {
                dbcon.Con.Open();
                string selectquery = "SELECT category FROM Fooditem WHERE category=(SELECT category_id FROM Category WHERE name=@Name);";
                SqlCommand com = new SqlCommand(selectquery, dbcon.Con);
                com.Parameters.AddWithValue("@Name", catdto.Name);
                SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows)
                {
                    string queryString = "Delete FROM Category WHERE name= @CatName;";
                    SqlCommand com1 = new SqlCommand(queryString, dbcon.Con);
                    com1.Parameters.AddWithValue("@CatName", catdto.Name);
                    int rowAffected = com1.ExecuteNonQuery();
                    return rowAffected;
                }
                return 0;
                
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
