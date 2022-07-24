using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using atmGym.Model.Entity;
using atmGym.View;
using atmGym.Views;



namespace atmGym
{
    internal static class Program
    {
        public static Conexao c = new Conexao("localhost", "gymbd", "root", "");
        public static string nameUser;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            frmMain f = new frmMain();


            if (c.testConecction())
            {
                Login log = new Login();
                DialogResult resultado = log.ShowDialog();
                
                if (resultado == DialogResult.Yes)
                {
                    
                    Application.Run(f);
                }
                else
                {
                    f.Close();
                }
            }
            else
            {
                MessageBox.Show(c.mgsError(), "ERRO NA CONEXÇÃO" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
