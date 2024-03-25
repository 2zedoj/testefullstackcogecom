using API_Cadastro.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace API_Cadastro.Context
{
    public interface IRoundTheCodeEfCoreDbContext
    {
        DbSet<Cooperado> Cooperados { get; set; }
        DbSet<Endereco> Enderecos { get; set; }
        DbSet<UnidadeConsumidora> unidadeConsumidoras { get; set; }

        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
