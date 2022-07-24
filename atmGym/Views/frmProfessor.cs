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
    public partial class frmProfessor : Form
    {
        public frmProfessor()
        {
            InitializeComponent();
            PreencherCheckModalidade();
        }
        public static string ID = null;
        public frmProfessor(string id)
        {
            InitializeComponent();
            PreencherCheckModalidade();
            DataRow dados = ProfessorControl.selectProfessorPessoa2(id);
            DataTable quali = ProfessorControl.selectQualificacao(id);
            DataTable espe = ProfessorControl.selectEspicializacao(id);
            DataTable dadosProfTelefone = ProfessorControl.selectProfessorTelefone(id);
            DataTable dadosModalidades = ModalidadeControler.SelectModalodadeProfessor(id);
            PreencherCheckModalidadeExist(dadosModalidades); 

            if (dados!=null)
            {
                ID = id;
                this.nomeP.Text = dados["nome"].ToString();
                this.biP.Text = dados["BI"].ToString();
                this.ncP.Text = dados["nCarteira"].ToString();
                this.sP.Text = dados["salario"].ToString();
                this.cidadeP.Text = dados["cidade"].ToString();
                this.muniP.Text = dados["municipio"].ToString();
                this.bairroP.Text = dados["bairro"].ToString();
                this.ruaP.Text = dados["rua"].ToString();
                this.ncasaP.Text = dados["nCasa"].ToString();
            }
            else
            {
                MessageBox.Show(ProfessorControl.getError());
            }
            //***************
            if (quali!=null)
            {
                foreach (DataRow i in quali.Rows)
                {
                    this.quaList.Items.Add(i[2].ToString());
                }
            }
            if (espe != null)
            {
                foreach (DataRow i in espe.Rows)
                {
                    this.esList.Items.Add(i[1].ToString());
                }
            }
            if (dadosProfTelefone != null)
            {
                foreach (DataRow i in dadosProfTelefone.Rows)
                {
                    this.teleList.Items.Add(i[1].ToString());
                }
            }
        }

        private void frmProfessor_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }
        public void PreencherCheckModalidade()
        {


            foreach (DataRow i in ModalidadeControler.SelectModalidade().Rows)
            {
                checkListModalidade.Items.Add(i[1].ToString());
            }
        }
        public void PreencherCheckModalidadeExist(DataTable b)
        {
           /* int a = 0;

            foreach (DataRow i in b.Rows)
            {
                foreach (string item in checkListModalidade.Items)
                {
                    if (item.ToString()==i[0].ToString())
                    {
                        checkListModalidade.SetItemChecked(a, true);
                    }
                    a++;
                }
            }*/
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
        public bool vazio(string n)
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
        public void ListToList(ListBox from, List<string> to)
        {
            for (int i = 0; i < from.Items.Count; i++)
            {
                to.Add(from.Items[i].ToString());
            }
        }

        public List<string> CheckListToList(CheckedListBox from)
        {
            List<string> b = new List<string>();
           
            foreach (string i in from.CheckedItems)
            {
                b.Add(i);
            }
        
            return b;
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

        private bool nCartairaExist(string n)
        {
            bool exist=false;

            foreach (DataRow i in ProfessorControl.selectProfessor().Rows)
            {
                string m = i[2].ToString();
                if (m.Equals(n))
                {
                    exist= true;
                }
                

            }
            return exist;
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
            if (vazio(ncP.Text) || vazio(nomeP.Text) || vazio(biP.Text) || vazio(sP.Text) || esList.Items.Count<1 || quaList.Items.Count < 1)
            {
                MessageBox.Show("Prencha todos os campos obrigatórios");
            }
            else
            {
                if (nCartairaExist(ncP.Text)==false && nBiExist(biP.Text)==false)
                {
                    List<string> tele = new List<string>();
                    List<string> quali = new List<string>();
                    List<string> espe = new List<string>();

                    ListToList(teleList, tele);
                    ListToList(quaList, quali);
                    ListToList(esList, espe);

                    double s = Double.Parse(sP.Text);
                    Professor p = new Professor(ncP.Text.Trim(), s, nomeP.Text.Trim(), biP.Text.Trim(),
                        cidadeP.Text.Trim(), muniP.Text.Trim(), bairroP.Text.Trim(), ruaP.Text.Trim(), ncasaP.Text.Trim(), tele, quali, espe);
                    if (ProfessorControl.addProfessor(p))
                    {
                        MessageBox.Show("SUCESSO");
                        limparCampos();
                    }
                    else
                    {
                        MessageBox.Show("NÃO FOI POSSIVEL CADASTRAR" + PessoaControl.getError() + "\n" + ProfessorControl.getError());
                    }

                    if (ProfessorControl.AddProfessorModalidade(CheckListToList(checkListModalidade)))
                    {

                    }
                    else
                    {
                        MessageBox.Show("NÃO FOI POSSIVEL ADICIONAR AS MODALIDADES NO REGISTO \n" + ProfessorControl.getError());
                    }
                }
                else
                {
                    MessageBox.Show("Nº CARTEIRA ou Nº BILHETE INSERIDO, JÁ EXISTE");
                }

                
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkListModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nomeP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
            
        }

        

        private void teleList_DoubleClick(object sender, EventArgs e)
        {

            removeSelectedItem(teleList, tele);
        }

        public void removeSelectedItem(ListBox list, MaskedTextBox txtBox)
        {
            int item = list.SelectedIndex;
            string num = list.SelectedItem.ToString();
            list.Items.RemoveAt(item);
            txtBox.Text = num;
        }
        public void removeSelectedItem(ListBox list, TextBox txtBox)
        {
            int item = list.SelectedIndex;
            string num = list.SelectedItem.ToString();
            list.Items.RemoveAt(item);
            txtBox.Text = num;
        }

        private void esList_DoubleClick(object sender, EventArgs e)
        {
            removeSelectedItem(esList, es);
        }

        private void quaList_DoubleClick(object sender, EventArgs e)
        {
            removeSelectedItem(quaList, qua);
        }

        private void ncP_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(e);
        }
        private void onlyNumber(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void onlyLetter(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && (e.KeyChar != 32) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void sP_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(e);
        }

        private void muniP_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyLetter(e);
        }

        private void bairroP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ruaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ncasaP_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumber(e);
        }
    }
}
