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
    public partial class frmModalidade : Form
    {
        public frmModalidade()
        {
            InitializeComponent();
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adiconarE_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios");
            }
            else
            {
                Modalidade m = new Modalidade(txtNome.Text, txtDescricao.Text);
                if (ModalidadeControler.addModalidade(m))
                {
                    MessageBox.Show("Sucesso");
                    txtNome.Text = "";
                    txtDescricao.Text = "";
                }
                else
                {
                    MessageBox.Show(ModalidadeControler.getError());
                }
            }
        }

        private void frmModalidade_Load(object sender, EventArgs e)
        {

        }
    }
}
