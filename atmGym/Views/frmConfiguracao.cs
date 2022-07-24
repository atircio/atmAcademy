using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atmGym.Model.Dao;

namespace atmGym.Views
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            usernameConfig.Text = Conta.nome;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (Conta.CriarConta)
            {
                frmContas F = new frmContas();
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Conta.EliminarConta)
            {
                frmContas F = new frmContas();
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            frmMain.ActiveForm.Close();
            View.Login l = new View.Login();
            l.Show();   
            

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (Conta.AlterarContas)
            {
                frmContas fprof = new frmContas(true);
                // Form1.ActiveForm.Opacity = 0.86;
                fprof.ShowDialog();
            }
            else
            {
                frmContas fprof = new frmContas();
                fprof.ShowDialog();
            }
        }
    }
}
