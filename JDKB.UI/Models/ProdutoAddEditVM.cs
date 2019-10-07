using JDKB.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JDKB.UI.Models
{
    public class ProdutoAddEditVM
    {
        public decimal Id { get; set; }

        [DisplayName("Código Produto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string CodProduto { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        public decimal DataHoraRegistro { get; set; }

        public decimal IdUsuarioRegistro { get; set; }
    }

    public static class ProdutoModelExtensions
    {
        public static ProdutoAddEditVM ToVM(this Produto data)
        {
            return new ProdutoAddEditVM
            {
                Id = data.IdProduto,
                CodProduto = data.CdProduto,
                Nome = data.NmProduto,
                DataHoraRegistro = data.DhRegistro,
                IdUsuarioRegistro = data.IdUsuarioRegistro
            };
        }

        public static Produto ToData(this ProdutoAddEditVM model)
        {
            return new Produto
            {
                IdProduto = model.Id,
                CdProduto = model.CodProduto,
                NmProduto = model.Nome,
                DhRegistro = model.DataHoraRegistro,
                IdUsuarioRegistro = model.IdUsuarioRegistro
            };
        }
    }
}
