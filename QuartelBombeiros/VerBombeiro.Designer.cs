namespace QuartelBombeiros
{
    partial class VerBombeiro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerBombeiro));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.msBombeiro = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.dGVBomb = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bombeironumbombeiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naturalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conselhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freguesiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distritoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigopostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numsegsocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numutenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numservmilitarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vacinaactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruposangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichabombeiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.ficha_bombeiroTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.ficha_bombeiroTableAdapter();
            this.pcFoto = new System.Windows.Forms.PictureBox();
            this.ficha = new QuartelBombeiros.Ficha();
            this.fichabombeiroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ficha_bombeiroTableAdapter1 = new QuartelBombeiros.FichaTableAdapters.ficha_bombeiroTableAdapter();
            this.msBombeiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichabombeiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichabombeiroBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.Location = new System.Drawing.Point(12, 35);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(225, 47);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "BOMBEIRO";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::QuartelBombeiros.Properties.Resources.ADICIONAR;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(318, 117);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::QuartelBombeiros.Properties.Resources.EDITAR;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(374, 117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::QuartelBombeiros.Properties.Resources.REMOVER;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(430, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // msBombeiro
            // 
            this.msBombeiro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msBombeiro.Location = new System.Drawing.Point(0, 0);
            this.msBombeiro.Name = "msBombeiro";
            this.msBombeiro.Size = new System.Drawing.Size(1264, 24);
            this.msBombeiro.TabIndex = 6;
            this.msBombeiro.Text = "msBombeiro";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 10);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::QuartelBombeiros.Properties.Resources.HOME;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(20, 117);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 2;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dGVBomb
            // 
            this.dGVBomb.AllowUserToAddRows = false;
            this.dGVBomb.AllowUserToDeleteRows = false;
            this.dGVBomb.AllowUserToResizeRows = false;
            this.dGVBomb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBomb.AutoGenerateColumns = false;
            this.dGVBomb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVBomb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVBomb.BackgroundColor = System.Drawing.Color.White;
            this.dGVBomb.ColumnHeadersHeight = 30;
            this.dGVBomb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVBomb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.bIDataGridViewTextBoxColumn,
            this.patenteDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.datanascimentoDataGridViewTextBoxColumn,
            this.bombeironumbombeiroDataGridViewTextBoxColumn,
            this.naturalidadeDataGridViewTextBoxColumn,
            this.nacionalidadeDataGridViewTextBoxColumn,
            this.moradaDataGridViewTextBoxColumn,
            this.conselhoDataGridViewTextBoxColumn,
            this.freguesiaDataGridViewTextBoxColumn,
            this.distritoDataGridViewTextBoxColumn,
            this.codigopostalDataGridViewTextBoxColumn,
            this.numsegsocialDataGridViewTextBoxColumn,
            this.estadocivilDataGridViewTextBoxColumn,
            this.numutenteDataGridViewTextBoxColumn,
            this.numservmilitarDataGridViewTextBoxColumn,
            this.vacinaactDataGridViewTextBoxColumn,
            this.gruposangDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn});
            this.dGVBomb.DataSource = this.fichabombeiroBindingSource1;
            this.dGVBomb.GridColor = System.Drawing.Color.Black;
            this.dGVBomb.Location = new System.Drawing.Point(12, 173);
            this.dGVBomb.MultiSelect = false;
            this.dGVBomb.Name = "dGVBomb";
            this.dGVBomb.ReadOnly = true;
            this.dGVBomb.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVBomb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBomb.Size = new System.Drawing.Size(1240, 496);
            this.dGVBomb.TabIndex = 23;
            this.dGVBomb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 88;
            // 
            // bIDataGridViewTextBoxColumn
            // 
            this.bIDataGridViewTextBoxColumn.DataPropertyName = "BI";
            this.bIDataGridViewTextBoxColumn.HeaderText = "BI";
            this.bIDataGridViewTextBoxColumn.Name = "bIDataGridViewTextBoxColumn";
            this.bIDataGridViewTextBoxColumn.ReadOnly = true;
            this.bIDataGridViewTextBoxColumn.Width = 51;
            // 
            // patenteDataGridViewTextBoxColumn
            // 
            this.patenteDataGridViewTextBoxColumn.DataPropertyName = "patente";
            this.patenteDataGridViewTextBoxColumn.HeaderText = "Patente";
            this.patenteDataGridViewTextBoxColumn.Name = "patenteDataGridViewTextBoxColumn";
            this.patenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.patenteDataGridViewTextBoxColumn.Width = 106;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 86;
            // 
            // datanascimentoDataGridViewTextBoxColumn
            // 
            this.datanascimentoDataGridViewTextBoxColumn.DataPropertyName = "data_nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.HeaderText = "Data Nascimento";
            this.datanascimentoDataGridViewTextBoxColumn.Name = "datanascimentoDataGridViewTextBoxColumn";
            this.datanascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.datanascimentoDataGridViewTextBoxColumn.Width = 196;
            // 
            // bombeironumbombeiroDataGridViewTextBoxColumn
            // 
            this.bombeironumbombeiroDataGridViewTextBoxColumn.DataPropertyName = "bombeiro_num_bombeiro";
            this.bombeironumbombeiroDataGridViewTextBoxColumn.HeaderText = "Número Bombeiro";
            this.bombeironumbombeiroDataGridViewTextBoxColumn.Name = "bombeironumbombeiroDataGridViewTextBoxColumn";
            this.bombeironumbombeiroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bombeironumbombeiroDataGridViewTextBoxColumn.Width = 202;
            // 
            // naturalidadeDataGridViewTextBoxColumn
            // 
            this.naturalidadeDataGridViewTextBoxColumn.DataPropertyName = "naturalidade";
            this.naturalidadeDataGridViewTextBoxColumn.HeaderText = "Naturalidade";
            this.naturalidadeDataGridViewTextBoxColumn.Name = "naturalidadeDataGridViewTextBoxColumn";
            this.naturalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.naturalidadeDataGridViewTextBoxColumn.Width = 159;
            // 
            // nacionalidadeDataGridViewTextBoxColumn
            // 
            this.nacionalidadeDataGridViewTextBoxColumn.DataPropertyName = "nacionalidade";
            this.nacionalidadeDataGridViewTextBoxColumn.HeaderText = "Nacionalidade";
            this.nacionalidadeDataGridViewTextBoxColumn.Name = "nacionalidadeDataGridViewTextBoxColumn";
            this.nacionalidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nacionalidadeDataGridViewTextBoxColumn.Width = 176;
            // 
            // moradaDataGridViewTextBoxColumn
            // 
            this.moradaDataGridViewTextBoxColumn.DataPropertyName = "morada";
            this.moradaDataGridViewTextBoxColumn.HeaderText = "Morada";
            this.moradaDataGridViewTextBoxColumn.Name = "moradaDataGridViewTextBoxColumn";
            this.moradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.moradaDataGridViewTextBoxColumn.Width = 109;
            // 
            // conselhoDataGridViewTextBoxColumn
            // 
            this.conselhoDataGridViewTextBoxColumn.DataPropertyName = "conselho";
            this.conselhoDataGridViewTextBoxColumn.HeaderText = "Conselho";
            this.conselhoDataGridViewTextBoxColumn.Name = "conselhoDataGridViewTextBoxColumn";
            this.conselhoDataGridViewTextBoxColumn.ReadOnly = true;
            this.conselhoDataGridViewTextBoxColumn.Width = 121;
            // 
            // freguesiaDataGridViewTextBoxColumn
            // 
            this.freguesiaDataGridViewTextBoxColumn.DataPropertyName = "freguesia";
            this.freguesiaDataGridViewTextBoxColumn.HeaderText = "Freguesia";
            this.freguesiaDataGridViewTextBoxColumn.Name = "freguesiaDataGridViewTextBoxColumn";
            this.freguesiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.freguesiaDataGridViewTextBoxColumn.Width = 124;
            // 
            // distritoDataGridViewTextBoxColumn
            // 
            this.distritoDataGridViewTextBoxColumn.DataPropertyName = "distrito";
            this.distritoDataGridViewTextBoxColumn.HeaderText = "Distrito";
            this.distritoDataGridViewTextBoxColumn.Name = "distritoDataGridViewTextBoxColumn";
            this.distritoDataGridViewTextBoxColumn.ReadOnly = true;
            this.distritoDataGridViewTextBoxColumn.Width = 96;
            // 
            // codigopostalDataGridViewTextBoxColumn
            // 
            this.codigopostalDataGridViewTextBoxColumn.DataPropertyName = "codigo_postal";
            this.codigopostalDataGridViewTextBoxColumn.HeaderText = "Codigo Postal";
            this.codigopostalDataGridViewTextBoxColumn.Name = "codigopostalDataGridViewTextBoxColumn";
            this.codigopostalDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigopostalDataGridViewTextBoxColumn.Width = 165;
            // 
            // numsegsocialDataGridViewTextBoxColumn
            // 
            this.numsegsocialDataGridViewTextBoxColumn.DataPropertyName = "num_seg_social";
            this.numsegsocialDataGridViewTextBoxColumn.HeaderText = "Número Segurança Social";
            this.numsegsocialDataGridViewTextBoxColumn.Name = "numsegsocialDataGridViewTextBoxColumn";
            this.numsegsocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.numsegsocialDataGridViewTextBoxColumn.Width = 276;
            // 
            // estadocivilDataGridViewTextBoxColumn
            // 
            this.estadocivilDataGridViewTextBoxColumn.DataPropertyName = "estado_civil";
            this.estadocivilDataGridViewTextBoxColumn.HeaderText = "Estado Civil";
            this.estadocivilDataGridViewTextBoxColumn.Name = "estadocivilDataGridViewTextBoxColumn";
            this.estadocivilDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadocivilDataGridViewTextBoxColumn.Width = 143;
            // 
            // numutenteDataGridViewTextBoxColumn
            // 
            this.numutenteDataGridViewTextBoxColumn.DataPropertyName = "num_utente";
            this.numutenteDataGridViewTextBoxColumn.HeaderText = "Número de Utente";
            this.numutenteDataGridViewTextBoxColumn.Name = "numutenteDataGridViewTextBoxColumn";
            this.numutenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.numutenteDataGridViewTextBoxColumn.Width = 203;
            // 
            // numservmilitarDataGridViewTextBoxColumn
            // 
            this.numservmilitarDataGridViewTextBoxColumn.DataPropertyName = "num_serv_militar";
            this.numservmilitarDataGridViewTextBoxColumn.HeaderText = "Número Serviço Social";
            this.numservmilitarDataGridViewTextBoxColumn.Name = "numservmilitarDataGridViewTextBoxColumn";
            this.numservmilitarDataGridViewTextBoxColumn.ReadOnly = true;
            this.numservmilitarDataGridViewTextBoxColumn.Width = 243;
            // 
            // vacinaactDataGridViewTextBoxColumn
            // 
            this.vacinaactDataGridViewTextBoxColumn.DataPropertyName = "vacina_act";
            this.vacinaactDataGridViewTextBoxColumn.HeaderText = "Vacina Actualizada";
            this.vacinaactDataGridViewTextBoxColumn.Name = "vacinaactDataGridViewTextBoxColumn";
            this.vacinaactDataGridViewTextBoxColumn.ReadOnly = true;
            this.vacinaactDataGridViewTextBoxColumn.Width = 221;
            // 
            // gruposangDataGridViewTextBoxColumn
            // 
            this.gruposangDataGridViewTextBoxColumn.DataPropertyName = "grupo_sang";
            this.gruposangDataGridViewTextBoxColumn.HeaderText = "Grupo Sanguinio";
            this.gruposangDataGridViewTextBoxColumn.Name = "gruposangDataGridViewTextBoxColumn";
            this.gruposangDataGridViewTextBoxColumn.ReadOnly = true;
            this.gruposangDataGridViewTextBoxColumn.Width = 189;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIFDataGridViewTextBoxColumn.Width = 63;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn.Width = 158;
            // 
            // fichabombeiroBindingSource
            // 
            this.fichabombeiroBindingSource.DataMember = "ficha_bombeiro";
            this.fichabombeiroBindingSource.DataSource = this.fireStationDataSetBindingSource;
            // 
            // fireStationDataSetBindingSource
            // 
            this.fireStationDataSetBindingSource.DataSource = this.fireStationDataSet;
            this.fireStationDataSetBindingSource.Position = 0;
            // 
            // fireStationDataSet
            // 
            this.fireStationDataSet.DataSetName = "FireStationDataSet";
            this.fireStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ficha_bombeiroTableAdapter
            // 
            this.ficha_bombeiroTableAdapter.ClearBeforeFill = true;
            // 
            // pcFoto
            // 
            this.pcFoto.BackColor = System.Drawing.Color.Transparent;
            this.pcFoto.Location = new System.Drawing.Point(1056, 35);
            this.pcFoto.MaximumSize = new System.Drawing.Size(200, 132);
            this.pcFoto.Name = "pcFoto";
            this.pcFoto.Size = new System.Drawing.Size(196, 132);
            this.pcFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcFoto.TabIndex = 24;
            this.pcFoto.TabStop = false;
            // 
            // ficha
            // 
            this.ficha.DataSetName = "Ficha";
            this.ficha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fichabombeiroBindingSource1
            // 
            this.fichabombeiroBindingSource1.DataMember = "ficha_bombeiro";
            this.fichabombeiroBindingSource1.DataSource = this.ficha;
            // 
            // ficha_bombeiroTableAdapter1
            // 
            this.ficha_bombeiroTableAdapter1.ClearBeforeFill = true;
            // 
            // VerBombeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pcFoto);
            this.Controls.Add(this.dGVBomb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.msBombeiro);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msBombeiro;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "VerBombeiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VerBombeiro";
            this.Load += new System.EventHandler(this.VerBombeiro_Load);
            this.msBombeiro.ResumeLayout(false);
            this.msBombeiro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichabombeiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ficha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichabombeiroBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MenuStrip msBombeiro;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dGVBomb;
        private System.Windows.Forms.BindingSource fireStationDataSetBindingSource;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource fichabombeiroBindingSource;
        private FireStationDataSetTableAdapters.ficha_bombeiroTableAdapter ficha_bombeiroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bombeironumbombeiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naturalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conselhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freguesiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distritoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigopostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numsegsocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadocivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numutenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numservmilitarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vacinaactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gruposangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pcFoto;
        private Ficha ficha;
        private System.Windows.Forms.BindingSource fichabombeiroBindingSource1;
        private FichaTableAdapters.ficha_bombeiroTableAdapter ficha_bombeiroTableAdapter1;
    }
}