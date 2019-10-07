using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbBaseConhecimento
    {
        public TbjkbBaseConhecimento()
        {
            TbjkbBaseProduto = new HashSet<TbjkbBaseProduto>();
            TbjkbBuscaChave = new HashSet<TbjkbBuscaChave>();
            TbjkbCausaRaiz = new HashSet<TbjkbCausaRaiz>();
            TbjkbResumo = new HashSet<TbjkbResumo>();
            TbjkbSolucaoPaliativa = new HashSet<TbjkbSolucaoPaliativa>();
        }

        public decimal IdKb { get; set; }
        public decimal DhRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }
        public string TpVisualizacao { get; set; }
        public string StBase { get; set; }

        public virtual TbjkbUsuario IdUsuarioRegistroNavigation { get; set; }
        public virtual TbjkbSituacaoBase StBaseNavigation { get; set; }
        public virtual TbjkbTipoVisualizacao TpVisualizacaoNavigation { get; set; }
        public virtual ICollection<TbjkbBaseProduto> TbjkbBaseProduto { get; set; }
        public virtual ICollection<TbjkbBuscaChave> TbjkbBuscaChave { get; set; }
        public virtual ICollection<TbjkbCausaRaiz> TbjkbCausaRaiz { get; set; }
        public virtual ICollection<TbjkbResumo> TbjkbResumo { get; set; }
        public virtual ICollection<TbjkbSolucaoPaliativa> TbjkbSolucaoPaliativa { get; set; }
    }
}