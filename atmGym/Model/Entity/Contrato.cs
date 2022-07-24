using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmGym.Model.Entity
{
    public class Contrato
    {
        public Contrato(string dataInicio, string dataFinal, string formaPagamento, double mensalidade)
        {
            this.dataInicio = dataInicio;
            this.dataFinal = dataFinal;
            this.formaPagamento = formaPagamento;
            this.mensalidade = mensalidade;
        }

        public string dataInicio { get; set; }
        public string dataFinal { get; set; }
        public string formaPagamento { get; set; }
        public double mensalidade { get; set; }
    }
}
