namespace QuartelBombeiros
{
    partial class MarcarFaltas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarcarFaltas));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pnlBomb = new System.Windows.Forms.Panel();
            this.lbDFimT = new System.Windows.Forms.Label();
            this.txtDFimT = new System.Windows.Forms.TextBox();
            this.lbdIniT = new System.Windows.Forms.Label();
            this.txtDatIniT = new System.Windows.Forms.TextBox();
            this.lbEBomb = new System.Windows.Forms.Label();
            this.lblBombeiros = new System.Windows.Forms.Label();
            this.cblBombeiro = new System.Windows.Forms.CheckedListBox();
            this.lbETurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.lbTurno = new System.Windows.Forms.Label();
            this.lbEData = new System.Windows.Forms.Label();
            this.cmbDataDD = new System.Windows.Forms.ComboBox();
            this.cmbDataMM = new System.Windows.Forms.ComboBox();
            this.cmbDataYYYY = new System.Windows.Forms.ComboBox();
            this.v = new System.Windows.Forms.Label();
            this.fireStationDataSet2 = new QuartelBombeiros.FireStationDataSet2();
            this.fireStationDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turnoTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.turnoTableAdapter();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlBomb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet2BindingSource)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 3);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitulo.Location = new System.Drawing.Point(12, 18);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(339, 47);
            this.lbTitulo.TabIndex = 30;
            this.lbTitulo.Text = "MARCAR FALTAS";
            // 
            // pnlBomb
            // 
            this.pnlBomb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBomb.AutoScroll = true;
            this.pnlBomb.BackColor = System.Drawing.Color.Transparent;
            this.pnlBomb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBomb.Controls.Add(this.lbDFimT);
            this.pnlBomb.Controls.Add(this.txtDFimT);
            this.pnlBomb.Controls.Add(this.lbdIniT);
            this.pnlBomb.Controls.Add(this.txtDatIniT);
            this.pnlBomb.Controls.Add(this.lbEBomb);
            this.pnlBomb.Controls.Add(this.lblBombeiros);
            this.pnlBomb.Controls.Add(this.cblBombeiro);
            this.pnlBomb.Controls.Add(this.lbETurno);
            this.pnlBomb.Controls.Add(this.cmbTurno);
            this.pnlBomb.Controls.Add(this.lbTurno);
            this.pnlBomb.Controls.Add(this.lbEData);
            this.pnlBomb.Controls.Add(this.cmbDataDD);
            this.pnlBomb.Controls.Add(this.cmbDataMM);
            this.pnlBomb.Controls.Add(this.cmbDataYYYY);
            this.pnlBomb.Controls.Add(this.v);
            this.pnlBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBomb.Location = new System.Drawing.Point(12, 86);
            this.pnlBomb.Name = "pnlBomb";
            this.pnlBomb.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBomb.Size = new System.Drawing.Size(1029, 523);
            this.pnlBomb.TabIndex = 32;
            // 
            // lbDFimT
            // 
            this.lbDFimT.AutoSize = true;
            this.lbDFimT.Location = new System.Drawing.Point(635, 57);
            this.lbDFimT.Name = "lbDFimT";
            this.lbDFimT.Size = new System.Drawing.Size(162, 23);
            this.lbDFimT.TabIndex = 143;
            this.lbDFimT.Text = "DATA FIM TURNO";
            this.lbDFimT.Visible = false;
            // 
            // txtDFimT
            // 
            this.txtDFimT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDFimT.Enabled = false;
            this.txtDFimT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDFimT.Location = new System.Drawing.Point(803, 55);
            this.txtDFimT.MaxLength = 130;
            this.txtDFimT.Name = "txtDFimT";
            this.txtDFimT.Size = new System.Drawing.Size(165, 31);
            this.txtDFimT.TabIndex = 142;
            this.txtDFimT.Visible = false;
            // 
            // lbdIniT
            // 
            this.lbdIniT.AutoSize = true;
            this.lbdIniT.Location = new System.Drawing.Point(298, 57);
            this.lbdIniT.Name = "lbdIniT";
            this.lbdIniT.Size = new System.Drawing.Size(160, 23);
            this.lbdIniT.TabIndex = 141;
            this.lbdIniT.Text = "DATA INI. TURNO";
            this.lbdIniT.Visible = false;
            // 
            // txtDatIniT
            // 
            this.txtDatIniT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDatIniT.Enabled = false;
            this.txtDatIniT.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatIniT.Location = new System.Drawing.Point(464, 55);
            this.txtDatIniT.MaxLength = 130;
            this.txtDatIniT.Name = "txtDatIniT";
            this.txtDatIniT.Size = new System.Drawing.Size(165, 31);
            this.txtDatIniT.TabIndex = 140;
            this.txtDatIniT.Visible = false;
            // 
            // lbEBomb
            // 
            this.lbEBomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEBomb.AutoSize = true;
            this.lbEBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEBomb.ForeColor = System.Drawing.Color.Red;
            this.lbEBomb.Location = new System.Drawing.Point(136, 104);
            this.lbEBomb.Name = "lbEBomb";
            this.lbEBomb.Size = new System.Drawing.Size(18, 23);
            this.lbEBomb.TabIndex = 139;
            this.lbEBomb.Text = "*";
            this.lbEBomb.Visible = false;
            // 
            // lblBombeiros
            // 
            this.lblBombeiros.AutoSize = true;
            this.lblBombeiros.Location = new System.Drawing.Point(13, 104);
            this.lblBombeiros.Name = "lblBombeiros";
            this.lblBombeiros.Size = new System.Drawing.Size(117, 23);
            this.lblBombeiros.TabIndex = 138;
            this.lblBombeiros.Text = "BOMBEIROS";
            // 
            // cblBombeiro
            // 
            this.cblBombeiro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblBombeiro.FormattingEnabled = true;
            this.cblBombeiro.Location = new System.Drawing.Point(7, 130);
            this.cblBombeiro.Name = "cblBombeiro";
            this.cblBombeiro.Size = new System.Drawing.Size(233, 316);
            this.cblBombeiro.TabIndex = 137;
            // 
            // lbETurno
            // 
            this.lbETurno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbETurno.AutoSize = true;
            this.lbETurno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbETurno.ForeColor = System.Drawing.Color.Red;
            this.lbETurno.Location = new System.Drawing.Point(261, 57);
            this.lbETurno.Name = "lbETurno";
            this.lbETurno.Size = new System.Drawing.Size(18, 23);
            this.lbETurno.TabIndex = 136;
            this.lbETurno.Text = "*";
            this.lbETurno.Visible = false;
            // 
            // cmbTurno
            // 
            this.cmbTurno.DataSource = this.turnoBindingSource;
            this.cmbTurno.DisplayMember = "horario";
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.IntegralHeight = false;
            this.cmbTurno.Location = new System.Drawing.Point(91, 55);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(159, 30);
            this.cmbTurno.TabIndex = 135;
            this.cmbTurno.ValueMember = "id_turno";
            this.cmbTurno.SelectedIndexChanged += new System.EventHandler(this.cmbTurno_SelectedIndexChanged);
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
            // lbTurno
            // 
            this.lbTurno.AutoSize = true;
            this.lbTurno.Location = new System.Drawing.Point(13, 57);
            this.lbTurno.Name = "lbTurno";
            this.lbTurno.Size = new System.Drawing.Size(72, 23);
            this.lbTurno.TabIndex = 134;
            this.lbTurno.Text = "TURNO";
            // 
            // lbEData
            // 
            this.lbEData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEData.AutoSize = true;
            this.lbEData.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEData.ForeColor = System.Drawing.Color.Red;
            this.lbEData.Location = new System.Drawing.Point(261, 15);
            this.lbEData.Name = "lbEData";
            this.lbEData.Size = new System.Drawing.Size(18, 23);
            this.lbEData.TabIndex = 133;
            this.lbEData.Text = "*";
            this.lbEData.Visible = false;
            // 
            // cmbDataDD
            // 
            this.cmbDataDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataDD.Enabled = false;
            this.cmbDataDD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDataDD.FormattingEnabled = true;
            this.cmbDataDD.IntegralHeight = false;
            this.cmbDataDD.Location = new System.Drawing.Point(78, 13);
            this.cmbDataDD.Name = "cmbDataDD";
            this.cmbDataDD.Size = new System.Drawing.Size(43, 30);
            this.cmbDataDD.TabIndex = 132;
            // 
            // cmbDataMM
            // 
            this.cmbDataMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataMM.Enabled = false;
            this.cmbDataMM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDataMM.FormattingEnabled = true;
            this.cmbDataMM.IntegralHeight = false;
            this.cmbDataMM.Location = new System.Drawing.Point(127, 13);
            this.cmbDataMM.Name = "cmbDataMM";
            this.cmbDataMM.Size = new System.Drawing.Size(43, 30);
            this.cmbDataMM.TabIndex = 131;
            this.cmbDataMM.SelectedIndexChanged += new System.EventHandler(this.cmbDataMM_SelectedIndexChanged);
            // 
            // cmbDataYYYY
            // 
            this.cmbDataYYYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataYYYY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDataYYYY.FormattingEnabled = true;
            this.cmbDataYYYY.IntegralHeight = false;
            this.cmbDataYYYY.Location = new System.Drawing.Point(176, 13);
            this.cmbDataYYYY.Name = "cmbDataYYYY";
            this.cmbDataYYYY.Size = new System.Drawing.Size(74, 30);
            this.cmbDataYYYY.TabIndex = 130;
            this.cmbDataYYYY.SelectedIndexChanged += new System.EventHandler(this.cmbDataYYYY_SelectedIndexChanged);
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(13, 15);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(59, 23);
            this.v.TabIndex = 0;
            this.v.Text = "DATA";
            // 
            // fireStationDataSet2
            // 
            this.fireStationDataSet2.DataSetName = "FireStationDataSet2";
            this.fireStationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fireStationDataSet2BindingSource
            // 
            this.fireStationDataSet2BindingSource.DataSource = this.fireStationDataSet2;
            this.fireStationDataSet2BindingSource.Position = 0;
            // 
            // turnoTableAdapter
            // 
            this.turnoTableAdapter.ClearBeforeFill = true;
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
            this.btnApagar.Location = new System.Drawing.Point(123, 615);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 30);
            this.btnApagar.TabIndex = 140;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 615);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 139;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.BackColor = System.Drawing.Color.Transparent;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(1047, 86);
            this.lbErros.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 21);
            this.lbErros.TabIndex = 141;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1264, 25);
            this.fillBy1ToolStrip.TabIndex = 142;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
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
            this.btnHome.Location = new System.Drawing.Point(991, 615);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 143;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // MarcarFaltas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.pnlBomb);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MarcarFaltas";
            this.Text = "MarcarFaltas";
            this.Load += new System.EventHandler(this.MarcarFaltas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlBomb.ResumeLayout(false);
            this.pnlBomb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet2BindingSource)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel pnlBomb;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label lbEData;
        private System.Windows.Forms.ComboBox cmbDataDD;
        private System.Windows.Forms.ComboBox cmbDataMM;
        private System.Windows.Forms.ComboBox cmbDataYYYY;
        private System.Windows.Forms.Label lbETurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lbTurno;
        private System.Windows.Forms.Label lblBombeiros;
        private System.Windows.Forms.CheckedListBox cblBombeiro;
        private System.Windows.Forms.BindingSource fireStationDataSetBindingSource;
        private FireStationDataSet fireStationDataSet;
        private FireStationDataSet2 fireStationDataSet2;
        private System.Windows.Forms.BindingSource fireStationDataSet2BindingSource;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private FireStationDataSetTableAdapters.turnoTableAdapter turnoTableAdapter;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lbEBomb;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.TextBox txtDatIniT;
        private System.Windows.Forms.Label lbdIniT;
        private System.Windows.Forms.Label lbDFimT;
        private System.Windows.Forms.TextBox txtDFimT;
        public System.Windows.Forms.Button btnHome;
    }
}