using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class SoftverNarudzba
    {
        public SoftverNarudzba()
        {
            Ocjenas = new HashSet<Ocjena>();
        }

        public int SoftverNarudzbaId { get; set; }
        public int? Kolicina { get; set; }
        public int? Ocjena { get; set; }
        public string Komentar { get; set; }
        public int? SoftverId { get; set; }
        public int? NarudzbaId { get; set; }

        public virtual Narudzba Narudzba { get; set; }
        public virtual Softver Softver { get; set; }
        public virtual ICollection<Ocjena> Ocjenas { get; set; }
    }
}
