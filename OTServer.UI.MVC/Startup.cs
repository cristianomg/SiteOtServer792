using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OTServer.UI.MVC.Models;
using Teste.Models;

namespace OTServer.UI.MVC
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
            services.Configure<IISOptions>(o =>
            {
                o.ForwardClientCertificate = false;
            });
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddControllersWithViews();
            AutoMapperConfig(services);
            services.AddMvc(options =>
            {
                options.CacheProfiles.Add("Default30",
                    new CacheProfile()
                    {
                        Duration = 30
                    });
            });
            services.AddRazorPages()
                .AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        private void AutoMapperConfig(IServiceCollection service)
        {
            var mapperConfiguration = new MapperConfiguration(config =>
            {
                //Account
                config.CreateMap<Account, DTOAccountLogin>();
                config.CreateMap<Account, DTOPainelAccount>();
                config.CreateMap<DTOCreateAccount, Account>();
                config.CreateMap<DTOAccountLogin, Account>();
                config.CreateMap<DTOPainelAccount, Account>();
                config.CreateMap<DTOCreateAccount, Account>();



                //Player
                config.CreateMap<Player, DTOListaDePlayer>();
                config.CreateMap<Player, DTOKills>();
                config.CreateMap<Player, DTOPlayerSearch>();
                config.CreateMap<Player, DTORankingLevel>();
                config.CreateMap<Player, DTORankFrags>();
                config.CreateMap<Player, DTORankMagic>();
                config.CreateMap<Player, DTORankSkill>();
                config.CreateMap<DTOKills, Player>();
                config.CreateMap<DTOPlayerSearch, Player>();
                config.CreateMap<DTORankingLevel, Player>();
                config.CreateMap<DTORankFrags, Player>();
                config.CreateMap<DTORankMagic, Player>();
                config.CreateMap<DTORankSkill, Player>();
                config.CreateMap<DTOListaDePlayer, Player>();




            });

            IMapper mapper = mapperConfiguration.CreateMapper();
            service.AddSingleton(mapper);
        }
    }

}
