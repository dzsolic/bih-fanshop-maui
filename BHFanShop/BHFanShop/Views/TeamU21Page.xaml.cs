using BHFanShop.Services;
namespace BHFanShop.Views;

public partial class TeamU21Page : ContentPage
{
	public TeamU21Page()
	{
		InitializeComponent();
        PlayersList.ItemsSource = PlayerData.U21Team;
    }
}