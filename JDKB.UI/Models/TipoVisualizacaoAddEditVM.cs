using JDKB.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JDKB.UI.Models
{
    public class TipoVisualizacaoAddEditVM
    {
        [DisplayName("Tipo Visualização")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Tipo { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string DescTipo { get; set; }
    }

    public static class TipoVisualizacaoModelExtensions
    {
        public static TipoVisualizacaoAddEditVM ToVM(this TipoVisualizacao data)
        {
            return new TipoVisualizacaoAddEditVM
            {
                Tipo = data.Tipo,
                DescTipo = data.Descricao
            };
        }

        public static TipoVisualizacao ToData(this TipoVisualizacaoAddEditVM model)
        {
            return new TipoVisualizacao
            {
                Tipo = model.Tipo,
                Descricao = model.DescTipo
            };
        }
    }
}
