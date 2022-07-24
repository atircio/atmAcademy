using atmGym.Model.Dao;
using atmGym.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmGym.Controller
{
    internal class AulaControler { 
    
        private static string msgError = "";
        public static string getError()
        {
            return msgError;
        }

        public static bool addAula(Aula a)
        {
            try
            {
                if (AulaDao.addAula(a))
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
        public static DataTable selectAllAula()
        {
            try
            {
                return AulaDao.selectAllAulas();
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
    }
}
