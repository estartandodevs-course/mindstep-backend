using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstartandoDevsCore.Mediator;
using FluentValidation.Results;
using MediatR;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using mindstep.contas.app.Application.Commands;
using mindstep.contas.app.domain.Interfaces;
using mindstep.contas.app.infra.Repositories;

namespace mindstep.api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices (this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatorHandler>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();


            services.AddScoped<IRequestHandler<AdicionarUsuarioCommand, ValidationResult>, UsuarioCommandHandler>();
            services.AddScoped<IRequestHandler<AtualizarUsuarioCommand, ValidationResult>, UsuarioCommandHandler>();
        }
    }
}