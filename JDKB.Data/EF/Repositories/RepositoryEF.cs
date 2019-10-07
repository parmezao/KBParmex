using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDKB.Data.EF.Repositories
{
    public class RepositoryEF<T> : IRepository<T> where T: Entity
    {
        private readonly JDDataContext _ctx;
        protected readonly DbSet<T> _db;

        public RepositoryEF(JDDataContext ctx)
        {
            _ctx = ctx;
            _db = _ctx.Set<T>();            
        }

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await _db.ToListAsync();
        }

        public void Add(T entity)
        {
            _db.Add(entity);
        }

        public async Task<T> GetAsync(object pk)
        {
            return await _db.FindAsync(pk);
        }

        public void Update(T entity)
        {
            _db.Update(entity);
        }

        public void Remove(T entity)
        {
            _db.Remove(entity);
        }
    }
}
