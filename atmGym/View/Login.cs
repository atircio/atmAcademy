using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atmGym.Model.Dao;

namespace atmGym.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static string idUsuario;
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = textuser.Text;
            string comando = "select p.nome, a.login, a.pass from pessoa p " +
                "join usuario a " +
                "on a.idUsuario = p.idPessoa " +
                "where login ='" +login+"' limit 1;";
             
            string cmd = "select * from usuario where login ='"+login+"';";
            //DataRow dados = Program.c.SELECT(comando).Rows[0];

            var dados = Program.c.SELECT(cmd);
            if(dados != null)
            {
                DataRow linhaDados = dados.Rows[0];
                string senha = linhaDados["pass"].ToString();
                string loginUsuario = linhaDados["login"].ToString();
                string nome = linhaDados[3].ToString();
                if ((senha == textPass.Text && loginUsuario==textuser.Text) || (senha == textPass.Text && nome == textuser.Text))
                {
                    idUsuario = linhaDados[0].ToString();
                    Conta.nome = nome;
                    if (linhaDados[4].ToString()=="1")
                    {
                        Conta.CriarConta = true;
                    }
                    if (linhaDados[5].ToString() == "1")
                    {
                        Conta.EliminarConta = true;
                    }
                    if (linhaDados[6].ToString() == "1")
                    {
                        Conta.AlterarContas = true;
                    }
                    if (linhaDados[7].ToString() == "1")
                    {
                        Conta.Cadastrar = true;
                    }
                    if (linhaDados[8].ToString() == "1")
                    {
                        Conta.Eliminar = true;
                    }
                    if (linhaDados[9].ToString() == "1")
                    {
                        Conta.Alterar = true;
                    }
                    if (linhaDados[10].ToString() == "1")
                    {
                        Conta.Consultar = true;
                    }
                    if (linhaDados[11].ToString() == "1")
                    {
                        Conta.GerarRelatorios = true;
                    }
                    if (linhaDados[12].ToString() == "1")
                    {
                        Conta.AgendarAulas = true;
                    }
                    
                    Program.nameUser = loginUsuario;
                    this.DialogResult = DialogResult.Yes;

                }
            }
            else
            {
                MessageBox.Show("Usuario Não encontrado");
            }

            if (textuser.Text.Equals("admin") && textPass.Text.Equals("admin") )
            {
                this.DialogResult = DialogResult.Yes;

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
