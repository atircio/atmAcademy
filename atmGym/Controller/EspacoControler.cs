using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atmGym.Model.Dao;
using atmGym.Model.Entity;

namespace atmGym.Controller
{

    internal class EspacoControler
    {
        private static string msgError ="";

        public static bool addEspaco(Espacos c)
        {
            try
            {
                EspacoDao.AddEspaco(c);
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
