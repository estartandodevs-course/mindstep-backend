
using mindstep.contas.app.domain.Enum;

namespace mindstep.contas.app.domain;

public class Neurodivergencia 
{
    public DesafioAprendizado DesafioDeAprendizado{ get; private set; }

    public AtividadesAjudamConcentrar AtividadesAjudamConcentrar { get; private set; }

    public PreferenciaInstrucao PreferenciaInstrucao{ get; private set; }

    public bool PossuiLaudoNeurodivergente { get; private set; }

    public bool JaUsouFerramentasDeApoio { get; private set; }
    public QuaisFerramentasForamUteis QuaisFerramentasForamUteis { get; private set; }
}
