using API_Cadastro.Models.Entity;

namespace API_Cadastro.Views.Repository.Interface
{
    public interface IRepository<T>
    {
        Task<T> Create(T entity);

        Task<List<T>> Read();
        Task<T> ReadById(int id);

        Task<T> Update(T entity, int id);

        Task<bool> Delete(int id);
    }
}
