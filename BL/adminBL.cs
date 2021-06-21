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
    class adminBL
    {
        adminDL admindl = new adminDL();
        EncryptorDecryptorBL edbl = new EncryptorDecryptorBL();
        public Form createUser(userDTO userdto)
        {
            userdto.Role = userdto.Role.ToLower();
            userdto.Password = edbl.EncryptData(userdto.Password);
            try
            {
                admindl.createruserinDB(userdto);
                return new outputFormGUI("Success");
            }
            catch (SqlException ex)
            {
                throw ex;

            }
        }
        public DataTable getAllUsers()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = admindl.getAllUsersFromDb();
                return dt;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public userDTO getAdminData()
        {
            userDTO udto;
            try
            {
                udto = admindl.getAdminDataFromDb();
                return udto;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Form updateUser(userDTO udto)
        {
            try
            {
                int num = admindl.updateUserInDb(udto);
                if(num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "It seems that user does not exist\n OR \n No record have been changed";
                    return new outputFormGUI(msg);
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public userDTO finduser(userDTO udto)
        {
            try
            {
                udto = admindl.findUserFromDb(udto);
                return udto;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void block_unblock_user(userDTO udto)
        {
            try
            {
                admindl.changeUserStatusInDb(udto);
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
    }
}
