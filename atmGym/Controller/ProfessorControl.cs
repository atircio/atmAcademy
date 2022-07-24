using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atmGym.Model.Dao;
using atmGym.Model.Entity;
using System.Data;

namespace atmGym.Controller
{
    internal class ProfessorControl
    {
        private static string msgError="";
        public static bool addProfessor(Professor p)
        {
            try
            {
                if (ProfessorDao.addProfessor(p) && ProfessorDao.AddEspe(p) && ProfessorDao.AddQuali(p))
                {
                    return true;
                }
                else
                {
                    msgError = ProfessorDao.erro;
                    return false;
                }
            }
            catch (Exception ex)
            {
                msgError =ex.Message.ToString();
                return false;

            }

        }
        public static bool AddProfessorModalidade(List<string> ListaModalidade)
        {
            try
            {
                ProfessorDao.AddModalidadeProfessor(ListaModalidade);
                return true;
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return false;
            }
        }
        public static string getError()
        {
            return msgError;
        }
        public static DataTable selectProfessor()
        {
            try
            {
                return ProfessorDao.SelectProfessor();
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
            
        }
        public static DataRow selectOneProfessor(string id)
        {
            try
            {
                return ProfessorDao.selectOneProfessor(id);

            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
        }
        public static DataTable selectProfessorPessoa(string a)
        {
            try
            {
                return ProfessorDao.selectProfessorPessoa(a);
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataRow selectProfessorPessoa2(string id)
        {
            try
            {
                return ProfessorDao.selectProfessorPessoa(id).Rows[0];
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
        }
        public static DataTable selectEspicializacao(string id)
        {
            try
            {
                return ProfessorDao.selectEspecializacao(id);
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataTable selectQualificacao(string id)
        {
            try
            {
                return ProfessorDao.selectQualificacao(id);
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataTable selectProfessorTelefone(string id)
        {
            try
            {
                return ProfessorDao.SelectProfessorTelefone(id);
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataTable SelectModalidadeProfessorById(string idProfessor)
        {
            try
            {
                return ProfessorDao.SelectModalidadeProfessorById(idProfessor);
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataTable SelectProfessorByModalidadeNome(string nomeModalidade)
        {
            try
            {
                return ProfessorDao.SelectProfessorByModalidadeName(nomeModalidade);
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static bool DeleteProfessorById(string p)
        {
            try
            {
                ProfessorDao.DeleteProfessorById(p);
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
