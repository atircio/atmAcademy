using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using atmGym.Controller;

namespace atmGym.Views
{
    public partial class frmConsularProfessor : Form
    {
        public frmConsularProfessor(string id)
        {
            InitializeComponent();

            DataTable dados = ProfessorControl.selectProfessorPessoa(id);
            DataTable telefone = Program.c.SELECT("SELECT");
            DataTable qua = Program.c.SELECT("SELECT");
            DataTable espe = Program.c.SELECT("SELECT");
            if (dados != null)
            {
                DataRow linhaDados = dados.Rows[0];
               // this.Nome =
                this.Nome.Text = linhaDados["nome"].ToString();
                this.nBI.Text = linhaDados["BI"].ToString();
                this.cidade.Text = linhaDados["cidade"].ToString();
                this.municipio.Text = linhaDados["municipio"].ToString();
                this.bairro.Text = linhaDados["bairro"].ToString();
                this.Rua.Text = linhaDados["rua"].ToString();
                this.nCasa.Text = linhaDados["nCasa"].ToString();
                this.nC.Text = linhaDados["nCarteira"].ToString();
                this.salario.Text = linhaDados["salario"].ToString();
            }
        }

        private void frmConsularProfessor_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
    }
}
