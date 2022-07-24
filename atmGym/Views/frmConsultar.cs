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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent(); 
            

        }

        public void formLoader(Form f)
        {
            this.pnlTableLoader.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            this.pnlTableLoader.Controls.Add(f);
            f.Show();

        }
        

        private void frmConsultar_Load(object sender, EventArgs e)
        {

        }

        private void dataProfessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmProfTable f = new frmProfTable() { Dock =  DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(f);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmClienteTable f = new frmClienteTable() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(f);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frmAlunoTable f = new frmAlunoTable() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(f);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            frmEspacoTable f = new frmEspacoTable() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(f);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            frmModalidadeTable f = new frmModalidadeTable() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(f);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            frmAulaTable f = new frmAulaTable() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(f);
        }
    }
}
