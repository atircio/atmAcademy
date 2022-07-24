using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atmGym.Model.Dao;
using atmGym.Model.Entity;

namespace atmGym.Controller
{
    internal class AlunoControl
    {
        private static string msgError = "";
        public static string getError()
        {
            return msgError;
        }
        public static bool addAlunos(Aluno p)
        {
            try
            {
                AlunoDao.addAluno(p);
                return true;
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return false;

            }

        }
        public static bool addAlunos(Cliente p)
        {
            try
            {
                AlunoDao.addAluno(p);
                return true;
            }
            catch (Exception ex)
            {
                msgError = "Ocorreu o seguinte erro:" + ex.Message.ToString();
                return false;

            }

        }
        public static DataTable selectAllAlunoPessoa()
        {
            try
            {
                return AlunoDao.selectAllAlunoPessoa();
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataRow selectAlunoById(string id)
        {
            try
            {
                return AlunoDao.selectAlunoById(id).Rows[0];
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
        }

        public static bool DeleteAlunoById(string p)
        {
            try
            {
                AlunoDao.DeleteAlunoById(p);
                return true;
            }
            catch (Exception ex)
            {
                msgError = "Ocorreu o seguinte erro:" + ex.Message.ToString();
                return false;

            }

        }
    }
}
