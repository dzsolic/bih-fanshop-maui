namespace BHFanShop.Views;

using BHFanShop.Services;
public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
        BindingContext = this;
	}
    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text ?? string.Empty;
        string password = PasswordEntry.Text ?? string.Empty;

        if(string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlertAsync("Greška", "Unjeli ste neispravno lozinku ili korisnicko ime.", "OK");
            return;
        }
        bool pass = LoginService.Register(username, password);
        if (pass)
        {
            await DisplayAlertAsync("Uspješno", "Sada se prijavi!", "OK");
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlertAsync("Greška", "Korisnik već postoji!", "OK");
        }
    }
    
}