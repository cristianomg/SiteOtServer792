using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OTServer.Domain.Factory;
using OTServer.Domain.Models.Account;
using OTServer.Domain.Models.Player;
using OTServer.UI.MVC.Models;

namespace OTServer.UI.MVC.Controllers
{
    public class AccountController : BaseController
    {
        const string SessionAccount = "_Account";
        const string SessionPassoword = "_Pass";
        const string SessionIsLoginValid = "_IsLoginValid";

        public AccountController(IMapper mapper) : base(mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        [Route("Login")]
        public IActionResult Login()
        {
            DTOAccountLogin model = new DTOAccountLogin();
            return PartialView(model);
        }
        [HttpPost]
        [Route("Login")]
        [ValidateAntiForgeryToken]
        public IActionResult Login(DTOAccountLogin model) 
        {
            var account = accounts.FirstOrDefault(x => x.Pass == model.Senha && x.AccountNumber == model.Login);
            if (account != null)
            {
                HttpContext.Session.SetString(SessionAccount, account.AccountNumber);
                HttpContext.Session.SetString(SessionPassoword, account.Pass);
                TempData[SessionIsLoginValid] = SessionIsLoginValid;
                return RedirectToAction("Painel", "Account");
            }
            TempData["ErroMessage"] = "Login e/ou senha incorretos";
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Route("Painel")]
        public IActionResult Painel()
        {
            try
            {
                string login = HttpContext.Session.GetString(SessionAccount);
                string senha = HttpContext.Session.GetString(SessionPassoword);
                var account = accounts.FirstOrDefault(x => x.Pass == senha && x.AccountNumber == login);
                if (account != null)
                {
                    var accountDTO = _mapper.Map<DTOPainelAccount>(account);
                    return View(accountDTO);
                }
                TempData.Remove(SessionIsLoginValid);
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                TempData.Remove(SessionIsLoginValid);
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpGet]
        [Route("ListarPlayer")]
        public IActionResult ListarPlayer(string account, string senha)
        {
            string login = HttpContext.Session.GetString(SessionAccount);
            string password = HttpContext.Session.GetString(SessionPassoword);
            if (login == account && password == senha)
            {
                var listaPlayers = players.Where(x => x.Account == account).OrderBy(x=>x.Name).ToList();

                if (listaPlayers.Any())
                {
                    var playerDTO = _mapper.Map<IEnumerable<DTOListaDePlayer>>(listaPlayers);
                    return PartialView(playerDTO);
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                ViewData["ErroMessage"] = "Relogue novamente!";
                return RedirectToAction("Index", "Home");
            }
        }
       
        [HttpGet]
        [Route("Logout")]
        public IActionResult RealizarLogout()
        {
            HttpContext.Session.Clear();
            TempData.Remove(SessionIsLoginValid);
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Route("InibirRk")]
        public IActionResult InibirRecoveryKey()
        {
            string login = HttpContext.Session.GetString(SessionAccount);
            string senha = HttpContext.Session.GetString(SessionPassoword);

            var account = accounts.Where(x => x.AccountNumber == login && x.Pass == senha).FirstOrDefault();
            if (account != null)
            {
                account.VisibleRk = false;
                base.AtualizarAccount(account);
                return RedirectToAction("painel");
            }
            return RedirectToAction("painel");

        }
        [HttpGet]
        [Route("Registrar")]
        public IActionResult RegistrarConta()
        {
            var accountDTO = new DTOCriarAccount();
            return View(accountDTO);
        }
        [HttpPost]
        [Route("Registrar")]
        [ValidateAntiForgeryToken]
        public IActionResult RegistrarConta(DTOCriarAccount model)
        {
            if (ModelState.IsValid)
            {
                if (model.Validar())
                {
                    var accountExiste = accounts.Where(x => x.AccountNumber == model.AccountNumber).Any();
                    if (accountExiste)
                    {
                        TempData["ErroMessage"] = "Essa Account já existe tente novamente.";
                        return View();
                    }
                    else
                    {
                        var account = _mapper.Map<Account>(model);
                        account.RecoveryKey = Guid.NewGuid().ToString().Split("-").Last();
                        account.VisibleRk = true;
                        account.PremDays = "0";
                        account.PremEnd = "0";
                        if (CriarAccount(account))
                        {
                            HttpContext.Session.SetString(SessionAccount, model.AccountNumber);
                            HttpContext.Session.SetString(SessionPassoword, model.Pass);
                            TempData[SessionIsLoginValid] = SessionIsLoginValid;
                            return RedirectToAction("Painel");
                        }
                        TempData["ErroMessage"] = "Essa Account já existe tente novamente.";
                        return View();
                    }
                }
                else
                {
                    TempData["ErroMessage"] = "Ocorreu um erro tente novamente.";
                    return View();
                }
            }
            TempData["ErroMessage"] = "Ocorreu um erro tente novamente.";
            return View();
        }
        [HttpGet]
        [Route("RecuperarSenha")]
        public IActionResult RecuperarSenha()
        {
            var dtoRecuperacao = new DTORecuperarSenha();
            return View(dtoRecuperacao);
        }
        [HttpPost]
        [Route("RecuperarSenha")]
        [ValidateAntiForgeryToken]
        public IActionResult RecuperarSenha(DTORecuperarSenha model)
        {
            if (ModelState.IsValid)
            {
                var account = accounts.FirstOrDefault(x => x.RecoveryKey == model.RecoveryKey
                                                      && x.AccountNumber == model.AccountNumber
                                                      && x.Email == model.Email);
                if (account != null)
                {
                    TempData["ResultadoRecuperacaoSenha"] = $"sua senha é: {account.Pass}";
                    return View();
                }
                else
                {
                    TempData["ResultadoRecuperacaoSenha"] = "Não foi possivel recuperar a senha, alguma informação está incorreta tente novamente.";
                    return View();
                }
            }
            TempData["ResultadoRecuperacaoSenha"] = "Não foi possivel recuperar a senha, alguma informação está incorreta tente novamente.";
            return View();
        }

        [HttpGet]
        [Route("MudarSenha")]
        public IActionResult MudarSenha()
        {
            var dtoMudarSenha = new DTOMudarSenha();
            return PartialView(dtoMudarSenha);
        }
        [HttpPost]
        [Route("MudarSenha")]
        [ValidateAntiForgeryToken]
        public IActionResult MudarSenha(DTOMudarSenha model)
        {
            string login = HttpContext.Session.GetString(SessionAccount);
            string senha = HttpContext.Session.GetString(SessionPassoword);
            if (senha == model.SenhaAtual)
            {
                if (ModelState.IsValid)
                {
                    var account = accounts.FirstOrDefault(x => x.Pass == model.SenhaAtual && x.RecoveryKey == model.RecoveryKey);
                    if (account != null)
                    {
                        if (model.SenhaNova == model.SenhaNovaConfirmacao)
                        {
                            account.Pass = model.SenhaNova;
                            if (AtualizarAccount(account))
                            {
                                HttpContext.Session.SetString(SessionPassoword, account.Pass);
                                TempData["ResultadoMudancaoSenha"] = "Senha alterada com sucesso.";
                                return RedirectToAction("Painel");
                            }
                            TempData["ResultadoMudancaoSenha"] = "Ocorreu um erro na alteração da senha, tente novamente.";
                            return RedirectToAction("Painel");
                        }
                        TempData["ResultadoMudancaoSenha"] = "Não foi possivel alterar a senha, a nova senha está diferente da confirmação.";
                        return RedirectToAction("Painel");
                    }
                    TempData["ResultadoMudancaoSenha"] = "Não foi possivel alterar a senha, senha atual e/ou recovery key estão incorretas.";
                    return RedirectToAction("Painel");
                }
                TempData["ResultadoMudancaoSenha"] = "Não foi possivel mudar a senha, alguma informação está incorreta tente novamente.";
                return RedirectToAction("Painel");
            }
            else
            {
                HttpContext.Session.Clear();
                ViewData["ErroMessage"] = "Relogue novamente!";
                return RedirectToAction("Index", "Home");
            }


        }
        [HttpGet]
        [Route("DeletarPersonagem")]
        public IActionResult DeletarPersonagem()
        {
            var dtoDeletarPersonagem = new DTODeletarPersonagem();
            return PartialView(dtoDeletarPersonagem);
        }
        [HttpPost]
        [Route("DeletarPersonagem")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletarPersonagem(DTODeletarPersonagem model)
        {
            var dtoDeletarPersonagem = new DTODeletarPersonagem();
            
            return RedirectToAction("Painel");
        }
        [HttpGet]
        [Route("CriarPersonagem")]
        public IActionResult CriarPersonagem()
        {
            var dtoCriarPersonagem = new DTOCriarPersonagem();
            return PartialView(dtoCriarPersonagem);
        }
        [HttpPost]
        [Route("CriarPersonagem")]
        public IActionResult CriarPersonagem(DTOCriarPersonagem model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Painel");
            }

            var newPlayer = PlayerFactory.NewPlayer(HttpContext.Session.GetString(SessionAccount),
                                                    model.Nome,
                                                    ((int)model.Voc).ToString(),
                                                    ((int)model.Sexo).ToString()
                                                    );
            base.CriarPlayer(newPlayer);
            return RedirectToAction("Painel");
        }
    }
}