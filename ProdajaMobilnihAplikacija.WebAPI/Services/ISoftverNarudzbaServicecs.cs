using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public interface ISoftverNarudzbaServicecs
    {
        Model.SoftverNarudzba GetRezervacijaByUserID(int id);

        //SoftverNarudzba UpdateStatus(int id, RezervacijaStatusRequest request);
    }
}
