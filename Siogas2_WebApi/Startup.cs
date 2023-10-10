using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Siogas2.BussinesLogic;
using Siogas2.Data;
using Siogas2.LogicInterfaces;
using Siogas2.LogicInterfaces.Parametrizacion;
using Siogas2.LogicInterfaces.Nominacion;
using System.Text;
using Siogas2.BusinessLogic.Nominacion;
using Siogas2.DataInterfaces;

namespace Siogas2_WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            
            services.AddTransient<IDataUnitOfWork, DataUnitOfWork>();
            services.AddScoped<IGasoductoManager, GasoductoManager>();

            services.AddTransient<IProcesos008Manager, Procesos008Manager>();

            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "gasoducto", Version = "v1" });    
            });
            //services.AddDbContext<ApplicationDbContext>(
            //options => options.UseSqlServer(Configuration.GetConnectionString("Conexion")
            //));



        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors(options =>
            {
                options.WithOrigins("*");
                options.AllowAnyMethod();
                options.AllowAnyHeader();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Siogas_WebApi"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

