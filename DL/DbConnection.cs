using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ordering_System.DL
{
    class DbConnection
    {
        private SqlConnection con;
        public DbConnection()
        {

            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            //string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + appPath[0] + @"SCRS_W3.mdf;Integrated Security=True";
            string conString =  @"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename =" + appPath[0] + @"ROS_DB.mdf; Integrated Security = True";
            con = new SqlConnection(conString);
        }

        public SqlConnection Con { get => con; }
    }
}
