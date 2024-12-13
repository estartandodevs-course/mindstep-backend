using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EstartandoDevsCore.Data;
using Microsoft.EntityFrameworkCore;
using mindstep.contas.app.domain;
using mindstep.contas.app.domain.Interfaces;

namespace mindstep.contas.app.infra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        private readonly UsuarioContext _context;

        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;
        }
        public IUnitOfWorks UnitOfWorks => (IUnitOfWorks)_context;

        public IUnitOfWorks UnitOfWork => throw new NotImplementedException();

        public void Adicionar(Usuario entity)
        {
            _context.Usuarios.Add(entity);
        }

        public void Apagar(Func<Usuario, bool> predicate)
        {
            var usuarios = _context.Usuarios.Where(predicate).ToList();
            _context.Usuarios.RemoveRange(usuarios);
        }

        public void Atualizar(Usuario entity)
        {
            _context.Usuarios.Update(entity);
        }

        public async Task<Usuario> ObterPorId(Guid Id)
        {
            return await _context.Usuarios.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public Task<IEnumerable<Usuario>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}