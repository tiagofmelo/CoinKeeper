using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Newtonsoft.Json;
using PontoEletronico.Models;

namespace PontoEletronico.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            try
            {
                return View();
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = "Erro ao carregar a página \n" + erro.Message;
                return RedirectToAction("Login", "Home");
            }
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}