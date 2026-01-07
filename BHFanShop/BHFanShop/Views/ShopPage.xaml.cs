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
        var user = LoginService.CurrentUser;

        var button = sender as Button;
        var selectedJersey = button?.BindingContext as Jersey;
        if (selectedJersey == null) return;
        bool confirm = await DisplayAlertAsync("Potvrda narudžbe",
        $"Artikal: {selectedJersey.Name}\n" +
        $"Cijena: {selectedJersey.Price}\n\n" +
        $"Dostava na adresu: {user.Address}\n" +
        $"Kontakt telefon: {user.Phone}\n\n" +
        "Želite li potvrditi kupovinu?", "DA", "NE");
        if (confirm)
        {
            LoginService.AddJerseyCurrentUser();

            await DisplayAlertAsync("Uspješno",
                $"Hvala {user.FullName}, vaša narudžba je primljena!", "OK");
        }
    }
    private async void OnTicketClicked(object Sender, EventArgs e)
    {
        if (nextMatch == null)
        {
            await DisplayAlertAsync("Greška", "Nema dostupne utakmice.", "OK");
            return;
        }
        var usr = LoginService.CurrentUser;
        bool confirm = await DisplayAlertAsync("Potvrda Rezervacije",
        $"Utakmica: {nextMatch.Home} - {nextMatch.Away}\n" +
        $"Datum: {nextMatch.Date:dd.MM.yyyy}\n" +
        $"Lokacija: Stadion Bilino Polje\n\n" +
        $"Karta će biti izdata na ime: {usr.FullName}\n" +
        "Želite li potvrditi kupovinu ulaznice?", "POTVRDI", "ODUSTANI");

        if (confirm)
        {
            TicketUserLabel.Text = usr.FullName.ToUpper();
            TicketMatchLabel.Text = $"{nextMatch.Home} - {nextMatch.Away}";
            TicketDateLabel.Text = $"{nextMatch.Date:dd.MM.yyyy}";

            var payload = $"IME={usr.FullName};UTAKMICA={nextMatch.Home}-{nextMatch.Away};DATUM={nextMatch.Date:dd.MM.yyyy}";
            var url = $"https://api.qrserver.com/v1/create-qr-code/?size=150x150&data={Uri.EscapeDataString(payload)}";
            QRCodeImage.Source = ImageSource.FromUri(new Uri(url));

            TicketView.IsVisible = true;

            LoginService.AddTicketCurrentUser();
            await DisplayAlertAsync("Uspješno", "Vaša karta je generisana! Možete je pronaći ispod.", "U redu");
        }
    }
}
