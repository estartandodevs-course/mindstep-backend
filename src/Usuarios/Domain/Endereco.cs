using Usuarios.Core.ValueObjects;

namespace Usuarios.Domain;

public class Endereco{
        public string Cidade {get; private set;}
        public string Estado {get; private set;}

        protected Endereco (){}

        public Endereco(string cidade, string estado)
        {
            Cidade = cidade;
            Estado = estado;
        }
}
