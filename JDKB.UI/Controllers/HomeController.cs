using JDKB.Domain.Contracts.Data;
using JDKB.Domain.Contracts.Repositories;
using JDKB.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;

namespace JDKB.UI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly JDDataContext _ctx;

        private readonly INPC_SituacaoRepository _situacaoRepo;
        private readonly IUnityOfWork _uow;

        //public HomeController(JDDataContext ctx)
        //{
        //    _ctx = ctx;
        //}

        public HomeController(INPC_SituacaoRepository situacaoRepo, IUnityOfWork uow)
        {
            _situacaoRepo = situacaoRepo;
            _uow = uow;
        }

        //public async Task<IActionResult> Index() => View(await _situacaoRepo.GetAsync());
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(NPC_SituacaoAddVM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var data = model.ToData();

            _situacaoRepo.Add(data);
            await _uow.CommitAsync();

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
