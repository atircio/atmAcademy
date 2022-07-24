using atmGym.Controller;
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
    public partial class frmEspacoTable : Form
    {
        public frmEspacoTable()
        {
            InitializeComponent();
            CriarTabelaSala();
        }

        public void preencherTabela(string id, string nome, string nbi)
        {
            data.Rows.Add(id, nome, nbi);
        }
        private void CriarTabelaSala()
        {
            data.Rows.Clear();
            DataTable dados = SalaControler.selectAllSalaEspaco();
            if (dados != null)
            {
                foreach (DataRow i in dados.Rows)
                {
                    preencherTabela(i[0].ToString(), i[1].ToString(), i[2].ToString());
                }
            }
        }
        private void CriarTabelaCancha()
        {
            data.Rows.Clear();

            DataTable dados = CanchaControler.selectAllCanchaEspaco();
            if (dados != null)
            {
                foreach (DataRow i in dados.Rows)
                {
                    preencherTabela(i[0].ToString(), i[1].ToString(), i[2].ToString());
                }
            }
        }

        private void frmEspacoTable_Load(object sender, EventArgs e)
        {

        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSala.Checked)
            {
                data.Rows.Clear();
                CriarTabelaSala();
            }
            
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCancha.Checked)
            {
                data.Rows.Clear();
                CriarTabelaCancha();
            }
            
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex > -1)
            {
                if (e.ColumnIndex < data.ColumnCount - 2)
                {
                    MessageBox.Show(data.Rows[e.RowIndex].Cells[0].Value.ToString());
                    frmEspaco f = new frmEspaco(data.Rows[e.RowIndex].Cells[0].Value.ToString());
                    f.ShowDialog();
                }

            }*/
        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkSala.Checked)
            {
                if (e.ColumnIndex == 0)
                {
                    return;
                }
                if (e.ColumnIndex == data.ColumnCount - 1)
                {
                    if (MessageBox.Show("TEM CERTEZA QUE DESEJA DELETAR ESTE REGISTO?", "DELETAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (SalaControler.DeleteSalaById(data.Rows[e.RowIndex].Cells[0].Value.ToString()))
                        {
                            CriarTabelaSala();
                            MessageBox.Show("REGISTO DELETADO COM SUCESSO");
                        }
                        else
                        {
                            MessageBox.Show(" NÃO FOI POSSIVEL DELETAR O REGISTO\n" + SalaControler.getError());
                        }
                    }       
                }
                if (e.ColumnIndex == data.ColumnCount - 2)
                {
                    frmEspaco f = new frmEspaco(data.Rows[e.RowIndex].Cells[0].Value.ToString());
                    f.ShowDialog();

                }
            }
            else
            {
                if (e.ColumnIndex == 0)
                {
                    return;
                }
                if (e.ColumnIndex == data.ColumnCount - 1)
                {
                    if (MessageBox.Show("TEM CERTEZA QUE DESEJA DELETAR ESTE REGISTO?", "DELETAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (CanchaControler.DeleteCanchaById(data.Rows[e.RowIndex].Cells[0].Value.ToString()))
                        {
                            CriarTabelaCancha();
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
                    frmEspaco f = new frmEspaco(Int32.Parse(data.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    f.ShowDialog();

                }
            }
            
        }
    }
}
