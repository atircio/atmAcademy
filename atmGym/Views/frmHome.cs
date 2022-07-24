using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atmGym.Controller;
using atmGym.Model.Dao;

namespace atmGym.Views
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
            numAlunos.Text = PessoaControl.countOfTable("aluno");
            numClientes.Text = PessoaControl.countOfTable("cliente");
            numProf.Text = PessoaControl.countOfTable("professor");
            numModalidade.Text = PessoaControl.countOfTable("modalidade");
            numEspaco.Text = PessoaControl.countOfTable("espaco");

            var d = new DateTime();

            d = DateTime.Now;
            dataHoje.Text = d.ToShortDateString();
            
            
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            NomeCompleto.Text = Conta.nome;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var d = new DateTime();

            d = DateTime.Now;
            hora.Text = d.ToLongTimeString();
        }
    }
}
