namespace QuartelBombeiros
{
    partial class InserirConcFreg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirConcFreg));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbESiglaConc = new System.Windows.Forms.Label();
            this.txtSiglaConc = new System.Windows.Forms.TextBox();
            this.lbSiglaConc = new System.Windows.Forms.Label();
            this.lbEConc = new System.Windows.Forms.Label();
            this.txtInsConc = new System.Windows.Forms.TextBox();
            this.lbInsConc = new System.Windows.Forms.Label();
            this.lbConc = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbESiglaFreg = new System.Windows.Forms.Label();
            this.txtSiglaFreg = new System.Windows.Forms.TextBox();
            this.lbSiglaFreg = new System.Windows.Forms.Label();
            this.lbECmbConc = new System.Windows.Forms.Label();
            this.lbEfreg = new System.Windows.Forms.Label();
            this.cmbConc = new System.Windows.Forms.ComboBox();
            this.conselhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fireStationDataSet = new QuartelBombeiros.FireStationDataSet();
            this.lbConc2 = new System.Windows.Forms.Label();
            this.txtInsFreg = new System.Windows.Forms.TextBox();
            this.lbInsFreg = new System.Windows.Forms.Label();
            this.lbFreg = new System.Windows.Forms.Label();
            this.btnApagarFreg = new System.Windows.Forms.Button();
            this.btnGuardarFreg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnApagarConc = new System.Windows.Forms.Button();
            this.btnGuardarConc = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.conselhoTableAdapter = new QuartelBombeiros.FireStationDataSetTableAdapters.conselhoTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conselhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.Location = new System.Drawing.Point(12, 35);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(621, 47);
            this.lbTitulo.TabIndex = 2;
            this.lbTitulo.Text = "INSERIR CONCELHO/FREGUESIA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbESiglaConc);
            this.panel1.Controls.Add(this.txtSiglaConc);
            this.panel1.Controls.Add(this.lbSiglaConc);
            this.panel1.Controls.Add(this.lbEConc);
            this.panel1.Controls.Add(this.txtInsConc);
            this.panel1.Controls.Add(this.lbInsConc);
            this.panel1.Controls.Add(this.lbConc);
            this.panel1.Location = new System.Drawing.Point(12, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 478);
            this.panel1.TabIndex = 4;
            // 
            // lbESiglaConc
            // 
            this.lbESiglaConc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbESiglaConc.AutoSize = true;
            this.lbESiglaConc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESiglaConc.ForeColor = System.Drawing.Color.Red;
            this.lbESiglaConc.Location = new System.Drawing.Point(378, 142);
            this.lbESiglaConc.Name = "lbESiglaConc";
            this.lbESiglaConc.Size = new System.Drawing.Size(18, 23);
            this.lbESiglaConc.TabIndex = 140;
            this.lbESiglaConc.Text = "*";
            this.lbESiglaConc.Visible = false;
            // 
            // txtSiglaConc
            // 
            this.txtSiglaConc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSiglaConc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiglaConc.Location = new System.Drawing.Point(131, 134);
            this.txtSiglaConc.MaxLength = 5;
            this.txtSiglaConc.Name = "txtSiglaConc";
            this.txtSiglaConc.Size = new System.Drawing.Size(241, 31);
            this.txtSiglaConc.TabIndex = 139;
            // 
            // lbSiglaConc
            // 
            this.lbSiglaConc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSiglaConc.AutoSize = true;
            this.lbSiglaConc.BackColor = System.Drawing.Color.Transparent;
            this.lbSiglaConc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiglaConc.Location = new System.Drawing.Point(16, 136);
            this.lbSiglaConc.Name = "lbSiglaConc";
            this.lbSiglaConc.Size = new System.Drawing.Size(109, 23);
            this.lbSiglaConc.TabIndex = 138;
            this.lbSiglaConc.Text = "Insira Sigla";
            // 
            // lbEConc
            // 
            this.lbEConc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEConc.AutoSize = true;
            this.lbEConc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEConc.ForeColor = System.Drawing.Color.Red;
            this.lbEConc.Location = new System.Drawing.Point(378, 97);
            this.lbEConc.Name = "lbEConc";
            this.lbEConc.Size = new System.Drawing.Size(18, 23);
            this.lbEConc.TabIndex = 137;
            this.lbEConc.Text = "*";
            this.lbEConc.Visible = false;
            // 
            // txtInsConc
            // 
            this.txtInsConc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInsConc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsConc.Location = new System.Drawing.Point(175, 97);
            this.txtInsConc.MaxLength = 20;
            this.txtInsConc.Name = "txtInsConc";
            this.txtInsConc.Size = new System.Drawing.Size(197, 31);
            this.txtInsConc.TabIndex = 136;
            // 
            // lbInsConc
            // 
            this.lbInsConc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbInsConc.AutoSize = true;
            this.lbInsConc.BackColor = System.Drawing.Color.Transparent;
            this.lbInsConc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsConc.Location = new System.Drawing.Point(16, 99);
            this.lbInsConc.Name = "lbInsConc";
            this.lbInsConc.Size = new System.Drawing.Size(153, 23);
            this.lbInsConc.TabIndex = 135;
            this.lbInsConc.Text = "Insira Concelho";
            // 
            // lbConc
            // 
            this.lbConc.AutoSize = true;
            this.lbConc.BackColor = System.Drawing.Color.Transparent;
            this.lbConc.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbConc.Location = new System.Drawing.Point(12, 9);
            this.lbConc.Name = "lbConc";
            this.lbConc.Size = new System.Drawing.Size(246, 47);
            this.lbConc.TabIndex = 134;
            this.lbConc.Text = "CONCELHO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbESiglaFreg);
            this.panel2.Controls.Add(this.txtSiglaFreg);
            this.panel2.Controls.Add(this.lbSiglaFreg);
            this.panel2.Controls.Add(this.lbECmbConc);
            this.panel2.Controls.Add(this.lbEfreg);
            this.panel2.Controls.Add(this.cmbConc);
            this.panel2.Controls.Add(this.lbConc2);
            this.panel2.Controls.Add(this.txtInsFreg);
            this.panel2.Controls.Add(this.lbInsFreg);
            this.panel2.Controls.Add(this.lbFreg);
            this.panel2.Location = new System.Drawing.Point(538, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 478);
            this.panel2.TabIndex = 24;
            // 
            // lbESiglaFreg
            // 
            this.lbESiglaFreg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbESiglaFreg.AutoSize = true;
            this.lbESiglaFreg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESiglaFreg.ForeColor = System.Drawing.Color.Red;
            this.lbESiglaFreg.Location = new System.Drawing.Point(377, 136);
            this.lbESiglaFreg.Name = "lbESiglaFreg";
            this.lbESiglaFreg.Size = new System.Drawing.Size(18, 23);
            this.lbESiglaFreg.TabIndex = 146;
            this.lbESiglaFreg.Text = "*";
            this.lbESiglaFreg.Visible = false;
            // 
            // txtSiglaFreg
            // 
            this.txtSiglaFreg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSiglaFreg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiglaFreg.Location = new System.Drawing.Point(130, 134);
            this.txtSiglaFreg.MaxLength = 5;
            this.txtSiglaFreg.Name = "txtSiglaFreg";
            this.txtSiglaFreg.Size = new System.Drawing.Size(241, 31);
            this.txtSiglaFreg.TabIndex = 145;
            // 
            // lbSiglaFreg
            // 
            this.lbSiglaFreg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSiglaFreg.AutoSize = true;
            this.lbSiglaFreg.BackColor = System.Drawing.Color.Transparent;
            this.lbSiglaFreg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSiglaFreg.Location = new System.Drawing.Point(15, 136);
            this.lbSiglaFreg.Name = "lbSiglaFreg";
            this.lbSiglaFreg.Size = new System.Drawing.Size(109, 23);
            this.lbSiglaFreg.TabIndex = 144;
            this.lbSiglaFreg.Text = "Insira Sigla";
            // 
            // lbECmbConc
            // 
            this.lbECmbConc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbECmbConc.AutoSize = true;
            this.lbECmbConc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbECmbConc.ForeColor = System.Drawing.Color.Red;
            this.lbECmbConc.Location = new System.Drawing.Point(291, 213);
            this.lbECmbConc.Name = "lbECmbConc";
            this.lbECmbConc.Size = new System.Drawing.Size(18, 23);
            this.lbECmbConc.TabIndex = 143;
            this.lbECmbConc.Text = "*";
            this.lbECmbConc.Visible = false;
            // 
            // lbEfreg
            // 
            this.lbEfreg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEfreg.AutoSize = true;
            this.lbEfreg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEfreg.ForeColor = System.Drawing.Color.Red;
            this.lbEfreg.Location = new System.Drawing.Point(377, 99);
            this.lbEfreg.Name = "lbEfreg";
            this.lbEfreg.Size = new System.Drawing.Size(18, 23);
            this.lbEfreg.TabIndex = 142;
            this.lbEfreg.Text = "*";
            this.lbEfreg.Visible = false;
            // 
            // cmbConc
            // 
            this.cmbConc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbConc.DataSource = this.conselhoBindingSource;
            this.cmbConc.DisplayMember = "nome";
            this.cmbConc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConc.FormattingEnabled = true;
            this.cmbConc.IntegralHeight = false;
            this.cmbConc.Location = new System.Drawing.Point(121, 211);
            this.cmbConc.Name = "cmbConc";
            this.cmbConc.Size = new System.Drawing.Size(164, 30);
            this.cmbConc.TabIndex = 141;
            this.cmbConc.ValueMember = "id_conselho";
            // 
            // conselhoBindingSource
            // 
            this.conselhoBindingSource.DataMember = "conselho";
            this.conselhoBindingSource.DataSource = this.fireStationDataSet;
            // 
            // fireStationDataSet
            // 
            this.fireStationDataSet.DataSetName = "FireStationDataSet";
            this.fireStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbConc2
            // 
            this.lbConc2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbConc2.AutoSize = true;
            this.lbConc2.BackColor = System.Drawing.Color.Transparent;
            this.lbConc2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConc2.Location = new System.Drawing.Point(15, 213);
            this.lbConc2.Name = "lbConc2";
            this.lbConc2.Size = new System.Drawing.Size(100, 23);
            this.lbConc2.TabIndex = 140;
            this.lbConc2.Text = "Concelho";
            // 
            // txtInsFreg
            // 
            this.txtInsFreg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtInsFreg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInsFreg.Location = new System.Drawing.Point(173, 97);
            this.txtInsFreg.MaxLength = 20;
            this.txtInsFreg.Name = "txtInsFreg";
            this.txtInsFreg.Size = new System.Drawing.Size(198, 31);
            this.txtInsFreg.TabIndex = 139;
            // 
            // lbInsFreg
            // 
            this.lbInsFreg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbInsFreg.AutoSize = true;
            this.lbInsFreg.BackColor = System.Drawing.Color.Transparent;
            this.lbInsFreg.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsFreg.Location = new System.Drawing.Point(15, 99);
            this.lbInsFreg.Name = "lbInsFreg";
            this.lbInsFreg.Size = new System.Drawing.Size(152, 23);
            this.lbInsFreg.TabIndex = 138;
            this.lbInsFreg.Text = "Insira Freguesia";
            // 
            // lbFreg
            // 
            this.lbFreg.AutoSize = true;
            this.lbFreg.BackColor = System.Drawing.Color.Transparent;
            this.lbFreg.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbFreg.Location = new System.Drawing.Point(11, 9);
            this.lbFreg.Name = "lbFreg";
            this.lbFreg.Size = new System.Drawing.Size(226, 47);
            this.lbFreg.TabIndex = 137;
            this.lbFreg.Text = "FREGUESIA";
            // 
            // btnApagarFreg
            // 
            this.btnApagarFreg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApagarFreg.AutoSize = true;
            this.btnApagarFreg.BackColor = System.Drawing.Color.Transparent;
            this.btnApagarFreg.BackgroundImage = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnApagarFreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagarFreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarFreg.FlatAppearance.BorderSize = 0;
            this.btnApagarFreg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApagarFreg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagarFreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarFreg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarFreg.ForeColor = System.Drawing.Color.White;
            this.btnApagarFreg.Location = new System.Drawing.Point(695, 599);
            this.btnApagarFreg.Name = "btnApagarFreg";
            this.btnApagarFreg.Size = new System.Drawing.Size(105, 30);
            this.btnApagarFreg.TabIndex = 102;
            this.btnApagarFreg.Text = "APAGAR";
            this.btnApagarFreg.UseVisualStyleBackColor = false;
            this.btnApagarFreg.Click += new System.EventHandler(this.btnApagarFreg_Click);
            // 
            // btnGuardarFreg
            // 
            this.btnGuardarFreg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarFreg.AutoSize = true;
            this.btnGuardarFreg.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarFreg.BackgroundImage = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnGuardarFreg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarFreg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarFreg.FlatAppearance.BorderSize = 0;
            this.btnGuardarFreg.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarFreg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarFreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFreg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarFreg.ForeColor = System.Drawing.Color.White;
            this.btnGuardarFreg.Location = new System.Drawing.Point(584, 599);
            this.btnGuardarFreg.Name = "btnGuardarFreg";
            this.btnGuardarFreg.Size = new System.Drawing.Size(105, 30);
            this.btnGuardarFreg.TabIndex = 101;
            this.btnGuardarFreg.Text = "GUARDAR";
            this.btnGuardarFreg.UseVisualStyleBackColor = false;
            this.btnGuardarFreg.Click += new System.EventHandler(this.btnGuardarFreg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 10);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnApagarConc
            // 
            this.btnApagarConc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApagarConc.AutoSize = true;
            this.btnApagarConc.BackColor = System.Drawing.Color.Transparent;
            this.btnApagarConc.BackgroundImage = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnApagarConc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagarConc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarConc.FlatAppearance.BorderSize = 0;
            this.btnApagarConc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApagarConc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagarConc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarConc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarConc.ForeColor = System.Drawing.Color.White;
            this.btnApagarConc.Location = new System.Drawing.Point(123, 599);
            this.btnApagarConc.Name = "btnApagarConc";
            this.btnApagarConc.Size = new System.Drawing.Size(105, 30);
            this.btnApagarConc.TabIndex = 99;
            this.btnApagarConc.Text = "APAGAR";
            this.btnApagarConc.UseVisualStyleBackColor = false;
            this.btnApagarConc.Click += new System.EventHandler(this.btnApagarConc_Click);
            // 
            // btnGuardarConc
            // 
            this.btnGuardarConc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarConc.AutoSize = true;
            this.btnGuardarConc.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarConc.BackgroundImage = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnGuardarConc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarConc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarConc.FlatAppearance.BorderSize = 0;
            this.btnGuardarConc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarConc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarConc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarConc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarConc.ForeColor = System.Drawing.Color.White;
            this.btnGuardarConc.Location = new System.Drawing.Point(12, 599);
            this.btnGuardarConc.Name = "btnGuardarConc";
            this.btnGuardarConc.Size = new System.Drawing.Size(105, 30);
            this.btnGuardarConc.TabIndex = 98;
            this.btnGuardarConc.Text = "GUARDAR";
            this.btnGuardarConc.UseVisualStyleBackColor = false;
            this.btnGuardarConc.Click += new System.EventHandler(this.btnGuardarConc_Click);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.BackColor = System.Drawing.Color.Transparent;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(1056, 115);
            this.lbErros.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 24);
            this.lbErros.TabIndex = 98;
            this.lbErros.UseCompatibleTextRendering = true;
            // 
            // conselhoTableAdapter
            // 
            this.conselhoTableAdapter.ClearBeforeFill = true;
            // 
            // InserirConcFreg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(1264, 682);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.btnApagarFreg);
            this.Controls.Add(this.btnApagarConc);
            this.Controls.Add(this.btnGuardarFreg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnGuardarConc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirConcFreg";
            this.Text = "Inserir Concelho/Freguesia";
            this.Load += new System.EventHandler(this.InserirConcFreg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conselhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnGuardarConc;
        public System.Windows.Forms.Button btnApagarConc;
        public System.Windows.Forms.Button btnApagarFreg;
        public System.Windows.Forms.Button btnGuardarFreg;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.Label lbESiglaConc;
        private System.Windows.Forms.TextBox txtSiglaConc;
        private System.Windows.Forms.Label lbSiglaConc;
        private System.Windows.Forms.Label lbEConc;
        private System.Windows.Forms.TextBox txtInsConc;
        private System.Windows.Forms.Label lbInsConc;
        private System.Windows.Forms.Label lbConc;
        private System.Windows.Forms.Label lbESiglaFreg;
        private System.Windows.Forms.TextBox txtSiglaFreg;
        private System.Windows.Forms.Label lbSiglaFreg;
        private System.Windows.Forms.Label lbECmbConc;
        private System.Windows.Forms.Label lbEfreg;
        private System.Windows.Forms.ComboBox cmbConc;
        private System.Windows.Forms.Label lbConc2;
        private System.Windows.Forms.TextBox txtInsFreg;
        private System.Windows.Forms.Label lbInsFreg;
        private System.Windows.Forms.Label lbFreg;
        private FireStationDataSet fireStationDataSet;
        private System.Windows.Forms.BindingSource conselhoBindingSource;
        private FireStationDataSetTableAdapters.conselhoTableAdapter conselhoTableAdapter;
    }
}