using System;
using System.Collections.Generic;
using System.Text;

namespace BHFanShop.Models
{
    public class Match
    {
        public DateTime Date { get; set; }
        public string Home { get; set; }
        public string Away { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
        public List<Goal> Goals { get; set; } = new();


        public string Result => $"{HomeGoals} : {AwayGoals}";
        public bool IsPlayed => Date <= DateTime.Now;
    }
}

