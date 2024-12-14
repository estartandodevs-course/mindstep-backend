using System;
using EstartandoDevsCore.DomainObjects;
using Mindstep.Usuarios.App.Enum;

namespace Mindstep.;

public class Usuario : Entity, IAggregateRoot
{
    public string Nome { get; private set; }
    public Login Login { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public int Celular { get; private set; }
    public string Formacao { get; private set; }
    public TipoUsuario TipoUsuario { get; private set; }
    public Neurodivergencia Neurodivergencia { get; private set; }
    public string Foto { get; private set; }

    private HashSet<Endereco> _Endereco;

    private HashSet<Login> _Login;

    public IReadOnlyCollection<Endereco> Enderecos => _Endereco;


    private Usuario()
    {
        _Endereco = new HashSet<Endereco>();
        _Login = new HashSet<Login>();
        
    }

    public Usuario(  string nome, DateTime dataNascimento, string formacao,string foto)
    {
    
        Nome = nome;
        DataNascimento = dataNascimento;
        Formacao = formacao;
        Foto = foto;
    }

    public Usuario(string nome, DateTime dataNascimento, int celular, string formacao, TipoUsuario tipoUsuario, Neurodivergencia neurodivergencia, string foto)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Celular = celular;
        Formacao = formacao;
        TipoUsuario = tipoUsuario;
        Neurodivergencia = neurodivergencia;
        Foto = foto;
    }

    public void AtribuirNome(string nome) => Nome = nome;
    public void AtribuirLogin(Login login) => Login = login;
    public void AtribuirDataNascimento(DateTime dataNascimento) => DataNascimento = dataNascimento;
    public void AtribuirFoto(string foto) => Foto = foto;
    public void AdicionarEndereco(Endereco endereco) => _Endereco.Add(endereco);
    public void RemoverEndereco(Endereco endereco) => _Endereco.Remove(endereco);

 
}

