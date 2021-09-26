using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Analiza
    {
        public int AnalizaID { get; set; }
        public string Naziv { get; set; }
        public string Datum_analize { get; set; }

        public int KlijentID { get; set; }
        public int ZaposlenikID { get; set; } // sto ce ovdje zaposlenik
        public int SoftverID { get; set; }
    }
}
