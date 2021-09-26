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

namespace ProdajaMobilnihAplikacija.WinUI.Admin
{
    public partial class frmKategorijaDetalji : Form
    {
        private readonly APIService _services = new APIService("Kategorija");
        private int? _id = null;
        public frmKategorijaDetalji(int? UgovorId = null)
        {
            InitializeComponent();
            _id = UgovorId;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var KategorijaInsertQuery = new KategorijaUpsertRequest();

            KategorijaInsertQuery.Oznaka = txtOpis.Text;

            KategorijaInsertQuery.Naziv = txtNaziv.Text;

            KategorijaInsertQuery.Opis = txtOpis.Text;

            await _services.Insert<Model.Kategorija>(KategorijaInsertQuery);

            MessageBox.Show("Uspjesno ste pohranili kategoriju");

            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
