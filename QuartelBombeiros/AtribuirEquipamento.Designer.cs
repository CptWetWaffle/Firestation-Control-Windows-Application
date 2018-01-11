namespace QuartelBombeiros
{
    partial class AtribuirEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtribuirEquipamento));
            this.lbInsEquip = new System.Windows.Forms.Label();
            this.lbAtrNovoEquip = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEQuant = new System.Windows.Forms.Label();
            this.lbEBombViat = new System.Windows.Forms.Label();
            this.lbEBV = new System.Windows.Forms.Label();
            this.lbEEquip = new System.Windows.Forms.Label();
            this.lbQuantTotal = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.lbQuant = new System.Windows.Forms.Label();
            this.lbBombViat = new System.Windows.Forms.Label();
            this.lbEquip = new System.Windows.Forms.Label();
            this.cmbBombViat = new System.Windows.Forms.ComboBox();
            this.cmbEquip = new System.Windows.Forms.ComboBox();
            this.equipamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipDS = new QuartelBombeiros.EquipDS();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbViat = new System.Windows.Forms.RadioButton();
            this.rbBomb = new System.Windows.Forms.RadioButton();
            this.lbErros = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.equipamentoTableAdapter = new QuartelBombeiros.EquipDSTableAdapters.equipamentoTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.paramToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paramToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDS)).BeginInit();
            this.panel2.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInsEquip
            // 
            this.lbInsEquip.AutoSize = true;
            this.lbInsEquip.BackColor = System.Drawing.Color.Transparent;
            this.lbInsEquip.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbInsEquip.Location = new System.Drawing.Point(63, 122);
            this.lbInsEquip.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbInsEquip.Name = "lbInsEquip";
            this.lbInsEquip.Size = new System.Drawing.Size(0, 47);
            this.lbInsEquip.TabIndex = 3;
            // 
            // lbAtrNovoEquip
            // 
            this.lbAtrNovoEquip.AutoSize = true;
            this.lbAtrNovoEquip.BackColor = System.Drawing.Color.Transparent;
            this.lbAtrNovoEquip.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbAtrNovoEquip.Location = new System.Drawing.Point(3, 23);
            this.lbAtrNovoEquip.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbAtrNovoEquip.Name = "lbAtrNovoEquip";
            this.lbAtrNovoEquip.Size = new System.Drawing.Size(477, 47);
            this.lbAtrNovoEquip.TabIndex = 4;
            this.lbAtrNovoEquip.Text = "ATRIBUIR EQUIPAMENTO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 3);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbEQuant);
            this.panel1.Controls.Add(this.lbEBombViat);
            this.panel1.Controls.Add(this.lbEBV);
            this.panel1.Controls.Add(this.lbEEquip);
            this.panel1.Controls.Add(this.lbQuantTotal);
            this.panel1.Controls.Add(this.txtQuant);
            this.panel1.Controls.Add(this.lbQuant);
            this.panel1.Controls.Add(this.lbBombViat);
            this.panel1.Controls.Add(this.lbEquip);
            this.panel1.Controls.Add(this.cmbBombViat);
            this.panel1.Controls.Add(this.cmbEquip);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(11, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 488);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbEQuant
            // 
            this.lbEQuant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEQuant.AutoSize = true;
            this.lbEQuant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEQuant.ForeColor = System.Drawing.Color.Red;
            this.lbEQuant.Location = new System.Drawing.Point(316, 126);
            this.lbEQuant.Name = "lbEQuant";
            this.lbEQuant.Size = new System.Drawing.Size(18, 23);
            this.lbEQuant.TabIndex = 143;
            this.lbEQuant.Text = "*";
            this.lbEQuant.Visible = false;
            // 
            // lbEBombViat
            // 
            this.lbEBombViat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEBombViat.AutoSize = true;
            this.lbEBombViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEBombViat.ForeColor = System.Drawing.Color.Red;
            this.lbEBombViat.Location = new System.Drawing.Point(316, 15);
            this.lbEBombViat.Name = "lbEBombViat";
            this.lbEBombViat.Size = new System.Drawing.Size(18, 23);
            this.lbEBombViat.TabIndex = 142;
            this.lbEBombViat.Text = "*";
            this.lbEBombViat.Visible = false;
            // 
            // lbEBV
            // 
            this.lbEBV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEBV.AutoSize = true;
            this.lbEBV.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEBV.ForeColor = System.Drawing.Color.Red;
            this.lbEBV.Location = new System.Drawing.Point(316, 88);
            this.lbEBV.Name = "lbEBV";
            this.lbEBV.Size = new System.Drawing.Size(18, 23);
            this.lbEBV.TabIndex = 141;
            this.lbEBV.Text = "*";
            this.lbEBV.Visible = false;
            // 
            // lbEEquip
            // 
            this.lbEEquip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEEquip.AutoSize = true;
            this.lbEEquip.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEEquip.ForeColor = System.Drawing.Color.Red;
            this.lbEEquip.Location = new System.Drawing.Point(316, 52);
            this.lbEEquip.Name = "lbEEquip";
            this.lbEEquip.Size = new System.Drawing.Size(18, 23);
            this.lbEEquip.TabIndex = 140;
            this.lbEEquip.Text = "*";
            this.lbEEquip.Visible = false;
            // 
            // lbQuantTotal
            // 
            this.lbQuantTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbQuantTotal.AutoSize = true;
            this.lbQuantTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantTotal.Location = new System.Drawing.Point(218, 126);
            this.lbQuantTotal.Name = "lbQuantTotal";
            this.lbQuantTotal.Size = new System.Drawing.Size(0, 23);
            this.lbQuantTotal.TabIndex = 139;
            this.lbQuantTotal.Visible = false;
            // 
            // txtQuant
            // 
            this.txtQuant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuant.Enabled = false;
            this.txtQuant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(149, 124);
            this.txtQuant.MaxLength = 130;
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(63, 31);
            this.txtQuant.TabIndex = 138;
            // 
            // lbQuant
            // 
            this.lbQuant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbQuant.AutoSize = true;
            this.lbQuant.BackColor = System.Drawing.Color.Transparent;
            this.lbQuant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuant.Location = new System.Drawing.Point(13, 126);
            this.lbQuant.Name = "lbQuant";
            this.lbQuant.Size = new System.Drawing.Size(130, 23);
            this.lbQuant.TabIndex = 137;
            this.lbQuant.Text = "QUANTIDADE";
            // 
            // lbBombViat
            // 
            this.lbBombViat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBombViat.AutoSize = true;
            this.lbBombViat.BackColor = System.Drawing.Color.Transparent;
            this.lbBombViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBombViat.Location = new System.Drawing.Point(13, 89);
            this.lbBombViat.Name = "lbBombViat";
            this.lbBombViat.Size = new System.Drawing.Size(0, 23);
            this.lbBombViat.TabIndex = 136;
            this.lbBombViat.Visible = false;
            // 
            // lbEquip
            // 
            this.lbEquip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEquip.AutoSize = true;
            this.lbEquip.BackColor = System.Drawing.Color.Transparent;
            this.lbEquip.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEquip.Location = new System.Drawing.Point(13, 52);
            this.lbEquip.Name = "lbEquip";
            this.lbEquip.Size = new System.Drawing.Size(144, 23);
            this.lbEquip.TabIndex = 135;
            this.lbEquip.Text = "EQUIPAMENTO";
            // 
            // cmbBombViat
            // 
            this.cmbBombViat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBombViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBombViat.FormattingEnabled = true;
            this.cmbBombViat.IntegralHeight = false;
            this.cmbBombViat.Items.AddRange(new object[] {
            ""});
            this.cmbBombViat.Location = new System.Drawing.Point(163, 86);
            this.cmbBombViat.Name = "cmbBombViat";
            this.cmbBombViat.Size = new System.Drawing.Size(147, 30);
            this.cmbBombViat.TabIndex = 134;
            this.cmbBombViat.Visible = false;
            this.cmbBombViat.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbEquip
            // 
            this.cmbEquip.DataSource = this.equipamentoBindingSource;
            this.cmbEquip.DisplayMember = "nome";
            this.cmbEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquip.Enabled = false;
            this.cmbEquip.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquip.FormattingEnabled = true;
            this.cmbEquip.IntegralHeight = false;
            this.cmbEquip.Location = new System.Drawing.Point(163, 50);
            this.cmbEquip.Name = "cmbEquip";
            this.cmbEquip.Size = new System.Drawing.Size(147, 30);
            this.cmbEquip.TabIndex = 133;
            this.cmbEquip.ValueMember = "id_equipamento";
            this.cmbEquip.SelectedIndexChanged += new System.EventHandler(this.cmbEquip_SelectedIndexChanged);
            // 
            // equipamentoBindingSource
            // 
            this.equipamentoBindingSource.DataMember = "equipamento";
            this.equipamentoBindingSource.DataSource = this.equipDS;
            // 
            // equipDS
            // 
            this.equipDS.DataSetName = "EquipDS";
            this.equipDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.rbViat);
            this.panel2.Controls.Add(this.rbBomb);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(11, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 25);
            this.panel2.TabIndex = 132;
            // 
            // rbViat
            // 
            this.rbViat.AutoSize = true;
            this.rbViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbViat.Location = new System.Drawing.Point(136, -2);
            this.rbViat.Name = "rbViat";
            this.rbViat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbViat.Size = new System.Drawing.Size(106, 27);
            this.rbViat.TabIndex = 1;
            this.rbViat.Text = "VIATURA";
            this.rbViat.UseVisualStyleBackColor = true;
            this.rbViat.CheckedChanged += new System.EventHandler(this.rbViat_CheckedChanged);
            // 
            // rbBomb
            // 
            this.rbBomb.AutoSize = true;
            this.rbBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBomb.Location = new System.Drawing.Point(0, -2);
            this.rbBomb.Name = "rbBomb";
            this.rbBomb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbBomb.Size = new System.Drawing.Size(125, 27);
            this.rbBomb.TabIndex = 0;
            this.rbBomb.Text = "BOMBEIRO";
            this.rbBomb.UseVisualStyleBackColor = true;
            this.rbBomb.CheckedChanged += new System.EventHandler(this.rbBomb_CheckedChanged);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.BackColor = System.Drawing.Color.Transparent;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(931, 82);
            this.lbErros.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 21);
            this.lbErros.TabIndex = 46;
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
            this.btnGuardar.Location = new System.Drawing.Point(11, 604);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 47;
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
            this.btnApagar.Location = new System.Drawing.Point(122, 604);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 30);
            this.btnApagar.TabIndex = 48;
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
            this.btnHome.Location = new System.Drawing.Point(875, 594);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 49;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // equipamentoTableAdapter
            // 
            this.equipamentoTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramToolStripLabel,
            this.paramToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1264, 25);
            this.fillByToolStrip.TabIndex = 50;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // paramToolStripLabel
            // 
            this.paramToolStripLabel.Name = "paramToolStripLabel";
            this.paramToolStripLabel.Size = new System.Drawing.Size(44, 22);
            this.paramToolStripLabel.Text = "param:";
            // 
            // paramToolStripTextBox
            // 
            this.paramToolStripTextBox.Name = "paramToolStripTextBox";
            this.paramToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // AtribuirEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbAtrNovoEquip);
            this.Controls.Add(this.lbInsEquip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AtribuirEquipamento";
            this.Text = "Atribuir Equipamento";
            this.Load += new System.EventHandler(this.AtribuicaoEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipDS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInsEquip;
        private System.Windows.Forms.Label lbAtrNovoEquip;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbViat;
        private System.Windows.Forms.ComboBox cmbBombViat;
        private System.Windows.Forms.ComboBox cmbEquip;
        private System.Windows.Forms.RadioButton rbBomb;
        private System.Windows.Forms.Label lbEquip;
        private System.Windows.Forms.Label lbBombViat;
        private System.Windows.Forms.Label lbQuant;
        private System.Windows.Forms.Label lbQuantTotal;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Label lbEEquip;
        private System.Windows.Forms.Label lbErros;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbEQuant;
        private System.Windows.Forms.Label lbEBombViat;
        private System.Windows.Forms.Label lbEBV;
        private EquipDS equipDS;
        private System.Windows.Forms.BindingSource equipamentoBindingSource;
        private EquipDSTableAdapters.equipamentoTableAdapter equipamentoTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel paramToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paramToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}