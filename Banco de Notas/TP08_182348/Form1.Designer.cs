namespace TP08_182348
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
            this.DgvRegistro = new System.Windows.Forms.DataGridView();
            this.BscDiario = new System.Windows.Forms.BindingSource(this.components);
            this.DtsResgistro = new System.Data.DataSet();
            this.DtbDiario = new System.Data.DataTable();
            this.DtcNome = new System.Data.DataColumn();
            this.DtcSerie = new System.Data.DataColumn();
            this.DtcNm = new System.Data.DataColumn();
            this.DtcN1 = new System.Data.DataColumn();
            this.DtcN2 = new System.Data.DataColumn();
            this.DtcN3 = new System.Data.DataColumn();
            this.DtcN4 = new System.Data.DataColumn();
            this.DtcMedia = new System.Data.DataColumn();
            this.DtcConceito = new System.Data.DataColumn();
            this.DtcIndice = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbNm = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TbN4 = new System.Windows.Forms.TextBox();
            this.TbN3 = new System.Windows.Forms.TextBox();
            this.TbN2 = new System.Windows.Forms.TextBox();
            this.TbN1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Cbprocura = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TbFiltro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota01DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota02DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota03DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota04DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BscDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtsResgistro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtbDiario)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvRegistro
            // 
            this.DgvRegistro.AllowUserToDeleteRows = false;
            this.DgvRegistro.AutoGenerateColumns = false;
            this.DgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegistro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.serieDataGridViewTextBoxColumn,
            this.Matricula,
            this.nota01DataGridViewTextBoxColumn,
            this.nota02DataGridViewTextBoxColumn,
            this.nota03DataGridViewTextBoxColumn,
            this.nota04DataGridViewTextBoxColumn,
            this.mediaDataGridViewTextBoxColumn,
            this.conceitoDataGridViewTextBoxColumn});
            this.DgvRegistro.DataSource = this.BscDiario;
            this.DgvRegistro.Enabled = false;
            this.DgvRegistro.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DgvRegistro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DgvRegistro.Location = new System.Drawing.Point(378, 117);
            this.DgvRegistro.Name = "DgvRegistro";
            this.DgvRegistro.Size = new System.Drawing.Size(809, 444);
            this.DgvRegistro.TabIndex = 0;
            // 
            // BscDiario
            // 
            this.BscDiario.DataMember = "Diario";
            this.BscDiario.DataSource = this.DtsResgistro;
            // 
            // DtsResgistro
            // 
            this.DtsResgistro.DataSetName = "Registro";
            this.DtsResgistro.Tables.AddRange(new System.Data.DataTable[] {
            this.DtbDiario});
            // 
            // DtbDiario
            // 
            this.DtbDiario.Columns.AddRange(new System.Data.DataColumn[] {
            this.DtcNome,
            this.DtcSerie,
            this.DtcNm,
            this.DtcN1,
            this.DtcN2,
            this.DtcN3,
            this.DtcN4,
            this.DtcMedia,
            this.DtcConceito,
            this.DtcIndice});
            this.DtbDiario.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Indice"}, false)});
            this.DtbDiario.TableName = "Diario";
            // 
            // DtcNome
            // 
            this.DtcNome.ColumnName = "Disciplina";
            // 
            // DtcSerie
            // 
            this.DtcSerie.ColumnName = "Serie";
            // 
            // DtcNm
            // 
            this.DtcNm.ColumnName = "Matricula";
            // 
            // DtcN1
            // 
            this.DtcN1.ColumnName = "Nota 01";
            // 
            // DtcN2
            // 
            this.DtcN2.ColumnName = "Nota 02";
            // 
            // DtcN3
            // 
            this.DtcN3.ColumnName = "Nota 03";
            // 
            // DtcN4
            // 
            this.DtcN4.ColumnName = "Nota 04";
            // 
            // DtcMedia
            // 
            this.DtcMedia.ColumnName = "Media";
            // 
            // DtcConceito
            // 
            this.DtcConceito.ColumnName = "Conceito";
            // 
            // DtcIndice
            // 
            this.DtcIndice.AutoIncrement = true;
            this.DtcIndice.ColumnName = "Indice";
            this.DtcIndice.DataType = typeof(int);
            this.DtcIndice.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.TbNm);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TbN4);
            this.groupBox1.Controls.Add(this.TbN3);
            this.groupBox1.Controls.Add(this.TbN2);
            this.groupBox1.Controls.Add(this.TbN1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbSerie);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-80, -10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 626);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TP08_182348.Properties.Resources.download;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(188, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 124);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TbNm
            // 
            this.TbNm.Location = new System.Drawing.Point(282, 297);
            this.TbNm.Name = "TbNm";
            this.TbNm.Size = new System.Drawing.Size(157, 26);
            this.TbNm.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(94, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(338, 96);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbN4
            // 
            this.TbN4.Location = new System.Drawing.Point(201, 429);
            this.TbN4.Name = "TbN4";
            this.TbN4.Size = new System.Drawing.Size(100, 26);
            this.TbN4.TabIndex = 2;
            this.TbN4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            // 
            // TbN3
            // 
            this.TbN3.Location = new System.Drawing.Point(201, 400);
            this.TbN3.Name = "TbN3";
            this.TbN3.Size = new System.Drawing.Size(100, 26);
            this.TbN3.TabIndex = 2;
            this.TbN3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            // 
            // TbN2
            // 
            this.TbN2.Location = new System.Drawing.Point(201, 371);
            this.TbN2.Name = "TbN2";
            this.TbN2.Size = new System.Drawing.Size(100, 26);
            this.TbN2.TabIndex = 2;
            this.TbN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            // 
            // TbN1
            // 
            this.TbN1.Location = new System.Drawing.Point(201, 342);
            this.TbN1.Name = "TbN1";
            this.TbN1.Size = new System.Drawing.Size(100, 26);
            this.TbN1.TabIndex = 2;
            this.TbN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verificar);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(89, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Nota 04:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nota 03:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(89, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nota 02:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(89, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nota 01:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nº de Matricula:";
            // 
            // TbSerie
            // 
            this.TbSerie.Location = new System.Drawing.Point(165, 253);
            this.TbSerie.Name = "TbSerie";
            this.TbSerie.Size = new System.Drawing.Size(274, 26);
            this.TbSerie.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(89, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Serie:";
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(94, 206);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(345, 26);
            this.TbNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome da Disciplina:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SlateBlue;
            this.groupBox2.Controls.Add(this.Cbprocura);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.TbFiltro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(378, -10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // Cbprocura
            // 
            this.Cbprocura.FormattingEnabled = true;
            this.Cbprocura.Items.AddRange(new object[] {
            "Disciplina",
            "Serie",
            "Matricula"});
            this.Cbprocura.Location = new System.Drawing.Point(165, 41);
            this.Cbprocura.Name = "Cbprocura";
            this.Cbprocura.Size = new System.Drawing.Size(140, 28);
            this.Cbprocura.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Procurar por:";
            // 
            // TbFiltro
            // 
            this.TbFiltro.Location = new System.Drawing.Point(387, 45);
            this.TbFiltro.Name = "TbFiltro";
            this.TbFiltro.Size = new System.Drawing.Size(274, 26);
            this.TbFiltro.TabIndex = 1;
            this.TbFiltro.TextChanged += new System.EventHandler(this.TbFiltro_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(310, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 29);
            this.label9.TabIndex = 0;
            this.label9.Text = "Filtro:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1193, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem1.Text = "Exportar";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Disciplina";
            this.Column1.HeaderText = "Disciplina";
            this.Column1.Name = "Column1";
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            this.serieDataGridViewTextBoxColumn.Width = 66;
            // 
            // Matricula
            // 
            this.Matricula.DataPropertyName = "Matricula";
            this.Matricula.HeaderText = "Matricula";
            this.Matricula.Name = "Matricula";
            // 
            // nota01DataGridViewTextBoxColumn
            // 
            this.nota01DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nota01DataGridViewTextBoxColumn.DataPropertyName = "Nota 01";
            this.nota01DataGridViewTextBoxColumn.HeaderText = "Nota 01";
            this.nota01DataGridViewTextBoxColumn.Name = "nota01DataGridViewTextBoxColumn";
            this.nota01DataGridViewTextBoxColumn.Width = 79;
            // 
            // nota02DataGridViewTextBoxColumn
            // 
            this.nota02DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nota02DataGridViewTextBoxColumn.DataPropertyName = "Nota 02";
            this.nota02DataGridViewTextBoxColumn.HeaderText = "Nota 02";
            this.nota02DataGridViewTextBoxColumn.Name = "nota02DataGridViewTextBoxColumn";
            this.nota02DataGridViewTextBoxColumn.Width = 79;
            // 
            // nota03DataGridViewTextBoxColumn
            // 
            this.nota03DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nota03DataGridViewTextBoxColumn.DataPropertyName = "Nota 03";
            this.nota03DataGridViewTextBoxColumn.HeaderText = "Nota 03";
            this.nota03DataGridViewTextBoxColumn.Name = "nota03DataGridViewTextBoxColumn";
            this.nota03DataGridViewTextBoxColumn.Width = 79;
            // 
            // nota04DataGridViewTextBoxColumn
            // 
            this.nota04DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.nota04DataGridViewTextBoxColumn.DataPropertyName = "Nota 04";
            this.nota04DataGridViewTextBoxColumn.HeaderText = "Nota 04";
            this.nota04DataGridViewTextBoxColumn.Name = "nota04DataGridViewTextBoxColumn";
            this.nota04DataGridViewTextBoxColumn.Width = 79;
            // 
            // mediaDataGridViewTextBoxColumn
            // 
            this.mediaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.mediaDataGridViewTextBoxColumn.DataPropertyName = "Media";
            this.mediaDataGridViewTextBoxColumn.HeaderText = "Media";
            this.mediaDataGridViewTextBoxColumn.Name = "mediaDataGridViewTextBoxColumn";
            this.mediaDataGridViewTextBoxColumn.Width = 71;
            // 
            // conceitoDataGridViewTextBoxColumn
            // 
            this.conceitoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.conceitoDataGridViewTextBoxColumn.DataPropertyName = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.HeaderText = "Conceito";
            this.conceitoDataGridViewTextBoxColumn.Name = "conceitoDataGridViewTextBoxColumn";
            this.conceitoDataGridViewTextBoxColumn.Width = 87;
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linhaToolStripMenuItem,
            this.colunaToolStripMenuItem});
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textoToolStripMenuItem.Text = "Texto";
            // 
            // linhaToolStripMenuItem
            // 
            this.linhaToolStripMenuItem.Name = "linhaToolStripMenuItem";
            this.linhaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linhaToolStripMenuItem.Text = "Por Linha";
            this.linhaToolStripMenuItem.Click += new System.EventHandler(this.linhaToolStripMenuItem_Click);
            // 
            // colunaToolStripMenuItem
            // 
            this.colunaToolStripMenuItem.Name = "colunaToolStripMenuItem";
            this.colunaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colunaToolStripMenuItem.Text = "Por Coluna";
            this.colunaToolStripMenuItem.Click += new System.EventHandler(this.colunaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1193, 573);
            this.Controls.Add(this.DgvRegistro);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Unisanta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BscDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtsResgistro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtbDiario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvRegistro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TbN4;
        private System.Windows.Forms.TextBox TbN3;
        private System.Windows.Forms.TextBox TbN2;
        private System.Windows.Forms.TextBox TbN1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbNm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Cbprocura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TbFiltro;
        private System.Windows.Forms.Label label9;
        private System.Data.DataSet DtsResgistro;
        private System.Data.DataTable DtbDiario;
        private System.Data.DataColumn DtcNome;
        private System.Data.DataColumn DtcSerie;
        private System.Data.DataColumn DtcNm;
        private System.Data.DataColumn DtcN1;
        private System.Data.DataColumn DtcN2;
        private System.Data.DataColumn DtcN3;
        private System.Data.DataColumn DtcN4;
        private System.Data.DataColumn DtcMedia;
        private System.Data.DataColumn DtcConceito;
        private System.Data.DataColumn DtcIndice;
        private System.Windows.Forms.BindingSource BscDiario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota01DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota02DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota03DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota04DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conceitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colunaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

