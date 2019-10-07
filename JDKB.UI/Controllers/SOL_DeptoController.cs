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
    public class SOL_DeptoController : Controller
    {
        private readonly ISOL_DeptoRepository _deptoRepo;
        private readonly IUnityOfWork _uow;

        public SOL_DeptoController(ISOL_DeptoRepository deptoRepo, IUnityOfWork uow)
        {
            _deptoRepo = deptoRepo;
            _uow = uow;
        }

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.Title = "Departamentos";

            ViewData["CurrentSort"] = sortOrder;
            ViewData["CodDeptoSortParm"] = String.IsNullOrEmpty(sortOrder) ? "cod_depto" : "";
            ViewData["DescDeptoSortParm"] = sortOrder == "Depto" ? "depto_desc" : "Depto";

            if (searchString != null)
                pageNumber = 1;
            else
                searchString = currentFilter;

            ViewData["CurrentFilter"] = searchString;

            var depto = await _deptoRepo.GetAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                depto = depto.Where(s => s.COD_DEPTO.ToUpper().Contains(searchString.ToUpper())
                    || s.DS_DEPTO.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "cod_depto":
                    depto = depto.OrderByDescending(s => s.COD_DEPTO);
                    break;
                case "Depto":
                    depto = depto.OrderBy(s => s.DS_DEPTO);
                    break;
                case "depto_desc":
                    depto = depto.OrderByDescending(s => s.DS_DEPTO);
                    break;
                default:
                    depto = depto.OrderBy(s => s.COD_DEPTO);
                    break;
            }

            int pageSize = 20; // Número de registros por Página

            return View(PaginatedList<SOL_Depto>.Create(depto.AsQueryable(), pageNumber ?? 1, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> Add(string id)
        {
            ViewBag.IsEditing = "N";
            var title = "Adicionar";

            SOL_DeptoAddEditVM model = null;

            if (!String.IsNullOrEmpty(id))
            {
                var data = await _deptoRepo.GetAsync(id);
                if (data == null) return NotFound();

                model = data.ToVM();
                title = "Editar";
                ViewBag.IsEditing = "S";
            }

            ViewBag.Title = $"{title} Departamento";

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Add(string id, SOL_DeptoAddEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = model.ToData();

            if (String.IsNullOrEmpty(id))
            {
                _deptoRepo.Add(data);
            }
            else
            {
                _deptoRepo.Update(data);
            }

            await _uow.CommitAsync();

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir(string id)
        {
            var depto = await _deptoRepo.GetAsync(id);

            if (depto == null) return BadRequest();

            _deptoRepo.Remove(depto);
            await _uow.CommitAsync();

            return Ok();
        }

    }

}