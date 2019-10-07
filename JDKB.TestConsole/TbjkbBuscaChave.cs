using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbBuscaChave
    {
        public decimal IdKb { get; set; }
        public decimal IdPalavra { get; set; }
        public decimal DhRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }

        public virtual TbjkbBaseConhecimento IdKbNavigation { get; set; }
        public virtual TbjkbPalavraChave IdPalavraNavigation { get; set; }
        public virtual TbjkbUsuario IdUsuarioRegistroNavigation { get; set; }
    }
}