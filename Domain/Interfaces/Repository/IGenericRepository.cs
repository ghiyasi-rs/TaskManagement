

using Domain.Error;

namespace Domain.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int Id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllByIdAsync(int Id);
        Task<ServiceResult<bool>> AddAsync(T entity);
        Task<ServiceResult<bool>> UpdateAsync(T entity);
        Task<ServiceResult<bool>> DeleteAsync(int Id);
    }
}
