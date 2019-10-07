using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbBaseProduto
    {
        public decimal IdKb { get; set; }
        public decimal IdProduto { get; set; }
        public decimal DhRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }

        public virtual TbjkbBaseConhecimento IdKbNavigation { get; set; }
        public virtual TbjkbProduto IdProdutoNavigation { get; set; }
        public virtual TbjkbUsuario IdUsuarioRegistroNavigation { get; set; }
    }
}