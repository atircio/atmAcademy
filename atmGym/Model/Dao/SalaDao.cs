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
    internal class SalaDao
    {
        public static string msgErro = null;
        public static bool addSala(Sala p)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = " INSERT INTO `gymbd`.`sala` ( `idEspaco`)" +
                 " VALUES ((SELECT max(idEspaco) FROM espaco));";


            if (Program.c.INSERT(sql))
            {
                return true;
            }
            else
            {
                msgErro = Program.c.mgsError();
                return false;
            }
        }
        public static DataTable selectAllSalaEspaco()
        {
            string sql = "select s.idSala, e.andar,  e.nSala from espaco e "+
                         " join sala s "+
                         " on e.idEspaco = s.idEspaco;";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable selectSalaById(string id)
        {
            string sql = " select s.idSala, s.idEspaco, e.andar, e.nSala from sala s " +
                        "join espaco e " +
                        "on e.idEspaco = s.idEspaco " +
                        "where s.idSala = '" + id + "'; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable selectSalaByNsala(string nSala)
        {
            string sql = " select* from espaco e " +
                        "join sala s " +
                        "on s.idEspaco = e.idEspaco " +
                        "where nSala = '" + nSala + "'; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static bool DeleteSalaById(string id)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "delete from espaco where idEspaco = (select a.idEspaco from sala a " +
                        " where a.idSala = '" + id + "'); ";
            if (Program.c.INSERT(sql))
            {
                return true;
            }
            else
            {
                msgErro = Program.c.mgsError();
                return false;
            }
        }


    }
}
