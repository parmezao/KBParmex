using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbProduto
    {
        public TbjkbProduto()
        {
            TbjkbBaseProduto = new HashSet<TbjkbBaseProduto>();
        }

        public decimal IdProduto { get; set; }
        public string NmProduto { get; set; }
        public string CdProduto { get; set; }
        public decimal DhRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }

        public virtual TbjkbUsuario IdUsuarioRegistroNavigation { get; set; }
        public virtual ICollection<TbjkbBaseProduto> TbjkbBaseProduto { get; set; }
    }
}