using BHFanShop.Models;
using BHFanShop.Services;
using System.Collections.ObjectModel;

namespace BHFanShop.Views;

public partial class ShopPage : ContentPage
{
    public ObservableCollection<Ticket> PurchasedTickets { get; set; } = new();
    private DBService _db = new DBService();
    private Match nextMatch;
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
        NextMatchLabel.Text = $"Utakmica: {nextMatch.Home} - {nextMatch.Away} ({nextMatch.Date:dd.MM.yyyy})";
        LoadUserTickets();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadUserTickets();
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
    private async Task LoadUserTickets()
    {
        var user = LoginService.CurrentUser;
        if (user != null)
        {
            var ticketsFromDb = await _db.GetTicketsForUserAsync(user.Username);
            PurchasedTickets.Clear();
            foreach (var t in ticketsFromDb)
            {
                PurchasedTickets.Add(t);
            }
            TicketsListView.ItemsSource = PurchasedTickets;
        }
    }
    private async void OnTicketClicked(object Sender, EventArgs e)
    {
        var user = LoginService.CurrentUser;

       
        string ticketName = await DisplayPromptAsync("Podaci", "Ime na karti:", initialValue: user.FullName);
        if (string.IsNullOrWhiteSpace(ticketName)) return;


        string side = await DisplayPromptAsync("Podaci", "Strana (Sjever, Jug, Istok, Zapad):");
        if (string.IsNullOrWhiteSpace(side)) return;

        string seat = await DisplayPromptAsync("Podaci", "Broj sjedišta (npr. B-12):");
        if (string.IsNullOrWhiteSpace(seat)) return;


        bool confirm = await DisplayAlertAsync("Potvrda", $"Karta za {side}, sjedište {seat}?", "DA", "NE");

        if (confirm)
        {
           
            var newTicket = new Ticket
            {
                Username = LoginService.CurrentUser.Username,
                Name = ticketName.ToUpper(),
                Match = $"{nextMatch.Home} - {nextMatch.Away}",
                Date = nextMatch.Date.ToString("dd.MM.yyyy"),
                Seat = seat.ToUpper(),
                Side = side.ToUpper(),
                QrUrl = $"https://api.qrserver.com/v1/create-qr-code/?size=150x150&data={Uri.EscapeDataString($"IME={ticketName};UTAKMICA={nextMatch.Home}-{nextMatch.Away};SJEDISTE={seat};STRANA={side}")}"
            };

     
            PurchasedTickets.Add(newTicket);
            await _db.SaveTicketAsync(newTicket);
            TicketsListView.ItemsSource = PurchasedTickets;

            
            LoginService.AddTicketCurrentUser();

            await DisplayAlertAsync("Uspješno", "Karta dodana u vašu listu!", "OK");
        }
    }
}
