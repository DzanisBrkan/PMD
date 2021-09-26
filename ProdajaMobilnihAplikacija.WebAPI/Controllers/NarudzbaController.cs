using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Services;

namespace ProdajaMobilnihAplikacija.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NarudzbaController : BaseCRUDController<Narudzba, NarudzbaSearchRequest, NarudzbaUpsertRequest, NarudzbaUpsertRequest>
    {
        private readonly INarudzbaService _service;
        public NarudzbaController(ICRUDService<Narudzba, NarudzbaSearchRequest, NarudzbaUpsertRequest, NarudzbaUpsertRequest> service, INarudzbaService rez_service) : base(service)
        {
            _service = rez_service;
        }


        [HttpGet("GetRezByUserID/{id}")]
        public Model.Narudzba GetRezervacijaByUserID(int id)
        {
            return _service.GetOcjenaByRezervacijaID(id);
        }

        [HttpPut("UpdateStatus/{id}")]
        public Model.Narudzba UpdateStatus(int id, NarudzbaStatusRequest request)
        {
            return _service.UpdateStatus(id, request);
        }
    }
}
