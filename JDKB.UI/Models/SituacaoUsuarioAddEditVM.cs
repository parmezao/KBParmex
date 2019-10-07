using JDKB.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JDKB.UI.Models
{
    public class SituacaoUsuarioAddEditVM
    {
        [DisplayName("Situação Usuário")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Situacao { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string DescSituacao { get; set; }
    }

    public static class SituacaoUsuarioModelExtensions
    {
        public static SituacaoUsuarioAddEditVM ToVM(this SituacaoUsuario data)
        {
            return new SituacaoUsuarioAddEditVM
            {
                Situacao = data.StUsuario,
                DescSituacao = data.Descricao
            };
        }

        public static SituacaoUsuario ToData(this SituacaoUsuarioAddEditVM model)
        {
            return new SituacaoUsuario
            {
                StUsuario = model.Situacao,
                Descricao = model.DescSituacao
            };
        }
    }
}
