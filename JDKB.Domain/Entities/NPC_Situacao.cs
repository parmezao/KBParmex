using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JDKB.Domain.Entities
{
    [Table("TBJDNPC_SITUACAO")]
    public class NPC_Situacao : Entity
    {
        [Key]
        public string CD_OBJETO { get; set; }

        public string CD_SITUACAO { get; set; }

        public string DSC_SITUACAO { get; set; }
    }
}
