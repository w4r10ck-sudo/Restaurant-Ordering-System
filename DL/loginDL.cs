using Restaurant_Ordering_System.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ordering_System.DL
{
    class loginDL
    {
        DbConnection dbcon;
        public loginDL()
        {
            dbcon = new DbConnection();
        }
        public userDTO VerifyUserFromDB(loginDTO logindto)
        {
            userDTO retDTO = new userDTO();
            try
            {
                dbcon.Con.Open();
                string queryString = "SELECT * FROM Users WHERE username=@Username AND Password=@Password;";
                SqlCommand com = new SqlCommand(queryString, dbcon.Con);
                com.Parameters.AddWithValue("@Username", logindto.Username);
                com.Parameters.AddWithValue("@Password", logindto.Password);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    retDTO.Id = Convert.ToInt16(reader["user_id"].ToString());
                    retDTO.Username = reader["username"].ToString();
                    retDTO.Email = reader["email"].ToString();
                    retDTO.Password = reader["password"].ToString();
                    retDTO.Contact = reader["contact"].ToString();
                    retDTO.Salary = reader["salary"].ToString();
                    retDTO.Role = reader["Role"].ToString();
                    retDTO.Status = reader["Status"].ToString();
                    return retDTO;

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
            return null;
        }
    }
}
