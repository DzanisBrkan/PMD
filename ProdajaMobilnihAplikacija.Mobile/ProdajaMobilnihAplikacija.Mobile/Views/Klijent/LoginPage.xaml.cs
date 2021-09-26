using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProdajaMobilnihAplikacija.Mobile.Views.Klijent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void RegisterLabel_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegistrujSePage();
            //await Navigation.PushAsync(new RegistracijaPage()); // ovo ima back tipku
            // ali ne moze jer udje u loop i pukne

        }
    }
}