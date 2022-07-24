using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace atmGym.Model.Entity
{
    internal class Conexao
    {
        private MySqlConnection cxao = new MySqlConnection();
        private MySqlCommand cm = new MySqlCommand();
        private MySqlDataAdapter memorydata = new MySqlDataAdapter();
        private string error;
        private string str;

        public Conexao (string server, string database, string user, string password)
        {
            str = "Persist Security Info=False;";
            str += "Server=" + server + ";";
            str += "Database=" + database + ";";
            str += "User id=" + user + ";";
            str += "Password=" + password + ";";

            //str = "SERVER=localhost;DATABASE=gymbd; User id=root; Password=;";
        }

        public string mgsError()
        {
            return error;
        }

        private bool connect()
        {
            try
            {
                disconnect();
                cxao.ConnectionString = str;
                cm.Connection = cxao;
                cxao.Open();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return false;
            }
        }
        private bool disconnect()
        {
            try
            {
                if(cxao.State == ConnectionState.Open)
                {
                    cxao.Close();
                }
                return true;
            }
            catch(Exception ex)
            {
                this.error = ex.Message.ToString();
                return false;
            }
        }

        public bool testConecction()
        {
            return connect();
        }

        public bool INSERT(string command)
        {
            try
            {
                bool retorno = false;
                if (this.connect())
                {
                    //cm = c;
                    cm.CommandText = command;
                    int result = cm.ExecuteNonQuery();
                    if (result > 0)
                    {
                        retorno = true;
                    }
                    else
                    {
                        error = "Erro na inclusão de dados";
                    }   
                }
                if (retorno)
                {
                    //
                }
                return retorno;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return false;
            }
        }

        public DataTable SELECT(string command)
        {
            try
            {
                if (connect())
                {
                    memorydata = new MySqlDataAdapter(command, cxao);
                    DataTable tb = new DataTable();
                    memorydata.Fill(tb);
                    if (tb.Rows.Count > 0)
                    {
                        return tb;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return null;
            }
        }

        public bool UPDATE(string command)
        {
            try
            {
                bool retorno = false;
                if (this.connect())
                {
                    cm.CommandText = command;
                    int result = cm.ExecuteNonQuery();
                    if (result > 0)
                    {
                        retorno = true;
                    }
                    else
                    {
                        error = "Erro na alteração de dados";
                    }
                }
                if (retorno)
                {
                    //
                }
                return retorno;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return false;
            }
        }

        public bool DELETE(string command)
        {
            try
            {
                if (this.connect())
                {
                    cm.CommandText = command;
                    int result = cm.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return true; ;
                    }
                    else
                    {
                        error = "Erro na inclusão de dados";
                    }
                }
                
                return false;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return false;
            }
        }
    }
}
