using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using JDKB.Helpers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JDKB.Data.EF.Repositories
{
    public class BaseConhecimentoRepositoryEF : RepositoryEF<BaseConhecimento>, IBaseConhecimentoRepository
    {
        public BaseConhecimentoRepositoryEF(JDDataContext ctx)
            : base(ctx)
        {
        }

        public async Task<IEnumerable<BaseConhecimento>> GetWithBaseChildsAsync(string[] searchArr, decimal idUser, int? pageNumber, int pageSize)
        {
            List<Resumo> resumos = new List<Resumo>();
            List<BuscaChave> tags = new List<BuscaChave>();
            var lsVersion = new List<BaseConhecimento>();            
            IEnumerable<BaseConhecimento> data = null;
            Expression<Func<BaseConhecimento, bool>> WhereVisibilidadeBase = null;
            int totalFound = 0;
            int total = 0;

            // Monta filtro de Tipo de Visualização da Base de Conhecimento
            if (idUser == 0)
            {
                WhereVisibilidadeBase = b => b.TpVisualizacao == EnumHelper.Visibilidade.PUBLICO.ToString();                
            }
            else
            {
                WhereVisibilidadeBase = b => 
                (
                    b.TpVisualizacao != EnumHelper.Visibilidade.PRIVADO.ToString() ||
                   (b.TpVisualizacao == EnumHelper.Visibilidade.PRIVADO.ToString() && b.IdUsuarioRegistro == idUser)   
                );
            }

            if (searchArr.Length > 0)
            {
                data = await _db
                    .Include(c => c.CausaRaiz)
                    .Include(r => r.Resumo)
                    .Include(s => s.SolucaoPaliativa)
                    .Include(s => s.BuscaChave)
                        .ThenInclude(e => e.PalavraChave)
                    .Include(p => p.BaseProduto)
                        .ThenInclude(e => e.Produto)

                    // Filtra a Base de Conhecimento de acordo com a(s) palavra(s) chave informada(s)
                    .Where(d => d.BuscaChave
                        .Where(a => searchArr.Contains(a.PalavraChave.Palavra.RemoveAccents().ToLower())).Any())

                    // Filtra a Base de Conhecimento de acordo com a Visibilidade
                    .Where(WhereVisibilidadeBase)

                    // Filtra Paginação na Base de Dados
                    .Skip(((pageNumber ?? 1) - 1) * pageSize).Take(pageSize)
                    .ToListAsync();

                total = await _db
                    .Where(d => d.BuscaChave
                        .Where(a => searchArr.Contains(a.PalavraChave.Palavra.RemoveAccents().ToLower())).Any())
                    .Where(WhereVisibilidadeBase).CountAsync();

                // Se não encontra, procura no Titulo, Resumo, etc
                if (data.Count() == 0)
                {
                    var WhereResumo = PredicateHelper.False<Resumo>();

                    foreach (var item in searchArr)
                    {
                        WhereResumo = WhereResumo.Or(p => p.DsTituloPuro.ToLower().Contains(item));
                        WhereResumo = WhereResumo.Or(p => p.TextoPuro.Contains(item));
                    }
                    
                    data = await _db
                        .Include(c => c.CausaRaiz)
                        .Include(r => r.Resumo)
                        .Include(s => s.SolucaoPaliativa)
                        .Include(s => s.BuscaChave)
                            .ThenInclude(e => e.PalavraChave)
                        .Include(p => p.BaseProduto)
                            .ThenInclude(e => e.Produto)

                        // Filtra o Titulo e o Resumo de acordo com a(s) palavra(s) chave informada(s)
                        .Where(r => r.Resumo.AsQueryable()                            
                            .Where(WhereResumo).Any())

                        // Filtra a Base de Conhecimento de acordo com a Visibilidade
                        .Where(WhereVisibilidadeBase)

                        // Filtra Paginação na Base de Dados
                        .Skip(((pageNumber ?? 1) - 1) * pageSize).Take(pageSize)
                        .ToListAsync();

                    total = await _db
                        .Where(r => r.Resumo.AsQueryable()
                            .Where(WhereResumo).Any())
                        .Where(WhereVisibilidadeBase).CountAsync();
                }
            }
            else
            {
                data = await _db
                    .Include(c => c.CausaRaiz)
                    .Include(r => r.Resumo)
                    .Include(s => s.SolucaoPaliativa)
                    .Include(s => s.BuscaChave)
                        .ThenInclude(e => e.PalavraChave)
                    .Include(p => p.BaseProduto)
                        .ThenInclude(e => e.Produto)

                    // Filtra a Base de Conhecimento de acordo com a Visibilidade
                    .Where(WhereVisibilidadeBase)

                    // Filtra Paginação na Base de Dados
                    .Skip(((pageNumber ?? 1) - 1) * pageSize).Take(pageSize)
                    .ToListAsync();

                total = await _db.Where(WhereVisibilidadeBase).CountAsync();
            }

            // Adiciona Destaque(Cor Amarela) nas palavras encontradas na busca
            foreach (var item in data)
            {
                AddHighLightWord
                (
                    item.Resumo.Where(d => d.SeqVersao == item.Resumo.Select(y => y.SeqVersao).Max()),
                    item.BuscaChave,
                    searchArr,
                    resumos,
                    tags,
                    out totalFound,
                    searchArr.Length > 0
                );

                lsVersion.Add(

                    new BaseConhecimento
                    {
                        Id = item.Id,
                        DtHrRegistro = item.DtHrRegistro,
                        IdUsuarioRegistro = item.IdUsuarioRegistro,
                        TpVisualizacao = item.TpVisualizacao,
                        StBase = item.StBase,
                        Usuario = item.Usuario,
                        TipoVisualizacao = item.TipoVisualizacao,
                        SituacaoBase = item.SituacaoBase,
                        BuscaChave = tags.Where(c => c.Id == item.Id).ToList(),
                        TotalMath = total, //totalFound,

                        // Filtra a CausaRaiz de maior Versão
                        CausaRaiz = item.CausaRaiz
                            .Where(d => d.SeqVersao == item.CausaRaiz.Select(y => y.SeqVersao).Max()).ToList(),

                        // Filtra o Resumo de maior Versão
                        Resumo = resumos.Where(r => r.Id == item.Id).ToList(),

                        // Filtra a Solução Paliativa de maior Versão
                        SolucaoPaliativa = item.SolucaoPaliativa
                            .Where(d => d.SeqVersao == item.SolucaoPaliativa.Select(y => y.SeqVersao).Max()).ToList(),

                        BaseProduto = item.BaseProduto
                    }
                );
            }

            lsVersion.OrderByDescending(b => b.DtHrRegistro);          

            return lsVersion;
        }

        public async Task<BaseConhecimento> GetWithBaseChildsAsync(object pk)
        {
            var data = await _db
                .Include(c => c.CausaRaiz)
                .Include(r => r.Resumo)
                .Include(s => s.SolucaoPaliativa)
                .Include(p => p.BuscaChave).ThenInclude(e => e.PalavraChave)
                .Include(p => p.BaseProduto).ThenInclude(e => e.Produto)
                .FirstOrDefaultAsync(d => d.Id == Convert.ToDecimal(pk));

            var Version = new BaseConhecimento();

            Version = new BaseConhecimento
            {
                Id = data.Id,
                DtHrRegistro = data.DtHrRegistro,
                IdUsuarioRegistro = data.IdUsuarioRegistro,
                TpVisualizacao = data.TpVisualizacao,
                StBase = data.StBase,
                Usuario = data.Usuario,
                TipoVisualizacao = data.TipoVisualizacao,
                SituacaoBase = data.SituacaoBase,
                BuscaChave = data.BuscaChave,

                // Filtra a CausaRaiz de maior Versão
                CausaRaiz = data.CausaRaiz
                        .Where(d => d.SeqVersao == data.CausaRaiz.Select(y => y.SeqVersao).Max()).ToList(),

                // Filtra o Resumo de maior Versão
                Resumo = data.Resumo
                        .Where(d => d.SeqVersao == data.Resumo.Select(y => y.SeqVersao).Max()).ToList(),

                // Filtra a Solução Paliativa de maior Versão
                SolucaoPaliativa = data.SolucaoPaliativa
                        .Where(d => d.SeqVersao == data.SolucaoPaliativa.Select(y => y.SeqVersao).Max()).ToList(),

                BaseProduto = data.BaseProduto
            };

            return Version;
        }

        private void AddHighLightWord(IEnumerable<Resumo> item, IEnumerable<BuscaChave> buscaChave, string[] values, 
            List<Resumo> modelResult, List<BuscaChave> chaveResult, out int totalFounded, bool IsSearch)
        {
            var conteudo = HtmlRemoval.StripTagsCharArray(item.Select(r => r.Texto).FirstOrDefault());
            var titulo = item.Select(r => r.DsTitulo).FirstOrDefault();
            var tags = "";

            // Palavra(s) Chave
            foreach (var tag in buscaChave)
            {
                tags += tag.PalavraChave.Palavra + ",";
            }
            tags = tags == "" ? "" : tags.Substring(0, tags.Length - 1);

            // Monta conteúdo do Resumo
            if ((values.Length > 0) && (!string.IsNullOrEmpty(values[0])))
            {
                var start = conteudo.IndexOf(values[0], StringComparison.InvariantCultureIgnoreCase);
                start = ((start < 0) ? 0 : start);
                if (start > 100)
                {
                    start -= 60;
                }
                var end = Math.Min(500, conteudo.Length - start);

                conteudo = "<p>" + ((start >= 1) ? "... " : "") + conteudo.Substring(start, end) + ((end < conteudo.Length) ? " ..." : "") + "</p>";
            }
            else
            {
                var end = Math.Min(500, conteudo.Length);
                conteudo = "<p>" + conteudo.Substring(0, end) + ((end < conteudo.Length) ? " ..." : "") + "</p>";
            }

            // Substitui o conteúdo pela(s) palavra(s) chave
            int TotalMath = 0;
            foreach (var value in values)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var valueExpr = value.AddAccents();
                    bool[] isMath = new bool[3] { false, false, false };

                    if (IsSearch)
                    {
                        titulo = titulo.CaseInsenstiveReplace("(" + valueExpr + ")", "<mark>$1</mark>", out isMath[0]);
                    }

                    if (IsSearch)
                    {
                        tags = tags.CaseInsenstiveReplace("(" + valueExpr + "\\b)", "<mark>$1</mark>", out isMath[1]);
                    }

                    if (IsSearch)
                    {
                        conteudo = conteudo.CaseInsenstiveReplace("(" + valueExpr + ")", "<mark>$1</mark>", out isMath[2]);
                    }

                    if (isMath.Where(x => x).Count() > 0)
                    {
                        TotalMath++;
                    }
                }
            }
           
            foreach (var resumo in item)
            {
                modelResult.Add(
                    new Resumo {
                        Id = resumo.Id,
                        DsTitulo = titulo,
                        Texto = conteudo,
                        DtHrRegistro = resumo.DtHrRegistro,
                        IdUsuarioRegistro = resumo.IdUsuarioRegistro,
                        SeqVersao = resumo.SeqVersao,
                        TpVisualizacao = resumo.TpVisualizacao,
                        BaseConhecimento = resumo.BaseConhecimento
                    }
                );
            }

            foreach (var busca in buscaChave)
            {
                chaveResult.Add(
                    new BuscaChave
                    {
                        Id = busca.Id,
                        IdPalavra = busca.IdPalavra,
                        Tags = tags,
                        DhRegistro = busca.DhRegistro,
                        PalavraChave = busca.PalavraChave,
                        IdUsuarioRegistro = busca.IdUsuarioRegistro,
                        BaseConhecimento = busca.BaseConhecimento
                    }
                );
            }

            totalFounded = TotalMath;
        }
    }
}
