using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using atmGym.Controller;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace atmGym.Views
{
    public partial class frmProfTable : Form
    {
        public frmProfTable()
        {
            
            InitializeComponent();
            CriarTabela();
            
        }

        public void CriarTabela()
        {
            data.Rows.Clear();
            foreach (DataRow i in ProfessorControl.selectProfessor().Rows)
            {

                preencherTabela(i[0].ToString(), i[1].ToString(), i[2].ToString() ,i[3].ToString());
            }

        }
      

        public void preencherTabela(string id, string nome,string nCa, string salario)
        {
            data.Rows.Add(id, nome,nCa, salario);
        }

        private void frmProfTable_Load(object sender, EventArgs e)
        {
            Color myRgbColor = new Color();
            myRgbColor = Color.FromArgb(81, 190, 161);

            data.Columns[4].DefaultCellStyle.BackColor = myRgbColor;
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex < data.ColumnCount-2)
                {
                    MessageBox.Show(data.Rows[e.RowIndex].Cells[0].Value.ToString());
                    frmConsularProfessor f = new frmConsularProfessor(data.Rows[e.RowIndex].Cells[0].Value.ToString());
                    f.ShowDialog();
                }
                
            }
            
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
                    if (ProfessorControl.DeleteProfessorById(data.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        CriarTabela();
                        guna2CheckBox1_CheckedChanged(sender, EventArgs.Empty);
                        MessageBox.Show("PROFESSOR DELETADO COM SUCESSO");

                    }
                    else
                    {
                        MessageBox.Show(" NÃO FOI POSSIVEL DELETAR O REGISTO\n" + ProfessorControl.getError());

                    }

                }
            }
                
            
            if (e.ColumnIndex == data.ColumnCount - 2)
            {
                frmProfessor f = new frmProfessor(data.Rows[e.RowIndex].Cells[0].Value.ToString());
                f.ShowDialog();

            }
            
        }

        private void data_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        string modalidades;
        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkModalidade.Checked)
            {
                try
                {
                    data.Columns.Remove("MODALIDADE");
                }
                catch (Exception)
                { }


                    DataGridViewTextBoxColumn mod = new DataGridViewTextBoxColumn();
                mod.Name = "MODALIDADE";
                data.Columns.Insert(data.Columns.Count-2,mod);
                string id;

                int tamanho = data.Rows.Count;
                for (int i = 0; i < tamanho; i++)
                {
                    modalidades = "";
                    id = data.Rows[i].Cells[0].Value.ToString();
                    if (ProfessorControl.SelectModalidadeProfessorById(id) != null)
                    {
                        DataTable r = ProfessorControl.SelectModalidadeProfessorById(id);
                        foreach (DataRow b in r.Rows)
                        {
                            modalidades = modalidades + "\n " + b[2].ToString();
                            
                        }
                        data.Rows[i].Cells[data.Columns.Count - 3].Value = modalidades;
                    }
                   

                }

            }
            else
            {
                try
                {
                    data.Columns.Remove("MODALIDADE");
                }
                catch (Exception)
                {
                    
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
