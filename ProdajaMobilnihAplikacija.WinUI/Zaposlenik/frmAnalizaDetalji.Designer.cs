﻿namespace ProdajaMobilnihAplikacija.WinUI.Zaposlenik
{
    partial class frmAnalizaDetalji
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalizaDetalji));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.Analiza = new System.Windows.Forms.Label();
            this.Datum = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.UkupnaKolicina = new System.Windows.Forms.Label();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.UkupnaCijena = new System.Windows.Forms.Label();
            this.txtSoftver = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "Naziv";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(112, 93);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(265, 20);
            this.txtNaziv.TabIndex = 116;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(330, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 42);
            this.btnExit.TabIndex = 111;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Analiza
            // 
            this.Analiza.AutoSize = true;
            this.Analiza.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Analiza.Location = new System.Drawing.Point(34, 15);
            this.Analiza.Name = "Analiza";
            this.Analiza.Size = new System.Drawing.Size(237, 39);
            this.Analiza.TabIndex = 115;
            this.Analiza.Text = "Detalji Analiza";
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.Location = new System.Drawing.Point(14, 133);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(77, 13);
            this.Datum.TabIndex = 114;
            this.Datum.Text = "Datum_analize";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(112, 130);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(265, 20);
            this.txtDatum.TabIndex = 108;
            // 
            // UkupnaKolicina
            // 
            this.UkupnaKolicina.AutoSize = true;
            this.UkupnaKolicina.Location = new System.Drawing.Point(14, 210);
            this.UkupnaKolicina.Name = "UkupnaKolicina";
            this.UkupnaKolicina.Size = new System.Drawing.Size(35, 13);
            this.UkupnaKolicina.TabIndex = 113;
            this.UkupnaKolicina.Text = "Klijent";
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(112, 207);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.Size = new System.Drawing.Size(265, 20);
            this.txtKlijent.TabIndex = 110;
            // 
            // UkupnaCijena
            // 
            this.UkupnaCijena.AutoSize = true;
            this.UkupnaCijena.Location = new System.Drawing.Point(14, 172);
            this.UkupnaCijena.Name = "UkupnaCijena";
            this.UkupnaCijena.Size = new System.Drawing.Size(41, 13);
            this.UkupnaCijena.TabIndex = 112;
            this.UkupnaCijena.Text = "Softver";
            // 
            // txtSoftver
            // 
            this.txtSoftver.Location = new System.Drawing.Point(112, 169);
            this.txtSoftver.Name = "txtSoftver";
            this.txtSoftver.Size = new System.Drawing.Size(265, 20);
            this.txtSoftver.TabIndex = 109;
            // 
            // frmAnalizaDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Analiza);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.UkupnaKolicina);
            this.Controls.Add(this.txtKlijent);
            this.Controls.Add(this.UkupnaCijena);
            this.Controls.Add(this.txtSoftver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnalizaDetalji";
            this.Text = "frmAnalizaDetalji";
            this.Load += new System.EventHandler(this.frmAnalizaDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label Analiza;
        private System.Windows.Forms.Label Datum;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label UkupnaKolicina;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.Label UkupnaCijena;
        private System.Windows.Forms.TextBox txtSoftver;
    }
}