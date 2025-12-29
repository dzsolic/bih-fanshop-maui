using BHFanShop.Services;

namespace BHFanShop.Views;

public partial class Selections : ContentPage
{

    public Selections()
    {
        InitializeComponent();
    }
    private async void OnAClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TeamAPage());
    }
    private async void OnU21Clicked(object sender,EventArgs e)
    {
        await Navigation.PushAsync(new TeamU21Page());
    }
    private async void OnZeneClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TeamWomanPage());
    }   


}