using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BHFanShop.Models
{
    public class Ticket
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Match { get; set; }
        public string Date { get; set; }
        public string Seat { get; set; }
        public string Side { get; set; }
        public string QrUrl { get; set; }
    }
}
