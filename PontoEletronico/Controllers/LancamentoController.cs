using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PontoEletronico.Models;

namespace PontoEletronico.Controllers
{
    public class LancamentoController : Controller
    {
        List<LancamentoModel> lancamentos = new List<LancamentoModel>();

        // GET: Lancamento
        public ActionResult Lancamento()
        {
            LancamentoModel lancamento = new LancamentoModel()
            {
                Descricao = "Fatura",
                Vencimento = new DateTime().ToString("d"),
                Valor = "R$ 999,00"
            };

            lancamentos.Add(lancamento);

            return View(lancamentos);
        }

        [HttpPost]
        public ActionResult Cadastro()
        {
            try
            {
                if (Request.Form["evento"] != null)
                {
                    switch (Request.Form["evento"])
                    {
                        case "1":
                            return RedirectToAction("Cadastro", "Cadastro");
                        case "2":
                            return RedirectToAction("Cadastro", "Cadastro");
                    }
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("Login", "Home");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = "Erro ao registrar o ponto \n" + erro.Message;
                return RedirectToAction("Login", "Home");
            }
        }
    }
}