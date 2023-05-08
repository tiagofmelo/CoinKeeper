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

        // GET: Lancamento
        public ActionResult Lancamento()
        {
            List<LancamentoModel> lancamentos = new List<LancamentoModel>
            {
                new LancamentoModel()
                {
                    Descricao = "Fatura Banco",
                    Vencimento = "01/06/2023",
                    Valor = "R$ 800,00"
                },
                new LancamentoModel()
                {
                    Descricao = "Fatura Internet",
                    Vencimento = "03/06/2023",
                    Valor = "R$ 99,00"
                },
                new LancamentoModel()
                {
                    Descricao = "Telefone",
                    Vencimento = "10/06/2023",
                    Valor = "R$ 78,00"
                }
            };

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