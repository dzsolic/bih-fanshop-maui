using BHFanShop.Services;

namespace BHFanShop.Views;

public partial class TeamAPage : ContentPage
{
	public TeamAPage()
	{
		InitializeComponent();
        PlayersList.ItemsSource = PlayerData.ATeam;	
    }
}