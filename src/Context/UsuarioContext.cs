using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mindstep_backend.src.Models;

namespace mindstep_backend.src.Context
{
        public class UsuarioContext : DbContext
        {
            public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
            {
            }

            public DbSet<UsuarioModel> Usuarios { get; set; }
        }
}