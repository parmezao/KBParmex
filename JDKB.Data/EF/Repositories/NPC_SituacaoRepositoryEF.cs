using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;

namespace JDKB.Data.EF.Repositories
{
    public class NPC_SituacaoRepositoryEF : RepositoryEF<NPC_Situacao>, INPC_SituacaoRepository
    {
        public NPC_SituacaoRepositoryEF(JDDataContext ctx) : base(ctx)
        {
        }
    }
}
