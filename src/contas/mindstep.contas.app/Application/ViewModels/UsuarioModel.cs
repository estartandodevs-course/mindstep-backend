using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using mindstep.contas.app.domain;

namespace mindstep.contas.app.Application.ViewModels
{
    public class UsuarioModel
    {
    public Guid UsuarioId { get; set; }
    public string Nome { get; set; }
    public string DataDeNascimento { get; set; }
    public string Foto { get; set; }

    public static UsuarioModel Mapear(Usuario usuario)
    {
        return new UsuarioModel()
        {
            UsuarioId = usuario.Id,
            Nome = usuario.Nome,
            DataDeNascimento = usuario.DataNascimento.ToString("G",new CultureInfo("pt-Br")),
            Foto = usuario.Foto,
        };
    }
    }
}