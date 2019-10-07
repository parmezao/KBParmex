using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class BaseProduto : Entity
    {
        public decimal Id { get; set; }

        public decimal IdProduto { get; set; }

        public decimal DtHrRegistro { get; set; } = Convert.ToDecimal(DateTime.Now.ToString("yyyyMMddHHmmss"));

        public decimal IdUsuarioRegistro { get; set; }

        public virtual Produto Produto { get; set; }

        public BaseConhecimento BaseConhecimento { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
