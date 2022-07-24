using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmGym.Model.Entity
{
    internal class Modalidade
    {
        public Modalidade(string nome, string descricao)
        {
            this.nome = nome;
            this.descricao = descricao;
        }

        public string nome { get; set; }
        public string descricao { get; set; }
    }
}
