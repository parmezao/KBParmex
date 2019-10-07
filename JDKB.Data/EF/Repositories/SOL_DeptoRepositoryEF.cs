using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Data.EF.Repositories
{
    public class SOL_DeptoRepositoryEF : RepositoryEF<SOL_Depto>, ISOL_DeptoRepository
    {
        public SOL_DeptoRepositoryEF(JDDataContext ctx) 
            : base(ctx)
        {
        }
    }
}
