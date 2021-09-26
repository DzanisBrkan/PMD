using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WinUI.Pocetna;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMobilnihAplikacija.WinUI.Login
{
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Zaposlenik"); //ovdje moze stajati sta god

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Obavezno unesite korisničko ime i lozinku!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;


                await _service.Get<dynamic>(null);

                var request = new ZaposlenikSearchRequest()
                {
                    KorisnickoIme = txtUsername.Text
                };


                var user = await _service.Get<List<Model.Zaposlenik>>(request);

                for (int i = 0; i < user.Count; i++)
                {
                    if (txtUsername.Text == user[i].KorisnickoIme)
                    {
                        var id = user[i].ZaposlenikId;
                        APIService.UserID = id;
                    }
                }




                //ako je admin ide na admin page
                // ako je zapolsenik ide na zaposlenik page

                frmPocetna frm = new frmPocetna(APIService.UserID);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Autentifikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
