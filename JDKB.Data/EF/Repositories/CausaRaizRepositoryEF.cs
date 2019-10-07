using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Data.EF.Repositories
{
    public class CausaRaizRepositoryEF : RepositoryEF<CausaRaiz>, ICausaRaizRepository
    {
        public CausaRaizRepositoryEF(JDDataContext ctx) 
            : base(ctx)
        {
        }
    }
}
