using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class BuscaChave : Entity
    {
        public decimal Id { get; set; }

        public decimal IdPalavra { get; set; }

        public decimal DhRegistro { get; set; } = Convert.ToDecimal(DateTime.Now.ToString("yyyyMMddHHmmss"));

        //public string MatRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }

        public string Tags { get; set; }

        public virtual BaseConhecimento BaseConhecimento { get; set; }

        public virtual PalavraChave PalavraChave { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
