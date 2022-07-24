using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atmGym.Model.Entity;
using atmGym.Controller;

namespace atmGym.View
{
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarAluno_Click(object sender, EventArgs e)
        {
            /*if (vazio(nomeA) || vazio(biA))
            {
                MessageBox.Show("Prencha todos os campos");
            }
            else
            {
                Aluno p = new Aluno(nomeA.Text.Trim(), biA.Text.Trim(),
                    cidadeA.Text.Trim(), muniA.Text.Trim(), bairroA.Text.Trim(), ruaA.Text.Trim(), ncasaA.Text.Trim());
                if (PessoaControl.addPessoas(p) && AlunoControl.addAlunos(p))
                {
                    MessageBox.Show("SUCESSO");
                }
            }*/
        }

        public bool vazio(TextBox n)
        {
            if (n.Text.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
