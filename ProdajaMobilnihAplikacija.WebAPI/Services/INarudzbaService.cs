using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface INarudzbaService
    {
        Model.Narudzba GetOcjenaByRezervacijaID(int id);

        Narudzba UpdateStatus(int id, NarudzbaStatusRequest request);
    }
}
