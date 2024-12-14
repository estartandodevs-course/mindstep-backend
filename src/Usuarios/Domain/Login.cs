using Usuarios.Core.DomainObjects;
using Usuarios.Core.ValueObjects;

namespace Usuarios.Domain;

public sealed class Login
{
    public Guid Hash { get; private set; }
    public Email Email { get; private set; }
    public Senha Senha { get; private set; }

    protected Login(){}

    public Login(Email email, Senha senha)
    {
        Email = email;
        Senha = senha;
        Hash = new Identidade(Email.Endereco,Senha.Valor);
    }
}