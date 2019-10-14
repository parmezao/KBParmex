using JDKB.Domain.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDKB.UI.Models
{
    public class AnexoVM
    {
        public IFormFile Anexo { get; set; }

        public List<IFormFile> Anexos { get; set; }
    }
}
