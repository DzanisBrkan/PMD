using ProdajaMobilnihApplikacija.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProdajaMobilnihApplikacija.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}