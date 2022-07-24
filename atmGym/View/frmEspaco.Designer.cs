namespace atmGym.View
{
    partial class frmEspaco
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioCancha = new System.Windows.Forms.RadioButton();
            this.radioSala = new System.Windows.Forms.RadioButton();
            this.txtAndar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNsala = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adiconarEspaco = new System.Windows.Forms.PictureBox();
            this.titleFormText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeForm = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adiconarEspaco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioCancha);
            this.groupBox1.Controls.Add(this.radioSala);
            this.groupBox1.Controls.Add(this.txtAndar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNsala);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(60, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 150);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // radioCancha
            // 
            this.radioCancha.AutoSize = true;
            this.radioCancha.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCancha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioCancha.Location = new System.Drawing.Point(100, 97);
            this.radioCancha.Name = "radioCancha";
            this.radioCancha.Size = new System.Drawing.Size(80, 21);
            this.radioCancha.TabIndex = 39;
            this.radioCancha.Text = "CANCHA";
            this.radioCancha.UseVisualStyleBackColor = true;
            // 
            // radioSala
            // 
            this.radioSala.AutoSize = true;
            this.radioSala.Checked = true;
            this.radioSala.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSala.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioSala.Location = new System.Drawing.Point(21, 97);
            this.radioSala.Name = "radioSala";
            this.radioSala.Size = new System.Drawing.Size(58, 21);
            this.radioSala.TabIndex = 39;
            this.radioSala.TabStop = true;
            this.radioSala.Text = "SALA";
            this.radioSala.UseVisualStyleBackColor = true;
            // 
            // txtAndar
            // 
            this.txtAndar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtAndar.ForeColor = System.Drawing.Color.White;
            this.txtAndar.Location = new System.Drawing.Point(21, 46);
            this.txtAndar.Name = "txtAndar";
            this.txtAndar.Size = new System.Drawing.Size(217, 20);
            this.txtAndar.TabIndex = 36;
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
            this.label1.Text = "Andar*";
            // 
            // txtNsala
            // 
            this.txtNsala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.txtNsala.ForeColor = System.Drawing.Color.White;
            this.txtNsala.Location = new System.Drawing.Point(308, 46);
            this.txtNsala.Name = "txtNsala";
            this.txtNsala.Size = new System.Drawing.Size(179, 20);
            this.txtNsala.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(305, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nº sala*";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.adiconarEspaco);
            this.panel2.Location = new System.Drawing.Point(523, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 50);
            this.panel2.TabIndex = 40;
            // 
            // adiconarEspaco
            // 
            this.adiconarEspaco.Image = global::atmGym.Properties.Resources.icons8_checkmark_208px;
            this.adiconarEspaco.Location = new System.Drawing.Point(6, 7);
            this.adiconarEspaco.Name = "adiconarEspaco";
            this.adiconarEspaco.Size = new System.Drawing.Size(36, 38);
            this.adiconarEspaco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.adiconarEspaco.TabIndex = 4;
            this.adiconarEspaco.TabStop = false;
            this.adiconarEspaco.Click += new System.EventHandler(this.adiconarEspaco_Click);
            // 
            // titleFormText
            // 
            this.titleFormText.AutoSize = true;
            this.titleFormText.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleFormText.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.titleFormText.Location = new System.Drawing.Point(28, 11);
            this.titleFormText.Name = "titleFormText";
            this.titleFormText.Size = new System.Drawing.Size(90, 30);
            this.titleFormText.TabIndex = 43;
            this.titleFormText.Text = "ESPAÇO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel1.Location = new System.Drawing.Point(-1, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 2);
            this.panel1.TabIndex = 42;
            // 
            // closeForm
            // 
            this.closeForm.Image = global::atmGym.Properties.Resources.icons8_close_window_500px;
            this.closeForm.Location = new System.Drawing.Point(601, 11);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(22, 23);
            this.closeForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeForm.TabIndex = 44;
            this.closeForm.TabStop = false;
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            // 
            // frmEspaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(635, 352);
            this.Controls.Add(this.closeForm);
            this.Controls.Add(this.titleFormText);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(635, 570);
            this.Name = "frmEspaco";
            this.Text = "frmEspaco";
            this.Load += new System.EventHandler(this.frmEspaco_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adiconarEspaco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox adiconarEspaco;
        private System.Windows.Forms.TextBox txtAndar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNsala;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioCancha;
        private System.Windows.Forms.RadioButton radioSala;
        private System.Windows.Forms.Label titleFormText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeForm;
    }
}