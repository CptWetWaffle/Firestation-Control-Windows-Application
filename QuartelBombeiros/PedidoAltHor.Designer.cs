namespace QuartelBombeiros
{
    partial class PedidoAltHor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoAltHor));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBomb = new System.Windows.Forms.ComboBox();
            this.pedidoaltBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet7 = new QuartelBombeiros.FireStationDataSet7();
            this.lbBomb = new System.Windows.Forms.Label();
            this.txtDFim = new System.Windows.Forms.TextBox();
            this.txtDIni = new System.Windows.Forms.TextBox();
            this.cmbHor = new System.Windows.Forms.ComboBox();
            this.turnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet5 = new QuartelBombeiros.FireStationDataSet5();
            this.lbEHorario = new System.Windows.Forms.Label();
            this.txtPosto = new System.Windows.Forms.TextBox();
            this.lbDataFim = new System.Windows.Forms.Label();
            this.lbDatIni = new System.Windows.Forms.Label();
            this.lbPosto = new System.Windows.Forms.Label();
            this.lbHor = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.turnoTableAdapter = new QuartelBombeiros.FireStationDataSet5TableAdapters.turnoTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.paramToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.paramToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lbErros = new System.Windows.Forms.Label();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.paramToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.paramToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pedido_altTableAdapter = new QuartelBombeiros.FireStationDataSet7TableAdapters.pedido_altTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoaltBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet5)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTitulo.Location = new System.Drawing.Point(12, 35);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(469, 47);
            this.lbTitulo.TabIndex = 25;
            this.lbTitulo.Text = "PEDIDO DE ALTERAÇÃO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 3);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmbBomb);
            this.panel1.Controls.Add(this.lbBomb);
            this.panel1.Controls.Add(this.txtDFim);
            this.panel1.Controls.Add(this.txtDIni);
            this.panel1.Controls.Add(this.cmbHor);
            this.panel1.Controls.Add(this.lbEHorario);
            this.panel1.Controls.Add(this.txtPosto);
            this.panel1.Controls.Add(this.lbDataFim);
            this.panel1.Controls.Add(this.lbDatIni);
            this.panel1.Controls.Add(this.lbPosto);
            this.panel1.Controls.Add(this.lbHor);
            this.panel1.Location = new System.Drawing.Point(12, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 488);
            this.panel1.TabIndex = 31;
            // 
            // cmbBomb
            // 
            this.cmbBomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbBomb.DataSource = this.pedidoaltBindingSource;
            this.cmbBomb.DisplayMember = "bombeiro_numero_bombeiro";
            this.cmbBomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBomb.FormattingEnabled = true;
            this.cmbBomb.IntegralHeight = false;
            this.cmbBomb.Location = new System.Drawing.Point(730, 13);
            this.cmbBomb.Name = "cmbBomb";
            this.cmbBomb.Size = new System.Drawing.Size(149, 30);
            this.cmbBomb.TabIndex = 151;
            this.cmbBomb.ValueMember = "bombeiro_numero_bombeiro";
            this.cmbBomb.Visible = false;
            this.cmbBomb.SelectedIndexChanged += new System.EventHandler(this.cmbBomb_SelectedIndexChanged);
            // 
            // pedidoaltBindingSource
            // 
            this.pedidoaltBindingSource.DataMember = "pedido_alt";
            this.pedidoaltBindingSource.DataSource = this.fireStationDataSet7;
            // 
            // fireStationDataSet7
            // 
            this.fireStationDataSet7.DataSetName = "FireStationDataSet7";
            this.fireStationDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbBomb
            // 
            this.lbBomb.AutoSize = true;
            this.lbBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBomb.Location = new System.Drawing.Point(610, 15);
            this.lbBomb.Name = "lbBomb";
            this.lbBomb.Size = new System.Drawing.Size(107, 23);
            this.lbBomb.TabIndex = 150;
            this.lbBomb.Text = "BOMBEIRO";
            this.lbBomb.Visible = false;
            // 
            // txtDFim
            // 
            this.txtDFim.Enabled = false;
            this.txtDFim.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDFim.Location = new System.Drawing.Point(425, 50);
            this.txtDFim.Name = "txtDFim";
            this.txtDFim.Size = new System.Drawing.Size(160, 31);
            this.txtDFim.TabIndex = 149;
            // 
            // txtDIni
            // 
            this.txtDIni.Enabled = false;
            this.txtDIni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDIni.Location = new System.Drawing.Point(454, 13);
            this.txtDIni.Name = "txtDIni";
            this.txtDIni.Size = new System.Drawing.Size(131, 31);
            this.txtDIni.TabIndex = 148;
            // 
            // cmbHor
            // 
            this.cmbHor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbHor.DataSource = this.turnoBindingSource;
            this.cmbHor.DisplayMember = "horario";
            this.cmbHor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHor.FormattingEnabled = true;
            this.cmbHor.IntegralHeight = false;
            this.cmbHor.Location = new System.Drawing.Point(122, 13);
            this.cmbHor.Name = "cmbHor";
            this.cmbHor.Size = new System.Drawing.Size(160, 30);
            this.cmbHor.TabIndex = 147;
            this.cmbHor.ValueMember = "id_turno";
            this.cmbHor.SelectedIndexChanged += new System.EventHandler(this.cmbHor_SelectedIndexChanged);
            // 
            // turnoBindingSource
            // 
            this.turnoBindingSource.DataMember = "turno";
            this.turnoBindingSource.DataSource = this.fireStationDataSet5;
            // 
            // fireStationDataSet5
            // 
            this.fireStationDataSet5.DataSetName = "FireStationDataSet5";
            this.fireStationDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbEHorario
            // 
            this.lbEHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEHorario.AutoSize = true;
            this.lbEHorario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEHorario.ForeColor = System.Drawing.Color.Red;
            this.lbEHorario.Location = new System.Drawing.Point(288, 15);
            this.lbEHorario.Name = "lbEHorario";
            this.lbEHorario.Size = new System.Drawing.Size(18, 23);
            this.lbEHorario.TabIndex = 127;
            this.lbEHorario.Text = "*";
            this.lbEHorario.Visible = false;
            // 
            // txtPosto
            // 
            this.txtPosto.Enabled = false;
            this.txtPosto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosto.Location = new System.Drawing.Point(90, 50);
            this.txtPosto.Name = "txtPosto";
            this.txtPosto.Size = new System.Drawing.Size(185, 31);
            this.txtPosto.TabIndex = 44;
            // 
            // lbDataFim
            // 
            this.lbDataFim.AutoSize = true;
            this.lbDataFim.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataFim.Location = new System.Drawing.Point(324, 52);
            this.lbDataFim.Name = "lbDataFim";
            this.lbDataFim.Size = new System.Drawing.Size(95, 23);
            this.lbDataFim.TabIndex = 42;
            this.lbDataFim.Text = "DATA FIM";
            // 
            // lbDatIni
            // 
            this.lbDatIni.AutoSize = true;
            this.lbDatIni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatIni.Location = new System.Drawing.Point(324, 15);
            this.lbDatIni.Name = "lbDatIni";
            this.lbDatIni.Size = new System.Drawing.Size(124, 23);
            this.lbDatIni.TabIndex = 41;
            this.lbDatIni.Text = "DATA INÍCIO";
            // 
            // lbPosto
            // 
            this.lbPosto.AutoSize = true;
            this.lbPosto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosto.Location = new System.Drawing.Point(13, 52);
            this.lbPosto.Name = "lbPosto";
            this.lbPosto.Size = new System.Drawing.Size(71, 23);
            this.lbPosto.TabIndex = 40;
            this.lbPosto.Text = "POSTO";
            // 
            // lbHor
            // 
            this.lbHor.AutoSize = true;
            this.lbHor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHor.Location = new System.Drawing.Point(13, 15);
            this.lbHor.Name = "lbHor";
            this.lbHor.Size = new System.Drawing.Size(96, 23);
            this.lbHor.TabIndex = 39;
            this.lbHor.Text = "HORÁRIO";
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
            this.btnGuardar.TabIndex = 53;
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
            this.btnApagar.TabIndex = 54;
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
            this.btnHome.TabIndex = 55;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // turnoTableAdapter
            // 
            this.turnoTableAdapter.ClearBeforeFill = true;
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
            this.fillByToolStrip.TabIndex = 56;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            this.fillByToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByToolStrip_ItemClicked);
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
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.BackColor = System.Drawing.Color.Transparent;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(910, 108);
            this.lbErros.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 21);
            this.lbErros.TabIndex = 57;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramToolStripLabel1,
            this.paramToolStripTextBox1,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(1264, 25);
            this.fillBy1ToolStrip.TabIndex = 58;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // paramToolStripLabel1
            // 
            this.paramToolStripLabel1.Name = "paramToolStripLabel1";
            this.paramToolStripLabel1.Size = new System.Drawing.Size(44, 22);
            this.paramToolStripLabel1.Text = "param:";
            // 
            // paramToolStripTextBox1
            // 
            this.paramToolStripTextBox1.Name = "paramToolStripTextBox1";
            this.paramToolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // pedido_altTableAdapter
            // 
            this.pedido_altTableAdapter.ClearBeforeFill = true;
            // 
            // PedidoAltHor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PedidoAltHor";
            this.Text = "Pedido Alteração";
            this.Load += new System.EventHandler(this.PedidoAltHor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoaltBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet5)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEHorario;
        private System.Windows.Forms.TextBox txtPosto;
        private System.Windows.Forms.Label lbDataFim;
        private System.Windows.Forms.Label lbDatIni;
        private System.Windows.Forms.Label lbPosto;
        private System.Windows.Forms.Label lbHor;
        private System.Windows.Forms.ComboBox cmbBomb;
        private System.Windows.Forms.Label lbBomb;
        private System.Windows.Forms.TextBox txtDFim;
        private System.Windows.Forms.TextBox txtDIni;
        private System.Windows.Forms.ComboBox cmbHor;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnHome;
        private FireStationDataSet5 fireStationDataSet5;
        private System.Windows.Forms.BindingSource turnoBindingSource;
        private FireStationDataSet5TableAdapters.turnoTableAdapter turnoTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel paramToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox paramToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel paramToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox paramToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private FireStationDataSet7 fireStationDataSet7;
        private System.Windows.Forms.BindingSource pedidoaltBindingSource;
        private FireStationDataSet7TableAdapters.pedido_altTableAdapter pedido_altTableAdapter;
    }
}