using EstartandoDevsCore.DomainObjects;
using EstartandoDevsCore.ValueObjects;

namespace mindstep.contas.app.domain;

public sealed class Login
{
    public Guid Hash {get; set;}
    public Email Email{ get; set; }

    public Senha Senha{ get; set; }

    protected Login(){}

    public Login(Email email, Senha senha)
    {
        Email = email;
        Senha = senha;
        Hash = new Identidade(Email.Endereco, Senha.Valor);
    }
}
