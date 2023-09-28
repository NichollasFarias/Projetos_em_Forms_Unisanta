namespace Calculadora_Arco_Tangente
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
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbR = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(144, 19);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(100, 38);
            this.txtV1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(64, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "CO(A):";
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(144, 70);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(100, 38);
            this.txtV2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.label2.Location = new System.Drawing.Point(64, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "CA(B):";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(70, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.label3.Location = new System.Drawing.Point(55, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 57);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resposta";
            // 
            // lbR
            // 
            this.lbR.AutoSize = true;
            this.lbR.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(224)))), ((int)(((byte)(213)))));
            this.lbR.Location = new System.Drawing.Point(138, 72);
            this.lbR.Name = "lbR";
            this.lbR.Size = new System.Drawing.Size(47, 57);
            this.lbR.TabIndex = 1;
            this.lbR.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbR);
            this.panel1.Location = new System.Drawing.Point(250, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 148);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(51)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(630, 187);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtV1);
            this.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbR;
        private System.Windows.Forms.Panel panel1;
    }
}

