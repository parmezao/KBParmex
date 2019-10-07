using JDKB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JDKB.Domain.Contracts.Repositories
{
    public interface IBaseConhecimentoRepository : IRepository<BaseConhecimento>
    {
        Task<IEnumerable<BaseConhecimento>> GetWithBaseChildsAsync(string[] searchArr, decimal idUser, int? pageNumber, int pageSize);
        Task<BaseConhecimento> GetWithBaseChildsAsync(object pk);
    }
}
