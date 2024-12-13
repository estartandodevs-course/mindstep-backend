using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mindstep.contas.app.Application.ViewModels;
using mindstep.contas.app.domain.Interfaces;

namespace mindstep.contas.app.Application.Queries
{
    public interface IUsuarioQueries
    {
        Task<IEnumerable<UsuarioModel>> ObterTodos();

        Task<UsuarioModel> ObterPorId(Guid Id);
    }


    public class UsuarioQueries : IUsuarioQueries
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioQueries(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioModel> ObterPorId(Guid Id)
        {
            var usuario = await _usuarioRepository.ObterPorId(Id);

            return UsuarioModel.Mapear(usuario);
        }

        public async Task<IEnumerable<UsuarioModel>> ObterTodos()
        {
            var usuarios = await _usuarioRepository.ObterTodos();

            return usuarios.Select(UsuarioModel.Mapear);
        }
    }
}