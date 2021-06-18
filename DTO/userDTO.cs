using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Ordering_System.DTO
{
    public class userDTO
    {
        public int Id{ get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public string Salary { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
    }
}
