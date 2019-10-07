using JDKB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JDKB.Domain.Contracts.Repositories
{
    public interface IRepository<T> where T: Entity
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);

        Task<IEnumerable<T>> GetAsync();
        Task<T> GetAsync(object pk);
    }
}
