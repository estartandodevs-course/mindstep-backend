using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstartandoDevsCore.ValueObjects;

namespace mindstep.contas.app.domain
{
    public class Endereco
    {
        public string Logradouro {get; private set;}
        public string Numero {get; private set;}    
        public string Complemento {get; private set;}
        public Cep Cep {get; private set;}
        public string Bairro {get; private set;}
        public string Cidade {get; private set;}
        public string Estado {get; private set;}

        protected Endereco (){}

        public Endereco(string logradouro, string numero, string complemento, Cep cep, string bairro, string cidade, string estado)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}