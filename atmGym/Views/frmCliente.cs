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


namespace atmGym.Views
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        public static string ID = null;

        public frmCliente(int id)
        {
            InitializeComponent();
            this.guna2Button1.Visible = false;
            DataRow dadosAluno = AlunoControl.selectAlunoById(id.ToString());
            DataTable dadosAlunoTelefone = PessoaControl.selectPessoaTelefone(id.ToString());
            if (dadosAluno != null)
            {
                ID = id.ToString();
                this.nomeC.Text = dadosAluno["nome"].ToString();
                this.biC.Text = dadosAluno["BI"].ToString();
                this.cidadeC.Text = dadosAluno["cidade"].ToString();
                this.muniC.Text = dadosAluno["municipio"].ToString();
                this.bairroC.Text = dadosAluno["bairro"].ToString();
                this.ruaC.Text = dadosAluno["rua"].ToString();
                this.ncasaC.Text = dadosAluno["nCasa"].ToString();

            }
            else
            {

            }
        }
        public frmCliente(string id)
        {
            InitializeComponent();

            this.guna2Button1.Visible = false;
           
            DataRow dadosClinte = ClienteControler.selectClienteById(id);
            DataTable dadosAlunoTelefone = PessoaControl.selectPessoaTelefone(id);
           
            
            if (dadosClinte != null)
            {
                ID = id;
                this.nomeC.Text = dadosClinte["nome"].ToString();
                this.biC.Text = dadosClinte["BI"].ToString();
                this.cidadeC.Text = dadosClinte["cidade"].ToString();
                this.muniC.Text = dadosClinte["municipio"].ToString();
                this.bairroC.Text = dadosClinte["bairro"].ToString();
                this.ruaC.Text = dadosClinte["rua"].ToString();
                this.ncasaC.Text = dadosClinte["nCasa"].ToString();
            }
            if (dadosAlunoTelefone != null)
            {
                foreach (DataRow i in dadosAlunoTelefone.Rows)
                {
                    this.teleListC.Items.Add(i[1].ToString());
                }
            }

        }

        public static string formaP = "";
        public static double mensalidade;
        public static string dInicio = "";
        public static string dFim = "";

        private void limparCampos()
        {
            
            this.nomeC.Text = "";
            this.biC.Text = "";
            this.cidadeC.Text = "";
            this.muniC.Text = "";
            this.bairroC.Text = "";
            this.ruaC.Text = "";
            this.ncasaC.Text = "";
            this.teleListC.Items.Clear();
            this.teleC.Clear();

        }
        private bool vazio(string n)
        {
            if (n.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool nBiExist(string n)
        {
            bool exist = false;

            foreach (DataRow i in PessoaControl.selectPessoa().Rows)
            {
                string m = i[2].ToString();
                if (m.Equals(n))
                {
                    exist = true;
                }


            }
            return exist;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<string> t = new List<string>();
            try
            {
                if (vazio(nomeC.Text) || vazio(biC.Text))
                {
                    MessageBox.Show("Prencha todos os campos");
                }
                else
                {
                    if (nBiExist(biC.Text) == false)
                    {
                        if (dInicio.Equals("") && dFim.Equals("") && formaP.Equals(""))
                        {
                            if (teleListC.Items.Count > 0)
                            {
                                ListToList(teleListC, t);
                            }



                            Cliente p = new Cliente(nomeC.Text.Trim(), biC.Text.Trim(),
                            cidadeC.Text.Trim(), muniC.Text.Trim(), bairroC.Text.Trim(), ruaC.Text.Trim(), ncasaC.Text.Trim(), t);
                            if (PessoaControl.addPessoas(p) && ClienteControler.addCliente(p))
                            {
                                MessageBox.Show("SUCESSO.");
                                limparCampos();
                            }
                            else
                            {
                                MessageBox.Show(PessoaControl.getError() + "\n" + ClienteControler.getError());
                            }
                        }
                        else
                        {
                            if (teleListC.Items.Count > 0)
                            {
                                ListToList(teleListC, t);
                            }
                            Contrato c = new Contrato(dInicio, dFim, formaP, mensalidade);
                            Cliente p = new Cliente(nomeC.Text.Trim(), biC.Text.Trim(),
                            cidadeC.Text.Trim(), muniC.Text.Trim(), bairroC.Text.Trim(), ruaC.Text.Trim(), ncasaC.Text.Trim(), t);
                            if (PessoaControl.addPessoas(p) && ClienteControler.addCliente(p) && AlunoControl.addAlunos(p) && ContratoControler.addContrato(c))
                            {
                                MessageBox.Show("SUCESSO");
                                limparCampos();
                            }
                            else
                            {
                                MessageBox.Show(PessoaControl.getError() + "\n" + ClienteControler.getError()
                                    + "\n" + AlunoControl.getError() + "\n" + ContratoControler.getError());
                            }


                        }
                    }
                    else
                    {
                        MessageBox.Show("Nº BILHETE INSERIDO JÁ EXISTE", "DADO JÁ EXISTE!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message.ToString());

            }

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ListToList(ListBox from, List<string> to)
        {
            for (int i = 0; i < from.Items.Count; i++)
            {
                to.Add(from.Items[i].ToString());
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (vazio(nomeC.Text) || vazio(biC.Text))
            {
                MessageBox.Show("Prencha os campos Obrigatórios");
            }
            else
            {
                frmContrato f = new frmContrato(nomeC.Text, biC.Text);
                f.ShowDialog();
            }
        }

        private void addTelefone_Click(object sender, EventArgs e)
        {
            string a = teleC.Text;

            if (a.Equals("") || a.Equals("(+244)         "))
            {
                MessageBox.Show("dado inválido");
            }
            else
            {
                teleListC.Items.Add(a);
                teleC.Clear();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void removeSelectedItem(ListBox list, MaskedTextBox txtBox)
        {
            int item = list.SelectedIndex;
            string num = list.SelectedItem.ToString();
            list.Items.RemoveAt(item);
            txtBox.Text = num;
        }
        private void teleListC_DoubleClick(object sender, EventArgs e)
        {
            removeSelectedItem(teleListC, teleC);
        }
    }
}
