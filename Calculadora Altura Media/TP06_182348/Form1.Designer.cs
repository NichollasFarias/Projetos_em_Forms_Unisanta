namespace TP06_182348
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
            this.StrMenu = new System.Windows.Forms.MenuStrip();
            this.MnuOrdenar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCalcular = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLimpar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_Aviso = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Lbx_Valores = new System.Windows.Forms.ListBox();
            this.Lbx_Ordenados = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lb_AlturaMedia = new System.Windows.Forms.Label();
            this.Gb_Termos = new System.Windows.Forms.GroupBox();
            this.Txt_Quantidade = new System.Windows.Forms.TextBox();
            this.Gb_Valor = new System.Windows.Forms.GroupBox();
            this.Lb_Ordinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.StrMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Gb_Termos.SuspendLayout();
            this.Gb_Valor.SuspendLayout();
            this.SuspendLayout();
            // 
            // StrMenu
            // 
            this.StrMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.StrMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.StrMenu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StrMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOrdenar,
            this.MnuCalcular,
            this.MnuLimpar,
            this.MnuSobre});
            this.StrMenu.Location = new System.Drawing.Point(0, 0);
            this.StrMenu.Name = "StrMenu";
            this.StrMenu.Size = new System.Drawing.Size(175, 428);
            this.StrMenu.TabIndex = 0;
            this.StrMenu.Text = "menuStrip1";
            // 
            // MnuOrdenar
            // 
            this.MnuOrdenar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MnuOrdenar.ForeColor = System.Drawing.Color.Black;
            this.MnuOrdenar.Image = global::TP06_182348.Properties.Resources.sort_descending_icon_152529;
            this.MnuOrdenar.Name = "MnuOrdenar";
            this.MnuOrdenar.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.MnuOrdenar.Size = new System.Drawing.Size(162, 50);
            this.MnuOrdenar.Text = "Ordenar";
            this.MnuOrdenar.Click += new System.EventHandler(this.MnuOrdenar_Click);
            // 
            // MnuCalcular
            // 
            this.MnuCalcular.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MnuCalcular.ForeColor = System.Drawing.Color.Black;
            this.MnuCalcular.Image = global::TP06_182348.Properties.Resources.calculator_icon_152684;
            this.MnuCalcular.Name = "MnuCalcular";
            this.MnuCalcular.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.MnuCalcular.Size = new System.Drawing.Size(162, 50);
            this.MnuCalcular.Text = "Altura Media";
            this.MnuCalcular.Click += new System.EventHandler(this.MnuCalcular_Click);
            // 
            // MnuLimpar
            // 
            this.MnuLimpar.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MnuLimpar.ForeColor = System.Drawing.Color.Black;
            this.MnuLimpar.Image = global::TP06_182348.Properties.Resources.trash_icon_152510;
            this.MnuLimpar.Name = "MnuLimpar";
            this.MnuLimpar.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.MnuLimpar.Size = new System.Drawing.Size(162, 50);
            this.MnuLimpar.Text = "Limpar";
            this.MnuLimpar.Click += new System.EventHandler(this.MnuLimpar_Click);
            // 
            // MnuSobre
            // 
            this.MnuSobre.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.MnuSobre.ForeColor = System.Drawing.Color.Black;
            this.MnuSobre.Image = global::TP06_182348.Properties.Resources.information_circle_icon_152596;
            this.MnuSobre.Name = "MnuSobre";
            this.MnuSobre.Padding = new System.Windows.Forms.Padding(4, 10, 4, 10);
            this.MnuSobre.Size = new System.Drawing.Size(162, 50);
            this.MnuSobre.Text = "Sobre";
            this.MnuSobre.Click += new System.EventHandler(this.MnuSobre_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Lb_Aviso);
            this.panel1.Location = new System.Drawing.Point(189, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 53);
            this.panel1.TabIndex = 1;
            // 
            // Lb_Aviso
            // 
            this.Lb_Aviso.AutoSize = true;
            this.Lb_Aviso.BackColor = System.Drawing.Color.Gray;
            this.Lb_Aviso.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.Lb_Aviso.ForeColor = System.Drawing.Color.White;
            this.Lb_Aviso.Location = new System.Drawing.Point(136, 13);
            this.Lb_Aviso.Name = "Lb_Aviso";
            this.Lb_Aviso.Size = new System.Drawing.Size(404, 22);
            this.Lb_Aviso.TabIndex = 0;
            this.Lb_Aviso.Text = "A Quantidade Máxima de Números é de 50!";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Lbx_Valores
            // 
            this.Lbx_Valores.FormattingEnabled = true;
            this.Lbx_Valores.ItemHeight = 19;
            this.Lbx_Valores.Location = new System.Drawing.Point(189, 31);
            this.Lbx_Valores.Name = "Lbx_Valores";
            this.Lbx_Valores.Size = new System.Drawing.Size(200, 308);
            this.Lbx_Valores.TabIndex = 9;
            // 
            // Lbx_Ordenados
            // 
            this.Lbx_Ordenados.FormattingEnabled = true;
            this.Lbx_Ordenados.ItemHeight = 19;
            this.Lbx_Ordenados.Location = new System.Drawing.Point(395, 31);
            this.Lbx_Ordenados.Name = "Lbx_Ordenados";
            this.Lbx_Ordenados.Size = new System.Drawing.Size(200, 308);
            this.Lbx_Ordenados.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lb_AlturaMedia);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(602, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altura Media";
            // 
            // Lb_AlturaMedia
            // 
            this.Lb_AlturaMedia.AutoSize = true;
            this.Lb_AlturaMedia.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_AlturaMedia.Location = new System.Drawing.Point(64, 24);
            this.Lb_AlturaMedia.Name = "Lb_AlturaMedia";
            this.Lb_AlturaMedia.Size = new System.Drawing.Size(138, 32);
            this.Lb_AlturaMedia.TabIndex = 0;
            this.Lb_AlturaMedia.Text = "Resposta";
            // 
            // Gb_Termos
            // 
            this.Gb_Termos.Controls.Add(this.Txt_Quantidade);
            this.Gb_Termos.ForeColor = System.Drawing.Color.White;
            this.Gb_Termos.Location = new System.Drawing.Point(603, 31);
            this.Gb_Termos.Name = "Gb_Termos";
            this.Gb_Termos.Size = new System.Drawing.Size(267, 101);
            this.Gb_Termos.TabIndex = 0;
            this.Gb_Termos.TabStop = false;
            this.Gb_Termos.Text = "Quantidade de termos";
            // 
            // Txt_Quantidade
            // 
            this.Txt_Quantidade.Location = new System.Drawing.Point(83, 37);
            this.Txt_Quantidade.Name = "Txt_Quantidade";
            this.Txt_Quantidade.Size = new System.Drawing.Size(100, 26);
            this.Txt_Quantidade.TabIndex = 0;
            this.Txt_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            this.Txt_Quantidade.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Quantidade_Validating);
            // 
            // Gb_Valor
            // 
            this.Gb_Valor.Controls.Add(this.Lb_Ordinal);
            this.Gb_Valor.Controls.Add(this.label1);
            this.Gb_Valor.Controls.Add(this.Txt_Valor);
            this.Gb_Valor.ForeColor = System.Drawing.Color.White;
            this.Gb_Valor.Location = new System.Drawing.Point(602, 138);
            this.Gb_Valor.Name = "Gb_Valor";
            this.Gb_Valor.Size = new System.Drawing.Size(267, 100);
            this.Gb_Valor.TabIndex = 1;
            this.Gb_Valor.TabStop = false;
            this.Gb_Valor.Text = "Digite os valores";
            // 
            // Lb_Ordinal
            // 
            this.Lb_Ordinal.AutoSize = true;
            this.Lb_Ordinal.Location = new System.Drawing.Point(19, 48);
            this.Lb_Ordinal.Name = "Lb_Ordinal";
            this.Lb_Ordinal.Size = new System.Drawing.Size(18, 19);
            this.Lb_Ordinal.TabIndex = 1;
            this.Lb_Ordinal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "º Numero:";
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Location = new System.Drawing.Point(134, 45);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(100, 26);
            this.Txt_Valor.TabIndex = 1;
            this.Txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            this.Txt_Valor.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Valor_Validating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(882, 428);
            this.Controls.Add(this.Gb_Valor);
            this.Controls.Add(this.Gb_Termos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbx_Ordenados);
            this.Controls.Add(this.Lbx_Valores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.StrMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.StrMenu;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Altura Media";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.StrMenu.ResumeLayout(false);
            this.StrMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gb_Termos.ResumeLayout(false);
            this.Gb_Termos.PerformLayout();
            this.Gb_Valor.ResumeLayout(false);
            this.Gb_Valor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip StrMenu;
        private System.Windows.Forms.ToolStripMenuItem MnuOrdenar;
        private System.Windows.Forms.ToolStripMenuItem MnuCalcular;
        private System.Windows.Forms.ToolStripMenuItem MnuLimpar;
        private System.Windows.Forms.ToolStripMenuItem MnuSobre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lb_Aviso;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox Lbx_Valores;
        private System.Windows.Forms.ListBox Lbx_Ordenados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lb_AlturaMedia;
        private System.Windows.Forms.GroupBox Gb_Termos;
        private System.Windows.Forms.TextBox Txt_Quantidade;
        private System.Windows.Forms.GroupBox Gb_Valor;
        private System.Windows.Forms.Label Lb_Ordinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Valor;
    }
}

