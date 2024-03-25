using API_Cadastro.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_Cadastro.Infraestrutura.Map
{
    public class CooperadoMap : IEntityTypeConfiguration<Cooperado>
    {
        public void Configure(EntityTypeBuilder<Cooperado> builder)
        {
            builder.ToTable("Cooperado");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(255);
            builder.Property(c => c.Telefone).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Email).IsRequired().HasMaxLength(255);
            builder.Property(c => c.Ativo).IsRequired();
        }
    }
}
