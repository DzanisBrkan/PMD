using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Racun
    {
        public Racun()
        {
            Narudzbas = new HashSet<Narudzba>();
        }

        public int RacunId { get; set; }
        public DateTime? Datum { get; set; }
        public double? Cijena { get; set; }
        public int? Kolicina { get; set; }
        public string NacinPlacanja { get; set; }

        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}
