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
        string fullName = FullNameEntry.Text ?? string.Empty;
        string email = EmailEntry.Text ?? string.Empty;
        string phone = PhoneEntry.Text ?? string.Empty;
        string address = AddressEntry.Text ?? string.Empty;

        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlertAsync("Greška", "Unjeli ste neispravno lozinku ili korisnicko ime.", "OK");
            return;
        }
        bool pass = LoginService.Register(username, password, fullName, email, phone, address);
        if (pass)
        {
            await DisplayAlertAsync("Uspješno", $"Registracija završena! Dobrodošao {fullName}", "OK");
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlertAsync("Greška", "Korisnik već postoji!", "OK");
        }
    }
    private async void OnGoToLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


}