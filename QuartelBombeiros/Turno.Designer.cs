namespace QuartelBombeiros
{
    partial class Turno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turno));
            this.Titulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dGVTurno = new System.Windows.Forms.DataGridView();
            this.id_turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datainicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datafimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.turnoTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.turnoTableAdapter();
            this.dGVBomb = new System.Windows.Forms.DataGridView();
            this.dGVViat = new System.Windows.Forms.DataGridView();
            this.fKturnobombeiroturno1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turno_bombeiroTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.turno_bombeiroTableAdapter();
            this.fireStationDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fichabombeiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ficha_bombeiroTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.ficha_bombeiroTableAdapter();
            this.fichabombeiroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet1 = new QuartelBombeiros.FireStationDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBomb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVViat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKturnobombeiroturno1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichabombeiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichabombeiroBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.Titulo.Location = new System.Drawing.Point(3, 27);
            this.Titulo.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(150, 47);
            this.Titulo.TabIndex = 1;
            this.Titulo.Text = "TURNO";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 3);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::QuartelBombeiros.Properties.Resources.HOME;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(11, 101);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 31;
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
            this.btnAdd.Location = new System.Drawing.Point(328, 101);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 32;
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
            this.btnEdit.Location = new System.Drawing.Point(384, 101);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 33;
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
            this.btnDelete.Location = new System.Drawing.Point(440, 101);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dGVTurno
            // 
            this.dGVTurno.AllowUserToAddRows = false;
            this.dGVTurno.AllowUserToDeleteRows = false;
            this.dGVTurno.AllowUserToResizeRows = false;
            this.dGVTurno.AutoGenerateColumns = false;
            this.dGVTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVTurno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVTurno.BackgroundColor = System.Drawing.Color.White;
            this.dGVTurno.ColumnHeadersHeight = 30;
            this.dGVTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_turno,
            this.horarioDataGridViewTextBoxColumn,
            this.postoDataGridViewTextBoxColumn,
            this.datainicioDataGridViewTextBoxColumn,
            this.datafimDataGridViewTextBoxColumn});
            this.dGVTurno.DataSource = this.turnoBindingSource;
            this.dGVTurno.GridColor = System.Drawing.Color.Black;
            this.dGVTurno.Location = new System.Drawing.Point(11, 157);
            this.dGVTurno.MultiSelect = false;
            this.dGVTurno.Name = "dGVTurno";
            this.dGVTurno.ReadOnly = true;
            this.dGVTurno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVTurno.Size = new System.Drawing.Size(330, 496);
            this.dGVTurno.TabIndex = 35;
            this.dGVTurno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVTurno_CellContentClick);
            // 
            // id_turno
            // 
            this.id_turno.DataPropertyName = "id_turno";
            this.id_turno.HeaderText = "ID Turno";
            this.id_turno.Name = "id_turno";
            this.id_turno.ReadOnly = true;
            this.id_turno.Visible = false;
            this.id_turno.Width = 74;
            // 
            // horarioDataGridViewTextBoxColumn
            // 
            this.horarioDataGridViewTextBoxColumn.DataPropertyName = "horario";
            this.horarioDataGridViewTextBoxColumn.HeaderText = "Horário";
            this.horarioDataGridViewTextBoxColumn.Name = "horarioDataGridViewTextBoxColumn";
            this.horarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioDataGridViewTextBoxColumn.Width = 66;
            // 
            // postoDataGridViewTextBoxColumn
            // 
            this.postoDataGridViewTextBoxColumn.DataPropertyName = "posto";
            this.postoDataGridViewTextBoxColumn.HeaderText = "Posto";
            this.postoDataGridViewTextBoxColumn.Name = "postoDataGridViewTextBoxColumn";
            this.postoDataGridViewTextBoxColumn.ReadOnly = true;
            this.postoDataGridViewTextBoxColumn.Width = 59;
            // 
            // datainicioDataGridViewTextBoxColumn
            // 
            this.datainicioDataGridViewTextBoxColumn.DataPropertyName = "data_inicio";
            this.datainicioDataGridViewTextBoxColumn.HeaderText = "Data Início";
            this.datainicioDataGridViewTextBoxColumn.Name = "datainicioDataGridViewTextBoxColumn";
            this.datainicioDataGridViewTextBoxColumn.ReadOnly = true;
            this.datainicioDataGridViewTextBoxColumn.Width = 85;
            // 
            // datafimDataGridViewTextBoxColumn
            // 
            this.datafimDataGridViewTextBoxColumn.DataPropertyName = "data_fim";
            this.datafimDataGridViewTextBoxColumn.HeaderText = "Data Fim";
            this.datafimDataGridViewTextBoxColumn.Name = "datafimDataGridViewTextBoxColumn";
            this.datafimDataGridViewTextBoxColumn.ReadOnly = true;
            this.datafimDataGridViewTextBoxColumn.Width = 74;
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "turno";
            this.turnoBindingSource.DataSource = this.fireStationDataSetBindingSource;
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
            // turnoTableAdapter
            // 
            this.turnoTableAdapter.ClearBeforeFill = true;
            // 
            // dGVBomb
            // 
            this.dGVBomb.AllowUserToAddRows = false;
            this.dGVBomb.AllowUserToDeleteRows = false;
            this.dGVBomb.AllowUserToResizeRows = false;
            this.dGVBomb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVBomb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVBomb.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVBomb.BackgroundColor = System.Drawing.Color.White;
            this.dGVBomb.ColumnHeadersHeight = 30;
            this.dGVBomb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVBomb.GridColor = System.Drawing.Color.Black;
            this.dGVBomb.Location = new System.Drawing.Point(347, 157);
            this.dGVBomb.MultiSelect = false;
            this.dGVBomb.Name = "dGVBomb";
            this.dGVBomb.ReadOnly = true;
            this.dGVBomb.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVBomb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVBomb.Size = new System.Drawing.Size(329, 496);
            this.dGVBomb.TabIndex = 36;
            this.dGVBomb.Visible = false;
            // 
            // dGVViat
            // 
            this.dGVViat.AllowUserToAddRows = false;
            this.dGVViat.AllowUserToDeleteRows = false;
            this.dGVViat.AllowUserToResizeRows = false;
            this.dGVViat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVViat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVViat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVViat.BackgroundColor = System.Drawing.Color.White;
            this.dGVViat.ColumnHeadersHeight = 30;
            this.dGVViat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVViat.GridColor = System.Drawing.Color.Black;
            this.dGVViat.Location = new System.Drawing.Point(682, 157);
            this.dGVViat.MultiSelect = false;
            this.dGVViat.Name = "dGVViat";
            this.dGVViat.ReadOnly = true;
            this.dGVViat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dGVViat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVViat.Size = new System.Drawing.Size(329, 496);
            this.dGVViat.TabIndex = 37;
            this.dGVViat.Visible = false;
            // 
            // fKturnobombeiroturno1BindingSource
            // 
            this.fKturnobombeiroturno1BindingSource.DataMember = "FK_turno_bombeiro_turno1";
            this.fKturnobombeiroturno1BindingSource.DataSource = this.turnoBindingSource;
            // 
            // turno_bombeiroTableAdapter
            // 
            this.turno_bombeiroTableAdapter.ClearBeforeFill = true;
            // 
            // fireStationDataSetBindingSource1
            // 
            this.fireStationDataSetBindingSource1.DataSource = this.fireStationDataSet;
            this.fireStationDataSetBindingSource1.Position = 0;
            // 
            // fichabombeiroBindingSource
            // 
            this.fichabombeiroBindingSource.DataMember = "ficha_bombeiro";
            this.fichabombeiroBindingSource.DataSource = this.fireStationDataSetBindingSource1;
            // 
            // ficha_bombeiroTableAdapter
            // 
            this.ficha_bombeiroTableAdapter.ClearBeforeFill = true;
            // 
            // fichabombeiroBindingSource1
            // 
            this.fichabombeiroBindingSource1.DataMember = "ficha_bombeiro";
            this.fichabombeiroBindingSource1.DataSource = this.fireStationDataSet;
            this.fichabombeiroBindingSource1.CurrentChanged += new System.EventHandler(this.fichabombeiroBindingSource1_CurrentChanged);
            // 
            // fireStationDataSet1
            // 
            this.fireStationDataSet1.DataSetName = "FireStationDataSet";
            this.fireStationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Turno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.dGVViat);
            this.Controls.Add(this.dGVBomb);
            this.Controls.Add(this.dGVTurno);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Titulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Turno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Turno";
            this.Load += new System.EventHandler(this.Turno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBomb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVViat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKturnobombeiroturno1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichabombeiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichabombeiroBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dGVTurno;
        private System.Windows.Forms.BindingSource fireStationDataSetBindingSource;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private FireStationDataSetTableAdapters.turnoTableAdapter turnoTableAdapter;
        private System.Windows.Forms.DataGridView dGVBomb;
        private System.Windows.Forms.DataGridView dGVViat;
        private System.Windows.Forms.BindingSource fKturnobombeiroturno1BindingSource;
        private FireStationDataSetTableAdapters.turno_bombeiroTableAdapter turno_bombeiroTableAdapter;
        private System.Windows.Forms.BindingSource fireStationDataSetBindingSource1;
        private System.Windows.Forms.BindingSource fichabombeiroBindingSource;
        private FireStationDataSetTableAdapters.ficha_bombeiroTableAdapter ficha_bombeiroTableAdapter;
        private System.Windows.Forms.BindingSource fichabombeiroBindingSource1;
        private FireStationDataSet fireStationDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datainicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datafimDataGridViewTextBoxColumn;
       
    }
}