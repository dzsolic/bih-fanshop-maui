using System;
using System.Collections.Generic;
using System.Text;

namespace BHFanShop.Models
{
    public class Goal
    {
        public string Player { get; set; }
        public int Minute { get; set; }

        public string DisplayText => $"{Minute}’ {Player}";
    }
}