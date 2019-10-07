using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class Produto : Entity
    {
        public Produto()
        {
            BaseProduto = new HashSet<BaseProduto>();
        }

        public decimal IdProduto { get; set; }

        public string NmProduto { get; set; }

        public string CdProduto { get; set; }

        public decimal DhRegistro { get; set; }

        public decimal IdUsuarioRegistro { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<BaseProduto> BaseProduto { get; set; }
    }
}
