using System;
using System.Collections.Generic;
using System.Text;
using BHFanShop.Models;
namespace BHFanShop.Services
{
    public static class MatchData
    {
        private static readonly List<Match> _matches = new()
        {
            new Match { Date = new DateTime(2025,3,21), Home="Rumunija", Away="Bosna i Hercegovina", HomeGoals=0, AwayGoals=1 },
            new Match { Date = new DateTime(2025,3,24), Home="Bosna i Hercegovina", Away="Kipar", HomeGoals=2, AwayGoals=1 },
            new Match { Date = new DateTime(2025,6,7), Home="Bosna i Hercegovina", Away="San Marino", HomeGoals=1, AwayGoals=0 },
            new Match { Date = new DateTime(2025,9,6), Home="San Marino", Away="Bosna i Hercegovina", HomeGoals=0, AwayGoals=6 },
            new Match { Date = new DateTime(2025,9,9), Home="Bosna i Hercegovina", Away="Austria", HomeGoals=1, AwayGoals=2 },
            new Match { Date = new DateTime(2025,10,9), Home="Kipar", Away="Bosna i Hercegovina", HomeGoals=2, AwayGoals=2 },
            new Match { Date = new DateTime(2025,11,15), Home="Bosna i Hercegovina", Away="Rumunija", HomeGoals=3, AwayGoals=1 },
            new Match { Date = new DateTime(2025,11,18), Home="Austria", Away="Bosna i Hercegovina", HomeGoals=1, AwayGoals=1 },
            new Match { Date = new DateTime(2026,3,26), Home="Vels", Away="Bosna i Hercegovina" }
        };

        public static IReadOnlyList<Match> GetAll() => _matches;

        public static IReadOnlyList<Match> GetPlayed() => _matches.Where(m => m.IsPlayed).ToList();

        public static IReadOnlyList<Match> GetUpcoming() => _matches.Where(m => !m.IsPlayed).OrderBy(m => m.Date).ToList();

        public static Match? GetNextUpcoming() => GetUpcoming().FirstOrDefault();
    }
}
