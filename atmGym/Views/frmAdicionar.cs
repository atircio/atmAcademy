using atmGym.Model.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmGym.Views
{
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProf_Click(object sender, EventArgs e)
        {
            if (Conta.Cadastrar)
            {
                frmProfessor fprof = new frmProfessor();
                // Form1.ActiveForm.Opacity = 0.86;
                fprof.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Conta.Cadastrar)
            {
                frmCliente F = new frmCliente();
                // Form1.ActiveForm.Opacity = 0.86;
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Conta.Cadastrar)
            {
                frmModalidade F = new frmModalidade();
                // Form1.ActiveForm.Opacity = 0.86;
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Conta.Cadastrar)
            {
                frmEspaco F = new frmEspaco();
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Conta.AgendarAulas)
            {
                frmAula F = new frmAula();
                // Form1.ActiveForm.Opacity = 0.86;
                F.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
