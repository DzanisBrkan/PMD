using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WebAPI.Services
{
    public class RecommenderService : IRecommenderService
    {
        private readonly Prodaja_Mobilnog_SoftveraContext _context;
        private readonly IMapper _mapper;
        public RecommenderService(Prodaja_Mobilnog_SoftveraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.RecommenderModel Get(UserRecommendationRequest request)
        {
            var UserEntity = _context.Klijent.Find(request.UserID);
            var SoftverList = _context.Softver.Include(x => x.Verzija).ToList();
            //var VoziloList = _context.Softver.Include(x => x.Lokacija).ToList();
            var ratingList = _context.Ocjena.Include(u => u.Klijent).ToList();

            float countRatings = 0;
            int brojacOcjena = 0;

            RecommenderModel model = new RecommenderModel();
            model.listToRecommend = new List<Model.Softver>();
            model.others = new List<Model.Softver>();

            foreach (var softver in SoftverList)
            {
                countRatings = 0;
                brojacOcjena = 0;
                if (softver.Cijena >= 1)
                { //if (softver.Verzija.Naziv == "Mostar")
                        foreach (var r in ratingList)
                    {
                        if (softver.SoftverId == r.SoftverId && r.KlijentId != UserEntity.KlijentId)
                        {
                            //if (r.Ocjena1 >= 2)
                            //{
                                countRatings += (float)r.Ocjena1;
                                brojacOcjena++;
                            //}
                        }
                    }
                    float avg = 0;
                    if (countRatings != 0)
                    {
                        avg = (float)(countRatings / brojacOcjena);
                    }
                    if (avg >= 2.5)
                    {

                        model.listToRecommend.Add(new Model.Softver()
                        {
                            SoftverId = softver.SoftverId,
                            Naziv = softver.Naziv,
                            Cijena = softver.Cijena,
                            KategorijaId = softver.KategorijaId,
                          
                            //TipId = softver.Tiop,
                            SlikaThumb = softver.SlikaThumb,
                            PositiveDifferent = avg
                        });
                    }
                    else
                    {
                        model.others.Add(new Model.Softver()
                        {
                            SoftverId = softver.SoftverId,
                            Naziv = softver.Naziv,
                            Cijena = softver.Cijena,
                            KategorijaId = softver.KategorijaId,

                            //TipId = softver.Tiop,
                            SlikaThumb = softver.SlikaThumb,
                            PositiveDifferent = avg

                        });
                    }
                }
            }
            model.listToRecommend = model.listToRecommend.OrderByDescending(r => r.PositiveDifferent).ToList();


            return model;
        }

    }
}
