using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using mindstep.contas.app.Application.Queries;
using EstartandoDevsCore.Mediator;
using mindstep.api.InputModels;
using EstartandoDevsCore.Ultilities;
using mindstep.contas.app.Application.Commands;

namespace mindstep.api.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioQueries _usuarioQueries;
        private readonly IMediatorHandler _mediatorHandler;
        private readonly UserManager<IdentityUser> _userManager;

        public UsuarioController(
            IMediatorHandler mediatorHandler,
            IUsuarioQueries usuarioQueries,
            UserManager<IdentityUser> userManager)
        {
            _mediatorHandler = mediatorHandler;
            _usuarioQueries = usuarioQueries;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var usuarios = await _usuarioQueries.ObterTodos();
            return CustomResponse(usuarios);
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(UsuarioInputModel model)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var dataDeNascimento = model.DataNascimento.ConverterParaData();
            if (dataDeNascimento is null)
            {
                AdicionarErro("Data de nascimento inválida!");
                return CustomResponse();
            }

            var user = new IdentityUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.Email,
                NormalizedUserName = model.Email.ToUpper(),
                Email = model.Email,
                NormalizedEmail = model.Email.ToUpper(),
                EmailConfirmed = true
            };

            var identidadeCriada = await _userManager.CreateAsync(user, model.Senha);
            if (!identidadeCriada.Succeeded)
            {
                foreach (var erro in identidadeCriada.Errors)
                    AdicionarErro(erro.Description);

                return CustomResponse();
            }

            var comando = new AdicionarUsuarioCommand(
                model.Nome, model.Email, model.Senha, dataDeNascimento.Value, model.Formacao,
                model.Foto
            );

            var result = await _mediatorHandler.EnviarComando(comando);
            return CustomResponse(result);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> Atualizar(Guid id, AtualizarUsuarioInputModel model)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var dataDeNascimento = model.DataNascimento.ConverterParaData();
            if (dataDeNascimento is null)
            {
                AdicionarErro("Data de nascimento inválida!");
                return CustomResponse();
            }

            var comando = new AtualizarUsuarioCommand(
                id, model.Nome,  model.Foto, model.Formacao,  dataDeNascimento!.Value
            );

            var result = await _mediatorHandler.EnviarComando(comando);
            return CustomResponse(result);
        }

        // Métodos auxiliares
        private IActionResult CustomResponse(object result = null)
        {
            if (result == null) return BadRequest(new { Errors = ModelState.Values.SelectMany(e => e.Errors).Select(e => e.ErrorMessage) });
            return Ok(result);
        }

        private void AdicionarErro(string mensagem)
        {
            ModelState.AddModelError(string.Empty, mensagem);
        }
    }
}
