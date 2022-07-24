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
using atmGym.Model.Entity;

namespace atmGym.Views
{
    public partial class frmAula : Form
    {
        string idProf=null;
        public frmAula()
        {
            InitializeComponent();
            CriarTabela();
            if (checkSala.Checked)
            {
                if (SalaControler.selectAllSalaEspaco() != null)
                {
                    DataTable b = SalaControler.selectAllSalaEspaco();
                    foreach (DataRow i in b.Rows)
                    {
                        ComboEspaco.Items.Add(i[2].ToString());
                    }
                }

            }

        }

        private void limparCampos()
        {
            CriarTabela();
            
        }


        public void CriarTabela()
        {
            data.Rows.Clear();
            foreach (DataRow i in ProfessorControl.selectProfessor().Rows)
            {

                preencherTabela(i[0].ToString(), i[1].ToString());
            }

            foreach( DataRow i in ModalidadeControler.SelectModalidade().Rows)
            {
                comoModalidade.Items.Add(i[1].ToString());
            }

            foreach (DataRow i in SalaControler.selectAllSalaEspaco().Rows)
            {
                comoModalidade.Items.Add(i[2].ToString());
            }
            

        }


        public void preencherTabela(string id, string nome)
        {
            data.Rows.Add(id, nome );
        }

        private void frmAula_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void checkSala_CheckedChanged(object sender, EventArgs e)
        {
            ComboEspaco.Items.Clear();
            if (checkSala.Checked)
            {
                if (SalaControler.selectAllSalaEspaco() != null)
                {
                    DataTable b = SalaControler.selectAllSalaEspaco();
                    foreach (DataRow i in b.Rows)
                    {
                        ComboEspaco.Items.Add(i[2].ToString());
                    }
                }
                
            }
            
        }

        private void checkCancha_CheckedChanged(object sender, EventArgs e)
        {
            ComboEspaco.Items.Clear();
            if (checkCancha.Checked)
            {
                if (CanchaControler.selectAllCanchaEspaco() != null)
                {
                    DataTable b = CanchaControler.selectAllCanchaEspaco();
                    foreach (DataRow i in b.Rows)
                    {
                        ComboEspaco.Items.Add(i[2].ToString());
                    }
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comoModalidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = comoModalidade.SelectedItem.ToString();
            data.Rows.Clear();
            if (ProfessorControl.SelectProfessorByModalidadeNome(nome) != null)
            {
                foreach (DataRow i in ProfessorControl.SelectProfessorByModalidadeNome(nome).Rows)
                {

                    preencherTabela(i[0].ToString(), i[1].ToString());
                }
            }
            else
            {
                data.Rows.Clear();
            }
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string idProfessor = idProf;
            string idModalidade = null;
            string idEspaco = null;
            string DURACAO = duracao.Value.ToString();
            string HORA = hora.Text;
            string LIMITEALUNO = limiteAluno.Value.ToString();
            string DATA = dataAula.Text;

            if (ModalidadeControler.selectModalidadeByNome(comoModalidade.SelectedItem.ToString()) != null)
            {
                DataRow i = ModalidadeControler.selectModalidadeByNome(comoModalidade.SelectedItem.ToString());
                idModalidade = i[0].ToString();
            }

            if (checkSala.Checked)
            {
                if (SalaControler.SelectSalaByNsala(ComboEspaco.SelectedItem.ToString()) != null)
                {
                    DataRow i = SalaControler.SelectSalaByNsala(ComboEspaco.SelectedItem.ToString());
                    idEspaco = i[0].ToString();
                }
            }
            else
            {
                if (CanchaControler.SelectCanchaByNsala(ComboEspaco.SelectedItem.ToString()) != null)
                {
                    DataRow i = CanchaControler.SelectCanchaByNsala(ComboEspaco.SelectedItem.ToString());
                    idEspaco = i[0].ToString();
                }
            }

            if (idProfessor!=null && idModalidade != null && idEspaco != null)
            {
                Aula a = new Aula(idProfessor, idModalidade, idEspaco, DURACAO, HORA, LIMITEALUNO, DATA);
                if (AulaControler.addAula(a))
                {
                    MessageBox.Show("AULA AGENDADA COM SUCESSO");
                    limparCampos();
                }
                else
                {
                    MessageBox.Show(AulaControler.getError());
                }

            }

           




        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             idProf = data.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}
