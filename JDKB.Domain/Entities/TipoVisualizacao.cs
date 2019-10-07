using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class TipoVisualizacao : Entity
    {
        public TipoVisualizacao()
        {
            BaseConhecimento = new HashSet<BaseConhecimento>();
            CausaRaiz = new HashSet<CausaRaiz>();
            Resumo = new HashSet<Resumo>();
            SolucaoPaliativa = new HashSet<SolucaoPaliativa>();
        }

        public string Tipo { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<BaseConhecimento> BaseConhecimento { get; set; }

        public virtual ICollection<CausaRaiz> CausaRaiz { get; set; }

        public virtual ICollection<Resumo> Resumo { get; set; }

        public virtual ICollection<SolucaoPaliativa> SolucaoPaliativa { get; set; }
    }
}
