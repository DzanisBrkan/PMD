using AutoMapper;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class NarudzbaService
         : BaseCRUDService<Model.Narudzba, NarudzbaSearchRequest, Database.Narudzba, NarudzbaUpsertRequest, NarudzbaUpsertRequest>,
        INarudzbaService
    {
        public NarudzbaService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Narudzba> Get(NarudzbaSearchRequest search)
        {
            var query = _context.Set<Narudzba>().AsQueryable();
            if (search?.Naziv != null)
            {
                query = query.Where(x => x.Naziv == search.Naziv);
            }
            query = query.OrderBy(x => x.Naziv);
            var list = query.ToList();

            return _mapper.Map<List<Model.Narudzba>>(list);
        }

        public Model.Narudzba GetOcjenaByRezervacijaID(int id)
        {
            var query = _context.Ocjena.FirstOrDefault(x => x.SoftverNarudzbaId == id);

            if (query != null)
            {
                return _mapper.Map<Model.Narudzba>(query);
            }
            return null;
        }


        public Model.Narudzba UpdateStatus(int id, NarudzbaStatusRequest request)
        {
            var entity = _context.Narudzba.Find(id);
            _context.Narudzba.Attach(entity);
            _context.Narudzba.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Narudzba>(entity);
        }
    }
}
