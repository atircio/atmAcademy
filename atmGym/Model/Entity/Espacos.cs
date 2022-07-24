using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmGym.Model.Entity
{
    public  class Espacos
    {
        public Espacos( string andar, string nSala)
        {
            this.andar = andar;
            this.nSala = nSala;
        }

        public string andar { get; set; }
        public string nSala { get; set; }
    }
}
