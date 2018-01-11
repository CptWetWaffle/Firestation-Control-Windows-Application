namespace QuartelBombeiros
{
    partial class VerLicencas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerLicencas));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dGVLicenc = new System.Windows.Forms.DataGridView();
            this.idlicencaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bombeironumerobombeiroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licencaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet1 = new QuartelBombeiros.FireStationDataSet1();
            this.licencaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.licencaTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.licencaTableAdapter();
            this.licencaTableAdapter1 = new QuartelBombeiros.FireStationDataSet1TableAdapters.licencaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLicenc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.Location = new System.Drawing.Point(12, 35);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(213, 47);
            this.lbTitulo.TabIndex = 5;
            this.lbTitulo.Text = "LICENÇAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 3);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImage = global::QuartelBombeiros.Properties.Resources.REMOVER;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(430, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 44;
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
            this.btnEdit.Location = new System.Drawing.Point(374, 108);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 43;
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
            this.btnAdd.Location = new System.Drawing.Point(318, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnHome.TabIndex = 41;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dGVLicenc
            // 
            this.dGVLicenc.AllowUserToAddRows = false;
            this.dGVLicenc.AllowUserToDeleteRows = false;
            this.dGVLicenc.AllowUserToResizeRows = false;
            this.dGVLicenc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVLicenc.AutoGenerateColumns = false;
            this.dGVLicenc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVLicenc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVLicenc.BackgroundColor = System.Drawing.Color.White;
            this.dGVLicenc.ColumnHeadersHeight = 30;
            this.dGVLicenc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVLicenc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlicencaDataGridViewTextBoxColumn,
            this.bombeironumerobombeiroDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dGVLicenc.DataSource = this.licencaBindingSource1;
            this.dGVLicenc.GridColor = System.Drawing.Color.Black;
            this.dGVLicenc.Location = new System.Drawing.Point(12, 164);
            this.dGVLicenc.MultiSelect = false;
            this.dGVLicenc.Name = "dGVLicenc";
            this.dGVLicenc.ReadOnly = true;
            this.dGVLicenc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVLicenc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVLicenc.Size = new System.Drawing.Size(485, 497);
            this.dGVLicenc.TabIndex = 45;
            // 
            // idlicencaDataGridViewTextBoxColumn
            // 
            this.idlicencaDataGridViewTextBoxColumn.DataPropertyName = "id_licenca";
            this.idlicencaDataGridViewTextBoxColumn.HeaderText = "id_licenca";
            this.idlicencaDataGridViewTextBoxColumn.Name = "idlicencaDataGridViewTextBoxColumn";
            this.idlicencaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlicencaDataGridViewTextBoxColumn.Visible = false;
            this.idlicencaDataGridViewTextBoxColumn.Width = 80;
            // 
            // bombeironumerobombeiroDataGridViewTextBoxColumn
            // 
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.DataPropertyName = "bombeiro_numero_bombeiro";
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.HeaderText = "Número de Bombeiro";
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.Name = "bombeironumerobombeiroDataGridViewTextBoxColumn";
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bombeironumerobombeiroDataGridViewTextBoxColumn.Width = 131;
            // 
            // datainicioDataGridViewTextBoxColumn
            // 
            this.datainicioDataGridViewTextBoxColumn.DataPropertyName = "data_inicio";
            this.datainicioDataGridViewTextBoxColumn.HeaderText = "Data de ínicio";
            this.datainicioDataGridViewTextBoxColumn.Name = "datainicioDataGridViewTextBoxColumn";
            this.datainicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.datainicioDataGridViewTextBoxColumn.Width = 99;
            // 
            // datafimDataGridViewTextBoxColumn
            // 
            this.datafimDataGridViewTextBoxColumn.DataPropertyName = "data_fim";
            this.datafimDataGridViewTextBoxColumn.HeaderText = "Data de Fim";
            this.datafimDataGridViewTextBoxColumn.Name = "datafimDataGridViewTextBoxColumn";
            this.datafimDataGridViewTextBoxColumn.ReadOnly = true;
            this.datafimDataGridViewTextBoxColumn.Width = 89;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 53;
            // 
            // licencaBindingSource1
            // 
            this.licencaBindingSource1.DataMember = "licenca";
            this.licencaBindingSource1.DataSource = this.fireStationDataSet1;
            // 
            // fireStationDataSet1
            // 
            this.fireStationDataSet1.DataSetName = "FireStationDataSet1";
            this.fireStationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // licencaBindingSource
            // 
            this.licencaBindingSource.DataMember = "licenca";
            this.licencaBindingSource.DataSource = this.fireStationDataSet;
            // 
            // fireStationDataSet
            // 
            this.fireStationDataSet.DataSetName = "FireStationDataSet";
            this.fireStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // licencaTableAdapter
            // 
            this.licencaTableAdapter.ClearBeforeFill = true;
            // 
            // licencaTableAdapter1
            // 
            this.licencaTableAdapter1.ClearBeforeFill = true;
            // 
            // VerLicencas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.dGVLicenc);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerLicencas";
            this.Text = "Licenças";
            this.Load += new System.EventHandler(this.VerLicencas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVLicenc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licencaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.DataGridView dGVLicenc;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource licencaBindingSource;
        private FireStationDataSetTableAdapters.licencaTableAdapter licencaTableAdapter;
        private FireStationDataSet1 fireStationDataSet1;
        private System.Windows.Forms.BindingSource licencaBindingSource1;
        private FireStationDataSet1TableAdapters.licencaTableAdapter licencaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlicencaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bombeironumerobombeiroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
    }
}