using ProdajaMobilnihApplikacija.Mobile.Services;
using ProdajaMobilnihApplikacija.Mobile.Views;
using ProdajaMobilnihApplikacija.Mobile.Views.Klijent;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProdajaMobilnihApplikacija.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            //MainPage = new Views.Klijent.LoginPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
