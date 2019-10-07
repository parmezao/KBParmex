using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class Resumo : Entity
    {
        public decimal Id { get; set; }

        public decimal SeqVersao { get; set; }

        public decimal DtHrRegistro { get; set; } = Convert.ToDecimal(DateTime.Now.ToString("yyyyMMddHHmmss"));

        //public string MatRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }

        public string TpVisualizacao { get; set; }

        public string DsTitulo { get; set; }

        public string Texto { get; set; }

        public BaseConhecimento BaseConhecimento { get; set; }

        //public virtual Responsavel Responsavel { get; set; }
        public virtual Usuario Usuario { get; set; }

        public virtual TipoVisualizacao TipoVisualizacao { get; set; }

        public override string ToString()
        {
            return this.Texto;
        }
    }
}
