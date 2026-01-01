using BHFanShop.Models;
using BHFanShop.Services;
using System.Collections.ObjectModel;

namespace BHFanShop.Views;

public partial class ShopPage : ContentPage
{
    private Match? nextMatch;
    public ShopPage()
    {
        InitializeComponent();

        JerseysCollection.ItemsSource = new ObservableCollection<Jersey>
        {
            new Jersey { Name = "Domaći dres",  Price = "109 KM", Image = "dres_domaci.jpeg" },
            new Jersey { Name = "Gostujući dres", Price = "109 KM", Image = "dres_gostujuci.jpeg" },
            new Jersey { Name = "Retro dres",     Price = "129 KM", Image = "retro.png" },
            new Jersey { Name = "Baby Set",        Price = "79 KM",  Image = "babyset.jpeg" }
        };
        nextMatch = MatchData.GetNextUpcoming();
        NextMatchLabel.Text = nextMatch != null
            ? $"Utakmica: {nextMatch.Home} - {nextMatch.Away} ({nextMatch.Date:dd.MM.yyyy})"
            : "Utakmica: Nema dostupnih utakmica";
    }

    private async void OnBuyClicked(object sender, EventArgs e)
    {
        string phone = await DisplayPromptAsync(
            "Kupovina",
            "Unesite broj telefona:");

        if (string.IsNullOrWhiteSpace(phone))
            return;

        string address = await DisplayPromptAsync(
            "Kupovina",
            "Unesite adresu:");

        if (string.IsNullOrWhiteSpace(address))
            return;

        await DisplayAlertAsync(
            "Uspješno",
            "Kupovina je uspješno izvršena!",
            "OK");
        LoginService.AddJerseyCurrentUser();
    }
    private async void OnTicketClicked(object Sender, EventArgs e)
    {
        if (nextMatch == null)
        {
            await DisplayAlertAsync("Greška", "Nema dostupne utakmice.", "OK");
            return;
        }
        var usr = LoginService.CurrentUser.Username;
        TicketUserLabel.Text = usr.ToUpper();
        TicketMatchLabel.Text = $"{nextMatch.Home} - {nextMatch.Away}";
        TicketDateLabel.Text = $"{nextMatch.Date:dd.MM.yyyy}";

        var payload = $"IME={usr};UTAKMICA={nextMatch.Home}-{nextMatch.Away};DATUM={nextMatch.Date:dd.MM.yyyy}";
        var url = $"https://api.qrserver.com/v1/create-qr-code/?size=150x150&data={Uri.EscapeDataString(payload)}";
        QRCodeImage.Source = ImageSource.FromUri(new Uri(url));

        TicketView.IsVisible = true;

        LoginService.AddTicketCurrentUser();
    }
}
