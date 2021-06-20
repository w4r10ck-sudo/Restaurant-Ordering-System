using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ordering_System.DTO
{
    class cartDTO
    {
        public string cartId { get; set; }
        public string Fooditem { get; set; }
        public string Waiter { get; set; }
        public string Customer { get; set; }
        public string Qty { get; set; }
    }
}
