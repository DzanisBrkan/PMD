using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    public partial class frmDodajSoftver : Form
    {
        private readonly APIService _voziloService = new APIService("Vozilo");
        private readonly APIService _kategorijaService = new APIService("Kategorija");
        private readonly APIService _specifikacijaService = new APIService("Specifikacija");
        private readonly APIService _tipVozila = new APIService("Tip");

        public frmDodajSoftver()
        {
            InitializeComponent();
        }

        private async void frmDodajSoftver_Load(object sender, EventArgs e)
        {
            await LoadKategorija();
            await LoadSpecifikacija();
            await LoadTipVozila();
        }


        private async Task LoadKategorija()
        {
            var result = await _kategorijaService.Get<List<Model.Kategorija>>(null);
            result.Insert(0, new Model.Kategorija());
            cmbKategorija.DisplayMember = "Oznaka";
            cmbKategorija.ValueMember = "KategorijaId";
            cmbKategorija.DataSource = result;
        }
        private async Task LoadSpecifikacija()
        {
        }
        private async Task LoadTipVozila()
        {
            var result = await _tipVozila.Get<List<Model.Tip>>(null);
            result.Insert(0, new Model.Tip());
            cmbTip.DisplayMember = "Naziv";
            cmbTip.ValueMember = "TipId";
            cmbTip.DataSource = result;
        }


        private async void cmbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKategorija.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVozila(id);
            }
        }

        private async Task LoadVozila(int kategorijaId)
        {
            var result = await _voziloService.Get<List<Model.Softver>>(new SoftverSearchRequest()
            {
                KategorijaId = kategorijaId
            });
        }


        SoftverUpsertRequest request = new SoftverUpsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.ValidateChildren())
                {
                    var _kategorijaId = 0;
                    var _tipId = 0;


                    //if (cmbKategorija.Text == "A1")
                    //{
                    //    _kategorijaId = 100;
                    //}
                    //else if (cmbKategorija.Text == "A")
                    //{
                    //    _kategorijaId = 101;
                    //}
                    //else if (cmbKategorija.Text == "B")
                    //{
                    //    _kategorijaId = 102;
                    //}

                    //if (cmbTip.Text == "Hečbek")
                    //{
                    //    _tipId = 100;
                    //}
                    //else if (cmbTip.Text == "Limuzina")
                    //{
                    //    _tipId = 101;
                    //}
                    //else if (cmbTip.Text == "Karavan")
                    //{
                    //    _tipId = 102;
                    //}
                    //else if (cmbTip.Text == "Skuter")
                    //{
                    //    _tipId = 103;
                    //}
                    //else if (cmbTip.Text == "Motor")
                    //{
                    //    _tipId = 104;
                    //}

                    //unos specifikacije
                    var specRequest = new KategorijaUpsertRequest()
                    {
                        Naziv = txtNazivKagegorije.Text,
                        Oznaka = txtOznaka.Text,
                        Opis = txtOpis.Text,
                     
                    };
                    var specifikacija = await _specifikacijaService.Insert<Model.Kategorija>(specRequest);

                    //unos vozila
                    var request = new SoftverUpsertRequest()
                    {
                        Naziv = txtNaziv.Text,
                        Verzija = txtVerzija.Text,
                        //Cijena = txtCijena.Text, // pretvoriti string u double?
                        KategorijaId = _kategorijaId,
                        TipId = _tipId                        
                    };


                    await _voziloService.Insert<Model.Softver>(request);

                    MessageBox.Show("Uspjesno ste dodali vozilo i njegovu specifikaciju!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Doslo je do greske!");
            }
            this.Close();
        }
    }
}
