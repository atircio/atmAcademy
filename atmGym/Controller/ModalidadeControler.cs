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
    internal class ModalidadeControler
    {
        private static string msgError = "";
        public static bool addModalidade(Modalidade m)
        {
            try
            {
                if (ModalidadeDao.addModalidade(m))
                {
                    
                     return true;
                }
                else
                {
                    msgError = SalaDao.msgErro;
                    return false;
                }
                
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
        public static DataTable SelectModalidade()
        {
            try
            {
                return ModalidadeDao.selectModalidade();
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataTable SelectModalodadeProfessor(string id)
        {
            try
            {
                return ModalidadeDao.SelectModalidadeProfessor(id);
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataRow selectModalidadeByID(string id)
        {
            try
            {
                return ModalidadeDao.selectModalidadeById(id).Rows[0];
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
        }
        public static DataRow selectModalidadeByNome(string nome)
        {
            try
            {
                return ModalidadeDao.selectModalidadeByName(nome).Rows[0];
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
        }
        public static DataRow SelectCanchaByNsala(string nSala)
        {
            try
            {
                return CanchaDao.selectCanhaByNsala(nSala).Rows[0];
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
        }
        public static bool DeleteModalidadeById(string p)
        {
            try
            {
                ModalidadeDao.DeleteModalidadeById(p);
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
