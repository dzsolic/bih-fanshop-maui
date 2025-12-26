using BHFanShop.Services;

namespace BHFanShop.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text;
        string password = PasswordEntry.Text;

        bool pass = LoginService.Login(username, password);

        if (pass)
        {
            Application.Current.Windows[0].Page = new AppShell();
        }
        else
        {
            await DisplayAlertAsync("Greška", "Netačno korisničko ime ili lozinka!", "OK");
        }

    }

    private async void OnGoToRegisterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}