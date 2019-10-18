using JDKB.Data.EF;
using JDKB.Domain.Contracts.Data;
using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using JDKB.Helpers;
using JDKB.UI.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace JDKB.UI.Controllers
{
    public class HomeController : Controller
    {
        //private readonly JDDataContext _ctx;

        private readonly INPC_SituacaoRepository _situacaoRepo;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IAnexoRepository _anexoRepo;
        private readonly IUnityOfWork _uow;

        //public HomeController(JDDataContext ctx)
        //{
        //    _ctx = ctx;
        //}

        public HomeController(INPC_SituacaoRepository situacaoRepo, IHostingEnvironment hostingEnvironment, 
            IAnexoRepository anexoRepo, IUnityOfWork uow)
        {
            _situacaoRepo = situacaoRepo;
            _hostingEnvironment = hostingEnvironment;
            _anexoRepo = anexoRepo;
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

        [HttpGet]
        public async Task<IActionResult> Upload()
        {
            var anexos = await _anexoRepo.GetAsync();

            //return new JsonResult(anexos);
            return View(anexos);
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (Request.Form.Files == null || Request.Form.Files.Count == 0)
                return Content("Arquivo não selecionado");

            var anexos = await _anexoRepo.GetAsync();
            int maxId = anexos.DefaultIfEmpty(new Anexo { Id = 0 }).Max(a => a.Id) + 1;
            
            foreach (var item in Request.Form.Files)
            {
                /// Salva o arquivo em memória
                byte[] bytes = new byte[item.Length];

                using (var ms = new MemoryStream(bytes))
                {
                    await item.CopyToAsync(ms);
                    ms.Seek(0, SeekOrigin.Begin);

                    /// Salva em arquivo
                    //var path = Path.Combine("c:\\", "Pessoal\\", file.FileName);
                    //using (var fs = new FileStream(path, FileMode.Create))
                    //{
                    //    await ms.CopyToAsync(fs);
                    //    await fs.FlushAsync();
                    //}

                    /// Salva na Base
                    _anexoRepo.Add(new Anexo
                    {
                        Id = maxId,
                        NomeArquivo = item.FileName,
                        Arquivo = ms.ToArray()
                    });

                    maxId++;
                }
            }

            await _uow.CommitAsync();

            return RedirectToAction("Upload");
        }

        [HttpPost]
        public IActionResult AddImage(List<IFormFile> files)
        {
            //if (files.Count == 0)
            //    return Content("file(s) not selected");

            //List<Anexo> anexos = (List<Anexo>)ViewData["Anexos"];
            //if (anexos == null)
            //{
            //    anexos = new List<Anexo>();
            //    ViewData["Anexos"] = anexos;
            //}

            foreach (var file in Request.Form.Files)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    ms.Seek(0, SeekOrigin.Begin);

                    //anexos.Add(new Anexo
                    //{
                    //    NomeArquivo = file.FileName,
                    //    Arquivo = ms.ToArray()
                    //});

                }
            }

            //IFormFile anexos = model.Anexos; //(List<Anexo>)ViewData["Anexos"];
            //if (anexos == null)
            //{
            //    //anexos = new List<Anexo>();
            //    model.Anexos = anexos; //new IFormFile;
            //    //ViewData["Anexos"] = anexos;
            //}

            //foreach (var file in Request.Form.Files)
            //{

            //using (var ms = new MemoryStream())
            //{
            //    //file.CopyTo(ms);
            //    //ms.Seek(0, SeekOrigin.Begin);                                 

            //}
            //}

            return View("Upload", ViewData);
        }

        [HttpGet]
        public async Task<IActionResult> Download(int id)
        {
            var anexo = await _anexoRepo.GetAsync(id);

            //var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot" + "/UserFiles/files/", filename);

            var memory = new MemoryStream();
            using (var ms = new MemoryStream(anexo.Arquivo))
            {
                await ms.CopyToAsync(memory);
                memory.Seek(0, SeekOrigin.Begin);                
            }
            
            return File(memory, anexo.NomeArquivo.GetMimeType(), Path.GetFileName(anexo.NomeArquivo));
        }

        //private string GetContentType(string path)
        //{
        //    var types = GetMimeTypes();
        //    var ext = Path.GetExtension(path).ToLowerInvariant();

        //    return types[ext];
        //}

        //private Dictionary<string, string> GetMimeTypes()
        //{
        //    return new Dictionary<string, string>
        //    {
        //        {".png", "image/png"},
        //        {".jpg", "image/jpeg"},
        //        {".jpeg", "image/jpeg"},
        //        {".gif", "image/gif"},
        //        {".svg", "image/svg+xml"},
        //        {".xml", "image/svg+xml"},
        //        {".txt", "text/plain"},
        //        {".docx", "text/plain"},
        //        {".doc", "text/plain"}
        //    };
        //}

    }
}
