using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstartandoDevsCore.Messages;
using mindstep.contas.app.domain;
using mindstep.contas.app.domain.Enum;

namespace mindstep.contas.app.Application.Commands
{
    public class AdicionarUsuarioCommand : Command
    {
        public string Nome { get; private set; }
        public Login Login { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int Celular { get; private set; }
        public string Formacao { get; private set; }
        public TipoUsuario TipoUsuario { get; private set; }
        public Neurodivergencia Neurodivergencia { get; private set; }
        public string Foto { get; private set; }

        public AdicionarUsuarioCommand(string nome, Login login, DateTime dataNascimento, int celular, string formacao, TipoUsuario tipoUsuario, Neurodivergencia neurodivergencia, string foto)
        {

            Nome = nome;
            Login = login;
            DataNascimento = dataNascimento;
            Celular = celular;
            Formacao = formacao;
            TipoUsuario = tipoUsuario;
            Neurodivergencia = neurodivergencia;
            Foto = foto;
        }

    }
}