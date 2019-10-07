using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbTipoVisualizacao
    {
        public TbjkbTipoVisualizacao()
        {
            TbjkbBaseConhecimento = new HashSet<TbjkbBaseConhecimento>();
            TbjkbCausaRaiz = new HashSet<TbjkbCausaRaiz>();
            TbjkbResumo = new HashSet<TbjkbResumo>();
            TbjkbSolucaoPaliativa = new HashSet<TbjkbSolucaoPaliativa>();
        }

        public string TpVisualizacao { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<TbjkbBaseConhecimento> TbjkbBaseConhecimento { get; set; }
        public virtual ICollection<TbjkbCausaRaiz> TbjkbCausaRaiz { get; set; }
        public virtual ICollection<TbjkbResumo> TbjkbResumo { get; set; }
        public virtual ICollection<TbjkbSolucaoPaliativa> TbjkbSolucaoPaliativa { get; set; }
    }
}