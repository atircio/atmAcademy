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
    public class  PessoaControl
    {
        public static string countOfTable(string nomeTabela)
        {
            try
            {
                return PessoaDao.countOfTable(nomeTabela);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        private static string msgError="";
        public static bool addPessoas(Pessoa p)
        {
            try
            {
                PessoaDao.addPessoa(p);
                PessoaDao.AddTelefone(p);
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

        public static DataTable selectPessoa()
        {
            try
            {
                return PessoaDao.SelectPessoa();
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }
        public static DataTable selectPessoaTelefone(string id)
        {
            try
            {
                return PessoaDao.SelectProfessorTelefone(id);
            }
            catch (Exception ex)
            {
                msgError = ex.Message.ToString();
                return null;
            }

        }


    }


}
