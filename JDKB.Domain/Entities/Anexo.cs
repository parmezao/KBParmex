using System;
using System.Collections.Generic;
using System.Text;

namespace JDKB.Domain.Entities
{
    public class Anexo : Entity
    {
        public int Id { get; set; }
        public string NomeArquivo { get; set; }
        public byte[] Arquivo { get; set; }
    }
}
