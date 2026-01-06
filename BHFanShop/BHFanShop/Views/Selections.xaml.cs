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
    private async void OnWomanClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TeamWomanPage());
    }
    private async void OnU17Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TeamU17Page());
    }
    private async void OnU19Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TeamU19Page());
    }



}