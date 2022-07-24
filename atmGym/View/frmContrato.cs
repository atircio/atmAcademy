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
    public partial class frmContrato : Form
    {
        public frmContrato(string nome, string bi)
        {
            InitializeComponent();
            this.nomeAluno.Text = nome;
            this.biAluno.Text = bi;
        }

        private void frmContrato_Load(object sender, EventArgs e)
        {

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddContrato_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            try
            {
                frmCliente.mensalidade = Double.Parse(this.Mensalidade.Text);
                frmCliente.formaP = this.formaPagamento.Text;
                frmCliente.dInicio  = this.dataInicio.Text;
                frmCliente.dFim =  this.dataFim.Text;
                MessageBox.Show("Contrado adicionado com suceso ao registo de " + this.nomeAluno.Text);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar o contrato \n ERRO: " + ex.Message.ToString());
                this.Close();
            }

           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
