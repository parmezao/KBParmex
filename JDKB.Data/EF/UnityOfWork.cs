using JDKB.Domain.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JDKB.Data.EF
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly JDDataContext _ctx;

        public UnityOfWork(JDDataContext ctx)
        {
            _ctx = ctx;
        }

        public async Task CommitAsync() => await _ctx.SaveChangesAsync();

        public Task RollBackAsync() => null;
    }
}
