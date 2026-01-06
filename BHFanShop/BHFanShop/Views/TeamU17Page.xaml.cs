using BHFanShop.Services;
namespace BHFanShop.Views;

public partial class TeamU17Page : ContentPage
{
    public TeamU17Page()
    {
        InitializeComponent();
        PlayersList.ItemsSource = PlayerData.U17Team;
    }
}