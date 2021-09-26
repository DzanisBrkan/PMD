﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Klijent
    {
        public Klijent()
        {
            Analizas = new HashSet<Analiza>();
            Narudzbas = new HashSet<Narudzba>();
            Ocjenas = new HashSet<Ocjena>();
        }

        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojTel { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string DatumRodjenja { get; set; }
        public int? GradId { get; set; }
        public int? KarticaId { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] SlikaThumb { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual Kartica Kartica { get; set; }
        public virtual ICollection<Analiza> Analizas { get; set; }
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
        public virtual ICollection<Ocjena> Ocjenas { get; set; }
    }
}
