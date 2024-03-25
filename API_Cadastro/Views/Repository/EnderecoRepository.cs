using API_Cadastro.Context;
using API_Cadastro.Models.Entity;
using API_Cadastro.Views.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace API_Cadastro.Views.Repository
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly IRoundTheCodeEfCoreDbContext _roundTheCodeEfCoreDbContext;
        public EnderecoRepository(IRoundTheCodeEfCoreDbContext roundTheCodeEfCoreDbContext)
        {
            _roundTheCodeEfCoreDbContext = roundTheCodeEfCoreDbContext;

        }
        public async Task<Endereco> Create(Endereco entity)
        {
            await _roundTheCodeEfCoreDbContext.Enderecos.AddAsync(entity);
            await _roundTheCodeEfCoreDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> Delete(int id)
        {
            Endereco EnderecoById = await ReadById(id);

            if (EnderecoById == null) throw new Exception($"Endereco: {id} não foi encontrado");


            _roundTheCodeEfCoreDbContext.Enderecos.Remove(EnderecoById);
            await _roundTheCodeEfCoreDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<List<Endereco>> Read()
        {
            return await _roundTheCodeEfCoreDbContext.Enderecos.ToListAsync();
        }

        public async Task<Endereco> ReadById(int id)
        {
            return await _roundTheCodeEfCoreDbContext.Enderecos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Endereco> Update(Endereco entity, int id)
        {
            Endereco EnderecoById = await ReadById(id);

            if (EnderecoById == null) throw new Exception($"Endereco: {entity.Logradouro} não foi encontrado");

            EnderecoById.Logradouro = entity.Logradouro;
            EnderecoById.Bairro = entity.Bairro;
            EnderecoById.Localidade = entity.Localidade;
            EnderecoById.UF = entity.UF;
            EnderecoById.numero = entity.numero;

            _roundTheCodeEfCoreDbContext.Enderecos.Update(EnderecoById);
            await _roundTheCodeEfCoreDbContext.SaveChangesAsync();

            return EnderecoById;

        }
    }
}
