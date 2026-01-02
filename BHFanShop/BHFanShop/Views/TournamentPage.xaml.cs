using BHFanShop.Models;
using BHFanShop.Services;
using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace BHFanShop.Views;

public partial class TournamentPage : ContentPage
{
    public TournamentPage()
    {
        InitializeComponent();
        var table = new ObservableCollection<Table>
        {
            new Table { Position=1, Team="Austria", GoalDifference=18, Points=19 },
            new Table { Position=2, Team="Bosna i Hercegovina", GoalDifference=10, Points=17 },
            new Table { Position=3, Team="Rumunija", GoalDifference=9, Points=13 },
            new Table { Position=4, Team="Kipar", GoalDifference=0, Points=8 },
            new Table { Position=5, Team="San Marino", GoalDifference=-37, Points=0 }
        };
        QualificationTable.ItemsSource = table;

        var matches = new ObservableCollection<Match>
        {
            new Match{Date = new DateTime(2025,3,21),Home="Rumunija",Away="Bosna i Hercegovina",HomeGoals=0,AwayGoals=1,Goals = new List<Goal>{
                new Goal { Player="Gigoviæ", Minute=14}}},
            new Match { Date = new DateTime(2025,3,24), Home="Bosna i Hercegovina", Away="Kipar", HomeGoals=2, AwayGoals=1,Goals = new List<Goal>{
                new Goal { Player="Demiroviæ", Minute=22}, new Goal { Player="Pittas", Minute=47},new Goal { Player="Hajradinoviæ", Minute=56}}},
            new Match { Date = new DateTime(2025,6,7), Home="Bosna i Hercegovina", Away="San Marino", HomeGoals=1, AwayGoals=0,Goals = new List<Goal>{
                new Goal { Player="Džeko", Minute=66}} },
            new Match { Date = new DateTime(2025,9,6), Home="San Marino", Away="Bosna i Hercegovina", HomeGoals=0, AwayGoals=6,Goals = new List<Goal>{
                new Goal { Player="Tahiroviæ", Minute=21},new Goal { Player="Džeko", Minute=70},new Goal { Player="Džeko", Minute=72},
                new Goal { Player="Baždar", Minute=81},new Goal { Player="Alajbegoviæ", Minute=85},new Goal { Player="Mujakiæ", Minute=90}} },
            new Match { Date = new DateTime(2025,9,9), Home="Bosna i Hercegovina", Away="Austria", HomeGoals=1, AwayGoals=2,Goals = new List<Goal>{
                new Goal { Player="Sabitzer", Minute=49},new Goal { Player="Džeko", Minute=50},new Goal { Player="Laimer", Minute=65}} },
            new Match { Date = new DateTime(2025,10,9), Home="Kipar", Away="Bosna i Hercegovina", HomeGoals=2, AwayGoals=2,Goals = new List<Goal>{
                new Goal { Player="Katiæ", Minute=10},new Goal { Player="Michail(AUTOGOL)", Minute=36},new Goal { Player="Laifis", Minute=46},
                new Goal { Player="Pittas", Minute=96}} },
            new Match { Date = new DateTime(2025,11,15), Home="Bosna i Hercegovina", Away="Rumunija", HomeGoals=3, AwayGoals=1,Goals = new List<Goal>{
                new Goal { Player="Birligea", Minute=17},new Goal { Player="Džeko", Minute=49},new Goal { Player="Bajraktareviæ", Minute=80},
                new Goal { Player="Tabakoviæ", Minute=93}} },
            new Match { Date = new DateTime(2025,11,18), Home="Austria", Away="Bosna i Hercegovina", HomeGoals=1, AwayGoals=1,Goals = new List<Goal>{
                new Goal { Player="Tabakoviæ", Minute=12},new Goal { Player="Gregoritsch", Minute=77}} },
            new Match { Date = new DateTime(2026,3,26), Home="Vels", Away="Bosna i Hercegovina"}
        };

        PlayedMatches.ItemsSource = matches.Where(m => m.IsPlayed).ToList();
        UpcomingMatches.ItemsSource = matches.Where(m => !m.IsPlayed).ToList();
    }
    private async void PlayedMatches_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var collectionView = (CollectionView)sender;
        var selectedMatch = e.CurrentSelection.FirstOrDefault() as Match;

        if (selectedMatch == null)
            return;

        await Navigation.PushModalAsync(new MatchDetailsPage(selectedMatch));
        collectionView.SelectedItem = null;
    }

}
