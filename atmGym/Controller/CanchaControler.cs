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
    internal class CanchaControler
    {
        private static string msgError="";
        public static string getError()
        {
            return msgError;
        }
        public static bool addCacha(Cancha c)
        {
            try
            {
                if (CanchaDao.addCancha(c))
                {
                    return true;
                }
                else
                {
                    msgError = CanchaDao.msgErro;
                    return false;
                }
                
                
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return false;
            }

        }

        public static DataTable selectAllCanchaEspaco()
        {
            try
            {
                return CanchaDao.selectAllCanchaEspaco();
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }

        public static DataRow selectCanchaById(string id)
        {
            try
            {
                return CanchaDao.selectCanchaById(id).Rows[0];
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
                public static bool DeleteCanchaById(string p)
        {
            try
            {
                CanchaDao.DeleteCanchaById(p);
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
