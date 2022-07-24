using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atmGym.Model.Dao;

namespace atmGym.Model.Entity
{
    public class Pessoa 
    {
        public int idPessoa { get; set; }
        public string nome { get; set; }
        public string BI { get; set; }
        public string cidade { get; set; }
        public string municipio { get; set; }
        public string bairro { get; set; }
        public string rua { get; set; }
        public string nCasa { get; set; }

        public  List<string> telefone;

        public Pessoa(string nome, string BI, string cidade, string municipio, string bairro, string rua, string nCasa, List<string>t)
        {
            this.nome = nome;
            this.BI = BI;
            this.cidade = cidade;
            this.municipio = municipio;
            this.bairro = bairro;
            this.rua = rua;
            this.nCasa = nCasa;
            telefone = new List<string>();
            telefone = t;

        }

        public Pessoa(string nome, string BI)
        {
            this.nome = nome;
            this.BI = BI;
        }

        public string getNome() { return this.nome; }
    }
}
