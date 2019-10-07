using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class BaseConhecimento : Entity
    {
        public BaseConhecimento()
        {
            CausaRaiz = new HashSet<CausaRaiz>();
            Resumo = new HashSet<Resumo>();
            SolucaoPaliativa = new HashSet<SolucaoPaliativa>();
            BuscaChave = new HashSet<BuscaChave>();
            BaseProduto = new HashSet<BaseProduto>();
        }

        public decimal Id { get; set; }

        public decimal DtHrRegistro { get; set; }

        //public string MatRegistro { get; set; }
        public decimal IdUsuarioRegistro { get; set; }

        public string TpVisualizacao { get; set; }

        public string StBase { get; set; }

        public int TotalMath { get; set; }

        //public virtual Responsavel Responsavel { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual SituacaoBase SituacaoBase { get; set; }

        public virtual TipoVisualizacao TipoVisualizacao { get; set; }

        public virtual ICollection<BaseProduto> BaseProduto { get; set; }

        public virtual ICollection<BuscaChave> BuscaChave { get; set; }

        public virtual ICollection<CausaRaiz> CausaRaiz { get; set; }

        public virtual ICollection<Resumo> Resumo { get; set; }

        public virtual ICollection<SolucaoPaliativa> SolucaoPaliativa { get; set; }        
    }
}
