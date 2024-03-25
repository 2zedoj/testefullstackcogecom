using API_Cadastro.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Cadastro.Infraestrutura.Map
{
    public class UnidadeConsumidoraMap : IEntityTypeConfiguration<UnidadeConsumidora>
    {
        public void Configure(EntityTypeBuilder<UnidadeConsumidora> builder)
        {
            builder.ToTable("UnidadeConsumidora");

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Codigo).IsRequired().HasMaxLength(255);
            builder.Property(c => c.Concessionaria).IsRequired();
            builder.Property(c => c.Ativo).IsRequired();
            builder.Property(c => c.UF).IsRequired().HasMaxLength(2);
            builder.Property(c => c.CooperadoId).IsRequired().HasColumnName("CooperadoId");
            builder.Property(c => c.EnderecoId).IsRequired().HasColumnName("EnderecoId");

        }
    }
}
