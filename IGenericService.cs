using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LuciaTech.Service
{
    public interface IGenericService<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(string id);
        Task<ICollection<T>> GetByIdsAsync(ICollection<int> ids);
        Task<ICollection<T>> GetByIdsAsync(ICollection<string> ids);
        Task<T> InsertAsync(T entity);
        Task<ICollection<T>> InsertRangeAsync(ICollection<T> entity);
        Task<T> UpdateAsync(T entity);
        Task<int> DeleteAsync(T entity);
        Task<ICollection<T>> UpdateRangeAsync(ICollection<T> entities);
        Task<int> DeleteRangeAsync(ICollection<T> entities);
        Task<int> DeleteByIdsRange(ICollection<int> ids);
        Task<int> DeleteByIdsRange(ICollection<string> ids);
        Task<ICollection<T>> GetAllAsync();
    }
}
