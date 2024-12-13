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
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Formacao { get; private set; }
        public string Foto { get; private set; }

        public AdicionarUsuarioCommand(string nome, string email, string senha, DateTime dataNascimento,string formacao, string foto)
        {

            Nome = nome;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
            Formacao = formacao;
            Foto = foto;
        }

    }
}