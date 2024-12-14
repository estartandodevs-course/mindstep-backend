using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mindstep_backend.src.Models
{
    public class UsuarioModel
    {
        public int Id { get;  private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int Celular { get; private set; }
        public string Formacao { get; private set; }
        public string TipoUsuario { get; private set; }
        public string Neurodivergencia { get; private set; }
        public string Foto { get; private set; }
    }
}