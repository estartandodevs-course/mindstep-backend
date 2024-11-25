using System;
using EstartandoDevsCore.DomainObjects;

namespace mindstep.contas.app.domain;

public class Usuario : Entity, IAggregateRoot
{
    public String Nome { get;  set; }
    public String Email { get; set; }   

    public DateTime DataNascimento { get; set; }
    public int Celular { get; set; }

    public String Estado { get; set; } 

    public String Cidade { get; set; }

    public String Formacao { get; set; }

}
