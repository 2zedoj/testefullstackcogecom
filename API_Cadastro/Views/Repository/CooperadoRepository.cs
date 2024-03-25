using API_Cadastro.Context;
using API_Cadastro.Models.Entity;
using API_Cadastro.Views.Repository.Interface;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore;

namespace API_Cadastro.Views.Repository
{
    public class CooperadoRepository : ICooperadoRepository
    {
        private readonly IRoundTheCodeEfCoreDbContext _roundTheCodeEfCoreDbContext;
        public CooperadoRepository(IRoundTheCodeEfCoreDbContext roundTheCodeEfCoreDbContext) 
        {
            _roundTheCodeEfCoreDbContext = roundTheCodeEfCoreDbContext;

        }
        public async Task<Cooperado> Create(Cooperado entity)
        {
            await _roundTheCodeEfCoreDbContext.Cooperados.AddAsync(entity);
            await _roundTheCodeEfCoreDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            Cooperado cooperadoById = await ReadById(id);

            if (cooperadoById == null) throw new Exception($"Cooperado: {id} não foi encontrado");


            _roundTheCodeEfCoreDbContext.Cooperados.Remove(cooperadoById);
            await _roundTheCodeEfCoreDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<Cooperado>> Read()
        {
            return await _roundTheCodeEfCoreDbContext.Cooperados.ToListAsync();
        }

        public async Task<Cooperado> ReadById(int id)
        {
            return await _roundTheCodeEfCoreDbContext.Cooperados.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Cooperado> Update(Cooperado entity, int id)
        {
            Cooperado cooperadoById = await ReadById(id);

            if (cooperadoById == null) throw new Exception($"Cooperado: {entity.Nome} não foi encontrado");

            cooperadoById.Nome = entity.Nome;
            cooperadoById.Email = entity.Email;
            cooperadoById.Telefone = entity.Telefone;
            cooperadoById.Ativo = entity.Ativo;

            _roundTheCodeEfCoreDbContext.Cooperados.Update(cooperadoById);
            await _roundTheCodeEfCoreDbContext.SaveChangesAsync();

            return cooperadoById;

        }
    }
}
