using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atmGym.Model.Entity;
using MySql.Data.MySqlClient;
using System.Data;

namespace atmGym.Model.Dao
{
    internal class ModalidadeDao
    {
        public static string msgErro = null;
        public static bool addModalidade(Modalidade m)
        {
            string sql = " INSERT INTO `gymbd`.`modalidade`  ( `nome`, `descricao`)" +
                 " VALUES ('"+m.nome+ "','"+m.descricao+"');";

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
        public static DataTable selectModalidade()
        {
            string sql = "select * from modalidade order by nome; ";

            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable selectAllModalidade()
        {
            string sql = "select s.idSala, e.andar,  e.nSala from espaco e " +
                         " join sala s " +
                         " on e.idEspaco = s.idEspaco;";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }

        public static DataTable SelectModalidadeProfessor(string id)
        {
            string sql = "select m.nome, pm.* from professormodalidade pm " +
                        "join modalidade m " +
                        " on m.idModalidade = pm.idModalidade " +
                         "where idProf = '"+id+"'; ";

            DataTable b = Program.c.SELECT(sql);
            return b;
        }

        public static DataTable selectModalidadeById(string id)
        {
            string sql = " select* from modalidade " +
                        "where idModalidade = '" + id + "'; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable selectModalidadeByName(string nome)
        {
            string sql = " select* from modalidade " +
                        "where nome = '" + nome + "'; ";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }

        public static bool DeleteModalidadeById(string id)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "delete from modalidade where idModalidade = '" + id + "'; ";
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
