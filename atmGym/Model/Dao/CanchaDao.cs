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
    internal class CanchaDao
    {
        public static string msgErro = null;
        public static bool addCancha(Cancha p)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = " INSERT INTO `gymbd`.`cancha` ( `idEspaco`)" +
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
        public static DataTable selectAllCanchaEspaco()
        {
            string sql = "SELECT c.idCancha, e.andar,  e.nSala FROM ESPACO e " +
                         "join cancha c " +
                         "on c.idEspaco = e.idEspaco;";
            DataTable b = Program.c.SELECT(sql);
            return b;

        }

        public static DataTable selectCanchaById(string id)
        {
            string sql = " select s.idCancha, s.idEspaco, e.andar, e.nSala from cancha s " +
                        "join espaco e " +
                        "on e.idEspaco = s.idEspaco " +
                        "where s.idCancha = '" + id + "'; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static bool DeleteCanchaById(string id)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "delete from espaco where idEspaco = (select a.idEspaco from cancha a " +
                        " where a.idCancha = '" + id + "'); ";
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

        public static DataTable selectCanhaByNsala(string nSala)
        {
            string sql = " select* from espaco e " +
                        "join cancha s " +
                        "on s.idEspaco = e.idEspaco " +
                        "where nSala = '" + nSala + "'; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }
    }
}
