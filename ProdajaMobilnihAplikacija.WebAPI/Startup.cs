using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Http.Description;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ProdajaMobilnihAplikacija.Model.Requests;
using ProdajaMobilnihAplikacija.WebAPI.Database;
using ProdajaMobilnihAplikacija.WebAPI.Filters;
using ProdajaMobilnihAplikacija.WebAPI.Security;
using ProdajaMobilnihAplikacija.WebAPI.Services;
using Swashbuckle.AspNetCore.SwaggerGen;
//using Swashbuckle.Swagger;
//using IDocumentFilter = Swashbuckle.Swagger.IDocumentFilter;


namespace ProdajaMobilnihAplikacija.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddAutoMapper(typeof(Startup));

            //services.AddAutoMapper();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication")
                        .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            services.AddScoped<IZaposlenikService, ZaposlenikServices>();
            services.AddScoped<ISoftverService, SoftverService>();
            services.AddScoped<IKlijentService, KlijentService>();
            services.AddScoped<ISoftverService, SoftverService>();
            services.AddScoped<IAnalizaService, AnalizaService>();
            services.AddScoped<IRacunService, RacunService>();
            services.AddScoped<IOcjenaService, OcjenaServices>();
            services.AddScoped<IKategorijaService, KategorijaService>();
            services.AddScoped<IGradService, GradService>();

            //services.AddScoped<IRezervacijaServicecs, RezervacijaServices>();

            ////services.AddScoped<ICRUDService<Model.Specifikacija, SpecifikacijaSearchRequest, SpecifikacijaUpsertRequest, SpecifikacijaUpsertRequest>, SpecifikacijaServices>();
            ////services.AddScoped<ICRUDService<Model.Rezervacija, RezervacijaSearchRequest, RezervacijaUpsertRequest, RezervacijaUpsertRequest>, RezervacijaServices>();
            //services.AddScoped<ISoftverService, SoftverService>();
            //services.AddScoped<ICRUDService<Model.Softver, SoftverSearchRequest, SoftverUpsertRequest, SoftverUpsertRequest>, SoftverService>();
            //services.AddScoped<ICRUDService<Model.Softver, SoftverSearchRequest, SoftverUpsertRequest, SoftverUpsertRequest>, SoftverService>();
            services.AddScoped<ICRUDService<Model.SoftverNarudzba, SoftverNarudzbaSearchRequest, SoftverNarudzbaUpsertRequest, SoftverNarudzbaUpsertRequest>, SoftverNarudzbaServicecs>();
            //services.AddScoped<ICRUDService<Model.Racun, RacunSearchRequest, RacunUpsertRequest, RacunUpsertRequest>, RacunService>();
            //services.AddScoped<ICRUDService<Model.Ocjena, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest>, OcjenaServices>();
            services.AddScoped<ICRUDService<Model.Narudzba, NarudzbaSearchRequest, NarudzbaUpsertRequest, NarudzbaUpsertRequest>, NarudzbaService>();
            //services.AddScoped<ICRUDService<Model.Grad, GradSearchRequest, GradUpsertRequest, GradUpsertRequest>, GradService>();
            services.AddScoped<ICRUDService<Model.Fakultet, FakultetSearchRequest, FakultetUpsertRequest, FakultetUpsertRequest>, FakultetService>();
            //services.AddScoped<ICRUDService<Model.Analiza, AnalizaSearchRequest, AnalizaUpsertRequest, AnalizaUpsertRequest>, AnalizaService>();
            //services.AddScoped<ICRUDService<Model.Drzava, DrzavaSearchRequest, DrzavaUpsertRequest, DrzavaUpsertRequest>, DrzavaService>();

            //services.AddScoped<IService<Model.KorisnickiNalog, object>, BaseService<Model.KorisnickiNalog, object, Model.KorisnickiNalog>>();
            ////services.AddScoped<IService<Model.Kategorija, object>, BaseService<Model.Kategorija, object, Kategorija>>();

            ////services.AddScoped<IService<Model.Tip, object>, BaseService<Model.Tip, object, Tip>>();

            //services.AddScoped<IService<Model.Drzava, object>, BaseService<Model.Drzava, object, Model.Drzava>>();
            ////services.AddScoped<IService<Model.Greska, object>, BaseService<Model.Greska, object, Greska>>();
            ////services.AddScoped<IService<Model.Lokacija, object>, BaseService<Model.Lokacija, object, Lokacija>>();
            ////services.AddScoped<IService<Model.Osiguranje, object>, BaseService<Model.Osiguranje, object, Osiguranje>>();
            ////services.AddScoped<IService<Model.Popust, object>, BaseService<Model.Popust, object, Popust>>();
            ////services.AddScoped<IService<Model.NacinPlacanja, object>, BaseService<Model.NacinPlacanja, object, NacinPlacanja>>();
            ////services.AddScoped<ICRUDService<Model.DojmoviZahtjevi, DojmoviZahtjeviSearchRequest, DojmoviZahtjeviUpsertRequest, DojmoviZahtjeviUpsertRequest>, DojmoviZahtjeviServices>();
            //services.AddScoped<IRecommenderService, RecommenderService>();

            ////mls da ide ovaj prvi
            ////services.AddScoped<ICRUDService<Model.Lociranje, LociranjeSearchRequest, LociranjeUpsertRequest, LociranjeUpsertRequest>, LociranjeService>();
            //services.AddScoped<IService<Model.Lociranje, object>, BaseService<Model.Lociranje, object, Lociranje>>();


            ////var connection = @"Server=.;Database=Rent_A_Car;Trusted_Connection=True;ConnectRetryCount=0";


            services.AddDbContext<Prodaja_Mobilnog_SoftveraContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("Prodaja_Mobilnog_Softvera")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
