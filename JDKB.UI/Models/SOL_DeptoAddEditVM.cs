using JDKB.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JDKB.UI.Models
{
    public class SOL_DeptoAddEditVM
    {
        [DisplayName("Departamento")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CodDepto { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string DescDepto { get; set; }
    }

    public static class SOL_DeptoModelExtensions
    {

        public static SOL_DeptoAddEditVM ToVM(this SOL_Depto data)
        {
            return new SOL_DeptoAddEditVM
            {
                CodDepto = data.COD_DEPTO,
                DescDepto = data.DS_DEPTO
            };
        }

        public static SOL_Depto ToData(this SOL_DeptoAddEditVM model)
        {
            return new SOL_Depto
            {
                COD_DEPTO = model.CodDepto,
                DS_DEPTO = model.DescDepto
            };
        }
    }
}
