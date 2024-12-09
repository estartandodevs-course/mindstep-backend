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

            services.AddDbContext<UsuarioContext>
        }
    }
}