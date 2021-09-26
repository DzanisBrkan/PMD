﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProdajaMobilnihAplikacija.Model
{
    public partial class Softver
    {
        public int SoftverId { get; set; }
        public string Naziv { get; set; }
        public string Verzija { get; set; }
        public double? Cijena { get; set; }

        public int? KategorijaId { get; set; }
        public int? TipId { get; set; }
        public byte[] SlikaThumb { get; set; }
        public float PositiveDifferent { get; set; } = 0;
        public string Color { get; set; }
    }
}
