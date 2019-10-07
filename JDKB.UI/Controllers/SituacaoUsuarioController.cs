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
    public class SituacaoUsuarioController : Controller
    {
        private readonly ISituacaoUsuarioRepository _situacaousuarioRepo;
        private readonly IUnityOfWork _uow;

        public SituacaoUsuarioController(ISituacaoUsuarioRepository situacaousuarioRepo, IUnityOfWork uow)
        {
            _situacaousuarioRepo = situacaousuarioRepo;
            _uow = uow;
        }

        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber, string message)
        {
            ViewBag.Title = "Situação Usuário";

            ViewData["CurrentSort"] = sortOrder;
            ViewData["SituacaoUsuarioSortParm"] = String.IsNullOrEmpty(sortOrder) ? "situacao_usuario" : "";
            ViewData["DescSituacaoUsuarioSortParm"] = sortOrder == "Situacao" ? "situacaousuario_desc" : "Situacao";

            if (searchString != null)
                pageNumber = 1;
            else
                searchString = currentFilter;

            ViewData["CurrentFilter"] = searchString;

            var situsuario = await _situacaousuarioRepo.GetAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                situsuario = situsuario.Where(s => s.StUsuario.ToUpper().Contains(searchString.ToUpper())
                    || s.Descricao.ToUpper().Contains(searchString.ToUpper()));
            }

            switch (sortOrder)
            {
                case "situacao_usuario":
                    situsuario = situsuario.OrderByDescending(s => s.StUsuario);
                    break;
                case "Situacao":
                    situsuario = situsuario.OrderBy(s => s.Descricao);
                    break;
                case "situacaousuario_desc":
                    situsuario = situsuario.OrderByDescending(s => s.Descricao);
                    break;
                default:
                    situsuario = situsuario.OrderBy(s => s.Descricao);
                    break;
            }

            int pageSize = 20; // Número de registros por Página

            if (!string.IsNullOrEmpty(message))
            {
                ViewBag.message = message;
            }

            return View(PaginatedList<SituacaoUsuario>.Create(situsuario.AsQueryable(), pageNumber ?? 1, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(string id)
        {
            ViewBag.IsEditing = "N";
            var title = "Adicionar";

            SituacaoUsuarioAddEditVM model = null;

            if (!String.IsNullOrEmpty(id))
            {
                var data = await _situacaousuarioRepo.GetAsync(id);
                if (data == null) return NotFound();

                model = data.ToVM();
                title = "Editar";
                ViewBag.IsEditing = "S";
            }

            ViewBag.Title = $"{title} Situação Usuário";

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEdit(string id, SituacaoUsuarioAddEditVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = model.ToData();

            if (String.IsNullOrEmpty(id))
            {
                _situacaousuarioRepo.Add(data);
            }
            else
            {
                _situacaousuarioRepo.Update(data);
            }

            await _uow.CommitAsync();

            return RedirectToAction("Index", new { message = "Adicionado com sucesso!" });
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir(string id)
        {
            var sitbase = await _situacaousuarioRepo.GetAsync(id);

            if (sitbase == null) return BadRequest();

            _situacaousuarioRepo.Remove(sitbase);

            await _uow.CommitAsync();

            return Ok();
        }
    }
}