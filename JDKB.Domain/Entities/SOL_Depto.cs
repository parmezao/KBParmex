using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JDKB.Domain.Entities
{
    [Table("TB_DEPTO")]
    public class SOL_Depto : Entity
    {
        [Key]
        public string COD_DEPTO { get; set; }

        public string DS_DEPTO { get; set; }
    }
}
