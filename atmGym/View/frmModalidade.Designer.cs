namespace atmGym.View
{
    partial class frmModalidade
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
            this.titleFormText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adiconarE = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adiconarE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeForm
            // 
            this.closeForm.Image = global::atmGym.Properties.Resources.icons8_close_window_500px;
            this.closeForm.Location = new System.Drawing.Point(563, 12);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(22, 23);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 49;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // titleFormText
            // 
            this.titleFormText.AutoSize = true;
            this.titleFormText.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFormText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.titleFormText.Location = new System.Drawing.Point(7, 12);
            this.titleFormText.Name = "titleFormText";
            this.titleFormText.Size = new System.Drawing.Size(153, 30);
            this.titleFormText.TabIndex = 48;
            this.titleFormText.Text = "MODALIDADE";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.adiconarE);
            this.panel2.Location = new System.Drawing.Point(502, 299);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 50);
            this.panel2.TabIndex = 45;
            // 
            // adiconarE
            // 
            this.adiconarE.Image = global::atmGym.Properties.Resources.icons8_checkmark_208px;
            this.adiconarE.Location = new System.Drawing.Point(6, 7);
            this.adiconarE.Name = "adiconarE";
            this.adiconarE.Size = new System.Drawing.Size(36, 38);
            this.adiconarE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adiconarE.TabIndex = 4;
            this.adiconarE.TabStop = false;
            this.adiconarE.Click += new System.EventHandler(this.adiconarE_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(-22, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 2);
            this.panel1.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(39, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 203);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtNome.ForeColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(21, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(217, 20);
            this.txtNome.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nome*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(21, 89);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(472, 97);
            this.txtDescricao.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Descrição";
            // 
            // frmModalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(598, 359);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.titleFormText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(635, 570);
            this.Name = "frmModalidade";
            this.Text = "frmModalidade";
            this.Load += new System.EventHandler(this.frmModalidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adiconarE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeForm;
        private System.Windows.Forms.Label titleFormText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox adiconarE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
    }
}