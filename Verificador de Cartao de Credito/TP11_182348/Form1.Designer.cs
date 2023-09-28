namespace TP11_182348
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Valida = new System.Windows.Forms.Button();
            this.BT_limp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Numb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LB_res = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.BT_Valida);
            this.panel1.Controls.Add(this.BT_limp);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(422, -23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 511);
            this.panel1.TabIndex = 0;
            // 
            // BT_Valida
            // 
            this.BT_Valida.BackColor = System.Drawing.Color.White;
            this.BT_Valida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Valida.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Valida.Location = new System.Drawing.Point(13, 221);
            this.BT_Valida.Name = "BT_Valida";
            this.BT_Valida.Size = new System.Drawing.Size(210, 83);
            this.BT_Valida.TabIndex = 1;
            this.BT_Valida.Text = "Validar";
            this.BT_Valida.UseVisualStyleBackColor = false;
            this.BT_Valida.Click += new System.EventHandler(this.BT_Valida_Click);
            // 
            // BT_limp
            // 
            this.BT_limp.BackColor = System.Drawing.Color.White;
            this.BT_limp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_limp.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_limp.Location = new System.Drawing.Point(13, 132);
            this.BT_limp.Name = "BT_limp";
            this.BT_limp.Size = new System.Drawing.Size(210, 83);
            this.BT_limp.TabIndex = 1;
            this.BT_limp.Text = "Limpar";
            this.BT_limp.UseVisualStyleBackColor = false;
            this.BT_limp.Click += new System.EventHandler(this.BT_limp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP11_182348.Properties.Resources.visa_logo_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número do Cartão";
            // 
            // TB_Numb
            // 
            this.TB_Numb.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Numb.Location = new System.Drawing.Point(18, 143);
            this.TB_Numb.MaxLength = 19;
            this.TB_Numb.Name = "TB_Numb";
            this.TB_Numb.Size = new System.Drawing.Size(383, 44);
            this.TB_Numb.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(35)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.LB_res);
            this.panel2.Location = new System.Drawing.Point(18, 222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 59);
            this.panel2.TabIndex = 3;
            // 
            // LB_res
            // 
            this.LB_res.AutoSize = true;
            this.LB_res.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_res.ForeColor = System.Drawing.Color.White;
            this.LB_res.Location = new System.Drawing.Point(106, 13);
            this.LB_res.Name = "LB_res";
            this.LB_res.Size = new System.Drawing.Size(170, 32);
            this.LB_res.TabIndex = 0;
            this.LB_res.Text = "Validando...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(660, 298);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TB_Numb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Validar Cartão de Credito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BT_Valida;
        private System.Windows.Forms.Button BT_limp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Numb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LB_res;
    }
}

