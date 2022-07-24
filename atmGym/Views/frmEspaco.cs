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
    public partial class frmEspaco : Form
    {
        public frmEspaco()
        {
            InitializeComponent();

        }
        static string ID;
        public frmEspaco(string id)
        {
            InitializeComponent();
            this.guna2Button1.Visible = false;
            DataRow dadosSala = SalaControler.selectSalaById(id);
            if (dadosSala != null)
            {
                ID = id;
                this.txtAndar.Text = dadosSala["andar"].ToString();
                this.txtNsala.Text = dadosSala["nSala"].ToString();
            }


        }
        public frmEspaco(int id)
        {
            InitializeComponent();
            this.guna2Button1.Visible = false;
            DataRow dadosCancha = CanchaControler.selectCanchaById(id.ToString());
            if (dadosCancha != null)
            {
                ID = id.ToString();
                this.txtAndar.Text = dadosCancha["andar"].ToString();
                this.txtNsala.Text = dadosCancha["nSala"].ToString();
            }

        }

        private void frmEspaco_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtAndar.Text.Equals("") && txtNsala.Text.Equals(""))
            {

            }
            else
            {
                if (radioCancha.Checked)
                {
                    Cancha c = new Cancha(txtAndar.Text, txtNsala.Text);
                    if (EspacoControler.addEspaco(c) && CanchaControler.addCacha(c))
                    {
                        MessageBox.Show("SUCESSO");
                    }
                    else
                    {
                        MessageBox.Show(EspacoControler.getError() + "\n" + CanchaControler.getError());
                    }
                }
                else
                {
                    Sala c = new Sala(txtAndar.Text, txtNsala.Text);
                    if (EspacoControler.addEspaco(c) && SalaControler.addSala(c))
                    {
                        MessageBox.Show("SUCESSO");
                    }
                    else
                    {
                        MessageBox.Show(EspacoControler.getError() + "\n" + SalaControler.getError());

                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
