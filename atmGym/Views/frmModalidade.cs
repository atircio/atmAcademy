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
    public partial class frmModalidade : Form
    {
        static string ID;
        public frmModalidade()
        {
            InitializeComponent();
        }
        public frmModalidade(string id)
        {
            InitializeComponent();

            this.guna2Button1.Visible = false;

            DataRow dadosModalidade = ModalidadeControler.selectModalidadeByID(id);


            if (dadosModalidade != null)
            {
                ID = id;
                this.txtNome.Text = dadosModalidade["nome"].ToString();
                this.txtDescricao.Text = dadosModalidade["descricao"].ToString();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool nomeModalidadeExist(string n)
        {
            bool exist = false;

            foreach (DataRow i in ModalidadeControler.SelectModalidade().Rows)
            {
                string m = i[1].ToString();
                if (m.Equals(n))
                {
                    exist = true;
                }


            }
            return exist;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios");
            }
            else
            {
                if (nomeModalidadeExist(txtNome.Text)==false)
                {
                    Modalidade m = new Modalidade(txtNome.Text, txtDescricao.Text);
                    if (ModalidadeControler.addModalidade(m))
                    {
                        MessageBox.Show("REGISTO FEITO COM SUCESSO","SUCESSO",MessageBoxButtons.OK);
                        txtNome.Text = "";
                        txtDescricao.Text = "";
                    }
                    else
                    {
                        MessageBox.Show(ModalidadeControler.getError());
                    }
                }
                else
                {
                    MessageBox.Show("O NOME DA MODALIDADE QUE FOI INSERIDO JÁ EXISTE", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void frmModalidade_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
