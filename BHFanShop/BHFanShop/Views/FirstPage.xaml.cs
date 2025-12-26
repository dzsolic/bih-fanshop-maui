using BHFanShop.Services;

namespace BHFanShop.Views;

public partial class FirstPage : ContentPage
{
    public FirstPage()
    {
        InitializeComponent();

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (LoginService.CurrentUser != null)
        {
            UserNameLabel.Text = LoginService.CurrentUser.Username.ToUpper();
        }
    }
}