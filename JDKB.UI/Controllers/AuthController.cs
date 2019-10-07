using JDKB.Domain.Contracts;
using JDKB.Domain.Contracts.Data;
using JDKB.Domain.Contracts.Repositories;
using JDKB.Domain.Entities;
using JDKB.Email;
using JDKB.Helpers;
using JDKB.UI.Models;
using log4net;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace JDKB.UI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepo;
        private readonly IUnityOfWork _uow;
        private readonly ICustomAppSettings _credential;
        private readonly ILogger<AuthController> _logger;

        public AuthController(IUsuarioRepository usuarioRepo, ICustomAppSettings credential,
            ILogger<AuthController> logger, IUnityOfWork uow)
        {
            _usuarioRepo = usuarioRepo;
            _uow = uow;
            _credential = credential;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult SignIn() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn(string returnUrl, SignInVM model)
        {
            try
            { 
                var usuario = await _usuarioRepo.AuthenticateAsync(model.Email, model.Senha.Encrypt());

                if (usuario == null)
                {
                    ModelState.AddModelError("", "Email e/ou Senha inválidos");
                    return View(model);
                }

                AddSignIn(usuario, model.Lembrar);

                return LocalRedirect(returnUrl ?? "/");
            }
            catch (Exception e)
            {
                _logger.LogError(99, e, LoggerHelper.GetStringLogError(e.Message), new { });

                ViewBag.CustomError = e.Message;
                return View("CustomError");
            }

        }
        private async void AddSignIn(Usuario usuario, bool lembraSenha = true)
        {
            var claims = new List<Claim>()
            {
                new Claim("id", usuario.IdUsuario.ToString()),
                new Claim("nome", usuario.NmUsuario),
                new Claim("email",usuario.EmailUsuario),
                new Claim("roles","admin,ti,estagiário")
            };

            var identity = new ClaimsIdentity
                (
                    claims,
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    "nome", "roles"
                );

            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(principal,
                new AuthenticationProperties
                {
                    IsPersistent = lembraSenha,
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(10)
                });
        }

        [HttpGet]
        public IActionResult AddNewUser()
        {
            ViewBag.IsEditing = "N";

            UsuarioAddEditVM model = null;

            ViewBag.Title = "Adicionar Usuário";

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNewUser(string returnUrl, UsuarioAddEditVM model)
        {
            try
            {
                var data = model.ToData();

                data.HashSenha = model.Senha.Encrypt();
                data.DhRegistro = Convert.ToDecimal(DateTime.Now.ToString("yyyyMMddHHmmss"));
                data.StUsuario = EnumHelper.SituacaoUsuario.UA9.ToString();

                _usuarioRepo.Add(data);
                data.IdUsuarioRegistro = data.IdUsuario;

                await _uow.CommitAsync();

                await Task.Run(async () =>
                {
                    int userId = Convert.ToInt32(data.IdUsuario);

                    var _userToSend = new EmailFormModel()
                    {
                        FromEmail = data.EmailUsuario,
                        FromName = data.NmUsuario
                    };

                // Credenciais para o envio do email
                var credentials = _credential.GetEmailCredentials();

                    var credEmail = credentials.Where(k => k.Key == "Email").Select(e => e.Value).ToList().FirstOrDefault();
                    var credPass = credentials.Where(k => k.Key == "Password").Select(e => e.Value).ToList().FirstOrDefault();
                    var credHost = credentials.Where(k => k.Key == "Host").Select(e => e.Value).ToList().FirstOrDefault();
                    var credPort = credentials.Where(k => k.Key == "Port").Select(e => e.Value).ToList().FirstOrDefault();

                    var _sender = new Sender(credEmail, credPass, credHost, Convert.ToInt16(credPort));

                    await _sender.SendConfirmation(_userToSend, userId);
                });

                if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/") && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return View("Success", data);
                };
            }
            catch (Exception e)
            {
                _logger.LogError(99, e, LoggerHelper.GetStringLogError(e.Message), new { });

                ViewBag.CustomError = e.Message;
                return View("CustomError");
            }
        }

        [HttpGet]
        public ActionResult Recover()
        {
            return View();
        }

        public async Task<JsonResult> Recover(string email)
        {
            var _login = _usuarioRepo.GetAsync().Result.FirstOrDefault(x => x.EmailUsuario == email);

            if (_login != null)
            {
                int userId = Convert.ToInt32(_login.IdUsuario);

                var _userToSend = new EmailFormModel()
                {
                    FromEmail = email,
                    FromName = _login.NmUsuario
                };

                // Credenciais para o envio do email
                var credentials = _credential.GetEmailCredentials();

                var credEmail = credentials.Where(k => k.Key == "Email").Select(e => e.Value).ToList().FirstOrDefault();
                var credPass = credentials.Where(k => k.Key == "Password").Select(e => e.Value).ToList().FirstOrDefault();
                var credHost = credentials.Where(k => k.Key == "Host").Select(e => e.Value).ToList().FirstOrDefault();
                var credPort = credentials.Where(k => k.Key == "Port").Select(e => e.Value).ToList().FirstOrDefault();

                var _sender = new Sender(credEmail, credPass, credHost, Convert.ToInt16(credPort));

                // Envia email para recuperação de senha
                await _sender.SendRecover(_userToSend, userId);

                return Json(new { status = true });
            }

            return Json(new { error = true });
        }

        public JsonResult ValidPassword(string SenhaAtual, string NovaSenha, string ConfirmaSenha)
        {
            if (NovaSenha != ConfirmaSenha)
            {
                return Json(new { error = "A nova senha não confere com a confirmação da senha" });
            }

            return Json(new { status = true });
        }

        [Route("RecoverConfirm")]
        public async Task<ActionResult> ConfirmRecover(string hash)
        {
            try
            {
                hash = CryptAES.Decrypt(hash);

                JObject json = JObject.Parse(hash);

                DateTime dateCreate = (DateTime)json["dateCreate"];
                DateTime dateExpire = (DateTime)json["dateExpire"];
                string Method = (string)json["Method"];
                decimal userId = (decimal)json["userId"];

                if (Method != "RecoverPassword")
                {
                    throw new Exception("Hash inválido para esse tipo de operação");
                }

                if (DateTime.Now > dateExpire)
                {
                    throw new Exception("Tempo limite expirado. Por favor, gere outra solicitação para recuperar a senha");
                }

                var user = await _usuarioRepo.GetAsync(userId);

                if (user == null)
                {
                    throw new Exception("Usuário inválido.");
                }

                var userVM = user.ToVM();
                userVM.Senha = "";

                return View(userVM);
            }
            catch (Exception E)
            {
                ViewBag.ErrorToConfirm = E.Message;
                return View("ErrorConfirm");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ResetPassword(UsuarioAddEditVM model)
        {
            if (model.Senha != model.ConfirmaSenha)
            {
                ModelState.AddModelError("", "A nova senha não confere com a confirmação da senha");
                return View("ConfirmRecover", model);
            }

            if (ModelState.IsValid)
            {
                var _usuario = await _usuarioRepo.GetAsync(model.Id);

                _usuario.HashSenha = model.Senha.Encrypt();
                _usuarioRepo.Update(_usuario);

                await _uow.CommitAsync();

                ViewBag.MessageSuccess = "Senha alterada com sucesso.";

                return View("Confirm");
            }

            return View("ConfirmRecover", model);
        }

        [Route("Confirm")]
        public ActionResult Confirm(string hash)
        {
            try
            {
                hash = CryptAES.Decrypt(hash);

                JObject json = JObject.Parse(hash);

                DateTime dateCreate = (DateTime)json["dateCreate"];
                DateTime dateExpire = (DateTime)json["dateExpire"];
                string Method = (string)json["Method"];
                int userId = (int)json["userId"];

                if (Method != "ConfirmEmail")
                {
                    throw new Exception("Hash inválido para esse tipo de operação");
                }

                if (DateTime.Now > dateExpire)
                {
                    throw new Exception("Tempo limite expirado. Por favor, gere outra chave de validação");
                }

                ViewBag.MessageSuccess = "Email confirmado com sucesso!";
                return View();
            }
            catch (Exception E)
            {
                ViewBag.ErrorToConfirm = E.Message;
                return View("ErrorConfirm");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> LogOff()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("SignIn");
        }
    }
}