using JDKB.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JDKB.UI.Models
{
    public class SituacaoBaseAddEditVM
    {
        [DisplayName("Situação Base")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Situacao { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string DescSituacao { get; set; }
    }

    public static class SituacaoBaseModelExtensions
    {
        public static SituacaoBaseAddEditVM ToVM(this SituacaoBase data)
        {
            return new SituacaoBaseAddEditVM
            {
                Situacao = data.Situacao,
                DescSituacao = data.Descricao
            };
        }

        public static SituacaoBase ToData(this SituacaoBaseAddEditVM model)
        {
            return new SituacaoBase
            {
                Situacao = model.Situacao,
                Descricao = model.DescSituacao
            };
        }
    }
}
