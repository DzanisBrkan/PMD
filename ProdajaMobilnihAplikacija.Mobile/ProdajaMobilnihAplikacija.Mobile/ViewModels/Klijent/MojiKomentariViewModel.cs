using ProdajaMobilnihAplikacija.Mobile.Views;
using ProdajaMobilnihAplikacija.Mobile.Views.Klijent;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;


namespace ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent
{
    public class MojiKomentariViewModel : BaseViewModel
    {

        string _ime = string.Empty;


        private readonly APIService _OcjenaService = new APIService("Ocjena");


        public MojiKomentariViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Ocjena> OcjenaList { get; set; } = new ObservableCollection<Model.Ocjena>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
           
            var Ocjena = await _OcjenaService.Get<List<Model.Ocjena>>(null); 

            foreach (var item in Ocjena)
            {
                OcjenaList.Add(item);
            }
        }

    }
}
