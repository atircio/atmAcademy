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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void limparCampos()
        {
            this.nomeP.Text = "";
            this.ncP.Text = "";
            this.sP.Text = "";
            this.biP.Text = "";
            this.cidadeP.Text = "";
            this.muniP.Text = "";
            this.bairroP.Text = "";
            this.ruaP.Text = "";
            this.ncasaP.Text = "";
            this.tele.Text = "";
            this.teleList.Items.Clear();
            this.quaList.Items.Clear();
            this.esList.Items.Clear();

        }

        private void AdicionarProfessor_Click(object sender, EventArgs e)
        {
            if(vazio(ncP) || vazio(nomeP) || vazio(biP) || vazio(sP))
            {
                MessageBox.Show("Prencha todos os campos obrigatórios");
            }
            else
            {

                List<string> tele = new List<string>();
                List<string> quali = new List<string>();
                List<string> espe = new List<string>();

                ListToList(teleList, tele);
                ListToList(quaList, quali);
                ListToList(esList, espe);

                double s = Double.Parse(sP.Text);
                Professor p = new Professor(ncP.Text.Trim(), s, nomeP.Text.Trim(), biP.Text.Trim(),
                    cidadeP.Text.Trim(), muniP.Text.Trim(), bairroP.Text.Trim(), ruaP.Text.Trim(), ncasaP.Text.Trim(), tele,quali,espe);
                if (PessoaControl.addPessoas(p) && ProfessorControl.addProfessor(p))
                {
                    MessageBox.Show("SUCESSO");
                    limparCampos();
                }
            }
            
        }

        public void ListToList(ListBox from, List<string>to)
        {
            for (int i = 0; i < from.Items.Count; i++)
            {
                to.Add(from.Items[i].ToString());
            }
        }

        public bool  vazio(TextBox n)
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

        public void opacity(int n)
        {
            Form1.ActiveForm.Opacity = n;
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

      

        private void frmProfessor_Load(object sender, EventArgs e)
        {

        }

        private void adEs_Click(object sender, EventArgs e)
        {
            string a = es.Text.Trim();
            if (a.Equals(""))
            {

            }
            else
            {
                esList.Items.Add(a);
                es.Text = "";
            }
        }

        private void addQua_Click(object sender, EventArgs e)
        {
            string a = qua.Text.Trim();
            if (a.Equals(""))
            {

            }
            else
            {
                quaList.Items.Add(a);
                qua.Text = "";
            }
        }

        private void addTelefone_Click(object sender, EventArgs e)
        {
            string a = tele.Text;

            if (a.Equals("") || a.Equals("(+244)         "))
            {
                MessageBox.Show("dado inválido");
            }
            else
            {
                teleList.Items.Add(a);
                tele.Clear();
            }
        }

        private void tele_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void teleList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
