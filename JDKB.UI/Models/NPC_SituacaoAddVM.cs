using JDKB.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace JDKB.UI.Models
{
    public class NPC_SituacaoAddVM
    {
        [Display(Name = "Cod. Objeto")]
        public string CD_OBJETO { get; set; }

        [Display(Name = "Cod. Situação")]
        public string CD_SITUACAO { get; set; }

        [Display(Name = "Situação")]
        public string DSC_SITUACAO { get; set; }
    }


    public static class NPC_SituacaoModelExtensions
    {
        public static NPC_Situacao ToData(this NPC_SituacaoAddVM model)
        {
            return new NPC_Situacao
            {
                CD_OBJETO = model.CD_OBJETO,
                CD_SITUACAO = model.CD_SITUACAO,
                DSC_SITUACAO = model.DSC_SITUACAO
            };
        }
    }
}
