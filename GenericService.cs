using LuciaTech.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LuciaTech.Service
{
    public abstract class GenericService<T> : IGenericService<T>
        where T : class, new()
    {
        protected IGenericRepository<T> EntityRepository { get; }
        protected GenericService(IGenericRepository<T> entityRepository)
        {

            EntityRepository = entityRepository;

        }

        public async Task<int> DeleteAsync(T entity)
        {
            return await EntityRepository.DeleteAsync(entity);
        }

        public async Task<int> DeleteRange(List<T> entities)
        {
            return await EntityRepository.DeleteRangeAsync(entities);
        }

        public async Task<ICollection<T>> GetAllAsync()
        {
            return await EntityRepository.Query().ToListAsync();
        }

        //public async Task<ICollection<T>> GetAllAsync()
        //{
        //    return await EntityRepository.Query().ToListAsync();
        //}

        public async Task<T> GetByIdAsync(int id)
        {
            return await EntityRepository.GetAsync(id);
        }

        public async Task<T> InsertAsync(T entity)
        {
            return await EntityRepository.InsertAsync(entity);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            return await EntityRepository.UpdateAsync(entity);
        }

        public async Task<ICollection<T>> UpdateRangeAsync(ICollection<T> entities)
        {
            return await EntityRepository.UpdateRangeAsync(entities);
        }

        public async Task<int> DeleteByIdsRange(ICollection<int> ids)
        {
            return await EntityRepository.DeleteByIdsRangeAsync(ids);
        }

        public async Task<T> GetByIdAsync(string id)
        {

            return await EntityRepository.GetAsync(id);
        }

        public async Task<ICollection<T>> GetByIdsAsync(ICollection<int> ids)
        {
            return await EntityRepository.GetByIdsAsync(ids);
        }

        public async Task<ICollection<T>> GetByIdsAsync(ICollection<string> ids)
        {
            return await EntityRepository.GetByIdsAsync(ids);
        }

        public async Task<ICollection<T>> InsertRangeAsync(ICollection<T> entity)
        {
            return await EntityRepository.InsertRangeAsync(entity);
        }

        public async Task<int> DeleteRangeAsync(ICollection<T> entities)
        {
            return await EntityRepository.DeleteRangeAsync(entities);
        }

        public async Task<int> DeleteByIdsRange(ICollection<string> ids)
        {
            return await EntityRepository.DeleteByIdsRangeAsync(ids);
        }
    }
}
