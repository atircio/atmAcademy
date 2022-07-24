using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atmGym.Model.Entity;
using MySql.Data.MySqlClient;

namespace atmGym.Model.Dao
{
    internal class EspacoDao
    {
        public static bool AddEspaco(Espacos p)
        {
            MySqlCommand c = new MySqlCommand();


            string sql = "  INSERT INTO `gymbd`.`espaco` (`andar`, `nSala`) " +
                 " VALUES ('" + p.andar + "', '" + p.nSala + "');";


            if (Program.c.INSERT(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
