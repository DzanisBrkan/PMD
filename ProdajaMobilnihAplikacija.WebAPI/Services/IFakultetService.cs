﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface IFakultetService
    {
        Model.Fakultet GetOcjenaByRezervacijaID(int id);
    }
}
