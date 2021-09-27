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
    public partial class OcjenaKomentariPage : ContentPage
    {
        OcjenaKomentariViewModel model = null;
        public OcjenaKomentariPage()
        {
            InitializeComponent();
            BindingContext = model = new OcjenaKomentariViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

    }
}