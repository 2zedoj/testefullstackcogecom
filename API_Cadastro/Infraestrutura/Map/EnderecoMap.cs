using API_Cadastro.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Cadastro.Infraestrutura.Map
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Logradouro).IsRequired().HasMaxLength(255);
            builder.Property(c => c.Bairro).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Localidade).IsRequired().HasMaxLength(255);
            builder.Property(c => c.UF).IsRequired().HasMaxLength(2);
            builder.Property(c => c.numero).IsRequired();
        }
    }
}
