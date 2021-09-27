using ProdajaMobilnihApplikacija.Mobile.ViewModels;
using ProdajaMobilnihApplikacija.Mobile.Views;
using ProdajaMobilnihApplikacija.Mobile.Views.Klijent;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ProdajaMobilnihApplikacija.Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(SoftverPage), typeof(SoftverPage));
            Routing.RegisterRoute(nameof(OcjenaKomentariPage), typeof(OcjenaKomentariPage));
            Routing.RegisterRoute(nameof(MojSoftverPage), typeof(MojSoftverPage));
            Routing.RegisterRoute(nameof(PostavkeProfilaPage), typeof(PostavkeProfilaPage));
            Routing.RegisterRoute(nameof(RegistrujSePage), typeof(RegistrujSePage));
            Routing.RegisterRoute(nameof(RacunPage), typeof(RacunPage));
            Routing.RegisterRoute(nameof(MojSoftverPage), typeof(MojSoftverPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
