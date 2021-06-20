using Restaurant_Ordering_System.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ordering_System.BL
{
    class SessionBL
    {
        public static void setCustomerInSession(string c_id)
        {
            Session.CustomerId = c_id;
        }
        public static void setUserInSession(string u_id)
        {
            Session.UserId = u_id;
        }
        public static string getCustomerFromSession()
        {
            return Session.CustomerId;
        }
        public static string getUserFromSession()
        {
            return Session.UserId;
        }
    }
}
