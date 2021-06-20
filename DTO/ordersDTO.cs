using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ordering_System.DTO
{
    class ordersDTO
    {
        public string OrderId { get; set; }
        public string Waiter { get; set; }
        public string Customer { get; set; }
        public string Fooditem { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
    }
}
