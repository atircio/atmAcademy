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
    public partial class frmCliente : Form
    {
        public static string formaP="";
        public static double mensalidade;
        public static string dInicio="";
        public static string dFim="";
        public frmCliente()
        {
            InitializeComponent();

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            
    }

        private void closeForm_Click(object sender, EventArgs e)
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

        private void AdicionarCliente_Click(object sender, EventArgs e)
        {
            List<string> t = new List<string>();
            try
            {
                if (vazio(nomeC) || vazio(biC))
                {
                    MessageBox.Show("Prencha todos os campos");
                }
                else
                {

                    if (dInicio.Equals("") && dFim.Equals("") && formaP.Equals(""))
                    {
                        ListToList(teleListC, t);
                        Cliente p = new Cliente(nomeC.Text.Trim(), biC.Text.Trim(),
                        cidadeC.Text.Trim(), muniC.Text.Trim(), bairroC.Text.Trim(), ruaC.Text.Trim(), ncasaC.Text.Trim(),t);
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
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message.ToString());
                
            }
            
        }
        private bool vazio(TextBox n)
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

        private void limparCampos()
        {
            this.nomeC.Text = "";
            this.biC.Text = "";
            this.cidadeC.Text = "";
            this.muniC.Text = "";
            this.bairroC.Text = "";
            this.ruaC.Text = "";
            this.ncasaC.Text = "";

        }

        private void btnAddContrato_Click(object sender, EventArgs e)
        {
            if (vazio(nomeC) || vazio(biC))
            {
                MessageBox.Show("Prencha os campos Obrigatórios");
            }
            else
            {
                frmContrato f = new frmContrato(nomeC.Text, biC.Text);
                f.ShowDialog();
            }
            
        }

        private void addTelefoneC_Click(object sender, EventArgs e)
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
    }
}
