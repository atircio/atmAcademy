using atmGym.Model.Dao;
using atmGym.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atmGym.Views
{
    public partial class frmContas : Form
    {
        string idMaster;
        public frmContas()
        {
            InitializeComponent();
            btnAlterar.Visible = false;
            guna2Button1.Visible = false;
        }
        public frmContas(bool a)
        {
            InitializeComponent();
            guna2Button1.Visible = false;
            nomeUsuario.Text = Conta.nome;
            UserName.Text = Program.nameUser;
            if (Conta.CriarConta)
            {
                guna2CheckBox1.Checked=true;
            }
            if (Conta.EliminarConta)
            {
                guna2CheckBox2.Checked = true;
            }
            if (Conta.AlterarContas)
            {
                guna2CheckBox3.Checked = true;
            }
            if (Conta.Cadastrar)
            {
                guna2CheckBox4.Checked = true;
            }
            if (Conta.Eliminar)
            {
                guna2CheckBox6.Checked = true;
            }
            if (Conta.Alterar)
            {
                guna2CheckBox7.Checked = true;
            }
            if (Conta.Consultar)
            {
                guna2CheckBox8.Checked = true;
            }
            if (Conta.GerarRelatorios)
            {
                guna2CheckBox6.Checked = true;
            }
            if (Conta.AgendarAulas)
            {
                AA.Checked = true;
            }
            if (a)
            {
                guna2Button1.Visible = true;
            }

            idMaster = Login.idUsuario;
           
        }

        public frmContas(string a, string nome, string nomeUser)
        {
            InitializeComponent();
            guna2Button1.Visible = false;
            nomeUsuario.Text = nome;
            UserName.Text = nomeUser;
            if (Conta.CriarConta)
            {
                guna2CheckBox1.Checked = true;
            }
            if (Conta.EliminarConta)
            {
                guna2CheckBox2.Checked = true;
            }
            if (Conta.AlterarContas)
            {
                guna2CheckBox3.Checked = true;
            }
            if (Conta.Cadastrar)
            {
                guna2CheckBox4.Checked = true;
            }
            if (Conta.Eliminar)
            {
                guna2CheckBox6.Checked = true;
            }
            if (Conta.Alterar)
            {
                guna2CheckBox7.Checked = true;
            }
            if (Conta.Consultar)
            {
                guna2CheckBox8.Checked = true;
            }
            if (Conta.GerarRelatorios)
            {
                guna2CheckBox6.Checked = true;
            }
            if (Conta.AgendarAulas)
            {
                AA.Checked = true;
            }

             idMaster = Login.idUsuario;
             Login.idUsuario = a;
        }

        private void PermissoesGroupBox_Enter(object sender, EventArgs e)
        {

        }
        string CC="0", EC = "0", AS = "0", C = "0", E = "0", A = "0", CO = "0", GR = "0", aa="0";

        private void guna2CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox7.Checked)
            {
                aa = "1";
            }
            else
            {
                aa = "0";
            }
        }

        private void guna2CheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox8.Checked)
            {
                CO = "1";
            }
            else
            {
                CO = "0";
            }
        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox8.Checked)
            {
                GR = "1";
            }
            else
            {
                GR = "0";
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAlter_click(object sender, EventArgs e)
        {


            string sql = "UPDATE `gymbd`.`usuario` SET `pass` = '" + senha.Text.Trim() + "'," +
            " `login` = '"+ UserName.Text.Trim() + "', `Nome` = '"+ nomeUsuario.Text.Trim() + "', `CC` = '"+CC+"', `EC` = '"+EC+"'," +
            " `AS` = '"+AS+"', `C` = '"+C+"', `E` = '"+E+"', `A` = '"+A+"', `CO` = '"+CO+"'," +
            " `GR` = '"+GR+"', `AA` = '"+AA+"' WHERE(`idUsuario` = '"+Login.idUsuario+"');";

            Login.idUsuario = idMaster;

            if (Program.c.INSERT(sql))
            {
                MessageBox.Show("CONTA ALTERADA COM SUCESSO");
            }
            else
            {
                MessageBox.Show("CONTA NÃO ALTERADA!");
            }
            
        }

        private void frmContas_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox6.Checked)
            {
                E = "1";
            }
            else
            {
                E = "0";
            }
        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            
                 if (guna2CheckBox4.Checked)
            {
                C= "1";
            }
            else
            {
                C = "0";
            }
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox3.Checked)
            {
                AS = "1";
            }
            else
            {
                AS = "0";
            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
            {
                EC = "1";
            }
            else
            {
                EC = "0";
            }
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                CC = "1";
            }
            else
            {
                CC = "0";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (Conta.CriarConta)
            {

                string sql = "INSERT INTO `gymbd`.`usuario` (`pass`, `login`,`Nome` ,`CC`, `EC`, `AS`, `C`, `E`, `A`, `CO`, `GR`, `AA`) " +
                "VALUES('" + senha.Text.Trim() + "', '" + UserName.Text.Trim() + "', ' " + nomeUsuario.Text.Trim() + "', '" + CC + "', '" + EC + "', '" + AS + "', '" + C + "', '" + E + "', '" + A + "', '" + CO + "', '" + GR + "', '" + aa+ "');";

                if (Program.c.INSERT(sql))
                {
                    MessageBox.Show("CONTA CRIADA COM SUCESSO");
                }
                else
                {
                    MessageBox.Show("ERRO AO CRIAR A CONTA", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }
        private void contas(object sender, EventArgs e)
        {
            if (Conta.AlterarContas)
            {
                frmContaTable fprof = new frmContaTable();
                // Form1.ActiveForm.Opacity = 0.86;
                fprof.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AS_Click(object sender, EventArgs e)
        {
            if (Conta.AlterarContas)
            {
                frmContaTable f = new frmContaTable();
                f.ShowDialog();
            }
        }
    }
}
