using EstartandoDevsCore.Messages;
using EstartandoDevsCore.ValueObjects;
using FluentValidation.Results;
using MediatR;
using mindstep.contas.app.domain;
using mindstep.contas.app.domain.Interfaces;

namespace mindstep.contas.app.Application.Commands
{
    public class UsuarioCommandHandler : CommandHandler,
        IRequestHandler<AdicionarUsuarioCommand, ValidationResult>,
        IRequestHandler<AtualizarUsuarioCommand, ValidationResult>,
        IDisposable
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioCommandHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<ValidationResult> Handle(AdicionarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var novo = new Usuario(request.Nome, request.DataNascimento, request.Formacao, request.Foto);

            var login = new Login(new Email(request.Email), new Senha(request.Senha));

            novo.AtribuirLogin(login);

            _usuarioRepository.Adicionar(novo);

            return await PersistirDados(_usuarioRepository.UnitOfWork);
        }

        public async Task<ValidationResult> Handle(AtualizarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = await _usuarioRepository.ObterPorId(request.UsuarioId);
            if (usuario is null)
            {
                AdicionarErro("Usuário não encontrado!");
                return ValidationResult;
            }

            usuario.AtribuirNome(request.Nome);
            usuario.AtribuirFoto(request.Foto);
            usuario.AtribuirDataNascimento(request.DataNascimento);

            _usuarioRepository.Atualizar(usuario);

            var evento = new UsuarioAtualizadoEvent (usuario.Id, usuario.Nome, usuario.Foto);

            usuario.AdicionarEvento(evento);

            return await PersistirDados(_usuarioRepository.UnitOfWork);
        }

        public void Dispose()
        {
            _usuarioRepository.Dispose();
        }
    }

    public  class UsuarioAtualizadoEvent : Event
    {
        public  Guid UsuarioId {get; private set;}
        public  string Nome {get; private set;}
        public  string Foto {get; private set;}

        public UsuarioAtualizadoEvent(Guid usuarioId, string nome, string foto)
        {
            UsuarioId = usuarioId;
            Nome = nome;
            Foto = foto;
        }
    }
}
