using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbSituacaoUsuario
    {
        public TbjkbSituacaoUsuario()
        {
            TbjkbUsuario = new HashSet<TbjkbUsuario>();
        }

        public string StUsuario { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TbjkbUsuario> TbjkbUsuario { get; set; }
    }
}