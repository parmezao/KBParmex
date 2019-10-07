using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Data.EF.Repositories
{
    public class EventoRepositoryEF : RepositoryEF<Evento>, IEventoRepository
    {
        public EventoRepositoryEF(JDDataContext ctx)
            : base(ctx)
        {
        }
    }
}
