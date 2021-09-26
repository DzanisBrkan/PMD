using AutoMapper;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using Rent_A_Car.WebAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class SoftverNarudzbaServicecs
         : BaseCRUDService<Model.SoftverNarudzba, SoftverNarudzbaSearchRequest, Database.SoftverNarudzba, SoftverNarudzbaUpsertRequest,SoftverNarudzbaUpsertRequest>,
        ISoftverNarudzbaServicecs
    {
        public SoftverNarudzbaServicecs(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public Model.SoftverNarudzba GetRezervacijaByUserID(int id)
        {
            var query = _context.SoftverNarudzba.FirstOrDefault(x => x.SoftverId == id);

            if (query != null)
            {
                return _mapper.Map<Model.SoftverNarudzba>(query);

            }
            throw new UserException("Narudzba nije pronadjena");
        }


     
    }
}
