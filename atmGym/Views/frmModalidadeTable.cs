using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atmGym.Controller;

namespace atmGym.Views
{
    public partial class frmModalidadeTable : Form
    {
        public frmModalidadeTable()
        {
            InitializeComponent();
            CriarTabela();
        }

        private void CriarTabela()
        {
            data.Rows.Clear();
            DataTable dados = ModalidadeControler.SelectModalidade(); ;
            if (dados != null)
            {
                foreach (DataRow i in dados.Rows)
                {
                    preencherTabela(i[0].ToString(), i[1].ToString());
                }
            }


        }

        public void preencherTabela(string id, string nome)
        {
            data.Rows.Add(id, nome);
        }

        private void frmModalidadeTable_Load(object sender, EventArgs e)
        {

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }
            if (e.ColumnIndex == data.ColumnCount - 1)
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA DELETAR ESTE REGISTO?", "DELETAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (ModalidadeControler.DeleteModalidadeById(data.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        CriarTabela();
                        MessageBox.Show("REGISTO DELETADO COM SUCESSO");
                    }
                    else
                    {
                        MessageBox.Show(" NÃO FOI POSSIVEL DELETAR O REGISTO\n" + CanchaControler.getError());
                    }
                }
            }
            if (e.ColumnIndex == data.ColumnCount - 2)
            {
                frmModalidade f = new frmModalidade(data.Rows[e.RowIndex].Cells[0].Value.ToString());
                f.ShowDialog();

            }
        }
    }
}
