using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Narudzba
    {
        public Narudzba()
        {
            SoftverNarudzbas = new HashSet<SoftverNarudzba>();
        }

        public int NarudzbaId { get; set; }
        public string Naziv { get; set; }
        public DateTime? DatumNarudzbe { get; set; }
        public int? KlijentId { get; set; }
        public int? RacunId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Racun Racun { get; set; }
        public virtual ICollection<SoftverNarudzba> SoftverNarudzbas { get; set; }
    }
}
