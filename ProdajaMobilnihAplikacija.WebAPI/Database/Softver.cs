using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Softver
    {
        public Softver()
        {
            Analizas = new HashSet<Analiza>();
            Ocjenas = new HashSet<Ocjena>();
            SoftverNarudzbas = new HashSet<SoftverNarudzba>();
        }

        public int SoftverId { get; set; }
        public string Naziv { get; set; }
        public string Verzija { get; set; }
        public double? Cijena { get; set; }
        public int? KategorijaId { get; set; }
        public byte[] SlikaThumb { get; set; }
        public double? PositiveDifferent { get; set; }
        public string Color { get; set; }

        public virtual Kategorija Kategorija { get; set; }
        public virtual ICollection<Analiza> Analizas { get; set; }
        public virtual ICollection<Ocjena> Ocjenas { get; set; }
        public virtual ICollection<SoftverNarudzba> SoftverNarudzbas { get; set; }
    }
}
