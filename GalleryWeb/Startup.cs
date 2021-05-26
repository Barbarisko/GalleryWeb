using AutoMapper;
using GalleryBLL.Interfaces;
using GalleryBLL.Services;
using GalleryDAL;
using GalleryDAL.Entities;
using GalleryDAL.Repository;
using GalleryDAL.UnitOfWork;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb
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
            services.AddEntityFrameworkNpgsql().AddDbContext<GalleryDbContext>(opt =>
                                 opt.UseNpgsql("Host = 165.232.107.123; Username = postgres; Password = 1; Database = postgres;" +
                                                " Persist Security Info = True"));

            services.AddScoped<IRepository<Artist>, Repository<Artist>>();
            services.AddScoped<IRepository<City>, Repository<City>>();
            services.AddScoped<IRepository<Country>, Repository<Country>>();
            services.AddScoped<IRepository<CurrentExhibition>, Repository<CurrentExhibition>>();
            services.AddScoped<IRepository<Employee>, Repository<Employee>>();
            services.AddScoped<IRepository<ExhibitedPicture>, Repository<ExhibitedPicture>>();
            services.AddScoped<IRepository<Exhibition>, Repository<Exhibition>>();
            services.AddScoped<IRepository<ExhibitPlace>, Repository<ExhibitPlace>>();
            services.AddScoped<IRepository<OwnedPicture>, Repository<OwnedPicture>>();
            services.AddScoped<IRepository<Owner>, Repository<Owner>>();
            services.AddScoped<IRepository<Picture>, Repository<Picture>>();
            services.AddScoped<IRepository<Technique>, Repository<Technique>>();
            services.AddScoped<IRepository<Ticket>, Repository<Ticket>>();
            services.AddScoped<IRepository<News>, Repository<News>>();
            services.AddScoped<IRepository<TicketsInCart>, Repository<TicketsInCart>>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddSingleton(new MapperConfiguration(c => c.AddProfile(new GalleryBLL.Mapper())).CreateMapper());

            services.AddTransient<IHRService, HRService>();
            services.AddTransient<IArtistService, ArtistService>();
            services.AddTransient<IExhibitionService, ExhibitionService>();
            services.AddTransient<IPictureService, PictureService>();
            services.AddTransient<ICurrentExhibitionService, CurrentExhibitionService>();
            services.AddTransient<IOwnershipService, OwnershipService>();
            services.AddTransient<ITicketService, TicketService>();

            services.AddControllersWithViews();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
