using System;
using System.IO;
using System.Reflection;
using SmartSchool.API.Context;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;

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

            #region CONTROLLES
            // Adicionar as controllers ao servi�o
            // Ir� ignorar o loop infinito dos relacionamento dos modelos
            services.AddControllers()
                    .AddNewtonsoftJson(
                        opt => opt.SerializerSettings.ReferenceLoopHandling =
                            Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            #endregion

            #region AUTO MAPPER
            // Adicionar pacote AutoMapper ao servi�o
            // Fazer o mapeamento entre os Dtos e os Dominios
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            #endregion

            #region INJE��O DE DEPEND�NCIA
            //Injetar o repository dentro das controllers com obstra��o do contexto por meio da interface.
            services.AddScoped<IBaseRepository, BaseRepository>();
            #endregion

            #region SWAGGER

            //services.AddSwaggerGen(options =>
            //{
            //    options.SwaggerDoc(
            //            "SmartSchoolAPI",
            //            new Microsoft.OpenApi.Models.OpenApiInfo()
            //            {
            //                Title = "SmartSchool API", //Titulo
            //                Version = "1.0"
            //            });
            //});

            //Adicionando Versionamento da API ao servi�o(Configura��es de vers�o de API)
            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true; // Substituir o numero da vers�o na URL

            }).AddApiVersioning(options =>
            {
                // Vers�o padr�o quando n�o definida
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.ReportApiVersions = true;
            });


            //Deixar as vers�es de API din�micas
           var apiProviderDescription = services.BuildServiceProvider().GetService<IApiVersionDescriptionProvider>();

            services.AddSwaggerGen(options =>
            {
                // Deixar a rota da api versionavel:
                foreach (var description in apiProviderDescription.ApiVersionDescriptions)
                {

                    // Documenta��o Open Id
                    options.SwaggerDoc(
                        description.GroupName,

                        new Microsoft.OpenApi.Models.OpenApiInfo()
                        {
                            // Configura��es:
                            Title = "SmartSchool API",
                            Version = description.ApiVersion.ToString(),
                            TermsOfService = new Uri("http://SeusTermosDeUso.com"), // Colocar o termo de uso do seu site
                            Description = "A descri��o da WebAPI do SmartSchool",
                            License = new Microsoft.OpenApi.Models.OpenApiLicense
                            {
                                Name = "SmartSchool License",
                                Url = new Uri("http://mit.com") // Url da sua api, tem que ser uma url v�lida se n�o d� erro.
                            },

                            Contact = new Microsoft.OpenApi.Models.OpenApiContact
                            {
                                // Contato da Empresa
                                Name = "Cristiano Campos de Souza",
                                Email = "cristiano.souzac@hotmail.com.br",
                                Url = new Uri("https://www.linkedin.com/in/cristiano-s1/")

                            }
                        });

                }

                // Configura��o para aparecer os coment�rios xml das controllers no Swagger
                // Criar arquivo xml do Assembly
                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

                // Passando o endere�o onde vai pegar o arquivo xml gerado (Vai ser criado no diret�rio base)
                var xmlCommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                // Passando para options
                options.IncludeXmlComments(xmlCommentsFullPath);
            });

            #endregion
        }

        // Use este m�todo para configurar o pipeline de solicita��o HTTP.
        // Passar como paremetro 'apiProviderDescription' para configurar versionamento da api
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IApiVersionDescriptionProvider apiProviderDescription)
        {
            //Se estiver no ambiente de desenvolvimento e aparecer um erro mostra uma Exception na pagina
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            #region SWAGGER

            //app.UseSwagger()

            //   // Configurando url para do Swagger (localhost:61091/index.html)
            //   .UseSwaggerUI(options =>
            //   {
            //       options.SwaggerEndpoint($"/swagger/SmartSchoolAPI/swagger.json", "SmartSchoolAPI");

            //       options.RoutePrefix = "";
            //   });

            app.UseSwagger()
               // Configurando url para do Swagger (localhost:61091/index.html)
               .UseSwaggerUI(options =>
               {
                   // Deixar rota da api versionavel
                   foreach (var description in apiProviderDescription.ApiVersionDescriptions)
                   {
                       options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json", description.GroupName.ToLowerInvariant());
                   }

                   options.RoutePrefix = "";
               });

            #endregion

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
