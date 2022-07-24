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
    public static class PessoaDao
    {
        public static string countOfTable(string nomeTabela)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "select count(*) from " + nomeTabela +" ;";
            DataRow b = Program.c.SELECT(sql).Rows[0];
            string count = b[0].ToString();

            return count;
        } 
        public static bool addPessoa(Pessoa p)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "INSERT INTO `gymbd`.`Pessoa` (`nome`, `BI`, `cidade`, `municipio`, `bairro`, `rua`, `nCasa`)" +
                 " VALUES ('"+p.nome + "', '" + p.BI + "', '" + p.cidade + "', '" + p.municipio + "', '" + p.bairro 
                 + "',  '" + p.rua + "','" + p.nCasa + "');";

            
            if (Program.c.INSERT(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool AddTelefone(Pessoa p)
        {
            bool a = false;
            int b = 0;
            MySqlCommand c = new MySqlCommand();
            foreach (string tele in p.telefone)
            {
                string sql = "INSERT INTO `gymbd`.`telefone` (`telefone`, `idPessoa`) " +
                 " VALUES ('" + tele + "', (SELECT max(idPessoa) FROM Pessoa)" + ");";
                if (Program.c.INSERT(sql))
                {
                    a= true;
                    b++;
                }
                else
                {
                    a= false;
                    break;
                }
            }

            if (b==p.telefone.Count)
            {
                
            }

            return  a;
        }

        public static DataTable SelectPessoa()
        {
            string sql = "select * from pessoa ";

            DataTable b = Program.c.SELECT(sql);
            return b;
        }

        public static DataTable SelectProfessorTelefone(string id)
        {
            string sql = "select t.* from telefone t"+
                            " join pessoa a"+
                            " on t.idPessoa = a.idPessoa"+
                            " where t.idPessoa = '"+id+"';" ;

            DataTable b = Program.c.SELECT(sql);
            return b;
        }
    }
}
