namespace QuartelBombeiros
{
    partial class VerEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerEquipamento));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dGVEquip = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_disponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.dGVBombViat = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.equipBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipB = new QuartelBombeiros.EquipB();
            this.codigooccorenciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Atrib = new System.Windows.Forms.Button();
            this.codigo_occorenciaTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.codigo_occorenciaTableAdapter();
            this.equipamentoTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.equipamentoTableAdapter();
            this.equipamentoTableAdapter1 = new QuartelBombeiros.EquipBTableAdapters.equipamentoTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.bombToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.bombToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBombViat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigooccorenciaBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.Location = new System.Drawing.Point(12, 35);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(302, 47);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "EQUIPAMENTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 10);
            this.pictureBox1.TabIndex = 23;
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
            this.btnHome.TabIndex = 24;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnAdd.TabIndex = 26;
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
            this.btnEdit.TabIndex = 27;
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
            this.btnDelete.TabIndex = 28;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dGVEquip
            // 
            this.dGVEquip.AllowUserToAddRows = false;
            this.dGVEquip.AllowUserToDeleteRows = false;
            this.dGVEquip.AllowUserToResizeRows = false;
            this.dGVEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVEquip.AutoGenerateColumns = false;
            this.dGVEquip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVEquip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVEquip.BackgroundColor = System.Drawing.Color.White;
            this.dGVEquip.ColumnHeadersHeight = 30;
            this.dGVEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVEquip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.quantidade_disponivel,
            this.quantidade_total,
            this.descricao,
            this.tipo,
            this.nomeDataGridViewTextBoxColumn});
            this.dGVEquip.DataSource = this.equipamentoBindingSource;
            this.dGVEquip.GridColor = System.Drawing.Color.Black;
            this.dGVEquip.Location = new System.Drawing.Point(12, 173);
            this.dGVEquip.MultiSelect = false;
            this.dGVEquip.Name = "dGVEquip";
            this.dGVEquip.ReadOnly = true;
            this.dGVEquip.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEquip.Size = new System.Drawing.Size(619, 497);
            this.dGVEquip.TabIndex = 29;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id_equipamento";
            this.Column1.HeaderText = "ID Equipamento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 108;
            // 
            // quantidade_disponivel
            // 
            this.quantidade_disponivel.DataPropertyName = "quantidade_disponivel";
            this.quantidade_disponivel.HeaderText = "Quantidade Disponivel";
            this.quantidade_disponivel.Name = "quantidade_disponivel";
            this.quantidade_disponivel.ReadOnly = true;
            this.quantidade_disponivel.Width = 139;
            // 
            // quantidade_total
            // 
            this.quantidade_total.DataPropertyName = "quantidade_total";
            this.quantidade_total.HeaderText = "Quantidade Total";
            this.quantidade_total.Name = "quantidade_total";
            this.quantidade_total.ReadOnly = true;
            this.quantidade_total.Width = 114;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 80;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 53;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 60;
            // 
            // equipamentoBindingSource
            // 
            this.equipamentoBindingSource.DataMember = "equipamento";
            this.equipamentoBindingSource.DataSource = this.fireStationDataSetBindingSource;
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
            // dGVBombViat
            // 
            this.dGVBombViat.AllowUserToAddRows = false;
            this.dGVBombViat.AllowUserToDeleteRows = false;
            this.dGVBombViat.AllowUserToResizeRows = false;
            this.dGVBombViat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBombViat.AutoGenerateColumns = false;
            this.dGVBombViat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVBombViat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVBombViat.BackgroundColor = System.Drawing.Color.White;
            this.dGVBombViat.ColumnHeadersHeight = 30;
            this.dGVBombViat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVBombViat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn1,
            this.descricaoDataGridViewTextBoxColumn});
            this.dGVBombViat.DataSource = this.equipamentoBindingSource1;
            this.dGVBombViat.GridColor = System.Drawing.Color.Black;
            this.dGVBombViat.Location = new System.Drawing.Point(649, 173);
            this.dGVBombViat.MultiSelect = false;
            this.dGVBombViat.Name = "dGVBombViat";
            this.dGVBombViat.ReadOnly = true;
            this.dGVBombViat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVBombViat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBombViat.Size = new System.Drawing.Size(619, 497);
            this.dGVBombViat.TabIndex = 30;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn1.Width = 58;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 78;
            // 
            // equipamentoBindingSource1
            // 
            this.equipamentoBindingSource1.DataMember = "equipamento";
            this.equipamentoBindingSource1.DataSource = this.equipBBindingSource;
            // 
            // equipBBindingSource
            // 
            this.equipBBindingSource.DataSource = this.equipB;
            this.equipBBindingSource.Position = 0;
            // 
            // equipB
            // 
            this.equipB.DataSetName = "EquipB";
            this.equipB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codigooccorenciaBindingSource
            // 
            this.codigooccorenciaBindingSource.DataMember = "codigo_occorencia";
            this.codigooccorenciaBindingSource.DataSource = this.fireStationDataSetBindingSource;
            // 
            // Atrib
            // 
            this.Atrib.BackColor = System.Drawing.Color.Transparent;
            this.Atrib.BackgroundImage = global::QuartelBombeiros.Properties.Resources.AtribButton;
            this.Atrib.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Atrib.FlatAppearance.BorderSize = 0;
            this.Atrib.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Atrib.Location = new System.Drawing.Point(262, 117);
            this.Atrib.Name = "Atrib";
            this.Atrib.Size = new System.Drawing.Size(50, 50);
            this.Atrib.TabIndex = 31;
            this.Atrib.UseVisualStyleBackColor = false;
            this.Atrib.Click += new System.EventHandler(this.Atrib_Click);
            // 
            // codigo_occorenciaTableAdapter
            // 
            this.codigo_occorenciaTableAdapter.ClearBeforeFill = true;
            // 
            // equipamentoTableAdapter
            // 
            this.equipamentoTableAdapter.ClearBeforeFill = true;
            // 
            // equipamentoTableAdapter1
            // 
            this.equipamentoTableAdapter1.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bombToolStripLabel,
            this.bombToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1280, 25);
            this.fillByToolStrip.TabIndex = 32;
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
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(652, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "EQUIPAMENTOS ADEQUIRIDOS";
            // 
            // VerEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.Atrib);
            this.Controls.Add(this.dGVBombViat);
            this.Controls.Add(this.dGVEquip);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerEquipamento";
            this.Text = "Equipamento";
            this.Load += new System.EventHandler(this.VerEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBombViat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigooccorenciaBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dGVEquip;
        private System.Windows.Forms.DataGridView dGVBombViat;
        private System.Windows.Forms.BindingSource fireStationDataSetBindingSource;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource codigooccorenciaBindingSource;
        private FireStationDataSetTableAdapters.codigo_occorenciaTableAdapter codigo_occorenciaTableAdapter;
        private System.Windows.Forms.BindingSource equipamentoBindingSource;
        private FireStationDataSetTableAdapters.equipamentoTableAdapter equipamentoTableAdapter;
        private System.Windows.Forms.Button Atrib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_disponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.BindingSource equipBBindingSource;
        private EquipB equipB;
        private System.Windows.Forms.BindingSource equipamentoBindingSource1;
        private EquipBTableAdapters.equipamentoTableAdapter equipamentoTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel bombToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox bombToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label1;
    }
}