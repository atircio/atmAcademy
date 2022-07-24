namespace atmGym.View
{
    partial class frmCliente
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
            this.AdicionarCliente = new System.Windows.Forms.PictureBox();
            this.biC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddContrato = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cidadeC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.muniC = new System.Windows.Forms.TextBox();
            this.ncasaC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bairroC = new System.Windows.Forms.TextBox();
            this.ruaC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.teleListC = new System.Windows.Forms.ListBox();
            this.teleC = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addTelefoneC = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdicionarCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTelefoneC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.AdicionarCliente);
            this.panel1.Location = new System.Drawing.Point(550, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 53);
            this.panel1.TabIndex = 39;
            // 
            // AdicionarCliente
            // 
            this.AdicionarCliente.Image = global::atmGym.Properties.Resources.icons8_checkmark_208px;
            this.AdicionarCliente.Location = new System.Drawing.Point(7, 6);
            this.AdicionarCliente.Name = "AdicionarCliente";
            this.AdicionarCliente.Size = new System.Drawing.Size(42, 41);
            this.AdicionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdicionarCliente.TabIndex = 4;
            this.AdicionarCliente.TabStop = false;
            this.AdicionarCliente.Click += new System.EventHandler(this.AdicionarCliente_Click);
            // 
            // biC
            // 
            this.biC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.biC.ForeColor = System.Drawing.Color.White;
            this.biC.Location = new System.Drawing.Point(339, 46);
            this.biC.Name = "biC";
            this.biC.Size = new System.Drawing.Size(170, 20);
            this.biC.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(336, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nº BI*";
            // 
            // nomeC
            // 
            this.nomeC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.nomeC.ForeColor = System.Drawing.Color.White;
            this.nomeC.Location = new System.Drawing.Point(21, 46);
            this.nomeC.Name = "nomeC";
            this.nomeC.Size = new System.Drawing.Size(288, 20);
            this.nomeC.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome:*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teleListC);
            this.groupBox1.Controls.Add(this.teleC);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.addTelefoneC);
            this.groupBox1.Controls.Add(this.btnAddContrato);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.nomeC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.biC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(50, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 200);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // btnAddContrato
            // 
            this.btnAddContrato.FlatAppearance.BorderSize = 0;
            this.btnAddContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContrato.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContrato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnAddContrato.Location = new System.Drawing.Point(69, 83);
            this.btnAddContrato.Name = "btnAddContrato";
            this.btnAddContrato.Size = new System.Drawing.Size(123, 50);
            this.btnAddContrato.TabIndex = 41;
            this.btnAddContrato.Text = "CONTRATO";
            this.btnAddContrato.UseVisualStyleBackColor = true;
            this.btnAddContrato.Click += new System.EventHandler(this.btnAddContrato_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(21, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 50);
            this.panel2.TabIndex = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::atmGym.Properties.Resources.icons8_agreement_500px;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(32, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 400);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(18, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cidade";
            // 
            // cidadeC
            // 
            this.cidadeC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cidadeC.ForeColor = System.Drawing.Color.White;
            this.cidadeC.Location = new System.Drawing.Point(21, 36);
            this.cidadeC.Name = "cidadeC";
            this.cidadeC.Size = new System.Drawing.Size(179, 20);
            this.cidadeC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(239, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Município";
            // 
            // muniC
            // 
            this.muniC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.muniC.ForeColor = System.Drawing.Color.White;
            this.muniC.Location = new System.Drawing.Point(242, 36);
            this.muniC.Name = "muniC";
            this.muniC.Size = new System.Drawing.Size(267, 20);
            this.muniC.TabIndex = 7;
            // 
            // ncasaC
            // 
            this.ncasaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ncasaC.ForeColor = System.Drawing.Color.White;
            this.ncasaC.Location = new System.Drawing.Point(21, 124);
            this.ncasaC.Name = "ncasaC";
            this.ncasaC.Size = new System.Drawing.Size(227, 20);
            this.ncasaC.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(292, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bairro";
            // 
            // bairroC
            // 
            this.bairroC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.bairroC.ForeColor = System.Drawing.Color.White;
            this.bairroC.Location = new System.Drawing.Point(295, 81);
            this.bairroC.Name = "bairroC";
            this.bairroC.Size = new System.Drawing.Size(214, 20);
            this.bairroC.TabIndex = 9;
            // 
            // ruaC
            // 
            this.ruaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ruaC.ForeColor = System.Drawing.Color.White;
            this.ruaC.Location = new System.Drawing.Point(21, 81);
            this.ruaC.Name = "ruaC";
            this.ruaC.Size = new System.Drawing.Size(229, 20);
            this.ruaC.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(20, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rua";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cidadeC);
            this.groupBox2.Controls.Add(this.bairroC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.muniC);
            this.groupBox2.Controls.Add(this.ruaC);
            this.groupBox2.Controls.Add(this.ncasaC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(18, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 159);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "nCasa";
            // 
            // closeForm
            // 
            this.closeForm.Image = global::atmGym.Properties.Resources.icons8_close_window_500px;
            this.closeForm.Location = new System.Drawing.Point(583, 23);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(22, 23);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 42;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // teleListC
            // 
            this.teleListC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.teleListC.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.teleListC.FormattingEnabled = true;
            this.teleListC.Location = new System.Drawing.Point(339, 92);
            this.teleListC.Name = "teleListC";
            this.teleListC.Size = new System.Drawing.Size(168, 69);
            this.teleListC.TabIndex = 44;
            // 
            // teleC
            // 
            this.teleC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.teleC.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teleC.ForeColor = System.Drawing.SystemColors.Window;
            this.teleC.Location = new System.Drawing.Point(339, 160);
            this.teleC.Mask = "(+244) 000 000 000";
            this.teleC.Name = "teleC";
            this.teleC.Size = new System.Drawing.Size(142, 22);
            this.teleC.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(336, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Telefone";
            // 
            // addTelefoneC
            // 
            this.addTelefoneC.Image = global::atmGym.Properties.Resources.icons8_add_96px_1;
            this.addTelefoneC.Location = new System.Drawing.Point(477, 161);
            this.addTelefoneC.Name = "addTelefoneC";
            this.addTelefoneC.Size = new System.Drawing.Size(30, 20);
            this.addTelefoneC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addTelefoneC.TabIndex = 45;
            this.addTelefoneC.TabStop = false;
            this.addTelefoneC.Click += new System.EventHandler(this.addTelefoneC_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(635, 570);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(635, 570);
            this.MinimumSize = new System.Drawing.Size(635, 570);
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdicionarCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTelefoneC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AdicionarCliente;
        private System.Windows.Forms.TextBox biC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cidadeC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox muniC;
        private System.Windows.Forms.TextBox ncasaC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bairroC;
        private System.Windows.Forms.TextBox ruaC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddContrato;
        private System.Windows.Forms.ListBox teleListC;
        private System.Windows.Forms.MaskedTextBox teleC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox addTelefoneC;
    }
}