using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mindstep.api.Configuration
{
    public static class ApiConfig
    {
        private const string ConexaoBanco = "MindStepConnection";

        public static void AddApiConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddControllers();

            services.AddDbContext<UsuarioContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(ConexaoBanco)));

            services.Configure<ApiBehaviorOptions>(options =>
       {
           options.SuppressModelStateInvalidFilter = true;
       });
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
            app.UseHttpsRedirection();
        }
    }
}
