namespace atmGym.Views
{
    partial class frmAulaTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nBI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODALIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROFESSOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.gerarRelatorio = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data.ColumnHeadersHeight = 50;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nBI,
            this.HORARIO,
            this.NALUNO,
            this.MODALIDADE,
            this.PROFESSOR,
            this.DURACAO,
            this.DAT,
            this.editar,
            this.deletar});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle5;
            this.data.DoubleBuffered = true;
            this.data.EnableHeadersVisualStyles = false;
            this.data.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.data.HeaderForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(25, 39);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data.RowHeadersVisible = false;
            this.data.RowTemplate.DividerHeight = 1;
            this.data.RowTemplate.Height = 40;
            this.data.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(855, 378);
            this.data.TabIndex = 8;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nBI
            // 
            this.nBI.HeaderText = "Nº SALA";
            this.nBI.Name = "nBI";
            this.nBI.ReadOnly = true;
            // 
            // HORARIO
            // 
            this.HORARIO.HeaderText = "HORÁRIO";
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.ReadOnly = true;
            // 
            // NALUNO
            // 
            this.NALUNO.HeaderText = "Nº ALUNOS";
            this.NALUNO.Name = "NALUNO";
            this.NALUNO.ReadOnly = true;
            // 
            // MODALIDADE
            // 
            this.MODALIDADE.HeaderText = "MODALIDADE";
            this.MODALIDADE.Name = "MODALIDADE";
            this.MODALIDADE.ReadOnly = true;
            // 
            // PROFESSOR
            // 
            this.PROFESSOR.HeaderText = "PROFESSOR";
            this.PROFESSOR.Name = "PROFESSOR";
            this.PROFESSOR.ReadOnly = true;
            // 
            // DURACAO
            // 
            this.DURACAO.HeaderText = "DURACÃO";
            this.DURACAO.Name = "DURACAO";
            this.DURACAO.ReadOnly = true;
            // 
            // DAT
            // 
            this.DAT.HeaderText = "DATA";
            this.DAT.Name = "DAT";
            this.DAT.ReadOnly = true;
            // 
            // editar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.editar.DefaultCellStyle = dataGridViewCellStyle3;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.HeaderText = "";
            this.editar.Name = "editar";
            this.editar.ReadOnly = true;
            this.editar.Text = "Editar";
            this.editar.UseColumnTextForButtonValue = true;
            // 
            // deletar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.deletar.DefaultCellStyle = dataGridViewCellStyle4;
            this.deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletar.HeaderText = "";
            this.deletar.Name = "deletar";
            this.deletar.ReadOnly = true;
            this.deletar.Text = "Remover";
            this.deletar.UseColumnTextForButtonValue = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::atmGym.Properties.Resources.icons8_close_window_480px_1;
            this.closeBtn.Location = new System.Drawing.Point(866, 5);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 32);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 76;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // gerarRelatorio
            // 
            this.gerarRelatorio.Animated = true;
            this.gerarRelatorio.AutoRoundedCorners = true;
            this.gerarRelatorio.BorderRadius = 13;
            this.gerarRelatorio.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.gerarRelatorio.Checked = true;
            this.gerarRelatorio.CheckedState.Parent = this.gerarRelatorio;
            this.gerarRelatorio.CustomImages.Parent = this.gerarRelatorio;
            this.gerarRelatorio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(233)))), ((int)(((byte)(181)))));
            this.gerarRelatorio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.gerarRelatorio.ForeColor = System.Drawing.Color.White;
            this.gerarRelatorio.HoverState.Parent = this.gerarRelatorio;
            this.gerarRelatorio.IndicateFocus = true;
            this.gerarRelatorio.Location = new System.Drawing.Point(35, 5);
            this.gerarRelatorio.Name = "gerarRelatorio";
            this.gerarRelatorio.ShadowDecoration.Parent = this.gerarRelatorio;
            this.gerarRelatorio.Size = new System.Drawing.Size(162, 29);
            this.gerarRelatorio.TabIndex = 77;
            this.gerarRelatorio.Text = "GERAR RELATÓRIO";
            this.gerarRelatorio.Click += new System.EventHandler(this.gerarRelatorio_Click);
            // 
            // frmAulaTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(904, 456);
            this.Controls.Add(this.gerarRelatorio);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAulaTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAulaTable";
            this.Load += new System.EventHandler(this.frmAulaTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid data;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nBI;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NALUNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODALIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFESSOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DAT;
        private System.Windows.Forms.DataGridViewButtonColumn editar;
        private System.Windows.Forms.DataGridViewButtonColumn deletar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.PictureBox closeBtn;
        private Guna.UI2.WinForms.Guna2Button gerarRelatorio;
    }
}