using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model.Requests
{
    public class SoftverSearchRequest
    {
        public int? SoftverId { get; set; }

        public string Naziv;
        public int? KategorijaId { get; set; }
        public int? TipId { get; set; }
        public string Verzija { get; set; }

    }
}
