using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JDKB.Domain.Contracts.Data
{
    public interface IUnityOfWork
    {
        Task CommitAsync();
        Task RollBackAsync();
    }
}
