using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WinUI.Admin;
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
    public partial class frmKlijent : Form
    {
        private readonly APIService _apiService = new APIService("Klijent");

        public frmKlijent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            var search = new KlijentSearchRequest()
            {
                Ime = txtPretraga.Text
            };
            var result = await _apiService.Get<List<Model.Klijent>>(search);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }

        private void dgvKlijent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKlijent.SelectedRows[0].Cells[0].Value;

            frmKlijentDetalji frm = new frmKlijentDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private async void frmKlijent_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Klijent>>(null);

            dgvKlijent.AutoGenerateColumns = false;

            dgvKlijent.DataSource = result;
        }
    }
}
