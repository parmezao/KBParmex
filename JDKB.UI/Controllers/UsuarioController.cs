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
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepo;
        private readonly IUnityOfWork _uow;

        public UsuarioController(IUsuarioRepository usuarioRepo, IUnityOfWork uow)
        {
            _usuarioRepo = usuarioRepo;
            _uow = uow;
        }

        [Authorize]
        public async Task<IActionResult> Index(string sortOrder, string currentFilter, string searchString, int? pageNumber)
        {
            ViewBag.Title = "Usuários";

            ViewData["CurrentSort"] = sortOrder;
            ViewData["UsuarioSortParm"] = String.IsNullOrEmpty(sortOrder) ? "usuariod" : "";
            ViewData["DescUsuarioSortParm"] = sortOrder == "Usuarios" ? "usuario_desc" : "Usuarios";

            if (searchString != null)
                pageNumber = 1;
            else
                searchString = currentFilter;

            ViewData["CurrentFilter"] = searchString;

            var usuario = await _usuarioRepo.GetAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                Func<Usuario, bool> WhereUsuario = u => true;

                WhereUsuario = WhereUsuario.And(u => u.IdUsuario.ToString().Contains(searchString.ToUpper()));
                WhereUsuario = WhereUsuario.Or(u => u.NmUsuario.ToString().ToLower().Contains(searchString.ToLower()));
                WhereUsuario = WhereUsuario.Or(u => u.EmailUsuario.ToString().Contains(searchString.ToUpper()));

                usuario = usuario.Where(WhereUsuario);
            }

            switch (sortOrder)
            {
                case "usuariod":
                    usuario = usuario.OrderByDescending(s => s.IdUsuario);
                    break;
                case "Usuarios":
                    usuario = usuario.OrderBy(s => s.NmUsuario);
                    break;
                case "usuario_desc":
                    usuario = usuario.OrderByDescending(s => s.NmUsuario);
                    break;
                default:
                    usuario = usuario.OrderBy(s => s.NmUsuario);
                    break;
            }

            int pageSize = 20; // Número de registros por Página

            return View(PaginatedList<Usuario>.Create(usuario.AsQueryable(), pageNumber ?? 1, pageSize));
        }

        [HttpGet]
        public async Task<IActionResult> AddEdit(decimal? id)
        {
            if (!User.Identity.IsAuthenticated && id == null)
            {
                return RedirectToAction("SignIn", "Auth");
            }

            ViewBag.IsEditing = "N";
            var title = "Adicionar";

            UsuarioAddEditVM model = null;

            if (id > 0)
            {
                var data = await _usuarioRepo.GetAsync(id);
                if (data == null) return NotFound();

                model = data.ToVM();
                title = "Editar";
                ViewBag.IsEditing = "S";
            }

            ViewBag.Title = $"{title} Usuário";

            return View(model);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddEdit(string id, UsuarioAddEditVM model)
        {
            ModelState.Remove("IdUsuarioRegistro");
            ModelState.Remove("DataHoraRegistro");
            ModelState.Remove("ConfirmaSenha");

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = model.ToData();

            if (String.IsNullOrEmpty(id))
            {
                data.HashSenha = model.Senha.Encrypt();
                data.IdUsuarioRegistro = Convert.ToDecimal(HttpContextHelper.GetAuthUserId(HttpContext));
                data.DhRegistro = Convert.ToDecimal(DateTime.Now.ToString("yyyyMMddHHmmss"));
                data.StUsuario = EnumHelper.SituacaoUsuario.UA9.ToString();

                _usuarioRepo.Add(data);
            }
            else
            {
                _usuarioRepo.Update(data);
            }

            await _uow.CommitAsync();

            return RedirectToAction("Index");
        }

        [HttpDelete]
        public async Task<IActionResult> Excluir(decimal id)
        {
            var usuario = await _usuarioRepo.GetAsync(id);

            if (usuario == null) return BadRequest();

            _usuarioRepo.Remove(usuario);

            await _uow.CommitAsync();

            return Ok();
        }

    }
}