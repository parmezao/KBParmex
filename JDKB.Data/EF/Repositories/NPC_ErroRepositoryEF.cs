using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Data.EF.Repositories
{
    public class NPC_ErroRepositoryEF: RepositoryEF<NPC_Erro>, INPC_ErroRepository
    {
        public NPC_ErroRepositoryEF(JDDataContext ctx): base(ctx)
        {
        }
    }
}
