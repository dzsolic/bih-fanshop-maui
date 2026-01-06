using BHFanShop.Services;
namespace BHFanShop.Views;

public partial class TeamU19Page : ContentPage
{
    public TeamU19Page()
    {
        InitializeComponent();
        PlayersList.ItemsSource = PlayerData.U19Team;
    }
}