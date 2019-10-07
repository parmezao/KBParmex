using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JDKB.Domain.Entities
{
    [Table("TBJDNPC_ERRO")]
    public class NPC_Erro : Entity
    {
        [Key]
        public string CD_ERRO { get; set; }

        public string DSC_ERRO { get; set; }
    }
}
