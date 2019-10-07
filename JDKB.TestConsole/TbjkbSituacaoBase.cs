using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbSituacaoBase
    {
        public TbjkbSituacaoBase()
        {
            TbjkbBaseConhecimento = new HashSet<TbjkbBaseConhecimento>();
        }

        public string StBase { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TbjkbBaseConhecimento> TbjkbBaseConhecimento { get; set; }
    }
}