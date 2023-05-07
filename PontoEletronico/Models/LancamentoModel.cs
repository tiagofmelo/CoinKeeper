using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PontoEletronico.Models
{
    public class LancamentoModel
    {
        public string Descricao { get; set; }
        public string Vencimento { get; set; }
        public string Valor { get; set; }
        public bool Notificacao { get; set; }

    }
}