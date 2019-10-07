using JDKB.Domain.Contracts.Data;
using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using JDKB.Helpers;
using JDKB.UI.Models;
using JDKB.UI.Models.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JDKB.UI.Controllers
{
    [Authorize]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepo;
        private readonly IUnityOfWork _uow;

        public ProdutoController(IProdutoRepository produtoRepo, IUnityOfWork uow)
        {
            _produtoRepo = produtoRepo;
            _uow = uow;
        }

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.Title = "Produtos";

            ViewData["CurrentSort"] = sortOrder;
            ViewData["ProdutoSortParm"] = String.IsNullOrEmpty(sortOrder) ? "produtod" : "";
            ViewData["DescProdutoSortParm"] = sortOrder == "Produtos" ? "produto_desc" : "Produtos";

            if (searchString != null)
                pageNumber = 1;
            else
                searchString = currentFilter;

            ViewData["CurrentFilter"] = searchString;

            var produto = await _produtoRepo.GetAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                produto = produto.Where(s => s.CdProduto.Contains(searchString.ToUpper())
                    || s.NmProduto.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "produtod":
                    produto = produto.OrderByDescending(s => s.CdProduto);
                    break;
                case "Produtos":
                    produto = produto.OrderBy(s => s.NmProduto);
                    break;
                case "produto_desc":
                    produto = produto.OrderByDescending(s => s.NmProduto);
                    break;
                default:
                    produto = produto.OrderBy(s => s.NmProduto);
                    break;
            }

            int pageSize = 20; // Número de registros por Página

            return View(PaginatedList<Produto>.Create(produto.AsQueryable(), pageNumber ?? 1, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(decimal id)
        {
            ViewBag.IsEditing = "N";
            var title = "Adicionar";

            ProdutoAddEditVM model = null;

            if (id != 0)
            {
                var data = await _produtoRepo.GetAsync(id);
                if (data == null) return NotFound();

                model = data.ToVM();
                title = "Editar";
                ViewBag.IsEditing = "S";
            }

            ViewBag.Title = $"{title} Produto";

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(string id, ProdutoAddEditVM model)
        {
            ModelState.Remove("DataHoraRegistro");
            ModelState.Remove("IdUsuarioRegistro");

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = model.ToData();

            if (String.IsNullOrEmpty(id))
            {
                data.IdUsuarioRegistro = Convert.ToDecimal(HttpContextHelper.GetAuthUserId(HttpContext));
                data.DhRegistro = Convert.ToDecimal(DateTime.Now.ToString("yyyyMMddHHmmss"));

                _produtoRepo.Add(data);
            }
            else
            {
                _produtoRepo.Update(data);
            }

            await _uow.CommitAsync();

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir(decimal id)
        {
            var produto = await _produtoRepo.GetAsync(id);

            if (produto == null) return BadRequest();

            _produtoRepo.Remove(produto);

            await _uow.CommitAsync();

            return Ok();
        }
    }
}