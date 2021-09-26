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
    public partial class frmAnaliza : Form
    {
        private readonly APIService _apiService = new APIService("Analiza");
        public frmAnaliza()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private async void frmAnaliza_Load(object sender, EventArgs e)
        {
            var result = await _apiService.Get<List<Model.Analiza>>(null);

            dgvAnaliza.AutoGenerateColumns = false;

            dgvAnaliza.DataSource = result;
        }

        private void dgvAnaliza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvAnaliza.SelectedRows[0].Cells[0].Value;

            frmAnalizaDetalji frm = new frmAnalizaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
