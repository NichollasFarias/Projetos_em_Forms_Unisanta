namespace TP03_182348
{
    partial class FM_TP03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FM_TP03));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_Sai = new System.Windows.Forms.Button();
            this.BT_Limp = new System.Windows.Forms.Button();
            this.BT_Calc = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TB_EspIni = new System.Windows.Forms.TextBox();
            this.TB_Temp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_A = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_VI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LB_Res = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LB_Temp = new System.Windows.Forms.Label();
            this.LB_Res02 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::TP03_182348.Properties.Resources.carro1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(304, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_Sai);
            this.groupBox1.Controls.Add(this.BT_Limp);
            this.groupBox1.Controls.Add(this.BT_Calc);
            this.groupBox1.Location = new System.Drawing.Point(407, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // BT_Sai
            // 
            this.BT_Sai.BackColor = System.Drawing.Color.White;
            this.BT_Sai.BackgroundImage = global::TP03_182348.Properties.Resources.download__1_;
            this.BT_Sai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Sai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Sai.Location = new System.Drawing.Point(249, 17);
            this.BT_Sai.Name = "BT_Sai";
            this.BT_Sai.Size = new System.Drawing.Size(115, 106);
            this.BT_Sai.TabIndex = 6;
            this.BT_Sai.UseVisualStyleBackColor = false;
            this.BT_Sai.Click += new System.EventHandler(this.BT_Sai_Click);
            // 
            // BT_Limp
            // 
            this.BT_Limp.BackColor = System.Drawing.Color.White;
            this.BT_Limp.BackgroundImage = global::TP03_182348.Properties.Resources.download;
            this.BT_Limp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Limp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Limp.Location = new System.Drawing.Point(128, 17);
            this.BT_Limp.Name = "BT_Limp";
            this.BT_Limp.Size = new System.Drawing.Size(115, 106);
            this.BT_Limp.TabIndex = 5;
            this.BT_Limp.UseVisualStyleBackColor = false;
            this.BT_Limp.Click += new System.EventHandler(this.BT_Limp_Click);
            // 
            // BT_Calc
            // 
            this.BT_Calc.BackColor = System.Drawing.Color.White;
            this.BT_Calc.BackgroundImage = global::TP03_182348.Properties.Resources.calculator;
            this.BT_Calc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_Calc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_Calc.Location = new System.Drawing.Point(7, 17);
            this.BT_Calc.Name = "BT_Calc";
            this.BT_Calc.Size = new System.Drawing.Size(115, 106);
            this.BT_Calc.TabIndex = 4;
            this.BT_Calc.UseVisualStyleBackColor = false;
            this.BT_Calc.Click += new System.EventHandler(this.BT_Calc_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LB_Temp);
            this.groupBox3.Location = new System.Drawing.Point(322, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 61);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 185);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tempo:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TB_EspIni);
            this.groupBox5.Controls.Add(this.TB_Temp);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.TB_A);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TB_VI);
            this.groupBox5.Location = new System.Drawing.Point(186, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(175, 151);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // TB_EspIni
            // 
            this.TB_EspIni.Location = new System.Drawing.Point(6, 16);
            this.TB_EspIni.Name = "TB_EspIni";
            this.TB_EspIni.Size = new System.Drawing.Size(111, 26);
            this.TB_EspIni.TabIndex = 0;
            // 
            // TB_Temp
            // 
            this.TB_Temp.Location = new System.Drawing.Point(6, 112);
            this.TB_Temp.Name = "TB_Temp";
            this.TB_Temp.Size = new System.Drawing.Size(111, 26);
            this.TB_Temp.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "m/s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "m/s²";
            // 
            // TB_A
            // 
            this.TB_A.Location = new System.Drawing.Point(6, 80);
            this.TB_A.Name = "TB_A";
            this.TB_A.Size = new System.Drawing.Size(111, 26);
            this.TB_A.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(123, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "s";
            // 
            // TB_VI
            // 
            this.TB_VI.Location = new System.Drawing.Point(6, 48);
            this.TB_VI.Name = "TB_VI";
            this.TB_VI.Size = new System.Drawing.Size(111, 26);
            this.TB_VI.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Aceleração:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Espaço Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Velocidade Inicial:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LB_Res02);
            this.groupBox4.Controls.Add(this.LB_Res);
            this.groupBox4.Location = new System.Drawing.Point(322, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(461, 99);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // LB_Res
            // 
            this.LB_Res.AutoSize = true;
            this.LB_Res.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Res.Location = new System.Drawing.Point(45, 18);
            this.LB_Res.Name = "LB_Res";
            this.LB_Res.Size = new System.Drawing.Size(0, 32);
            this.LB_Res.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LB_Temp
            // 
            this.LB_Temp.AutoSize = true;
            this.LB_Temp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Temp.Location = new System.Drawing.Point(143, 21);
            this.LB_Temp.Name = "LB_Temp";
            this.LB_Temp.Size = new System.Drawing.Size(174, 18);
            this.LB_Temp.TabIndex = 0;
            this.LB_Temp.Text = "00/00/0000  00:00:00";
            // 
            // LB_Res02
            // 
            this.LB_Res02.AutoSize = true;
            this.LB_Res02.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Res02.Location = new System.Drawing.Point(45, 50);
            this.LB_Res02.Name = "LB_Res02";
            this.LB_Res02.Size = new System.Drawing.Size(0, 32);
            this.LB_Res02.TabIndex = 0;
            // 
            // FM_TP03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(793, 382);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FM_TP03";
            this.Text = "Deslocamento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB_EspIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TB_Temp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_A;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_VI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_Sai;
        private System.Windows.Forms.Button BT_Limp;
        private System.Windows.Forms.Button BT_Calc;
        private System.Windows.Forms.Label LB_Temp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LB_Res;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LB_Res02;
    }
}

