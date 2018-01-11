namespace QuartelBombeiros
{
    partial class Servicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicos));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dGVServ = new System.Windows.Forms.DataGridView();
            this.occorenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.bombToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.bombToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servico = new QuartelBombeiros.servico();
            this.occorenciaTableAdapter = new QuartelBombeiros.servicoTableAdapters.occorenciaTableAdapter();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bombToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.bombToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoproteccaocivilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conselhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freguesiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occorenciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sServicos = new QuartelBombeiros.sServicos();
            this.occorenciaTableAdapter1 = new QuartelBombeiros.sServicosTableAdapters.occorenciaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occorenciaBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servico)).BeginInit();
            this.fillByToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occorenciaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.Location = new System.Drawing.Point(12, 35);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(210, 47);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "SERVIÇOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 3);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // dGVServ
            // 
            this.dGVServ.AllowUserToAddRows = false;
            this.dGVServ.AllowUserToDeleteRows = false;
            this.dGVServ.AllowUserToResizeRows = false;
            this.dGVServ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVServ.AutoGenerateColumns = false;
            this.dGVServ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVServ.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVServ.BackgroundColor = System.Drawing.Color.White;
            this.dGVServ.ColumnHeadersHeight = 30;
            this.dGVServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricaoDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.codigoproteccaocivilDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn,
            this.conselhoDataGridViewTextBoxColumn,
            this.freguesiaDataGridViewTextBoxColumn});
            this.dGVServ.DataSource = this.occorenciaBindingSource1;
            this.dGVServ.GridColor = System.Drawing.Color.Black;
            this.dGVServ.Location = new System.Drawing.Point(12, 108);
            this.dGVServ.MultiSelect = false;
            this.dGVServ.Name = "dGVServ";
            this.dGVServ.ReadOnly = true;
            this.dGVServ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVServ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVServ.Size = new System.Drawing.Size(1256, 497);
            this.dGVServ.TabIndex = 34;
            this.dGVServ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVServ_CellContentClick);
            // 
            // occorenciaBindingSource
            // 
            this.occorenciaBindingSource.DataMember = "occorencia";
            this.occorenciaBindingSource.DataSource = this.servicoBindingSource;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bombToolStripLabel,
            this.bombToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1272, 25);
            this.fillByToolStrip.TabIndex = 36;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // bombToolStripLabel
            // 
            this.bombToolStripLabel.Name = "bombToolStripLabel";
            this.bombToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.bombToolStripLabel.Text = "bomb:";
            // 
            // bombToolStripTextBox
            // 
            this.bombToolStripTextBox.Name = "bombToolStripTextBox";
            this.bombToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataSource = this.servico;
            this.servicoBindingSource.Position = 0;
            // 
            // servico
            // 
            this.servico.DataSetName = "servico";
            this.servico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occorenciaTableAdapter
            // 
            this.occorenciaTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bombToolStripLabel1,
            this.bombToolStripTextBox1,
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(1280, 25);
            this.fillByToolStrip1.TabIndex = 37;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            this.fillByToolStrip1.Visible = false;
            // 
            // bombToolStripLabel1
            // 
            this.bombToolStripLabel1.Name = "bombToolStripLabel1";
            this.bombToolStripLabel1.Size = new System.Drawing.Size(42, 22);
            this.bombToolStripLabel1.Text = "bomb:";
            // 
            // bombToolStripTextBox1
            // 
            this.bombToolStripTextBox1.Name = "bombToolStripTextBox1";
            this.bombToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton1.Text = "FillBy";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // datainicioDataGridViewTextBoxColumn
            // 
            this.datainicioDataGridViewTextBoxColumn.DataPropertyName = "data_inicio";
            this.datainicioDataGridViewTextBoxColumn.HeaderText = "Data Inicio";
            this.datainicioDataGridViewTextBoxColumn.Name = "datainicioDataGridViewTextBoxColumn";
            this.datainicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.datainicioDataGridViewTextBoxColumn.Width = 83;
            // 
            // datafimDataGridViewTextBoxColumn
            // 
            this.datafimDataGridViewTextBoxColumn.DataPropertyName = "data_fim";
            this.datafimDataGridViewTextBoxColumn.HeaderText = "Data Fim";
            this.datafimDataGridViewTextBoxColumn.Name = "datafimDataGridViewTextBoxColumn";
            this.datafimDataGridViewTextBoxColumn.ReadOnly = true;
            this.datafimDataGridViewTextBoxColumn.Width = 74;
            // 
            // codigoproteccaocivilDataGridViewTextBoxColumn
            // 
            this.codigoproteccaocivilDataGridViewTextBoxColumn.DataPropertyName = "codigo_proteccao_civil";
            this.codigoproteccaocivilDataGridViewTextBoxColumn.HeaderText = "Código Proteccao Civil";
            this.codigoproteccaocivilDataGridViewTextBoxColumn.Name = "codigoproteccaocivilDataGridViewTextBoxColumn";
            this.codigoproteccaocivilDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoproteccaocivilDataGridViewTextBoxColumn.Width = 139;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            this.localDataGridViewTextBoxColumn.Width = 84;
            // 
            // codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn
            // 
            this.codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn.DataPropertyName = "codigo_occorencia_id_codigo_occorencia";
            this.codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn.HeaderText = "Código de Ocorrência";
            this.codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn.Name = "codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn";
            this.codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn.Width = 135;
            // 
            // conselhoDataGridViewTextBoxColumn
            // 
            this.conselhoDataGridViewTextBoxColumn.DataPropertyName = "conselho";
            this.conselhoDataGridViewTextBoxColumn.HeaderText = "Concelho";
            this.conselhoDataGridViewTextBoxColumn.Name = "conselhoDataGridViewTextBoxColumn";
            this.conselhoDataGridViewTextBoxColumn.ReadOnly = true;
            this.conselhoDataGridViewTextBoxColumn.Width = 77;
            // 
            // freguesiaDataGridViewTextBoxColumn
            // 
            this.freguesiaDataGridViewTextBoxColumn.DataPropertyName = "freguesia";
            this.freguesiaDataGridViewTextBoxColumn.HeaderText = "Freguesia";
            this.freguesiaDataGridViewTextBoxColumn.Name = "freguesiaDataGridViewTextBoxColumn";
            this.freguesiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.freguesiaDataGridViewTextBoxColumn.Width = 78;
            // 
            // occorenciaBindingSource1
            // 
            this.occorenciaBindingSource1.DataMember = "occorencia";
            this.occorenciaBindingSource1.DataSource = this.sServicos;
            // 
            // sServicos
            // 
            this.sServicos.DataSetName = "sServicos";
            this.sServicos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // occorenciaTableAdapter1
            // 
            this.occorenciaTableAdapter1.ClearBeforeFill = true;
            // 
            // Servicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1280, 682);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dGVServ);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Servicos";
            this.Text = "Servicos";
            this.Load += new System.EventHandler(this.Servicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occorenciaBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servico)).EndInit();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.occorenciaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dGVServ;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private servico servico;
        private System.Windows.Forms.BindingSource occorenciaBindingSource;
        private servicoTableAdapters.occorenciaTableAdapter occorenciaTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel bombToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox bombToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoproteccaocivilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigooccorenciaidcodigooccorenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conselhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn freguesiaDataGridViewTextBoxColumn;
        private sServicos sServicos;
        private System.Windows.Forms.BindingSource occorenciaBindingSource1;
        private sServicosTableAdapters.occorenciaTableAdapter occorenciaTableAdapter1;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripLabel bombToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox bombToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
    }
}