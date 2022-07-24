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
    public class AlunoDao
    {
        public static string erro = null;
        public static bool addAluno(Aluno p)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "INSERT INTO aluno(idPessoa)" +
                 " VALUES ((SELECT max(idPessoa) FROM pessoa) );";


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
        public static bool addAluno(Cliente p)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "INSERT INTO aluno(idPessoa)" +
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

        public static DataTable selectAllAlunoPessoa()
        {
            string sql = "select a.idAluno as ID, p.nome as NOME, p.BI as BI  from pessoa p "+
                         "join aluno a "+
                         "on a.idPessoa = p.idPessoa; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }

        public static DataTable selectAlunoById(string id)
        {
            string sql = "select p.*,a.* from pessoa p " +
                        "join aluno a " +
                        "on a.idPessoa = p.idPessoa " +
                        "where idAluno = '" + id + "'; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }

        public static bool DeleteAlunoById(string id)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "delete from pessoa where idPessoa = " +
                        " (select a.idPessoa from aluno a" +
                        " where a.idAluno = '"+id+"'); ";
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
