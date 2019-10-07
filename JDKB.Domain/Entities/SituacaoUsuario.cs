using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class SituacaoUsuario : Entity
    {
        public SituacaoUsuario()
        {
            Usuario = new HashSet<Usuario>();
        }

        public string StUsuario { get; set; }

        public string Descricao { get; set; }

        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
