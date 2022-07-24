namespace atmGym.View
{
    partial class frmAluno
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
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdicionarAluno = new System.Windows.Forms.PictureBox();
            this.biA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cidadeA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.muniA = new System.Windows.Forms.TextBox();
            this.ncasaA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bairroA = new System.Windows.Forms.TextBox();
            this.ruaA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdicionarAluno)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeForm
            // 
            this.closeForm.Image = global::atmGym.Properties.Resources.icons8_close_window_500px;
            this.closeForm.Location = new System.Drawing.Point(582, 24);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(22, 23);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 34;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.AdicionarAluno);
            this.panel1.Location = new System.Drawing.Point(549, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 53);
            this.panel1.TabIndex = 27;
            // 
            // AdicionarAluno
            // 
            this.AdicionarAluno.Image = global::atmGym.Properties.Resources.icons8_checkmark_208px;
            this.AdicionarAluno.Location = new System.Drawing.Point(7, 6);
            this.AdicionarAluno.Name = "AdicionarAluno";
            this.AdicionarAluno.Size = new System.Drawing.Size(42, 41);
            this.AdicionarAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdicionarAluno.TabIndex = 4;
            this.AdicionarAluno.TabStop = false;
            this.AdicionarAluno.Click += new System.EventHandler(this.AdicionarAluno_Click);
            // 
            // biA
            // 
            this.biA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.biA.ForeColor = System.Drawing.Color.White;
            this.biA.Location = new System.Drawing.Point(407, 165);
            this.biA.Name = "biA";
            this.biA.Size = new System.Drawing.Size(151, 20);
            this.biA.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(404, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nº BI*";
            // 
            // nomeA
            // 
            this.nomeA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.nomeA.ForeColor = System.Drawing.Color.White;
            this.nomeA.Location = new System.Drawing.Point(70, 165);
            this.nomeA.Name = "nomeA";
            this.nomeA.Size = new System.Drawing.Size(288, 20);
            this.nomeA.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(67, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nome:*";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(49, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 87);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cidadeA);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.muniA);
            this.groupBox3.Controls.Add(this.ncasaA);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.bairroA);
            this.groupBox3.Controls.Add(this.ruaA);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(31, 110);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 357);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(36, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cidade";
            // 
            // cidadeA
            // 
            this.cidadeA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cidadeA.ForeColor = System.Drawing.Color.White;
            this.cidadeA.Location = new System.Drawing.Point(39, 179);
            this.cidadeA.Name = "cidadeA";
            this.cidadeA.Size = new System.Drawing.Size(179, 20);
            this.cidadeA.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(257, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Município";
            // 
            // muniA
            // 
            this.muniA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.muniA.ForeColor = System.Drawing.Color.White;
            this.muniA.Location = new System.Drawing.Point(260, 179);
            this.muniA.Name = "muniA";
            this.muniA.Size = new System.Drawing.Size(267, 20);
            this.muniA.TabIndex = 7;
            // 
            // ncasaA
            // 
            this.ncasaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ncasaA.ForeColor = System.Drawing.Color.White;
            this.ncasaA.Location = new System.Drawing.Point(41, 292);
            this.ncasaA.Name = "ncasaA";
            this.ncasaA.Size = new System.Drawing.Size(227, 20);
            this.ncasaA.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(310, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bairro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(38, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "nCasa";
            // 
            // bairroA
            // 
            this.bairroA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.bairroA.ForeColor = System.Drawing.Color.White;
            this.bairroA.Location = new System.Drawing.Point(313, 238);
            this.bairroA.Name = "bairroA";
            this.bairroA.Size = new System.Drawing.Size(214, 20);
            this.bairroA.TabIndex = 9;
            // 
            // ruaA
            // 
            this.ruaA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ruaA.ForeColor = System.Drawing.Color.White;
            this.ruaA.Location = new System.Drawing.Point(39, 238);
            this.ruaA.Name = "ruaA";
            this.ruaA.Size = new System.Drawing.Size(229, 20);
            this.ruaA.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(38, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rua";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(18, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 200);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // frmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(635, 570);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.biA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(635, 570);
            this.MinimumSize = new System.Drawing.Size(635, 570);
            this.Name = "frmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAluno";
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdicionarAluno)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AdicionarAluno;
        private System.Windows.Forms.TextBox biA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cidadeA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox muniA;
        private System.Windows.Forms.TextBox ncasaA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bairroA;
        private System.Windows.Forms.TextBox ruaA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}