using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Data.EF.Repositories
{
    public class BuscaChaveRepositoryEF : RepositoryEF<BuscaChave>, IBuscaChaveRepository
    {
        public BuscaChaveRepositoryEF(JDDataContext ctx) 
            : base(ctx)
        {
        }
    }
}
