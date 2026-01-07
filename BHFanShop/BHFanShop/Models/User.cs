using System;
using System.Collections.Generic;
using System.Text;

namespace BHFanShop.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int TicketCounter { get; set; }
        public int JerseyCounter { get; set; }
        public string Status { get; set; } = "Navijač";
    }
}
