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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace atmGym.Views
{
    public partial class frmAulaTable : Form
    {
        public frmAulaTable()
        {
            InitializeComponent();
            closeBtn.Visible = false;
            gerarRelatorio.Visible = false;
            CriarTabela();
        }
        public frmAulaTable(bool a)
        {
            InitializeComponent();

            CriarTabela();
            data.Columns.Remove(editar);
            data.Columns.Remove(deletar);
        }

        private void CriarTabela()
        {
            data.Rows.Clear();
                DataTable dados = AulaControler.selectAllAula(); 
            if (dados != null)
            {
                foreach (DataRow i in dados.Rows)
                {
                    preencherTabela(i[0].ToString(), i[1].ToString(), i[2].ToString(), i[3].ToString(), i[4].ToString(), i[5].ToString(), i[6].ToString(), i[7].ToString());
                }
            }


        }

        public void preencherTabela(string id, string nSala, string horario, string nAlunos, string modalidade, string professor, string duracao, string dataAula)
        {
            data.Rows.Add(id, nSala,horario, nAlunos,modalidade,professor,duracao,dataAula);
        }

        private void frmAulaTable_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gerarRelatorio_Click(object sender, EventArgs e)
        {
            
            if (data.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = "RELATORIO.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Não é possível gravar dados no disco" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(data.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in data.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in data.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(dcell.Value.ToString());

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("RELATÓRIO GERADO COM SUCESSO", "info");
                            this.Close();

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("ERRO AO GERAR O PDF" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("Nenhum Registro Encontrado", "Info");

            }
        }
    }
}
