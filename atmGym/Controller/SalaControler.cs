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
    internal class SalaControler
    {
        private static string msgError = "";
        public static bool addSala(Sala s)
        {
            try
            {
                if (SalaDao.addSala(s))
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
        public static DataTable selectAllSalaEspaco()
        {
            try
            {
                return SalaDao.selectAllSalaEspaco();
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static string getError()
        {
            return msgError;
        }
        public static DataRow selectSalaById(string id)
        {
            try
            {
                return SalaDao.selectSalaById(id).Rows[0];
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
        }
        public static bool DeleteSalaById(string p)
        {
            try
            {
                SalaDao.DeleteSalaById(p);
                return true;
            }
            catch (Exception ex)
            {
                msgError = "Ocorreu o seguinte erro:" + ex.Message.ToString();
                return false;

            }

        }
        public static DataRow SelectSalaByNsala(string nSala)
        {
            try
            {
                return SalaDao.selectSalaByNsala(nSala).Rows[0];
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
        }

    }
}
