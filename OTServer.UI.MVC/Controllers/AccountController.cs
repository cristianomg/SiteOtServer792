using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OTServer.UI.MVC.Models;

namespace OTServer.UI.MVC.Controllers
{
    public class AccountController : BaseController
    {
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
                TempData["Account"] = account.AccountNumber;
                TempData["Pass"] =  account.Pass;
                TempData["LoginAceito"] = "loginAceito";
                return RedirectToAction("Painel", "Account");
            }
            TempData["FalhaLogin"] = "Login não encontrado";
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [Route("Painel")]
        public IActionResult Painel()
        {
            try
            {
                string login = TempData["Account"] as String;
                string senha = TempData["Pass"] as String;
                var account = accounts.FirstOrDefault(x => x.Pass == senha && x.AccountNumber == login);
                if (account != null)
                {
                    TempData.Keep("Account");
                    TempData.Keep("Pass");
                    TempData.Keep("LoginAceito");
                    var accountDTO = _mapper.Map<DTOPainelAccount>(account);
                    return View(accountDTO);
                }
                TempData.Remove("Account");
                TempData.Remove("Pass");
                TempData.Remove("LoginAceito");
                ViewData["FalhaLogin"] = "Login não encontrado";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception e)
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}