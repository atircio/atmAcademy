using atmGym.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmGym.Model.Dao
{
    internal class AulaDao
    {
        public static string msgErro = null;
        public static bool addAula(Aula a)
        {
            MySqlCommand c = new MySqlCommand();
            string sql = "  INSERT INTO `gymbd`.`aula` (`horaInicio`, `horaDuracao`, `data`, `limiteAluno`, `idModalidade`, `idProf`, `idEspaco`)" +
                 " VALUES('"+a.hora+"', '"+a.duracao+"', '"+a.data+"', '"+a.limiteAluno+"', '"+a.idMOdalidade+"', '"+a.idProfessor+"', '"+a.idEspaco+"');";


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
        public static DataTable selectAllAulas()
        {
            string sql = "select a.idAula, e.nSala, a.horaInicio, a.limiteAluno as Nalunos, " +
                " m.nome as modalidade, pe.nome as professor, a.horaDuracao, a.dataAula from aula a"+
                            " join modalidade m "+
                            " on m.idModalidade = a.idModalidade "+
                            " join professor p "+
                            " on p.idProf = a.idProf "+
                            " join pessoa pe "+
                            " on pe.idPessoa = p.idPessoa "+
                            " join espaco e "+
                            " on e.idEspaco = a.idEspaco; ";
            DataTable b = Program.c.SELECT(sql);
            return b;

        }
        



    }
}
