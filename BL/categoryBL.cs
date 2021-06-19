using Restaurant_Ordering_System.DL;
using Restaurant_Ordering_System.DTO;
using Restaurant_Ordering_System.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Restaurant_Ordering_System.BL
{
    class categoryBL
    {
        categoryDL catdl = new categoryDL();
        public Form createCategory(categoryDTO catdto)
        {
            catdto.Name = catdto.Name.ToLower();
            try
            {
                catdl.createCategoryInDb(catdto);
                return new outputFormGUI("Success");
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return new outputFormGUI("Something went wrong..!");
        }
        public DataTable getAllCategories()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = catdl.getAllCatFromDb();
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return null;
        }
        public categoryDTO GetCategory(categoryDTO catdto)
        {
            try
            {
                catdto = catdl.getCategoryFromDb(catdto);
                if (!string.IsNullOrEmpty(catdto.Description))
                    return catdto;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            return null;
        }
        public Form updateCategory(categoryDTO catdto1, categoryDTO catdto2)
        {
            try
            {
                int num = catdl.updateCategoryInDb(catdto1, catdto2);
                if (num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "It seems that category does not exist\n OR \n No record have been changed";
                    return new outputFormGUI(msg);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Form deleteCategory(categoryDTO catdto)
        {
            try
            {
                int num = catdl.deleteCatFromDb(catdto);
                if (num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "Products with this Category exists.\nDelete them first!";
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
