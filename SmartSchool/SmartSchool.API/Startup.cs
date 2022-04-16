using SmartSchool.API.Context;
using SmartSchool.API.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SmartSchool.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }


        // Use este m�todo para adicionar servi�os ao cont�iner.
        public void ConfigureServices(IServiceCollection services)
        {
            #region CONEX�O COM BANCO DE DADOS
            services.AddDbContext<SmartContext>(
                context => context.UseSqlite(Configuration.GetConnectionString("Default"))
            );
            #endregion

            // Adicionar as controllers ao servi�o
            // Ir� ignorar o loop infinito dos relacionamento dos modelos
            services.AddControllers()
                    .AddNewtonsoftJson(
                        opt => opt.SerializerSettings.ReferenceLoopHandling =
                            Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            // Adicionar pacote AutoMapper ao servi�o
            // Fazer o mapeamento entre os Dtos e os Dominios
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
           
            #region INJE��O DE DEPEND�NCIA
            //Injetar o repository dentro das controllers com obstra��o do contexto por meio da interface.
            services.AddScoped<IBaseRepository, BaseRepository>();
            #endregion

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
