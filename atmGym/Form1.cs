using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using atmGym.View;

namespace atmGym
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,int nTopRect, int nRigthRect, int nBottomRect,
            int nWidthEllips, int nHeightEllipse
            );
        public Form1()
        {
            InitializeComponent();
            
            btnHome_Click(btnHome, EventArgs.Empty);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            username.Text = Program.nameUser;
        }

        public void selectedBottom( Button a )
        {
            pnlNav.Height = a.Height;
            pnlNav.Top = a.Top;
            pnlNav.Left = a.Left;
            a.BackColor = Color.FromArgb(46, 51, 73);
        }
        public void leaveBottom(Button a)
        {
            a.BackColor = Color.FromArgb(24, 30, 54);
        }

        public void formLoader(Form f, String titleForm)
        {
            titleFormText.Text = titleForm;
            this.pnlFormLoader.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(f);
            f.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            selectedBottom(btnHome);
            frmHome fHome = new frmHome(){Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            formLoader(fHome, "HOME");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            selectedBottom(btnAdicionar);
            frmAdicionar fHome = new frmAdicionar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(fHome, "ADICIONAR");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            selectedBottom(btnConsultar);
            frmConsultar fHome = new frmConsultar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(fHome, "CONSULTAR");
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            selectedBottom(btnRelatorio);
            frmRelatorio fHome = new frmRelatorio() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(fHome, "RELATÓRIO");
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            leaveBottom(btnHome);
        }

        private void btnAdicionar_Leave(object sender, EventArgs e)
        {
            leaveBottom(btnAdicionar);
        }

        private void btnConsultar_Leave(object sender, EventArgs e)
        {
            leaveBottom(btnConsultar);
        }

        private void btnRelatorio_Leave(object sender, EventArgs e)
        {
            leaveBottom(btnRelatorio);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opacidade(1);


        }

        public void opacidade(int n)
        {
            Form1.ActiveForm.Opacity = n;
        }

        private void btnDefinicao_Click(object sender, EventArgs e)
        {
            selectedBottom(btnDefinicao);
            frmConfig fHome = new frmConfig() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formLoader(fHome, "CONFIGURAÇÕES");
        }

        private void btnDefinicao_Leave(object sender, EventArgs e)
        {
            leaveBottom(btnDefinicao);
        }

        private void titleFormText_Click(object sender, EventArgs e)
        {

        }
    }
}
