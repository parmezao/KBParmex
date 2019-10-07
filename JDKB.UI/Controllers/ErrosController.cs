using JDKB.Domain.Contracts.Data;
using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace JDKB.UI.Controllers
{
    public class ErrosController : Controller
    {
        private readonly INPC_ErroRepository _erroRepo;
        private readonly IUnityOfWork _uow;

        public ErrosController(INPC_ErroRepository erroRepo, IUnityOfWork uow)
        {
            _erroRepo = erroRepo;
            _uow = uow;
        }

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.Title = "NPC Erros";

            ViewData["CurrentSort"] = sortOrder;
            ViewData["CodErroSortParm"] = String.IsNullOrEmpty(sortOrder) ? "cod_erro" : "";
            ViewData["DescErroSortParm"] = sortOrder == "Erro" ? "erro_desc" : "Erro";

            if (searchString != null)
                pageNumber = 1;
            else
                searchString = currentFilter;

            ViewData["CurrentFilter"] = searchString;

            var data = await _erroRepo.GetAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                data = data.Where(s => s.CD_ERRO.ToUpper().Contains(searchString.ToUpper())
                    || s.DSC_ERRO.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "cod_erro":
                    data = data.OrderByDescending(s => s.CD_ERRO);
                    break;
                case "Erro":
                    data = data.OrderBy(s => s.DSC_ERRO);
                    break;
                case "erro_desc":
                    data = data.OrderByDescending(s => s.DSC_ERRO);
                    break;
                default:
                    data = data.OrderBy(s => s.CD_ERRO);
                    break;
            }

            int pageSize = 20; // Número de registros por Página

            return View(PaginatedList<NPC_Erro>.Create(data.AsQueryable(), pageNumber ?? 1, pageSize));
        }

    }
}