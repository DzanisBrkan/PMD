﻿using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent
{
    public class SoftverViewModel : BaseViewModel
    {
        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _KategorijaService = new APIService("Kategorija");



        public SoftverViewModel()
        {
            InitCommand = new Command(async () => await Init());
            
        }
        


        public ObservableCollection<Softver> SoftverList { get; set; } = new ObservableCollection<Softver>();
        public ObservableCollection<Kategorija> Kategorija { get; set; } = new ObservableCollection<Kategorija>();

        Kategorija _SelectedTKategorija = null;
        public Kategorija SelectedTKategorija
        {
            get { return _SelectedTKategorija; }
            set
            {
                SetProperty(ref _SelectedTKategorija, value);
                if (value != null)
                {
                    InitCommand.Execute(null);

                }
            }
        }


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (Kategorija.Count == 0)
            {
                var tipSoftveraList = await _KategorijaService.Get<List<Kategorija>>(null);

                foreach (var tipSoftvera in tipSoftveraList)
                {
                    Kategorija.Add(tipSoftvera);
                }
            }

            if (SelectedTKategorija != null)
            {
                SoftverSearchRequest search = new SoftverSearchRequest();
                search.TipId = SelectedTKategorija.KategorijaId;
                //search.Verzija = SelectedTipSoftvera.Naziv

                var list = await _SoftverService.Get<List<Softver>>(search);

                //Promiojenjeno VoziloServices
                //int brojac = 0;
                SoftverList.Clear();
                foreach (var softvare in list)
                {
                    //if (list.ElementAt(brojac).Zauzeto != true)
                    //{
                        SoftverList.Add(softvare);
                    //}
                    //brojac++;

                }

            }
            else
            {
                var list = await _SoftverService.Get<List<Softver>>(null);
                //int brojac = 0;
                SoftverList.Clear();
                foreach (var vozilo in list)
                {

                    //if (list.ElementAt(brojac).Zauzeto != true)
                    //{
                        SoftverList.Add(vozilo);
                    //}
                    //brojac++;

                }
            }
        }

       


    }
}
