using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstartandoDevsCore.ValueObjects;

namespace mindstep.contas.app.domain
{
    public class Endereco
    {
        public string Cidade {get; private set;}
        public string Estado {get; private set;}

        protected Endereco (){}

        public Endereco(string cidade, string estado)
        {
            Cidade = cidade;
            Estado = estado;
        }
    }
}