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
    public partial class frmEspaco : Form
    {
        public frmEspaco()
        {
            InitializeComponent();
        }

        private void adiconarEspaco_Click(object sender, EventArgs e)
        {
            if(txtAndar.Text.Equals("") && txtNsala.Text.Equals(""))
            {

            }
            else
            {
                if (radioCancha.Checked)
                {
                    Cancha c = new Cancha(txtAndar.Text, txtNsala.Text);
                    if ( EspacoControler.addEspaco(c)  &&  CanchaControler.addCacha(c))
                    {
                        this.Close();
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
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(EspacoControler.getError() + "\n" + SalaControler.getError());

                    }
                }
            }
            
            
        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEspaco_Load(object sender, EventArgs e)
        {

        }
    }
}
