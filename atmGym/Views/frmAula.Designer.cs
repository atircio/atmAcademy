namespace atmGym.Views
{
    partial class frmAula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comoModalidade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ComboEspaco = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.duracao = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.checkSala = new Guna.UI2.WinForms.Guna2RadioButton();
            this.checkCancha = new Guna.UI2.WinForms.Guna2RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.hora = new System.Windows.Forms.MaskedTextBox();
            this.limiteAluno = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dataAula = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracao)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limiteAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.BackgroundColor = System.Drawing.Color.White;
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.data.ColumnHeadersHeight = 50;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nome});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(238)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle6;
            this.data.DoubleBuffered = true;
            this.data.EnableHeadersVisualStyles = false;
            this.data.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.data.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(190)))), ((int)(((byte)(161)))));
            this.data.HeaderForeColor = System.Drawing.Color.White;
            this.data.Location = new System.Drawing.Point(43, 52);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data.RowHeadersVisible = false;
            this.data.RowTemplate.DividerHeight = 1;
            this.data.RowTemplate.Height = 40;
            this.data.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(338, 364);
            this.data.TabIndex = 7;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // comoModalidade
            // 
            this.comoModalidade.BackColor = System.Drawing.Color.Transparent;
            this.comoModalidade.BorderRadius = 5;
            this.comoModalidade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comoModalidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comoModalidade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comoModalidade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comoModalidade.FocusedState.Parent = this.comoModalidade;
            this.comoModalidade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comoModalidade.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comoModalidade.HoverState.Parent = this.comoModalidade;
            this.comoModalidade.ItemHeight = 30;
            this.comoModalidade.ItemsAppearance.Parent = this.comoModalidade;
            this.comoModalidade.Location = new System.Drawing.Point(450, 200);
            this.comoModalidade.Name = "comoModalidade";
            this.comoModalidade.ShadowDecoration.Parent = this.comoModalidade;
            this.comoModalidade.Size = new System.Drawing.Size(253, 36);
            this.comoModalidade.TabIndex = 8;
            this.comoModalidade.SelectedIndexChanged += new System.EventHandler(this.comoModalidade_SelectedIndexChanged);
            // 
            // ComboEspaco
            // 
            this.ComboEspaco.BackColor = System.Drawing.Color.Transparent;
            this.ComboEspaco.BorderRadius = 5;
            this.ComboEspaco.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboEspaco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboEspaco.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboEspaco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboEspaco.FocusedState.Parent = this.ComboEspaco;
            this.ComboEspaco.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboEspaco.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ComboEspaco.HoverState.Parent = this.ComboEspaco;
            this.ComboEspaco.ItemHeight = 30;
            this.ComboEspaco.ItemsAppearance.Parent = this.ComboEspaco;
            this.ComboEspaco.Location = new System.Drawing.Point(450, 280);
            this.ComboEspaco.Name = "ComboEspaco";
            this.ComboEspaco.ShadowDecoration.Parent = this.ComboEspaco;
            this.ComboEspaco.Size = new System.Drawing.Size(253, 36);
            this.ComboEspaco.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(446, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 33;
            this.label10.Text = "Espaço:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(446, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Modalidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(446, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "Hora:";
            // 
            // duracao
            // 
            this.duracao.BackColor = System.Drawing.Color.Transparent;
            this.duracao.BorderRadius = 5;
            this.duracao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.duracao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.duracao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.duracao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.duracao.DisabledState.Parent = this.duracao;
            this.duracao.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.duracao.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.duracao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.duracao.FocusedState.Parent = this.duracao;
            this.duracao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.duracao.Location = new System.Drawing.Point(452, 142);
            this.duracao.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.duracao.Name = "duracao";
            this.duracao.ShadowDecoration.Parent = this.duracao;
            this.duracao.Size = new System.Drawing.Size(100, 33);
            this.duracao.TabIndex = 9;
            this.duracao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(446, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Duracão:";
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.guna2Button2.BorderRadius = 14;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.IndianRed;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(450, 385);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(125, 31);
            this.guna2Button2.TabIndex = 41;
            this.guna2Button2.Text = "Cancelar";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.guna2Button1.BorderRadius = 14;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(233)))), ((int)(((byte)(182)))));
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(603, 385);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(125, 31);
            this.guna2Button1.TabIndex = 42;
            this.guna2Button1.Text = "Confirmar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // checkSala
            // 
            this.checkSala.AutoSize = true;
            this.checkSala.Checked = true;
            this.checkSala.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkSala.CheckedState.BorderThickness = 0;
            this.checkSala.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkSala.CheckedState.InnerColor = System.Drawing.Color.White;
            this.checkSala.CheckedState.InnerOffset = -4;
            this.checkSala.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.checkSala.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkSala.Location = new System.Drawing.Point(5, 9);
            this.checkSala.Name = "checkSala";
            this.checkSala.Size = new System.Drawing.Size(59, 23);
            this.checkSala.TabIndex = 43;
            this.checkSala.TabStop = true;
            this.checkSala.Text = "sala";
            this.checkSala.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkSala.UncheckedState.BorderThickness = 2;
            this.checkSala.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkSala.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.checkSala.CheckedChanged += new System.EventHandler(this.checkSala_CheckedChanged);
            // 
            // checkCancha
            // 
            this.checkCancha.AutoSize = true;
            this.checkCancha.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkCancha.CheckedState.BorderThickness = 0;
            this.checkCancha.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkCancha.CheckedState.InnerColor = System.Drawing.Color.White;
            this.checkCancha.CheckedState.InnerOffset = -4;
            this.checkCancha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.checkCancha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkCancha.Location = new System.Drawing.Point(76, 9);
            this.checkCancha.Name = "checkCancha";
            this.checkCancha.Size = new System.Drawing.Size(89, 23);
            this.checkCancha.TabIndex = 44;
            this.checkCancha.Text = "cancha";
            this.checkCancha.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkCancha.UncheckedState.BorderThickness = 2;
            this.checkCancha.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.checkCancha.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.checkCancha.CheckedChanged += new System.EventHandler(this.checkCancha_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkSala);
            this.groupBox1.Controls.Add(this.checkCancha);
            this.groupBox1.Location = new System.Drawing.Point(534, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 35);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::atmGym.Properties.Resources.icons8_close_window_480px_1;
            this.pictureBox2.Location = new System.Drawing.Point(762, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 74;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // hora
            // 
            this.hora.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hora.Location = new System.Drawing.Point(450, 83);
            this.hora.Mask = "00:00";
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(46, 33);
            this.hora.TabIndex = 76;
            this.hora.ValidatingType = typeof(System.DateTime);
            // 
            // limiteAluno
            // 
            this.limiteAluno.BackColor = System.Drawing.Color.Transparent;
            this.limiteAluno.BorderRadius = 5;
            this.limiteAluno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.limiteAluno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.limiteAluno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.limiteAluno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.limiteAluno.DisabledState.Parent = this.limiteAluno;
            this.limiteAluno.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.limiteAluno.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.limiteAluno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.limiteAluno.FocusedState.Parent = this.limiteAluno;
            this.limiteAluno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limiteAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.limiteAluno.Location = new System.Drawing.Point(534, 83);
            this.limiteAluno.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.limiteAluno.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.limiteAluno.Name = "limiteAluno";
            this.limiteAluno.ShadowDecoration.Parent = this.limiteAluno;
            this.limiteAluno.Size = new System.Drawing.Size(64, 33);
            this.limiteAluno.TabIndex = 9;
            this.limiteAluno.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(535, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Limite de alunos";
            // 
            // dataAula
            // 
            this.dataAula.CustomFormat = "yyyy-MM-dd";
            this.dataAula.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataAula.Location = new System.Drawing.Point(450, 341);
            this.dataAula.MaxDate = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.dataAula.MinDate = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            this.dataAula.Name = "dataAula";
            this.dataAula.Size = new System.Drawing.Size(200, 25);
            this.dataAula.TabIndex = 77;
            this.dataAula.Value = new System.DateTime(2022, 5, 15, 0, 0, 0, 0);
            // 
            // frmAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataAula);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.limiteAluno);
            this.Controls.Add(this.duracao);
            this.Controls.Add(this.ComboEspaco);
            this.Controls.Add(this.comoModalidade);
            this.Controls.Add(this.data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAula";
            this.Load += new System.EventHandler(this.frmAula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duracao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limiteAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid data;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private Guna.UI2.WinForms.Guna2ComboBox comoModalidade;
        private Guna.UI2.WinForms.Guna2ComboBox ComboEspaco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown duracao;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2RadioButton checkSala;
        private Guna.UI2.WinForms.Guna2RadioButton checkCancha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.MaskedTextBox hora;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown limiteAluno;
        private System.Windows.Forms.DateTimePicker dataAula;
    }
}