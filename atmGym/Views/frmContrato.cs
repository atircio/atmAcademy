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
    public partial class frmContrato : Form
    {

        public frmContrato(string nome, string bi)
        {
            InitializeComponent();
            this.nomeAluno.Text = nome;
            this.biAluno.Text = bi;
        }
        public frmContrato()
        {
            InitializeComponent();
        }

        private void biAluno_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente.mensalidade = Double.Parse(this.Mensalidade.Text);
                frmCliente.formaP = this.formaPagamento.Text;
                frmCliente.dInicio = this.dataInicio.Text;
                frmCliente.dFim = this.dataFim.Text;
                MessageBox.Show("Contrado adicionado com suceso ao registo de " + this.nomeAluno.Text);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o contrato \n ERRO: " + ex.Message.ToString());
                this.Close();
            }
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
