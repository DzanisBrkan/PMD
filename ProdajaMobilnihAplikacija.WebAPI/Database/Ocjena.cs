using System;
using System.Collections.Generic;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Ocjena
    {
        public int OcjenaId { get; set; }
        public int? Ocjena1 { get; set; }
        public string Komentar { get; set; }
        public int? SoftverNarudzbaId { get; set; }
        public int? SoftverId { get; set; }
        public int? KlijentId { get; set; }

        public virtual Klijent Klijent { get; set; }
        public virtual Softver Softver { get; set; }
        public virtual SoftverNarudzba SoftverNarudzba { get; set; }
    }
}
