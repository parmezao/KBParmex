using JDKB.Domain.Contracts.Data;
using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using JDKB.Helpers;
using JDKB.UI.Models;
using JDKB.UI.Models.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JDKB.UI.Controllers
{
    public class BaseConhecimentoController : Controller
    {
        private readonly IBaseConhecimentoRepository _baseconhecimentoRepo;
        private readonly ITipoVisualizacaoRepository _tipovisualizacaoRepo;
        private readonly ISituacaoBaseRepository _situacaobaseRepo;
        private readonly IProdutoRepository _produtoRepo;
        private readonly IBuscaChaveRepository _buscachaveRepo;
        private readonly IPalavraChaveRepository _palavrachaveRepo;
        private readonly ILogger<BaseConhecimentoController> _logger;
        private readonly IUnityOfWork _uow;

        public BaseConhecimentoController(IBaseConhecimentoRepository baseconhecimentoRepo,
            ITipoVisualizacaoRepository tipovisualizacaoRepo,
            ISituacaoBaseRepository situacaobaseRepo,
            IProdutoRepository produtoRepo,
            IBuscaChaveRepository buscachaveRepo,
            IPalavraChaveRepository palavrachaveRepo,
            ILogger<BaseConhecimentoController> logger,
            IUnityOfWork uow)
        {
            _baseconhecimentoRepo = baseconhecimentoRepo;
            _tipovisualizacaoRepo = tipovisualizacaoRepo;
            _situacaobaseRepo = situacaobaseRepo;
            _produtoRepo = produtoRepo;
            _buscachaveRepo = buscachaveRepo;
            _palavrachaveRepo = palavrachaveRepo;
            _logger = logger;
            _uow = uow;
        }

        public async Task<IActionResult> Index(string currentFilter, string searchString, int? pageNumber)
        {
            try
            {
                ViewBag.Title = "Base de Conhecimento";

                if (searchString != null)
                    pageNumber = 1;
                else
                    searchString = currentFilter;

                ViewData["CurrentFilter"] = searchString;

                var searchArray = new string[] { };
                if (!String.IsNullOrEmpty(searchString))
                {
                    searchArray = searchString.RemoveAccents().KeyWordToArray();
                    searchArray = Array.ConvertAll(searchArray, d => d.ToLower());
                }

                // Verifica se existe usuário logado
                var userId = !string.IsNullOrEmpty(HttpContextHelper.GetAuthUserId(HttpContext)) ? Convert.ToDecimal(HttpContextHelper.GetAuthUserId(HttpContext)) : 0;

                int pageSize = 10; // Número de registros por Página                 

                var data = await _baseconhecimentoRepo.GetWithBaseChildsAsync(searchArray, userId, pageNumber ?? 1, pageSize);

                int total = data.Select(c => c.TotalMath).FirstOrDefault();

                return View(PaginatedList<BaseConhecimento>.Create(data.AsQueryable(), pageNumber ?? 1, pageSize, total));
            }
            catch (Exception e)
            {
                _logger.LogError(99, e, LoggerHelper.GetStringLogError(e.Message), new { });

                ViewBag.CustomError = e.Message;
                return View("CustomError");
            }
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(decimal? id)
        {
            try
            {

                if (!User.Identity.IsAuthenticated && id == null)
                {
                    return RedirectToAction("SignIn", "Auth");
                }

                ViewBag.IsEditing = "N";

                BaseConhecimentoAddEditVM model = null;

                if (id != null)
                {
                    var data = await _baseconhecimentoRepo.GetWithBaseChildsAsync(id);
                    if (data == null) return NotFound();

                    model = data.ToVM();
                    ViewBag.IsEditing = "S";
                }

                await getTipoVisualizacaoSelect();
                await getSituacaoBaseSelect();
                await getProdutosBaseSelect();

                return View(model);

            }
            catch (Exception e)
            {
                _logger.LogError(99, e, LoggerHelper.GetStringLogError(e.Message), new { });

                ViewBag.CustomError = e.Message;
                return View("CustomError");
            }
        }

        private async Task getTipoVisualizacaoSelect()
        {
            var tipovisual = await _tipovisualizacaoRepo.GetAsync();

            ViewBag.TiposDeVisualizacao =
                            tipovisual.Select(c => new SelectListItem
                            {
                                Value = c.Tipo,
                                Text = c.Descricao
                            });
        }

        private async Task getSituacaoBaseSelect()
        {
            var situacao = await _situacaobaseRepo.GetAsync();

            ViewBag.SituacaoDaBase =
                            situacao.Select(c => new SelectListItem
                            {
                                Value = c.Situacao,
                                Text = c.Descricao
                            });
        }

        private async Task getProdutosBaseSelect()
        {
            var produto = await _produtoRepo.GetAsync();

            ViewBag.ProdutoDaBase =
                            produto.Select(c => new SelectListItem
                            {
                                Value = c.IdProduto.ToString(),
                                Text = c.NmProduto
                            });
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddEdit(decimal id, BaseConhecimentoAddEditVM model)
        {
            try
            {
                ModelState.Remove("IdUsuarioRegistro");
                ModelState.Remove("DataHoraRegistro");
                ModelState.Remove("SitBase");

                ViewBag.IsEditing = "N";
                if (id > 0)
                {
                    ModelState.Remove("PalavraChave");
                    ViewBag.IsEditing = "S";
                }

                if (!ModelState.IsValid)
                {
                    await getTipoVisualizacaoSelect();
                    await getSituacaoBaseSelect();
                    await getProdutosBaseSelect();

                    return View(model);
                }

                var userContext = Convert.ToDecimal(HttpContextHelper.GetAuthUserId(HttpContext));

                var data = model.ToData(userContext, id);

                if (id == 0)
                {
                    data.DtHrRegistro = Convert.ToDecimal(DateTime.Now.ToString("yyyyMMddHHmmss"));
                    data.StBase = EnumHelper.SituacaoBase.BA9.ToString();

                    _baseconhecimentoRepo.Add(data);

                    // Palavras Chave existentes
                    var words = model.PalavraChave.KeyWordToArray();

                    // Lista das palavras chave que foram informadas
                    var wordID = new List<decimal>();

                    // Verifica se a Palavra Chave informada já existe na tabela
                    var wordsData = await _palavrachaveRepo.GetAsync();

                    foreach (var word in words)
                    {
                        decimal IdWord = wordsData
                            .Where(c => c.Palavra.ToUpper() == word.ToUpper())
                            .Select(c => c.IdPalavra).FirstOrDefault();

                        if (IdWord == 0)
                        {
                            // Cria a nova palavra chave
                            var plvr = new PalavraChave()
                            {
                                Palavra = word,
                                IdUsuarioRegistro = data.IdUsuarioRegistro
                            };

                            _palavrachaveRepo.Add(plvr);

                            wordID.Add(plvr.IdPalavra);
                        }
                        else
                        {
                            wordID.Add(IdWord);
                        }
                    }

                    // Busca Chave
                    foreach (var word in wordID)
                    {
                        _buscachaveRepo.Add(new BuscaChave()
                        {
                            Id = data.Id,
                            IdPalavra = word,
                            IdUsuarioRegistro = data.IdUsuarioRegistro
                        });
                    }
                }
                else
                {
                    _baseconhecimentoRepo.Update(data);
                }

                await _uow.CommitAsync();

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                _logger.LogError(99, e, LoggerHelper.GetStringLogError(e.Message), new { });

                ViewBag.CustomError = e.Message;
                return View("CustomError");
            }
        }

        public IActionResult About() => View();
    }
}