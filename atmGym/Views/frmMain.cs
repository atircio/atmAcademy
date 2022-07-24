using atmGym.Model.Dao;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmHome fHome = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(fHome);
        }

        public void formLoader(Form f)
        {
            this.pnlFormLoader.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(f);
            f.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Click(object sender, EventArgs e)
        {
            frmHome fHome = new frmHome() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(fHome);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            frmAdicionar f = new frmAdicionar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(f);

        }

        private void menuConsultar_Click(object sender, EventArgs e)
        {
            if (Conta.Consultar)
            {
                frmConsultar f = new frmConsultar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                formLoader(f);
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void relatorio_Click(object sender, EventArgs e)
        {
            if (Conta.GerarRelatorios)
            {
                frmRelatorio f = new frmRelatorio();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não tem acesso a está funcionalidade", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
              
        }

        private void configuracao_Click(object sender, EventArgs e)
        {
            frmConfiguracao f = new frmConfiguracao() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(f);
        }
    }
}
