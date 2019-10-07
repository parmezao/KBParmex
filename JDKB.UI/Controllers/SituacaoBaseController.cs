using JDKB.Domain.Contracts.Data;
using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using JDKB.Helpers;
using JDKB.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace JDKB.UI.Controllers
{
    public class SituacaoBaseController : Controller
    {
        private readonly ISituacaoBaseRepository _situacaobaseRepo;
        private readonly IUnityOfWork _uow;

        public SituacaoBaseController(ISituacaoBaseRepository situacaobaseRepo, IUnityOfWork uow)
        {
            _situacaobaseRepo = situacaobaseRepo;
            _uow = uow;
        }

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.Title = "Situação Base";

            ViewData["CurrentSort"] = sortOrder;
            ViewData["SituacaoBaseSortParm"] = String.IsNullOrEmpty(sortOrder) ? "situacao_base" : "";
            ViewData["DescSituacaoBaseSortParm"] = sortOrder == "Situacao" ? "situacaobase_desc" : "Situacao";

            if (searchString != null)
                pageNumber = 1;
            else
                searchString = currentFilter;

            ViewData["CurrentFilter"] = searchString;

            var sitbase = await _situacaobaseRepo.GetAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                sitbase = sitbase.Where(s => s.Situacao.ToUpper().Contains(searchString.ToUpper())
                    || s.Descricao.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "situacao_base":
                    sitbase = sitbase.OrderByDescending(s => s.Situacao);
                    break;
                case "Situacao":
                    sitbase = sitbase.OrderBy(s => s.Descricao);
                    break;
                case "situacaobase_desc":
                    sitbase = sitbase.OrderByDescending(s => s.Descricao);
                    break;
                default:
                    sitbase = sitbase.OrderBy(s => s.Descricao);
                    break;
            }

            int pageSize = 20; // Número de registros por Página

            return View(PaginatedList<SituacaoBase>.Create(sitbase.AsQueryable(), pageNumber ?? 1, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(string id)
        {
            ViewBag.IsEditing = "N";
            var title = "Adicionar";

            SituacaoBaseAddEditVM model = null;

            if (!String.IsNullOrEmpty(id))
            {
                var data = await _situacaobaseRepo.GetAsync(id);
                if (data == null) return NotFound();

                model = data.ToVM();
                title = "Editar";
                ViewBag.IsEditing = "S";
            }

            ViewBag.Title = $"{title} Situação Base";

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(string id, SituacaoBaseAddEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = model.ToData();

            if (String.IsNullOrEmpty(id))
            {
                _situacaobaseRepo.Add(data);
            }
            else
            {
                _situacaobaseRepo.Update(data);
            }

            await _uow.CommitAsync();

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir(string id)
        {
            var sitbase = await _situacaobaseRepo.GetAsync(id);

            if (sitbase == null) return BadRequest();

            _situacaobaseRepo.Remove(sitbase);

            await _uow.CommitAsync();

            return Ok();
        }

    }
}