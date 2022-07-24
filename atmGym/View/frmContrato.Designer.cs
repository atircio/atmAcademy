namespace atmGym.View
{
    partial class frmContrato
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleFormText = new System.Windows.Forms.Label();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.nomeAluno = new System.Windows.Forms.Label();
            this.biAluno = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.formaPagamento = new System.Windows.Forms.ComboBox();
            this.Mensalidade = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 2);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // titleFormText
            // 
            this.titleFormText.AutoSize = true;
            this.titleFormText.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFormText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.titleFormText.Location = new System.Drawing.Point(16, 15);
            this.titleFormText.Name = "titleFormText";
            this.titleFormText.Size = new System.Drawing.Size(125, 30);
            this.titleFormText.TabIndex = 2;
            this.titleFormText.Text = "CONTRATO";
            // 
            // dataInicio
            // 
            this.dataInicio.CustomFormat = "yyyy-MM-dd";
            this.dataInicio.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataInicio.Location = new System.Drawing.Point(191, 262);
            this.dataInicio.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.dataInicio.MinDate = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(200, 25);
            this.dataInicio.TabIndex = 44;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.BackColor = System.Drawing.Color.Transparent;
            this.nome.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.nome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nome.Location = new System.Drawing.Point(39, 101);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(49, 17);
            this.nome.TabIndex = 45;
            this.nome.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Número de Bilhete";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(39, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Data de Inicio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(39, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Data de fim:";
            // 
            // dataFim
            // 
            this.dataFim.CustomFormat = "yyyy-MM-dd";
            this.dataFim.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dataFim.Location = new System.Drawing.Point(191, 307);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(200, 25);
            this.dataFim.TabIndex = 50;
            // 
            // nomeAluno
            // 
            this.nomeAluno.AutoSize = true;
            this.nomeAluno.BackColor = System.Drawing.Color.Transparent;
            this.nomeAluno.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeAluno.Location = new System.Drawing.Point(188, 101);
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.Size = new System.Drawing.Size(47, 17);
            this.nomeAluno.TabIndex = 51;
            this.nomeAluno.Text = "Nome:";
            // 
            // biAluno
            // 
            this.biAluno.AutoSize = true;
            this.biAluno.BackColor = System.Drawing.Color.Transparent;
            this.biAluno.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biAluno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.biAluno.Location = new System.Drawing.Point(188, 134);
            this.biAluno.Name = "biAluno";
            this.biAluno.Size = new System.Drawing.Size(47, 17);
            this.biAluno.TabIndex = 52;
            this.biAluno.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Location = new System.Drawing.Point(191, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(251, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "Diretor Geral";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(21, 428);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 50);
            this.panel3.TabIndex = 55;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::atmGym.Properties.Resources.icons8_stamp_144px;
            this.pictureBox2.Location = new System.Drawing.Point(5, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // closeForm
            // 
            this.closeForm.Image = global::atmGym.Properties.Resources.icons8_close_window_500px;
            this.closeForm.Location = new System.Drawing.Point(402, 12);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(22, 23);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 43;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::atmGym.Properties.Resources.icons8_signature_512px_1;
            this.pictureBox1.Location = new System.Drawing.Point(177, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Forma de Pagamento";
            // 
            // formaPagamento
            // 
            this.formaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.formaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formaPagamento.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formaPagamento.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.formaPagamento.FormattingEnabled = true;
            this.formaPagamento.Location = new System.Drawing.Point(191, 167);
            this.formaPagamento.Name = "formaPagamento";
            this.formaPagamento.Size = new System.Drawing.Size(200, 25);
            this.formaPagamento.TabIndex = 57;
            // 
            // Mensalidade
            // 
            this.Mensalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Mensalidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mensalidade.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensalidade.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Mensalidade.FormattingEnabled = true;
            this.Mensalidade.Location = new System.Drawing.Point(191, 215);
            this.Mensalidade.Name = "Mensalidade";
            this.Mensalidade.Size = new System.Drawing.Size(200, 25);
            this.Mensalidade.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(39, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Mensalidade";
            // 
            // frmContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(436, 507);
            this.Controls.Add(this.Mensalidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.formaPagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.biAluno);
            this.Controls.Add(this.nomeAluno);
            this.Controls.Add(this.dataFim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.dataInicio);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.titleFormText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(635, 570);
            this.Name = "frmContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmContrato";
            this.Load += new System.EventHandler(this.frmContrato_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleFormText;
        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.Label nomeAluno;
        private System.Windows.Forms.Label biAluno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox formaPagamento;
        private System.Windows.Forms.ComboBox Mensalidade;
        private System.Windows.Forms.Label label6;
    }
}