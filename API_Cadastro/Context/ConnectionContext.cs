using API_Cadastro.Infraestrutura.Map;
using API_Cadastro.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Reflection;

namespace API_Cadastro.Context
{
    public class ConnectionContext : DbContext, IRoundTheCodeEfCoreDbContext
    {

        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {

        }

        public DbSet<Cooperado> Cooperados { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<UnidadeConsumidora> unidadeConsumidoras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                Assembly.GetExecutingAssembly()
                );
            modelBuilder.ApplyConfiguration(new CooperadoMap());
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new UnidadeConsumidoraMap());
            base.OnModelCreating(modelBuilder);
        }





    }
}
