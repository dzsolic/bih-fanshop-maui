using BHFanShop.Models;
using System;

namespace BHFanShop.Views
{
    public partial class MatchDetailsPage : ContentPage
    {
        public MatchDetailsPage(Match match)
        {
            InitializeComponent();
            BindingContext = match;
        }

        private async void Close_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}