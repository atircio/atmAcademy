using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmGym.Model.Entity
{
    public class Cliente : Pessoa
    {
        public Cliente(string nome, string BI, string cidade, string municipio, string bairro, string rua, string nCasa, List<string> t) : base(nome, BI, cidade, municipio, bairro, rua, nCasa,t)
        {

        }
    }
}
