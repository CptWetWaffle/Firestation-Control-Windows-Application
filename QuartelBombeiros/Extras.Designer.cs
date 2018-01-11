namespace QuartelBombeiros
{
    partial class Extras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Extras));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lbEtipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lbBomb = new System.Windows.Forms.Label();
            this.lbDesc = new System.Windows.Forms.Label();
            this.cmbBomb = new System.Windows.Forms.ComboBox();
            this.bombeiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbEbomb = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.bombeiroTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.bombeiroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombeiroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).BeginInit();
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
            this.lbTitulo.Size = new System.Drawing.Size(967, 47);
            this.lbTitulo.TabIndex = 6;
            this.lbTitulo.Text = "INSERIR CASTIGOS / RECOMENDAÇÕES / CURSOS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1000, 3);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbEDesc);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lbEtipo);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.lbBomb);
            this.panel1.Controls.Add(this.lbDesc);
            this.panel1.Controls.Add(this.cmbBomb);
            this.panel1.Controls.Add(this.lbTipo);
            this.panel1.Controls.Add(this.lbEbomb);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 488);
            this.panel1.TabIndex = 43;
            // 
            // lbEDesc
            // 
            this.lbEDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEDesc.AutoSize = true;
            this.lbEDesc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEDesc.ForeColor = System.Drawing.Color.Red;
            this.lbEDesc.Location = new System.Drawing.Point(138, 89);
            this.lbEDesc.Name = "lbEDesc";
            this.lbEDesc.Size = new System.Drawing.Size(18, 23);
            this.lbEDesc.TabIndex = 140;
            this.lbEDesc.Text = "*";
            this.lbEDesc.Visible = false;
            // 
            // txtDesc
            // 
            this.txtDesc.AllowDrop = true;
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(17, 115);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(848, 159);
            this.txtDesc.TabIndex = 139;
            // 
            // lbEtipo
            // 
            this.lbEtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEtipo.AutoSize = true;
            this.lbEtipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtipo.ForeColor = System.Drawing.Color.Red;
            this.lbEtipo.Location = new System.Drawing.Point(282, 52);
            this.lbEtipo.Name = "lbEtipo";
            this.lbEtipo.Size = new System.Drawing.Size(18, 23);
            this.lbEtipo.TabIndex = 138;
            this.lbEtipo.Text = "*";
            this.lbEtipo.Visible = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.IntegralHeight = false;
            this.cmbTipo.Items.AddRange(new object[] {
            "Castigo",
            "Recomendação",
            "Curso"});
            this.cmbTipo.Location = new System.Drawing.Point(69, 50);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(207, 30);
            this.cmbTipo.TabIndex = 137;
            // 
            // lbBomb
            // 
            this.lbBomb.AutoSize = true;
            this.lbBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBomb.Location = new System.Drawing.Point(13, 15);
            this.lbBomb.Name = "lbBomb";
            this.lbBomb.Size = new System.Drawing.Size(107, 23);
            this.lbBomb.TabIndex = 136;
            this.lbBomb.Text = "BOMBEIRO";
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(13, 89);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(119, 23);
            this.lbDesc.TabIndex = 135;
            this.lbDesc.Text = "DESCRIÇÃO";
            // 
            // cmbBomb
            // 
            this.cmbBomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBomb.DataSource = this.bombeiroBindingSource;
            this.cmbBomb.DisplayMember = "numero_bombeiro";
            this.cmbBomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBomb.FormattingEnabled = true;
            this.cmbBomb.IntegralHeight = false;
            this.cmbBomb.Location = new System.Drawing.Point(126, 13);
            this.cmbBomb.Name = "cmbBomb";
            this.cmbBomb.Size = new System.Drawing.Size(150, 30);
            this.cmbBomb.TabIndex = 132;
            this.cmbBomb.ValueMember = "numero_bombeiro";
            // 
            // bombeiroBindingSource
            // 
            this.bombeiroBindingSource.DataMember = "bombeiro";
            this.bombeiroBindingSource.DataSource = this.fireStationDataSetBindingSource;
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
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(13, 52);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(50, 23);
            this.lbTipo.TabIndex = 131;
            this.lbTipo.Text = "TIPO";
            this.lbTipo.Click += new System.EventHandler(this.lbTipo_Click);
            // 
            // lbEbomb
            // 
            this.lbEbomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEbomb.AutoSize = true;
            this.lbEbomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEbomb.ForeColor = System.Drawing.Color.Red;
            this.lbEbomb.Location = new System.Drawing.Point(282, 15);
            this.lbEbomb.Name = "lbEbomb";
            this.lbEbomb.Size = new System.Drawing.Size(18, 23);
            this.lbEbomb.TabIndex = 130;
            this.lbEbomb.Text = "*";
            this.lbEbomb.Visible = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 614);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApagar.AutoSize = true;
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.BackgroundImage = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnApagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Location = new System.Drawing.Point(123, 614);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 30);
            this.btnApagar.TabIndex = 52;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.AutoSize = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundImage = global::QuartelBombeiros.Properties.Resources.HOME;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(844, 604);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 53;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbErros
            // 
            this.lbErros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbErros.AutoSize = true;
            this.lbErros.BackColor = System.Drawing.Color.Transparent;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbErros.Location = new System.Drawing.Point(900, 108);
            this.lbErros.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 21);
            this.lbErros.TabIndex = 54;
            // 
            // bombeiroTableAdapter
            // 
            this.bombeiroTableAdapter.ClearBeforeFill = true;
            // 
            // Extras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Extras";
            this.Text = "Extras";
            this.Load += new System.EventHandler(this.Extras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombeiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEbomb;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.ComboBox cmbBomb;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lbBomb;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbEtipo;
        private System.Windows.Forms.TextBox txtDesc;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.Label lbEDesc;
        private System.Windows.Forms.BindingSource fireStationDataSetBindingSource;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource bombeiroBindingSource;
        private FireStationDataSetTableAdapters.bombeiroTableAdapter bombeiroTableAdapter;
    }
}