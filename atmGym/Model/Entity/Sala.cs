using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmGym.Model.Entity
{
    internal class Sala : Espacos
    {
        public Sala(string andar, string nSala) : base( andar, nSala)
        {
        }
    }
}
