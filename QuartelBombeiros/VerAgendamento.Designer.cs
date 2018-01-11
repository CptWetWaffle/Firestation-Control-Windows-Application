namespace QuartelBombeiros
{
    partial class VerAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerAgendamento));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dGVAgend = new System.Windows.Forms.DataGridView();
            this.idagendamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.agendamentoTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.agendamentoTableAdapter();
            this.dGVEquip = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAgend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEquip)).BeginInit();
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
            this.lbTitulo.Size = new System.Drawing.Size(331, 47);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "AGENDAMENTO";
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btnAdd.TabIndex = 25;
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
            this.btnEdit.TabIndex = 26;
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
            this.btnDelete.TabIndex = 27;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dGVAgend
            // 
            this.dGVAgend.AllowUserToAddRows = false;
            this.dGVAgend.AllowUserToDeleteRows = false;
            this.dGVAgend.AllowUserToResizeRows = false;
            this.dGVAgend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVAgend.AutoGenerateColumns = false;
            this.dGVAgend.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVAgend.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVAgend.BackgroundColor = System.Drawing.Color.White;
            this.dGVAgend.ColumnHeadersHeight = 30;
            this.dGVAgend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVAgend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idagendamentoDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dGVAgend.DataSource = this.agendamentoBindingSource;
            this.dGVAgend.GridColor = System.Drawing.Color.Black;
            this.dGVAgend.Location = new System.Drawing.Point(12, 173);
            this.dGVAgend.MultiSelect = false;
            this.dGVAgend.Name = "dGVAgend";
            this.dGVAgend.ReadOnly = true;
            this.dGVAgend.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVAgend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVAgend.Size = new System.Drawing.Size(473, 497);
            this.dGVAgend.TabIndex = 28;
            this.dGVAgend.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAgend_CellContentClick);
            // 
            // idagendamentoDataGridViewTextBoxColumn
            // 
            this.idagendamentoDataGridViewTextBoxColumn.DataPropertyName = "id_agendamento";
            this.idagendamentoDataGridViewTextBoxColumn.HeaderText = "id_agendamento";
            this.idagendamentoDataGridViewTextBoxColumn.Name = "idagendamentoDataGridViewTextBoxColumn";
            this.idagendamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idagendamentoDataGridViewTextBoxColumn.Visible = false;
            this.idagendamentoDataGridViewTextBoxColumn.Width = 111;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horaDataGridViewTextBoxColumn.Width = 55;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataDataGridViewTextBoxColumn.Width = 55;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 80;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "agendamento";
            this.agendamentoBindingSource.DataSource = this.fireStationDataSet;
            // 
            // fireStationDataSet
            // 
            this.fireStationDataSet.DataSetName = "FireStationDataSet";
            this.fireStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // dGVEquip
            // 
            this.dGVEquip.AllowUserToAddRows = false;
            this.dGVEquip.AllowUserToDeleteRows = false;
            this.dGVEquip.AllowUserToResizeRows = false;
            this.dGVEquip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVEquip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVEquip.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVEquip.BackgroundColor = System.Drawing.Color.White;
            this.dGVEquip.ColumnHeadersHeight = 30;
            this.dGVEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVEquip.GridColor = System.Drawing.Color.Black;
            this.dGVEquip.Location = new System.Drawing.Point(491, 173);
            this.dGVEquip.MultiSelect = false;
            this.dGVEquip.Name = "dGVEquip";
            this.dGVEquip.ReadOnly = true;
            this.dGVEquip.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVEquip.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVEquip.Size = new System.Drawing.Size(473, 497);
            this.dGVEquip.TabIndex = 29;
            this.dGVEquip.Visible = false;
            // 
            // VerAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.dGVEquip);
            this.Controls.Add(this.dGVAgend);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VerAgendamento";
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.VerAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAgend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVEquip)).EndInit();
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
        private System.Windows.Forms.DataGridView dGVAgend;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private FireStationDataSetTableAdapters.agendamentoTableAdapter agendamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagendamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dGVEquip;
    }
}