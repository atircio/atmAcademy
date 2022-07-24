using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmGym.Model.Entity
{
    public class Professor : Pessoa
    {
        public string nCarteira { get; set; }
        public double salario { get; set; }
        public List<string> qualificacao;
        public List<string> especializacao;





        public Professor(string nC, double s, string nomeP, string BIp, string cidadeP, 
            string municipioP, string bairroP, string ruaP, string nCasaP, List<string> t, List<string> qua, List<string> es)
            : base(nomeP, BIp, cidadeP, municipioP, bairroP, ruaP, nCasaP, t)
        {
            this.nCarteira = nC;
            this.salario = s;
            this.qualificacao = qua;
            this.especializacao = es;
           
        }

        public Professor(string nC, double s, string nomeP, string BIp)
            : base(nomeP, BIp)
        {
            this.nCarteira = nC;
            this.salario = s;

        }


    }
     
    }

