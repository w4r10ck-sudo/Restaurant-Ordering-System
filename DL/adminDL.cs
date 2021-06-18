using Restaurant_Ordering_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Ordering_System.DL
{
    class adminDL
    {
        DbConnection dbcon;
        public adminDL()
        {
            dbcon = new DbConnection();
        }
        public void createruserinDB(userDTO userdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "INSERT INTO Users (username, email, password, contact, salary, role, status) VALUES(@Username, @Email, @Password, @Contact, @Salary, @Role, @Status);";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Username", userdto.Username);
                com.Parameters.AddWithValue("@Email", userdto.Email);
                com.Parameters.AddWithValue("@Password", userdto.Password);
                com.Parameters.AddWithValue("@Contact", userdto.Contact);
                com.Parameters.AddWithValue("@Salary", userdto.Salary);
                com.Parameters.AddWithValue("@Role", userdto.Role);
                com.Parameters.AddWithValue("@Status", userdto.Status);
                int rowAffected = com.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
        public DataTable getAllUsersFromDb()
        {
            DataTable dt = new DataTable();
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT * FROM Users WHERE role != @Role; ";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Role", "admin");
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
        public userDTO getAdminDataFromDb()
        {
            userDTO udto = new userDTO();
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT * FROM Users WHERE role = @Role; ";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Role", "admin");
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    udto.Username = reader["username"].ToString();
                    udto.Email = reader["email"].ToString();
                    udto.Contact = reader["contact"].ToString();
                    udto.Salary = reader["salary"].ToString();
                    udto.Role = reader["role"].ToString();
                    udto.Status = reader["status"].ToString();
                    return udto;
                }
                else
                {
                    return null;
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
        public int updateUserInDb(userDTO userdto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "UPDATE Users SET email = @Email, password = @Password, contact = @Contact, salary = @Salary, role = @Role WHERE username = @Username;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Email", userdto.Email);
                com.Parameters.AddWithValue("@Password", userdto.Password);
                com.Parameters.AddWithValue("@Contact", userdto.Contact);
                com.Parameters.AddWithValue("@Salary", userdto.Salary);
                com.Parameters.AddWithValue("@Role", userdto.Role);
                com.Parameters.AddWithValue("@Username", userdto.Username);
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
            return 0;
        }
        public userDTO findUserFromDb(userDTO udto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT * FROM Users WHERE username = @Username; ";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Username", udto.Username);
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    udto.Username = reader["username"].ToString();
                    udto.Email = reader["email"].ToString();
                    udto.Password = reader["password"].ToString();
                    udto.Contact = reader["contact"].ToString();
                    udto.Salary = reader["salary"].ToString();
                    udto.Role = reader["role"].ToString();
                    udto.Status = reader["status"].ToString();
                    return udto;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dbcon.Con.Close();
            }
        }
        public void changeUserStatusInDb(userDTO udto)
        {
            try
            {
                dbcon.Con.Open();
                string queryString = "UPDATE Users SET status = @Status WHERE username = @Username;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                udto.Status = (udto.Status == "active") ? "blocked" : "active";
                com.Parameters.AddWithValue("@Status", udto.Status);
                com.Parameters.AddWithValue("@Username", udto.Username);
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
    }
}
