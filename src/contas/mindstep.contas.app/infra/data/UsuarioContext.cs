using System;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using mindstep.contas.app.domain;


public class UsuarioContext : DbContext
{
    public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
    {}

    public DbSet<Usuario> Usuarios {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuario>(entity =>{
            entity.HasKey(x => x.Id);
            entity.Property(u => u.Celular);
            entity.Property(u => u.Enderecos);
            entity.Property(u => u.DataNascimento);
            entity.Property(u => u.TipoUsuario);
            entity.Property(u => u.Notificacoes);
            entity.Property(u => u.Neurodivergencia);
            entity.Property(u => u.Login);
            entity.Property(u => u.Nome);
            entity.Property(u => u.Foto);
            entity.Property(u => u.Formacao);
        });
    }
}