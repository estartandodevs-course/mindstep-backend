using System;
using EstartandoDevsCore.DomainObjects;

namespace mindstep.contas.app.domain;

public class Usuario : Entity, IAggregateRoot
{
    public string Nome {get; set;}
    public string Email {get; set;}
    public string Senha {get; set;}
    public DateTime DataNascimento {get; set;}
    public string Celular {get; set;}
    public string Estado {get; set;}
    public string Cidade {get; set;}
    public string Formacao {get; set;}
}
