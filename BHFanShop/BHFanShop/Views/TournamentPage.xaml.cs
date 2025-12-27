using BHFanShop.Models;
using Microsoft.Maui.Controls;

namespace BHFanShop.Views;

public partial class TournamentPage : ContentPage
{
    public TournamentPage()
    {
        InitializeComponent();
        var table = new List<Table>
        {
            new Table { Position=1, Team="Austria", GoalDifference=18, Points=19 },
            new Table { Position=2, Team="Bosna i Hercegovina", GoalDifference=10, Points=17 },
            new Table { Position=3, Team="Rumunija", GoalDifference=9, Points=13 },
            new Table { Position=4, Team="Kipar", GoalDifference=0, Points=8 },
            new Table { Position=5, Team="San Marino", GoalDifference=-37, Points=0 }
        };
        QualificationTable.ItemsSource = table;

        var matches = new List<Match>
        {
            new Match { Date = new DateTime(2025,3,21), Home="Rumunija", Away="Bosna i Hercegovina", HomeGoals=0, AwayGoals=1 },
            new Match { Date = new DateTime(2025,3,24), Home="Bosna i Hercegovina", Away="Kipar", HomeGoals=2, AwayGoals=1 },
            new Match { Date = new DateTime(2025,6,7), Home="Bosna i Hercegovina", Away="San Marino", HomeGoals=1, AwayGoals=0 },
            new Match { Date = new DateTime(2025,9,6), Home="San Marino", Away="Bosna i Hercegovina", HomeGoals=0, AwayGoals=6 },
            new Match { Date = new DateTime(2025,9,9), Home="Bosna i Hercegovina", Away="Austria", HomeGoals=1, AwayGoals=2 },
            new Match { Date = new DateTime(2025,10,9), Home="Kipar", Away="Bosna i Hercegovina", HomeGoals=2, AwayGoals=2 },
            new Match { Date = new DateTime(2025,11,15), Home="Bosna i Hercegovina", Away="Rumunija", HomeGoals=3, AwayGoals=1 },
            new Match { Date = new DateTime(2025,11,18), Home="Austria", Away="Bosna i Hercegovina", HomeGoals=1, AwayGoals=1 },
            new Match { Date = new DateTime(2026,3,26), Home="Vels", Away="Bosna i Hercegovina"}
        };

        PlayedMatches.ItemsSource = matches.Where(m => m.IsPlayed).ToList();
        UpcomingMatches.ItemsSource = matches.Where(m => !m.IsPlayed).ToList();
    }
}
