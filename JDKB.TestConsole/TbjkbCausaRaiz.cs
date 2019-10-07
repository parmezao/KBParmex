using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbCausaRaiz
    {
        public decimal IdKb { get; set; }
        public decimal SqVersao { get; set; }
        public decimal DhRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }
        public string TpVisualizacao { get; set; }
        public string TxCausaRaiz { get; set; }

        public virtual TbjkbBaseConhecimento IdKbNavigation { get; set; }
        public virtual TbjkbUsuario IdUsuarioRegistroNavigation { get; set; }
        public virtual TbjkbTipoVisualizacao TpVisualizacaoNavigation { get; set; }
    }
}