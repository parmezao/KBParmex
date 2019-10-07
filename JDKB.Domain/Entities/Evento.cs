using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class Evento : Entity
    {
        public Evento()
        {
            Produto = new HashSet<Produto>();
        }

        public string CodEvento { get; set; }

        public string DescEvento { get; set; }

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
