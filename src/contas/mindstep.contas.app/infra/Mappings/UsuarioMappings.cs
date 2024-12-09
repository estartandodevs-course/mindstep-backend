using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using mindstep.contas.app.domain;


namespace mindstep.contas.app.infra.Mappings
{
    public class UsuarioMappings : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("Nome").HasMaxLength(300).IsRequired();
            builder.Property(x => x.TipoUsuario).HasColumnName("TipoUsuario").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Celular).HasColumnName("Celular").HasMaxLength(100);
            builder.Property(x => x.DataNascimento).HasColumnName("DataNascimento").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Formacao).HasColumnName("Formacao").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Foto).HasColumnName("Foto").HasMaxLength(200).IsRequired();
            builder.Property(x => x.Neurodivergencia).HasColumnName("Neurodivergencia").HasMaxLength(100).IsRequired();

            builder.OwnsOne(x => x.Login, login =>
            {
                login.Property(x => x.Hash).HasColumnName("LoginHash");

                login.OwnsOne(x => x.Email, email =>{
                    email.Property(x => x.Endereco).HasMaxLength(500).HasColumnName("Email");
                });

                login.OwnsOne(x => x.Senha, senha =>{
                    senha.Property(x => x.Valor).HasMaxLength(100).HasColumnName("Senha");
                });
            });

            builder.OwnsMany(x => x.Enderecos, endereco =>
            {
                endereco.WithOwner().HasForeignKey("UsuarioId");
                endereco.Property<Guid>("Id").ValueGeneratedOnAdd();
                endereco.HasKey("Id");

                endereco.Property(x => x.Estado).HasMaxLength(100);
                endereco.Property(x => x.Cidade).HasMaxLength(100);
            });
        }
    }
}