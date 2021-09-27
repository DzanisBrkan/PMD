using ProdajaMobilnihApplikacija.Mobile.ViewModels.Klijent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProdajaMobilnihApplikacija.Mobile.Views.Klijent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SoftverPage : ContentPage
    {
        SoftverViewModel model = null;
        public SoftverPage()
        {
            InitializeComponent();
            BindingContext = model = new SoftverViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            //await Navigation.PushAsync(new NapraviRezervacijuPage((Vozilo)e.SelectedItem)); // kada vise puta udjem, app pukne 

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new DetaljiVozilaSlikePage(null));
        }
    }
}