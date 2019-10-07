using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class PalavraChave : Entity
    {
        public PalavraChave()
        {
            BuscaChave = new HashSet<BuscaChave>();
        }

        public decimal IdPalavra { get; set; }

        public string Palavra { get; set; }

        //public string MatRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }

        public decimal DhRegistro { get; set; } = Convert.ToDecimal(DateTime.Now.ToString("yyyyMMddHHmmss"));

        //public virtual Responsavel Responsavel { get; set; }
        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<BuscaChave> BuscaChave { get; set; }
    }
}
