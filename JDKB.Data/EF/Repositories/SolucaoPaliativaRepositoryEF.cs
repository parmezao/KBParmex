using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Data.EF.Repositories
{
    public class SolucaoPaliativaRepositoryEF : RepositoryEF<SolucaoPaliativa>, ISolucaoPaliativaRepository
    {
        public SolucaoPaliativaRepositoryEF(JDDataContext ctx)
            : base(ctx)
        {
        }
    }
}
