using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atmGym.Model.Entity;
using MySql.Data.MySqlClient;
using atmGym.Views;
using System.Windows.Forms;
using System.Data;

namespace atmGym.Model.Dao
{
    public class ProfessorDao  
    {
        
        public static string erro=null;
        public static bool addProfessor(Professor p)
        {
            MySqlCommand c = new MySqlCommand();
            Controller.PessoaControl.addPessoas(p);
            string sql = "INSERT INTO professor(nCarteira, salario, idPessoa)" +
                 " VALUES ('" + p.nCarteira + "', '" + p.salario + "', (SELECT max(idPessoa) FROM pessoa) );";

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
        public static bool AddQuali(Professor p)
        {
            bool a = false;
            MySqlCommand c = new MySqlCommand();
            foreach (string quali in p.qualificacao)
            {
                string sql = "  INSERT INTO `gymbd`.`qualificacao` (`idProf`, `quali`) " +
                    "VALUES ((select max(idProf) from professor), '"+quali+"');";
                if (Program.c.INSERT(sql))
                {
                    a = true;
                }
                else
                {
                    a = false;
                    erro = Program.c.mgsError();
                    break;
                }
            }

            return a;
        }
        public static bool AddEspe(Professor p)
        {
            bool a = false;
            MySqlCommand c = new MySqlCommand();
            foreach (string es in p.especializacao)
            {
                string sql = " INSERT INTO `gymbd`.`especializacao` (`especializacao`, `idProf`) " +
                    " VALUES('" + es + "', (SELECT max(idProf) FROM professor));";
                if (Program.c.INSERT(sql))
                {
                    a = true;



                }
                else
                {
                    erro = Program.c.mgsError();
                    a = false;
                    break;
                }
            }

            return a;
        }
        public static bool AddModalidadeProfessor(List<string> ListaModalidade)
        {
            bool a = false;
            MySqlCommand c = new MySqlCommand();
            foreach (string m in ListaModalidade)
            {
                string sql = "insert into professormodalidade(idModalidade, idProf) "+
                             "values((select idModalidade from modalidade "+
                              "where nome = '"+m+"'), (select max(idProf) from professor));";
                if (Program.c.INSERT(sql))
                {
                    a = true;
                }
                else
                {
                    erro = Program.c.mgsError();
                    a = false;
                    break;
                }
            }

            return a;
        }
        public static DataTable SelectProfessor()
        {
            string sql = "select pe.idProf as ID, p.nome as NOME, pe.nCarteira as N_CARTEIRA , pe.salario as SALARIO from pessoa p " +
               "join professor pe " +
               "on p.idPessoa = pe.idPessoa"+
               " order by pe.idProf; ";

            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable selectProfessorPessoa(string id)
        {
            string sql = "select p.*, pe.nCarteira, pe.salario from pessoa p " +
                "join professor pe " +
                "on p.idPessoa = pe.idPessoa " +
                "where pe.idProf = '"+id+"'; ";

            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataRow selectOneProfessor(string id)
        {
            string sql= "select * from professor where idProf = '"+id+"';";
            DataRow dados = Program.c.SELECT(sql).Rows[0];
            return dados;
        }
        public static DataTable selectQualificacao(string id)
        {
            string sql = "select q.* from qualificacao q "+
                         "join professor p "+
                         "on q.idProf = p.idProf "+
                         "where q.idProf = '"+id+"';";

            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable selectEspecializacao(string id)
        {
            string sql = "select es.*from especializacao es " +
                         "join professor p " +
                         "on es.idProf = p.idProf " +
                         "where es.idProf = '" + id + "';";
            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable SelectProfessorTelefone(string id)
        {
            string sql = "select t.* from telefone t "+
                          "join professor a "+
                          "on t.idPessoa = a.idPessoa"+
                          " where a.idProf ='"+id+"' ;" ;

            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable SelectModalidadeProfessorById(string idProfessor)
        {
            string sql = " select pm.*, m.nome from professormodalidade pm " +
                          "join modalidade m " +
                          "on m.idModalidade = pm.idModalidade " +
                          "  where pm.idProf = '" + idProfessor + "' ;";

            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static DataTable SelectProfessorByModalidadeName(string nomeModalidade)
        {
            string sql = " select p.idProf, pe.nome from professormodalidade pm " +
                         " join professor p " +
                         " on p.idProf = pm.idProf " +
                         " join modalidade m " +
                         " on pm.idModalidade = m.idModalidade " +
                         " join pessoa pe " +
                         " on pe.idPessoa = p.idPessoa " +
                         " where m.nome = '"+nomeModalidade+"'; ";

            DataTable b = Program.c.SELECT(sql);
            return b;
        }
        public static bool DeleteProfessorById(string id)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = " delete from pessoa where idPessoa =  " +
                        "  (select a.idPessoa from professor a " +
                        " where a.idProf = '" + id + "'); ";
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

