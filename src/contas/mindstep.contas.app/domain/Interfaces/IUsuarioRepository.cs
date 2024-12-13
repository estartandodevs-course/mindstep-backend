using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstartandoDevsCore.Data;

namespace mindstep.contas.app.domain.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario>, IDisposable
    {
        Task<IEnumerable<Usuario>> ObterTodos();
    }
}