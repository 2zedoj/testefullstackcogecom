using API_Cadastro.Context;
using API_Cadastro.Models.Entity;
using API_Cadastro.Views.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Cadastro.Views.Repository
{
    public class UnidadeConsumidorRepository : IUnidadeConsumidoraRepository
    {
        private readonly IRoundTheCodeEfCoreDbContext _roundTheCodeEfCoreDbContext;
        public UnidadeConsumidorRepository(IRoundTheCodeEfCoreDbContext roundTheCodeEfCoreDbContext)
        {
            _roundTheCodeEfCoreDbContext = roundTheCodeEfCoreDbContext;

        }
        public async Task<UnidadeConsumidora> Create(UnidadeConsumidora entity)
        {
            await _roundTheCodeEfCoreDbContext.unidadeConsumidoras.AddAsync(entity);
            await _roundTheCodeEfCoreDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            UnidadeConsumidora UnidadeConsumidoraById = await ReadById(id);

            if (UnidadeConsumidoraById == null) throw new Exception($"Unidade Consumidora: {id} não foi encontrado");


            _roundTheCodeEfCoreDbContext.unidadeConsumidoras.Remove(UnidadeConsumidoraById);
            await _roundTheCodeEfCoreDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<UnidadeConsumidora>> Read()
        {
            return await _roundTheCodeEfCoreDbContext.unidadeConsumidoras.ToListAsync();
        }

        public async Task<UnidadeConsumidora> ReadById(int id)
        {
            return await _roundTheCodeEfCoreDbContext.unidadeConsumidoras.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UnidadeConsumidora> Update(UnidadeConsumidora entity, int id)
        {
            UnidadeConsumidora UnidadeConsumidoraById = await ReadById(id);

            if (UnidadeConsumidoraById == null) throw new Exception($"Endereco: {UnidadeConsumidoraById.Codigo} não foi encontrado");

            UnidadeConsumidoraById.Codigo = entity.Codigo;
            UnidadeConsumidoraById.Concessionaria = entity.Concessionaria;
            UnidadeConsumidoraById.Ativo = entity.Ativo;
            UnidadeConsumidoraById.UF = entity.UF;
            UnidadeConsumidoraById.CooperadoId = entity.UF;
            UnidadeConsumidoraById.EnderecoId = entity.EnderecoId;

            _roundTheCodeEfCoreDbContext.unidadeConsumidoras.Update(UnidadeConsumidoraById);
            await _roundTheCodeEfCoreDbContext.SaveChangesAsync();

            return UnidadeConsumidoraById;

        }
    }
}
