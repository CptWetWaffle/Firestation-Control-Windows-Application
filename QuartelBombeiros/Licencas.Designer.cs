namespace QuartelBombeiros
{
    partial class Licencas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Licencas));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEtipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbEDataFim = new System.Windows.Forms.Label();
            this.lbEDatInic = new System.Windows.Forms.Label();
            this.cmbDatFimDD = new System.Windows.Forms.ComboBox();
            this.cmbDatFimMM = new System.Windows.Forms.ComboBox();
            this.cmbDatFimYYYY = new System.Windows.Forms.ComboBox();
            this.cmbDatInicDD = new System.Windows.Forms.ComboBox();
            this.cmbDatInicMM = new System.Windows.Forms.ComboBox();
            this.cmbDatInicYYYY = new System.Windows.Forms.ComboBox();
            this.lbDataFim = new System.Windows.Forms.Label();
            this.lbDatIni = new System.Windows.Forms.Label();
            this.cmbBomb = new System.Windows.Forms.ComboBox();
            this.bombeiroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.lbEbomb = new System.Windows.Forms.Label();
            this.lbBomb = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.bombeiroTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.bombeiroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombeiroBindingSource)).BeginInit();
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
            this.lbTitulo.Size = new System.Drawing.Size(364, 47);
            this.lbTitulo.TabIndex = 4;
            this.lbTitulo.Text = "INSERIR LICENÇAS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(850, 3);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbEtipo);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.lbTipo);
            this.panel1.Controls.Add(this.lbEDataFim);
            this.panel1.Controls.Add(this.lbEDatInic);
            this.panel1.Controls.Add(this.cmbDatFimDD);
            this.panel1.Controls.Add(this.cmbDatFimMM);
            this.panel1.Controls.Add(this.cmbDatFimYYYY);
            this.panel1.Controls.Add(this.cmbDatInicDD);
            this.panel1.Controls.Add(this.cmbDatInicMM);
            this.panel1.Controls.Add(this.cmbDatInicYYYY);
            this.panel1.Controls.Add(this.lbDataFim);
            this.panel1.Controls.Add(this.lbDatIni);
            this.panel1.Controls.Add(this.cmbBomb);
            this.panel1.Controls.Add(this.lbEbomb);
            this.panel1.Controls.Add(this.lbBomb);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 488);
            this.panel1.TabIndex = 44;
            // 
            // lbEtipo
            // 
            this.lbEtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEtipo.AutoSize = true;
            this.lbEtipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtipo.ForeColor = System.Drawing.Color.Red;
            this.lbEtipo.Location = new System.Drawing.Point(291, 125);
            this.lbEtipo.Name = "lbEtipo";
            this.lbEtipo.Size = new System.Drawing.Size(18, 23);
            this.lbEtipo.TabIndex = 159;
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
            "Casamento",
            "Maternidade",
            "Paternidade",
            "Nascimento",
            "Adopção",
            "Falecimento de um familiar",
            "Doença",
            "Acidente",
            "Reabilitação Profissional ",
            "Assistência a familiares",
            "Isolamento Profiláctico",
            "Trabalhador-estudante",
            "Bolseiro ou equiparado",
            "Doação de Sangue e Socorrismo",
            "Cumprimento de Obrigações",
            "Prestação de Provas de Concurso",
            "Férias"});
            this.cmbTipo.Location = new System.Drawing.Point(68, 123);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(217, 30);
            this.cmbTipo.TabIndex = 158;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(13, 126);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(50, 23);
            this.lbTipo.TabIndex = 157;
            this.lbTipo.Text = "TIPO";
            // 
            // lbEDataFim
            // 
            this.lbEDataFim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEDataFim.AutoSize = true;
            this.lbEDataFim.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEDataFim.ForeColor = System.Drawing.Color.Red;
            this.lbEDataFim.Location = new System.Drawing.Point(291, 88);
            this.lbEDataFim.Name = "lbEDataFim";
            this.lbEDataFim.Size = new System.Drawing.Size(18, 23);
            this.lbEDataFim.TabIndex = 156;
            this.lbEDataFim.Text = "*";
            this.lbEDataFim.Visible = false;
            // 
            // lbEDatInic
            // 
            this.lbEDatInic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEDatInic.AutoSize = true;
            this.lbEDatInic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEDatInic.ForeColor = System.Drawing.Color.Red;
            this.lbEDatInic.Location = new System.Drawing.Point(320, 51);
            this.lbEDatInic.Name = "lbEDatInic";
            this.lbEDatInic.Size = new System.Drawing.Size(18, 23);
            this.lbEDatInic.TabIndex = 155;
            this.lbEDatInic.Text = "*";
            this.lbEDatInic.Visible = false;
            // 
            // cmbDatFimDD
            // 
            this.cmbDatFimDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatFimDD.Enabled = false;
            this.cmbDatFimDD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatFimDD.FormattingEnabled = true;
            this.cmbDatFimDD.IntegralHeight = false;
            this.cmbDatFimDD.Location = new System.Drawing.Point(114, 87);
            this.cmbDatFimDD.Name = "cmbDatFimDD";
            this.cmbDatFimDD.Size = new System.Drawing.Size(43, 30);
            this.cmbDatFimDD.TabIndex = 154;
            // 
            // cmbDatFimMM
            // 
            this.cmbDatFimMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatFimMM.Enabled = false;
            this.cmbDatFimMM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatFimMM.FormattingEnabled = true;
            this.cmbDatFimMM.IntegralHeight = false;
            this.cmbDatFimMM.Location = new System.Drawing.Point(163, 87);
            this.cmbDatFimMM.Name = "cmbDatFimMM";
            this.cmbDatFimMM.Size = new System.Drawing.Size(43, 30);
            this.cmbDatFimMM.TabIndex = 153;
            this.cmbDatFimMM.SelectedIndexChanged += new System.EventHandler(this.cmbDatFimMM_SelectedIndexChanged);
            // 
            // cmbDatFimYYYY
            // 
            this.cmbDatFimYYYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatFimYYYY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatFimYYYY.FormattingEnabled = true;
            this.cmbDatFimYYYY.IntegralHeight = false;
            this.cmbDatFimYYYY.Location = new System.Drawing.Point(212, 87);
            this.cmbDatFimYYYY.Name = "cmbDatFimYYYY";
            this.cmbDatFimYYYY.Size = new System.Drawing.Size(74, 30);
            this.cmbDatFimYYYY.TabIndex = 152;
            this.cmbDatFimYYYY.SelectedIndexChanged += new System.EventHandler(this.cmbDatFimYYYY_SelectedIndexChanged);
            // 
            // cmbDatInicDD
            // 
            this.cmbDatInicDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatInicDD.Enabled = false;
            this.cmbDatInicDD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatInicDD.FormattingEnabled = true;
            this.cmbDatInicDD.IntegralHeight = false;
            this.cmbDatInicDD.Location = new System.Drawing.Point(143, 50);
            this.cmbDatInicDD.Name = "cmbDatInicDD";
            this.cmbDatInicDD.Size = new System.Drawing.Size(43, 30);
            this.cmbDatInicDD.TabIndex = 151;
            // 
            // cmbDatInicMM
            // 
            this.cmbDatInicMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatInicMM.Enabled = false;
            this.cmbDatInicMM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatInicMM.FormattingEnabled = true;
            this.cmbDatInicMM.IntegralHeight = false;
            this.cmbDatInicMM.Location = new System.Drawing.Point(192, 50);
            this.cmbDatInicMM.Name = "cmbDatInicMM";
            this.cmbDatInicMM.Size = new System.Drawing.Size(43, 30);
            this.cmbDatInicMM.TabIndex = 150;
            this.cmbDatInicMM.SelectedIndexChanged += new System.EventHandler(this.cmbDatInicMM_SelectedIndexChanged);
            // 
            // cmbDatInicYYYY
            // 
            this.cmbDatInicYYYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatInicYYYY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatInicYYYY.FormattingEnabled = true;
            this.cmbDatInicYYYY.IntegralHeight = false;
            this.cmbDatInicYYYY.Location = new System.Drawing.Point(241, 50);
            this.cmbDatInicYYYY.Name = "cmbDatInicYYYY";
            this.cmbDatInicYYYY.Size = new System.Drawing.Size(74, 30);
            this.cmbDatInicYYYY.TabIndex = 149;
            this.cmbDatInicYYYY.SelectedIndexChanged += new System.EventHandler(this.cmbDatInicYYYY_SelectedIndexChanged);
            // 
            // lbDataFim
            // 
            this.lbDataFim.AutoSize = true;
            this.lbDataFim.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataFim.Location = new System.Drawing.Point(13, 89);
            this.lbDataFim.Name = "lbDataFim";
            this.lbDataFim.Size = new System.Drawing.Size(95, 23);
            this.lbDataFim.TabIndex = 148;
            this.lbDataFim.Text = "DATA FIM";
            // 
            // lbDatIni
            // 
            this.lbDatIni.AutoSize = true;
            this.lbDatIni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatIni.Location = new System.Drawing.Point(13, 52);
            this.lbDatIni.Name = "lbDatIni";
            this.lbDatIni.Size = new System.Drawing.Size(124, 23);
            this.lbDatIni.TabIndex = 147;
            this.lbDatIni.Text = "DATA INÍCIO";
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
            this.cmbBomb.Location = new System.Drawing.Point(125, 12);
            this.cmbBomb.Name = "cmbBomb";
            this.cmbBomb.Size = new System.Drawing.Size(160, 30);
            this.cmbBomb.TabIndex = 146;
            this.cmbBomb.ValueMember = "numero_bombeiro";
            // 
            // bombeiroBindingSource
            // 
            this.bombeiroBindingSource.DataMember = "bombeiro";
            this.bombeiroBindingSource.DataSource = this.fireStationDataSet;
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
            this.lbEbomb.Location = new System.Drawing.Point(291, 14);
            this.lbEbomb.Name = "lbEbomb";
            this.lbEbomb.Size = new System.Drawing.Size(18, 23);
            this.lbEbomb.TabIndex = 143;
            this.lbEbomb.Text = "*";
            this.lbEbomb.Visible = false;
            // 
            // lbBomb
            // 
            this.lbBomb.AutoSize = true;
            this.lbBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBomb.Location = new System.Drawing.Point(13, 15);
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 622);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 52;
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
            this.btnApagar.Location = new System.Drawing.Point(123, 622);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 30);
            this.btnApagar.TabIndex = 53;
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
            this.btnHome.Location = new System.Drawing.Point(844, 612);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 54;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(900, 108);
            this.lbErros.MaximumSize = new System.Drawing.Size(350, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 24);
            this.lbErros.TabIndex = 55;
            this.lbErros.UseCompatibleTextRendering = true;
            // 
            // bombeiroTableAdapter
            // 
            this.bombeiroTableAdapter.ClearBeforeFill = true;
            // 
            // Licencas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
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
            this.Name = "Licencas";
            this.Text = "Licenças";
            this.Load += new System.EventHandler(this.Licencas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bombeiroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEbomb;
        private System.Windows.Forms.Label lbBomb;
        private System.Windows.Forms.ComboBox cmbBomb;
        private System.Windows.Forms.Label lbEDataFim;
        private System.Windows.Forms.Label lbEDatInic;
        private System.Windows.Forms.ComboBox cmbDatFimDD;
        private System.Windows.Forms.ComboBox cmbDatFimMM;
        private System.Windows.Forms.ComboBox cmbDatFimYYYY;
        private System.Windows.Forms.ComboBox cmbDatInicDD;
        private System.Windows.Forms.ComboBox cmbDatInicMM;
        private System.Windows.Forms.ComboBox cmbDatInicYYYY;
        private System.Windows.Forms.Label lbDataFim;
        private System.Windows.Forms.Label lbDatIni;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbEtipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbErros;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource bombeiroBindingSource;
        private FireStationDataSetTableAdapters.bombeiroTableAdapter bombeiroTableAdapter;
    }
}