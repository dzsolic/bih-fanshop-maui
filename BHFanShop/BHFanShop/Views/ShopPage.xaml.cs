using BHFanShop.Models;
using System.Collections.ObjectModel;

namespace BHFanShop.Views;

public partial class ShopPage : ContentPage
{
    public ShopPage()
    {
        InitializeComponent();

        JerseysCollection.ItemsSource = new ObservableCollection<Jersey>  //Observable zbog stalnog collapsanja//
{
    new Jersey
    {
        Name = "Domaæi dres",
        Price = "109 KM",
        Image = "dres_domaci.jpeg"
    },
    new Jersey
    {
        Name = "Gostujuæi dres",
        Price = "109 KM",
        Image = "dres_gostujuci.jpeg"
    },
    new Jersey
    {
        Name = "Retro dres",
        Price = "129 KM",
        Image = "retro.png"
    }
};

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

        await DisplayAlert(
            "Uspješno",
            "Kupovina je uspješno izvršena!",
            "OK");
    }
}
