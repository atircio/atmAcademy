using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atmGym.Model.Entity;
using MySql.Data.MySqlClient;

namespace atmGym.Model.Dao
{
    internal class ContratoDao
    {
        public static bool addContrato(Contrato p)
        {
            MySqlCommand c = new MySqlCommand();


            string sql = " INSERT INTO `gymbd`.`contrato` (`idAluno`, `dataInicio`, `dataFim`, `formaPagemnto`,  mensalidade)" +
                 " VALUES ((SELECT max(idAluno) FROM aluno),'" + p.dataInicio + "', '" + p.dataFinal + "', '" + p.formaPagamento + 
                 "', '" + p.mensalidade + "');";
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
