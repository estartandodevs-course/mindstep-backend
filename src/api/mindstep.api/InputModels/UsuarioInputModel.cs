using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mindstep.api.InputModels
{
    public class UsuarioInputModel
    {
        [Required(ErrorMessage = "Informe um nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe um login!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe uma formação!")]
        public string Formacao { get; set; }

        [Required(ErrorMessage = "Data de nascimento não deve estar vazia!")]
        [RegularExpression(@"^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$", ErrorMessage = "Data de nascimento invalida")]
        public string DataNascimento { get; set; }

        public string Foto { get; set; }

        [Required(AllowEmptyStrings = true)]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido...")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe uma senha!")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Informe um celular!")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Informe um tipo de usuario!")]
        public string TipoUsuario { get; set; }

        [Required(ErrorMessage = "Informe uma neurodivergencia!")]
        public string Neurodivergencia { get; set; }
    }

    public class AtualizarUsuarioInputModel
    {
        [Required(ErrorMessage = "Informe um nome!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Data de nascimento não deve estar vazia!")]
        [RegularExpression(@"^(((0[1-9]|[12]\d|3[01])\/(0[13578]|1[02])\/((19|[2-9]\d)\d{2}))|((0[1-9]|[12]\d|30)\/(0[13456789]|1[012])\/((19|[2-9]\d)\d{2}))|((0[1-9]|1\d|2[0-8])\/02\/((19|[2-9]\d)\d{2}))|(29\/02\/((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))))$", ErrorMessage = "Data de nascimento invalida")]
        public string DataNascimento { get; set; }

        public string Foto { get; set; }

        public string Formacao { get; set; }
    }
}