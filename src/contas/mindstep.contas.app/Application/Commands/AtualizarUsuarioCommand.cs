using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstartandoDevsCore.Messages;

namespace mindstep.contas.app.Application.Commands
{
    public class AtualizarUsuarioCommand : Command
    {
        public Guid UsuarioId { get; private set; }
        public string Nome { get; private set; }
        public string Formacao { get; private set; }
        public string Foto { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public AtualizarUsuarioCommand(Guid usuarioId, string mome, string formacao, string foto, DateTime DataNascimento)
        {
            UsuarioId = usuarioId;
            Nome = mome;
            Formacao = formacao;
            Foto = foto;
            DataNascimento = DataNascimento;
        }
    }
}