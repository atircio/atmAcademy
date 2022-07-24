using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atmGym.Model.Dao;
using atmGym.Model.Entity;

namespace atmGym.Controller
{
    internal class ContratoControler
    {
        private static string msgError = "";
        public static bool addContrato(Contrato p)
        {
            try
            {
                ContratoDao.addContrato(p);
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
    }
}
