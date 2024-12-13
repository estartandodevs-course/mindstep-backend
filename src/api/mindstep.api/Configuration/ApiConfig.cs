using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace mindstep.api.Configuration
{
    public static  class ApiConfig
    {
        private const string ConexaoBanco = "MindStepConnection";

        public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            services.AddDbContext<UsuarioContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(ConexaoBancoDeDados)));

             services.Configure<ApiBehaviorOptions>(options =>
        {
            options.SuppressModelStateInvalidFilter = true;
        });    
        }

       /*  services.AddCors(options =>
        {
            // options.AddPolicy(PermissoesDeOrigem,
            // policy =>{
            //     policy.WithOrigins("http://www.mindstep.com.br",
            //                        "http://mindstep.com.br");
            // });

            options.AddPolicy(PermissoesDeOrigem,
            builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
        }); */
    }

    public static void UseApiConfiguration(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwaggerConfiguration();
            app.UseSwagger();
            app.UseSwaggerUI();

        }

        app.MapControllers();
        app.UseAuthConfiguration();
        app.UseHttpsRedirection();
    }
}
