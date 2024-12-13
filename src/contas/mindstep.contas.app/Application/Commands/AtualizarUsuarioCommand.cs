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
        public int Celular { get; private set; }
        public string Formacao { get; private set; }
        public string Foto { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public AtualizarUsuarioCommand(Guid usuarioId, string mome, int celular, string formacao, string foto, DateTime datanascimento)
        {
            UsuarioId = usuarioId;
            Nome = mome;
            Celular = celular;
            Formacao = formacao;
            Foto = foto;
            DataNascimento = datanascimento;
        }
    }
}