using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class SituacaoBase : Entity
    {
        public SituacaoBase()
        {
            BaseConhecimento = new HashSet<BaseConhecimento>();
        }

        public string Situacao { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<BaseConhecimento> BaseConhecimento { get; set; }
    }
}
