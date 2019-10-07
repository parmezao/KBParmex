using System;
using System.Collections.Generic;

namespace JDKB.TestConsole
{
    public partial class TbjkbResumo
    {
        public decimal IdKb { get; set; }
        public decimal SqVersao { get; set; }
        public decimal DhRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }
        public string TpVisualizacao { get; set; }
        public string DsTitulo { get; set; }
        public string TxResumo { get; set; }

        public virtual TbjkbBaseConhecimento IdKbNavigation { get; set; }
        public virtual TbjkbUsuario IdUsuarioRegistroNavigation { get; set; }
        public virtual TbjkbTipoVisualizacao TpVisualizacaoNavigation { get; set; }
    }
}