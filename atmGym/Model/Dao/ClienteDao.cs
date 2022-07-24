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
    public class ClienteDao
    {
        public static string erro = null;
        public static bool addCli(Cliente p)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "INSERT INTO cliente(idPessoa)" +
                 " VALUES ((SELECT max(idPessoa) FROM pessoa) );";


            if (Program.c.INSERT(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static DataTable selectAllClientePessoa()
        {
            string sql = "select c.idCliente as ID, p.nome as NOME, p.BI as BI  from pessoa p "+
                        "join cliente c "+
                        " on c.idPessoa = p.idPessoa; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable selectClienteById(string id)
        {            string sql = "select p.*,a.* from pessoa p " +
                        "join cliente a " +
                        "on a.idPessoa = p.idPessoa " +
                        "where idCliente = '" + id + "'; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static bool DeleteClienteById(string id)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "delete from pessoa where idPessoa = " +
                        " (select a.idPessoa from cliente a" +
                        " where a.idCliente = '" + id + "'); ";
            if (Program.c.INSERT(sql))
            {

                return true;
            }
            else
            {
                erro = Program.c.mgsError();
                return false;
            }
        }
    }
}
