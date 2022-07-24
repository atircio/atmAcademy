using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmGym.View
{
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
        }

        public void formLoader(Form f)
        {

            
        }

        private void btnAddProf_Click(object sender, EventArgs e)
        {
            frmProfessor fprof = new frmProfessor();
            // Form1.ActiveForm.Opacity = 0.86;
            fprof.ShowDialog();

        }

        private void btnAddAluno_Click(object sender, EventArgs e)
        {
            frmAluno f = new frmAluno();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCliente f = new frmCliente();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEspaco f = new frmEspaco();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmModalidade f = new frmModalidade();
            f.ShowDialog();
        }
    }
}
