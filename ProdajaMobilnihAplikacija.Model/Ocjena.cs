using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Ocjena
    {
        public int OcjenaId { get; set; }
        public int ocjena { get; set; }
        public string Komentar { get; set; }



        public int? SoftverNarudzbaID { get; set; }
        public int? SoftverID { get; set; }
        public int KlijentID { get; set; }

    }
}
