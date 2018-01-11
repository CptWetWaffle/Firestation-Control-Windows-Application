namespace QuartelBombeiros
{
    partial class VerExtras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerExtras));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dGVBomb = new System.Windows.Forms.DataGridView();
            this.idextraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bombeironumerobombeiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.extraTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.extraTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.bombToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.bombToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.Location = new System.Drawing.Point(12, 31);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(816, 47);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "CASTIGOS / RECOMENDAÇÕES / CURSOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(850, 3);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
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
            this.idextraDataGridViewTextBoxColumn,
            this.bombeironumerobombeiroDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dGVBomb.DataSource = this.extraBindingSource;
            this.dGVBomb.GridColor = System.Drawing.Color.Black;
            this.dGVBomb.Location = new System.Drawing.Point(12, 173);
            this.dGVBomb.MultiSelect = false;
            this.dGVBomb.Name = "dGVBomb";
            this.dGVBomb.ReadOnly = true;
            this.dGVBomb.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVBomb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBomb.Size = new System.Drawing.Size(816, 497);
            this.dGVBomb.TabIndex = 36;
            // 
            // idextraDataGridViewTextBoxColumn
            // 
            this.idextraDataGridViewTextBoxColumn.DataPropertyName = "id_extra";
            this.idextraDataGridViewTextBoxColumn.HeaderText = "id_extra";
            this.idextraDataGridViewTextBoxColumn.Name = "idextraDataGridViewTextBoxColumn";
            this.idextraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idextraDataGridViewTextBoxColumn.Visible = false;
            this.idextraDataGridViewTextBoxColumn.Width = 69;
            // 
            // bombeironumerobombeiroDataGridViewTextBoxColumn
            // 
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.DataPropertyName = "bombeiro_numero_bombeiro";
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.HeaderText = "Número de Bombeiro";
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.Name = "bombeironumerobombeiroDataGridViewTextBoxColumn";
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.Width = 131;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 53;
            // 
            // extraBindingSource
            // 
            this.extraBindingSource.DataMember = "extra";
            this.extraBindingSource.DataSource = this.fireStationDataSet;
            // 
            // fireStationDataSet
            // 
            this.fireStationDataSet.DataSetName = "FireStationDataSet";
            this.fireStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::QuartelBombeiros.Properties.Resources.HOME;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(20, 108);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 37;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::QuartelBombeiros.Properties.Resources.REMOVER;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(782, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::QuartelBombeiros.Properties.Resources.EDITAR;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(726, 108);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = global::QuartelBombeiros.Properties.Resources.ADICIONAR;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(670, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // extraTableAdapter
            // 
            this.extraTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bombToolStripLabel,
            this.bombToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1264, 25);
            this.fillByToolStrip.TabIndex = 41;
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
            // VerExtras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1264, 690);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.dGVBomb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerExtras";
            this.Text = "Extras";
            this.Load += new System.EventHandler(this.VerExtras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dGVBomb;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource extraBindingSource;
        private FireStationDataSetTableAdapters.extraTableAdapter extraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idextraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bombeironumerobombeiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel bombToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox bombToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}