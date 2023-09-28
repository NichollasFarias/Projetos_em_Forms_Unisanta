namespace TP05_182348
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TB_vp = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TB_uF = new System.Windows.Forms.TextBox();
            this.TB_Hz = new System.Windows.Forms.TextBox();
            this.TB_Af = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_Calc = new System.Windows.Forms.Button();
            this.BT_Limp = new System.Windows.Forms.Button();
            this.LB_Data = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBX_Cap = new System.Windows.Forms.ListBox();
            this.LBX_R3 = new System.Windows.Forms.ListBox();
            this.LBX_R2 = new System.Windows.Forms.ListBox();
            this.LBX_R1 = new System.Windows.Forms.ListBox();
            this.PBX_Circuito = new System.Windows.Forms.PictureBox();
            this.TMR_Data = new System.Windows.Forms.Timer(this.components);
            this.Animação = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Circuito)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.BT_Calc);
            this.groupBox1.Controls.Add(this.BT_Limp);
            this.groupBox1.Controls.Add(this.LB_Data);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(-13, -11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 497);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(51)))), ((int)(((byte)(110)))));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(61, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "passa baixa ativo";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TB_vp);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(24, 236);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 88);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Variação do Passo";
            // 
            // TB_vp
            // 
            this.TB_vp.Location = new System.Drawing.Point(92, 35);
            this.TB_vp.Name = "TB_vp";
            this.TB_vp.Size = new System.Drawing.Size(100, 32);
            this.TB_vp.TabIndex = 3;
            this.TB_vp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TB_uF);
            this.groupBox4.Controls.Add(this.TB_Hz);
            this.groupBox4.Controls.Add(this.TB_Af);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(24, 91);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 139);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // TB_uF
            // 
            this.TB_uF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_uF.Location = new System.Drawing.Point(161, 95);
            this.TB_uF.Name = "TB_uF";
            this.TB_uF.Size = new System.Drawing.Size(74, 26);
            this.TB_uF.TabIndex = 2;
            this.TB_uF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            // 
            // TB_Hz
            // 
            this.TB_Hz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Hz.Location = new System.Drawing.Point(161, 57);
            this.TB_Hz.Name = "TB_Hz";
            this.TB_Hz.Size = new System.Drawing.Size(74, 26);
            this.TB_Hz.TabIndex = 1;
            this.TB_Hz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            // 
            // TB_Af
            // 
            this.TB_Af.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Af.Location = new System.Drawing.Point(161, 17);
            this.TB_Af.Name = "TB_Af";
            this.TB_Af.Size = new System.Drawing.Size(74, 26);
            this.TB_Af.TabIndex = 0;
            this.TB_Af.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(241, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "uF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(241, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Hz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Frequência:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Capacitor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Amplificação:";
            // 
            // BT_Calc
            // 
            this.BT_Calc.BackColor = System.Drawing.Color.White;
            this.BT_Calc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Calc.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Calc.ForeColor = System.Drawing.Color.Black;
            this.BT_Calc.Location = new System.Drawing.Point(25, 330);
            this.BT_Calc.Name = "BT_Calc";
            this.BT_Calc.Size = new System.Drawing.Size(283, 56);
            this.BT_Calc.TabIndex = 4;
            this.BT_Calc.Text = "Calcular";
            this.BT_Calc.UseVisualStyleBackColor = false;
            this.BT_Calc.Click += new System.EventHandler(this.BT_Calc_Click);
            // 
            // BT_Limp
            // 
            this.BT_Limp.BackColor = System.Drawing.Color.White;
            this.BT_Limp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Limp.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Limp.Location = new System.Drawing.Point(25, 392);
            this.BT_Limp.Name = "BT_Limp";
            this.BT_Limp.Size = new System.Drawing.Size(283, 56);
            this.BT_Limp.TabIndex = 5;
            this.BT_Limp.Text = "Limpar";
            this.BT_Limp.UseVisualStyleBackColor = false;
            this.BT_Limp.Click += new System.EventHandler(this.BT_Limp_Click);
            // 
            // LB_Data
            // 
            this.LB_Data.AutoSize = true;
            this.LB_Data.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Data.ForeColor = System.Drawing.Color.White;
            this.LB_Data.Location = new System.Drawing.Point(116, 451);
            this.LB_Data.Name = "LB_Data";
            this.LB_Data.Size = new System.Drawing.Size(89, 19);
            this.LB_Data.TabIndex = 2;
            this.LB_Data.Text = "00/00/0000";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.LBX_Cap);
            this.groupBox3.Controls.Add(this.LBX_R3);
            this.groupBox3.Controls.Add(this.LBX_R2);
            this.groupBox3.Controls.Add(this.LBX_R1);
            this.groupBox3.Location = new System.Drawing.Point(318, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(631, 196);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(478, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Capacitor 2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(376, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "R3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(215, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "R2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(56, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "R1";
            // 
            // LBX_Cap
            // 
            this.LBX_Cap.Enabled = false;
            this.LBX_Cap.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.LBX_Cap.FormattingEnabled = true;
            this.LBX_Cap.ItemHeight = 19;
            this.LBX_Cap.Location = new System.Drawing.Point(474, 45);
            this.LBX_Cap.Name = "LBX_Cap";
            this.LBX_Cap.Size = new System.Drawing.Size(150, 137);
            this.LBX_Cap.TabIndex = 0;
            // 
            // LBX_R3
            // 
            this.LBX_R3.Enabled = false;
            this.LBX_R3.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.LBX_R3.FormattingEnabled = true;
            this.LBX_R3.ItemHeight = 19;
            this.LBX_R3.Location = new System.Drawing.Point(318, 45);
            this.LBX_R3.Name = "LBX_R3";
            this.LBX_R3.Size = new System.Drawing.Size(150, 137);
            this.LBX_R3.TabIndex = 0;
            // 
            // LBX_R2
            // 
            this.LBX_R2.Enabled = false;
            this.LBX_R2.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.LBX_R2.ItemHeight = 19;
            this.LBX_R2.Location = new System.Drawing.Point(162, 45);
            this.LBX_R2.Name = "LBX_R2";
            this.LBX_R2.Size = new System.Drawing.Size(150, 137);
            this.LBX_R2.TabIndex = 0;
            // 
            // LBX_R1
            // 
            this.LBX_R1.Enabled = false;
            this.LBX_R1.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold);
            this.LBX_R1.FormattingEnabled = true;
            this.LBX_R1.ItemHeight = 19;
            this.LBX_R1.Location = new System.Drawing.Point(6, 45);
            this.LBX_R1.Name = "LBX_R1";
            this.LBX_R1.Size = new System.Drawing.Size(150, 137);
            this.LBX_R1.TabIndex = 0;
            // 
            // PBX_Circuito
            // 
            this.PBX_Circuito.Image = global::TP05_182348.Properties.Resources.res01;
            this.PBX_Circuito.Location = new System.Drawing.Point(316, 12);
            this.PBX_Circuito.Name = "PBX_Circuito";
            this.PBX_Circuito.Size = new System.Drawing.Size(633, 241);
            this.PBX_Circuito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBX_Circuito.TabIndex = 2;
            this.PBX_Circuito.TabStop = false;
            // 
            // TMR_Data
            // 
            this.TMR_Data.Enabled = true;
            this.TMR_Data.Tick += new System.EventHandler(this.TMR_Data_Tick);
            // 
            // Animação
            // 
            this.Animação.Enabled = true;
            this.Animação.Tick += new System.EventHandler(this.Animação_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(24)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(954, 461);
            this.Controls.Add(this.PBX_Circuito);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Passa Baixa Ativo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Circuito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox PBX_Circuito;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TB_vp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TB_Af;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_Calc;
        private System.Windows.Forms.Button BT_Limp;
        private System.Windows.Forms.Label LB_Data;
        private System.Windows.Forms.TextBox TB_uF;
        private System.Windows.Forms.TextBox TB_Hz;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer TMR_Data;
        private System.Windows.Forms.Timer Animação;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LBX_Cap;
        private System.Windows.Forms.ListBox LBX_R3;
        private System.Windows.Forms.ListBox LBX_R2;
        private System.Windows.Forms.ListBox LBX_R1;
    }
}

