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
                TicketLabel.Text = LoginService.CurrentUser.TicketCounter.ToString();
                JerseyLabel.Text = LoginService.CurrentUser.JerseyCounter.ToString();
                StatusLabel.Text = LoginService.CurrentUser.Status.ToUpper();
            }
        else
            {
                UserNameLabel.Text = "GOST";
                TicketLabel.Text = "0";
                JerseyLabel.Text = "0";
                StatusLabel.Text = "N/A";
            }
    }

}