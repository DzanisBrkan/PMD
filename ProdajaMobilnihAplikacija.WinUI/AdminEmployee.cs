﻿using ProdajaMobilnihAplikacija.WinUI.Pocetna;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdajaMobilnihAplikacija.WinUI
{
    public partial class AdminEmployee : Form
    {
        public AdminEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPocetna frm = new frmPocetna();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPocetnaAdmin frm = new frmPocetnaAdmin();
            frm.Show();
        }
    }
}
