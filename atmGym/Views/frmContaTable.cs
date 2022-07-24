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
    public partial class frmContaTable : Form
    {
        public frmContaTable()
        {
            InitializeComponent();
            CriarTabela();
        }
        private void CriarTabela()
        {
            data.Rows.Clear();
            string comando = "select idUsuario ,nome, login from usuario;";
            var dados = Program.c.SELECT(comando);
            if (dados != null)
            {
                foreach (DataRow i in dados.Rows)
                {
                    preencherTabela(i[0].ToString(), i[1].ToString(), i[2].ToString());
                }
            }
        }
        public void preencherTabela(string id, string nome, string login)
        {
            data.Rows.Add(id, nome, login);
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmContaTable_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == data.ColumnCount - 1)
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA DELETAR ESTA CONTA?", "DELETAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (deletarConta(data.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        CriarTabela();
                        MessageBox.Show("CONTA DELETADO COM SUCESSO");
                    }
                    else
                    {
                        MessageBox.Show(" NÃO FOI POSSIVEL DELETAR A CONTA\n");
                    }
                }
            }
            if (e.ColumnIndex == data.ColumnCount - 2)
            {
                frmContas f = new frmContas(data.Rows[e.RowIndex].Cells[0].Value.ToString(), data.Rows[e.RowIndex].Cells[1].Value.ToString(), data.Rows[e.RowIndex].Cells[2].Value.ToString());
                f.ShowDialog();

            }
        }

        private bool deletarConta(string id)
        {
            string comando = "delete from usuario where idUsuario = '" + id + "';";
            if (Program.c.DELETE(comando))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

    }
}