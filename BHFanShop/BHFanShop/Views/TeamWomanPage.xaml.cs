
using BHFanShop.Services;
namespace BHFanShop.Views;

public partial class TeamWomanPage : ContentPage
{
	public TeamWomanPage()
	{
		InitializeComponent();
        PlayersList.ItemsSource = PlayerData.WomenTeam;
    }
}