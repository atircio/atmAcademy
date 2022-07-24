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
    public class ClienteControler
    {
        private static string msgError="";
        public static string getError()
        {
            return msgError;
        }
        public static bool addCliente(Cliente p)
        {
            try
            {
                ClienteDao.addCli(p);
                
                return true;
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return false;

            }

        }
        public static bool addClienteTelefone(Cliente p)
        {
            try
            {
                ClienteDao.addCli(p);
                PessoaDao.AddTelefone(p);

                return true;
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return false;

            }

        }
        public static DataTable selectAllClientePessoa()
        {
            try
            {
                return ClienteDao.selectAllClientePessoa();
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataRow selectClienteById(string id)
        {
            try
            {
                return ClienteDao.selectClienteById(id).Rows[0];
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }
        }
        public static bool DeleteClienteById(string p)
        {
            try
            {
                ClienteDao.DeleteClienteById(p);
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
