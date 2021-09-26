using ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent;
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
    public partial class OcjeneIKomentariPage : ContentPage
    {
        OcjeneIKomentariViewModel model = null;
        public OcjeneIKomentariPage()
        {
            InitializeComponent();
            BindingContext = model = new OcjeneIKomentariViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
   
    }
}