using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbPalavraChave
    {
        public TbjkbPalavraChave()
        {
            TbjkbBuscaChave = new HashSet<TbjkbBuscaChave>();
        }

        public decimal IdPalavra { get; set; }
        public string Palavra { get; set; }
        public decimal DhRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }

        public virtual TbjkbUsuario IdUsuarioRegistroNavigation { get; set; }
        public virtual ICollection<TbjkbBuscaChave> TbjkbBuscaChave { get; set; }
    }
}