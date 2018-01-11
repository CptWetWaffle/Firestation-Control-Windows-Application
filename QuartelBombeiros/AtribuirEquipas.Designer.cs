namespace QuartelBombeiros
{
    partial class AtribuirEquipas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtribuirEquipas));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEViat = new System.Windows.Forms.Label();
            this.cmbViat = new System.Windows.Forms.ComboBox();
            this.viaturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.lbEbomb = new System.Windows.Forms.Label();
            this.cblBombeiros = new System.Windows.Forms.CheckedListBox();
            this.lbViat = new System.Windows.Forms.Label();
            this.lbBomb = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.viaturaTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.viaturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viaturaBindingSource)).BeginInit();
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
            this.lbTitulo.Size = new System.Drawing.Size(492, 47);
            this.lbTitulo.TabIndex = 3;
            this.lbTitulo.Text = "ATRIBUIÇÃO DE EQUIPAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(550, 3);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbEViat);
            this.panel1.Controls.Add(this.cmbViat);
            this.panel1.Controls.Add(this.lbEbomb);
            this.panel1.Controls.Add(this.cblBombeiros);
            this.panel1.Controls.Add(this.lbViat);
            this.panel1.Controls.Add(this.lbBomb);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 488);
            this.panel1.TabIndex = 43;
            // 
            // lbEViat
            // 
            this.lbEViat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEViat.AutoSize = true;
            this.lbEViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEViat.ForeColor = System.Drawing.Color.Red;
            this.lbEViat.Location = new System.Drawing.Point(263, 15);
            this.lbEViat.Name = "lbEViat";
            this.lbEViat.Size = new System.Drawing.Size(18, 23);
            this.lbEViat.TabIndex = 145;
            this.lbEViat.Text = "*";
            this.lbEViat.Visible = false;
            // 
            // cmbViat
            // 
            this.cmbViat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbViat.DataSource = this.viaturaBindingSource;
            this.cmbViat.DisplayMember = "codigo";
            this.cmbViat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViat.FormattingEnabled = true;
            this.cmbViat.IntegralHeight = false;
            this.cmbViat.Location = new System.Drawing.Point(107, 13);
            this.cmbViat.Name = "cmbViat";
            this.cmbViat.Size = new System.Drawing.Size(150, 30);
            this.cmbViat.TabIndex = 144;
            this.cmbViat.ValueMember = "codigo";
            // 
            // viaturaBindingSource
            // 
            this.viaturaBindingSource.DataMember = "viatura";
            this.viaturaBindingSource.DataSource = this.fireStationDataSet;
            // 
            // fireStationDataSet
            // 
            this.fireStationDataSet.DataSetName = "FireStationDataSet";
            this.fireStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbEbomb
            // 
            this.lbEbomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEbomb.AutoSize = true;
            this.lbEbomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEbomb.ForeColor = System.Drawing.Color.Red;
            this.lbEbomb.Location = new System.Drawing.Point(199, 78);
            this.lbEbomb.Name = "lbEbomb";
            this.lbEbomb.Size = new System.Drawing.Size(18, 23);
            this.lbEbomb.TabIndex = 143;
            this.lbEbomb.Text = "*";
            this.lbEbomb.Visible = false;
            // 
            // cblBombeiros
            // 
            this.cblBombeiros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblBombeiros.FormattingEnabled = true;
            this.cblBombeiros.IntegralHeight = false;
            this.cblBombeiros.Location = new System.Drawing.Point(17, 78);
            this.cblBombeiros.Name = "cblBombeiros";
            this.cblBombeiros.Size = new System.Drawing.Size(176, 96);
            this.cblBombeiros.Sorted = true;
            this.cblBombeiros.TabIndex = 141;
            this.cblBombeiros.SelectedIndexChanged += new System.EventHandler(this.cblBombeiros_SelectedIndexChanged);
            // 
            // lbViat
            // 
            this.lbViat.AutoSize = true;
            this.lbViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViat.Location = new System.Drawing.Point(13, 15);
            this.lbViat.Name = "lbViat";
            this.lbViat.Size = new System.Drawing.Size(88, 23);
            this.lbViat.TabIndex = 140;
            this.lbViat.Text = "VIATURA";
            // 
            // lbBomb
            // 
            this.lbBomb.AutoSize = true;
            this.lbBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBomb.Location = new System.Drawing.Point(13, 52);
            this.lbBomb.Name = "lbBomb";
            this.lbBomb.Size = new System.Drawing.Size(107, 23);
            this.lbBomb.TabIndex = 139;
            this.lbBomb.Text = "BOMBEIRO";
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 612);
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
            this.btnApagar.Location = new System.Drawing.Point(123, 612);
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
            this.btnHome.Location = new System.Drawing.Point(844, 602);
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
            this.lbErros.TabIndex = 56;
            // 
            // viaturaTableAdapter
            // 
            this.viaturaTableAdapter.ClearBeforeFill = true;
            // 
            // AtribuirEquipas
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
            this.Name = "AtribuirEquipas";
            this.Text = "Atribuir Equipas";
            this.Load += new System.EventHandler(this.AtribuirEquipas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viaturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEbomb;
        private System.Windows.Forms.CheckedListBox cblBombeiros;
        private System.Windows.Forms.Label lbViat;
        private System.Windows.Forms.Label lbBomb;
        private System.Windows.Forms.Label lbEViat;
        private System.Windows.Forms.ComboBox cmbViat;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbErros;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource viaturaBindingSource;
        private FireStationDataSetTableAdapters.viaturaTableAdapter viaturaTableAdapter;
    }
}