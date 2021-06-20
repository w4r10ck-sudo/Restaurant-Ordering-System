using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ordering_System.DTO
{
    class paymentDTO
    {
        public string PaymentId { get; set; }
        public string Amount { get; set; }
        public string Customer { get; set; }
        public string Status { get; set; }
    }
}
