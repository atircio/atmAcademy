using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmGym.Model.Entity
{
    internal class Aula
    {
        public Aula(string idProfessor, string idMOdalidade, string idEspaco, string duracao, string hora, string limiteAluno, string data)
        {
            this.idProfessor = idProfessor;
            this.idMOdalidade = idMOdalidade;
            this.idEspaco = idEspaco;
            this.duracao = duracao;
            this.hora = hora;
            this.limiteAluno = limiteAluno;
            this.data = data;
        }

        public string idProfessor { get; set; }
        public string idMOdalidade { get; set; }
        public string idEspaco { get; set; }
        public string duracao { get; set; }
        public string hora { get; set; }

        public string limiteAluno { get; set; }
        public string data { get; set; }
    }
}
