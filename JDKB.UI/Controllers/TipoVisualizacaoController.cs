using JDKB.Domain.Contracts.Data;
using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using JDKB.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JDKB.UI.Controllers
{
    public class TipoVisualizacaoController : Controller
    {
        private readonly ITipoVisualizacaoRepository _tipovisualRepo;
        private readonly IUnityOfWork _uow;

        public TipoVisualizacaoController(ITipoVisualizacaoRepository tipovisualRepo, IUnityOfWork uow)
        {
            _tipovisualRepo = tipovisualRepo;
            _uow = uow;
        }

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.Title = "Tipo Visualização";

            ViewData["CurrentSort"] = sortOrder;
            ViewData["TipoVisualSortParm"] = String.IsNullOrEmpty(sortOrder) ? "tipo_visual" : "";
            ViewData["DescTipoVisualSortParm"] = sortOrder == "Tipo" ? "tipovisual_desc" : "Tipo";

            if (searchString != null)
                pageNumber = 1;
            else
                searchString = currentFilter;

            ViewData["CurrentFilter"] = searchString;

            var tipovisual = await _tipovisualRepo.GetAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                tipovisual = tipovisual.Where(s => s.Tipo.ToUpper().Contains(searchString.ToUpper())
                    || s.Descricao.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "tipo_visual":
                    tipovisual = tipovisual.OrderByDescending(s => s.Tipo);
                    break;
                case "Tipo":
                    tipovisual = tipovisual.OrderBy(s => s.Descricao);
                    break;
                case "tipovisual_desc":
                    tipovisual = tipovisual.OrderByDescending(s => s.Descricao);
                    break;
                default:
                    tipovisual = tipovisual.OrderBy(s => s.Descricao);
                    break;
            }

            int pageSize = 20; // Número de registros por Página

            return View(PaginatedList<TipoVisualizacao>.Create(tipovisual.AsQueryable(), pageNumber ?? 1, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(string id)
        {
            ViewBag.IsEditing = "N";
            var title = "Adicionar";

            TipoVisualizacaoAddEditVM model = null;

            if (!String.IsNullOrEmpty(id))
            {
                var data = await _tipovisualRepo.GetAsync(id);
                if (data == null) return NotFound();

                model = data.ToVM();
                title = "Editar";
                ViewBag.IsEditing = "S";
            }

            ViewBag.Title = $"{title} Tipo Visualização";

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(string id, TipoVisualizacaoAddEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = model.ToData();

            if (String.IsNullOrEmpty(id))
            {
                _tipovisualRepo.Add(data);
            }
            else
            {
                _tipovisualRepo.Update(data);
            }

            await _uow.CommitAsync();

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir(string id)
        {
            var tipovisual = await _tipovisualRepo.GetAsync(id);

            if (tipovisual == null) return BadRequest();

            _tipovisualRepo.Remove(tipovisual);
            await _uow.CommitAsync();

            return Ok();
        }
    }
}