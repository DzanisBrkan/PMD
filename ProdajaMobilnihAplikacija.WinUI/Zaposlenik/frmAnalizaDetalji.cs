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
    public partial class frmAnalizaDetalji : Form
    {
        private readonly APIService _services = new APIService("Analiza");
        private readonly APIService _servicesKlijent = new APIService("Klijent");
        private readonly APIService _servicesSoftver = new APIService("Softver");
        private int? _id = null;
        public frmAnalizaDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmAnalizaDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var analiza = await _services.GetById<Model.Analiza>(_id);
                var klijent = await _servicesKlijent.GetById<Model.Klijent>(analiza.KlijentID);
                var softver = await _servicesSoftver.GetById<Model.Softver>(analiza.SoftverID);

                txtNaziv.Text = analiza.Naziv;
                txtDatum.ReadOnly = true;

                txtDatum.Text = analiza.Datum_analize.ToString();
                txtDatum.ReadOnly = true;

                txtSoftver.Text = softver.Naziv;
                txtSoftver.ReadOnly = true;

                txtKlijent.Text = klijent.Ime + " " +  klijent.Prezime;
                txtKlijent.ReadOnly = true;


            }
        }
    }
}
