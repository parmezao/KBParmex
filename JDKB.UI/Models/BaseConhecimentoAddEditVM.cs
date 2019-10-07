using JDKB.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace JDKB.UI.Models
{
    public class BaseConhecimentoAddEditVM
    {
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Titulo { get; set; }

        [Display(Name = "Palavra(s) Chave")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string PalavraChave { get; set; }

        [Display(Name = "Produto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Produto { get; set; }

        [Display(Name = "Visibilidade")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string TpVisualizacao { get; set; }

        public string StBase { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string TextoCausaRaiz { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string TextoResumo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string TextoSolucaoPaliativa { get; set; }

        public decimal SeqVersao { get; set; }

        public decimal IdUsuarioRegistro { get; set; }

        public decimal DataHoraRegistro { get; set; }

        public string SitBase { get; set; }
    }

    public static class BaseConhecimentoModelExtensions
    {
        public static BaseConhecimentoAddEditVM ToVM(this BaseConhecimento data)
        {
            var palavras = new List<string>();

            foreach (var chave in data.BuscaChave)
            {
                palavras.Add(chave.PalavraChave.Palavra);
            }

            string palavrasChave = string.Join(", ", palavras);

            return new BaseConhecimentoAddEditVM
            {
                Titulo = data.Resumo.Select(t => t.DsTitulo).FirstOrDefault(),
                Produto = data.BaseProduto.Select(p => p.IdProduto).FirstOrDefault(),
                TpVisualizacao = data.TpVisualizacao,
                StBase = data.StBase,
                TextoCausaRaiz = data.CausaRaiz.Select(c => c.Texto).FirstOrDefault(),
                TextoResumo = data.Resumo.Select(r => r.Texto).FirstOrDefault(),
                TextoSolucaoPaliativa = data.SolucaoPaliativa.Select(s => s.Texto).FirstOrDefault(),
                SeqVersao = data.CausaRaiz.Select(c => c.SeqVersao).FirstOrDefault(),
                PalavraChave = palavrasChave,
                SitBase = data.StBase,
                IdUsuarioRegistro = data.IdUsuarioRegistro,
                DataHoraRegistro = data.DtHrRegistro
            };
        }

        public static BaseConhecimento ToData(this BaseConhecimentoAddEditVM model, decimal IdUsuarioRegistro, decimal id = 0)
        {
            if (id == 0)
                model.IdUsuarioRegistro = IdUsuarioRegistro;

            return new BaseConhecimento
            {
                Id = id,
                IdUsuarioRegistro = model.IdUsuarioRegistro,
                TpVisualizacao = model.TpVisualizacao,
                StBase = model.SitBase,
                DtHrRegistro = model.DataHoraRegistro,

                CausaRaiz = new List<CausaRaiz>()
                {
                    new CausaRaiz
                    {
                        SeqVersao = model.SeqVersao == -1 ? 1 : (model.SeqVersao + 1),
                        IdUsuarioRegistro = model.IdUsuarioRegistro,
                        TpVisualizacao = model.TpVisualizacao,
                        Texto = model.TextoCausaRaiz
                    }
                },

                Resumo = new List<Resumo>()
                {
                    new Resumo
                    {
                        SeqVersao = model.SeqVersao == -1 ? 1 : (model.SeqVersao + 1),
                        IdUsuarioRegistro = model.IdUsuarioRegistro,
                        DsTitulo = model.Titulo,
                        TpVisualizacao = model.TpVisualizacao,
                        Texto = model.TextoResumo
                    }
                },

                SolucaoPaliativa = new List<SolucaoPaliativa>()
                {
                    new SolucaoPaliativa
                    {
                        SeqVersao = model.SeqVersao == -1 ? 1 : (model.SeqVersao + 1),
                        IdUsuarioRegistro = model.IdUsuarioRegistro,
                        TpVisualizacao = model.TpVisualizacao,
                        Texto = model.TextoSolucaoPaliativa
                    }
                },

                BaseProduto = new List<BaseProduto>()
                {
                    new BaseProduto
                    {
                        IdUsuarioRegistro = model.IdUsuarioRegistro,
                        IdProduto = model.Produto,
                        Id = id
                    }
                }

            };
        }
    }
}
