using System;
using EstartandoDevsCore.DomainObjects;

namespace mindstep.contas.app.domain;

public class Usuario : Entity, IAggregateRoot
{
    public Usuario(Login login, DateTime dataNascimento, int celular, string estado, string cidade, string formacao, TipoUsuario tipoUsuario, Neurodivergencia neurodivergencia)
    {
        Login = login;
        DataNascimento = dataNascimento;
        Celular = celular;
        Estado = estado;
        Cidade = cidade;
        Formacao = formacao;
        TipoUsuario = tipoUsuario;
        Neurodivergencia = neurodivergencia;
    }

    private  Usuario()
    {
        
    }

    public Login Login {get; private set;}
    public DateTime DataNascimento { get; private set; }
    public int Celular { get; private set; }
    public string Estado { get; private set; } 
    public string Cidade { get; private set; }
    public string Formacao { get; private set; }
    public TipoUsuario TipoUsuario {get; private set;}
    public Neurodivergencia Neurodivergencia { get; private set; }
}

