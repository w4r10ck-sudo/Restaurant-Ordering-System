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
    class foodItemBL
    {
        foodItemDL fooditemdl = new foodItemDL();
        categoryDL catdl = new categoryDL();
        public Form createfoodItem(foodItemDTO foodItemdto)
        {
            foodItemdto.Name = foodItemdto.Name.ToLower();
            try
            {
                fooditemdl.createFoodItemInDb(foodItemdto);
                return new outputFormGUI("Success");
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public DataTable getAllFoodItems()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = fooditemdl.getAllFoodItemsFromDb();
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
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
        }
        public foodItemDTO GetfoodItem(foodItemDTO foodItemdto)
        {
            try
            {
                foodItemDTO fd = new foodItemDTO();
                fd = fooditemdl.getFoodItemFromDb(foodItemdto);
                if (!object.ReferenceEquals(null, fd))
                {
                    return fd;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return null;
        }
        public Form updatefoodItem(foodItemDTO foodItemdto)
        {
            try
            {
                int num = fooditemdl.updateFoodItemInDb(foodItemdto);
                if (num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "It seems that Food Item does not exist\n OR \n No record have been changed";
                    return new outputFormGUI(msg);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Form deletefoodItem(foodItemDTO foodItemdto)
        {
            try
            {
                int num = fooditemdl.deleteFoodItemFromDb(foodItemdto);
                if (num >= 1)
                {
                    return new outputFormGUI("Success");
                }
                else
                {
                    string msg = "It seems that Food Item does not exist\n OR \n No record have been deleted";
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
