using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontoEletronico.Models;

namespace PontoEletronico.Controllers
{
    public class CadastroController : Controller
    {
        List<LancamentoModel> lancamentos = new List<LancamentoModel>();

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(LancamentoModel lancamentoModel)
        {
            lancamentos.Add(lancamentoModel);

            return View("Lancamento", lancamentos);
        }
    }
}