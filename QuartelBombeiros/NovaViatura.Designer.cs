namespace QuartelBombeiros
{
    partial class NovaViatura
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
            System.Windows.Forms.Button btnHome;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaViatura));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bombeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.velhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pbLinha = new System.Windows.Forms.PictureBox();
            this.lblMat = new System.Windows.Forms.Panel();
            this.cmbAbateYYYY = new System.Windows.Forms.ComboBox();
            this.cmbUltInspYYYY = new System.Windows.Forms.ComboBox();
            this.cmbValYYYY = new System.Windows.Forms.ComboBox();
            this.cmbUltInspDD = new System.Windows.Forms.ComboBox();
            this.cmbUltInspMM = new System.Windows.Forms.ComboBox();
            this.cmbAbateMM = new System.Windows.Forms.ComboBox();
            this.cmbAbateDD = new System.Windows.Forms.ComboBox();
            this.cmbValDD = new System.Windows.Forms.ComboBox();
            this.cmbValMM = new System.Windows.Forms.ComboBox();
            this.txtKil = new System.Windows.Forms.TextBox();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.lbETip = new System.Windows.Forms.Label();
            this.lbEMat = new System.Windows.Forms.Label();
            this.lbECod = new System.Windows.Forms.Label();
            this.txtOBS = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtApoice = new System.Windows.Forms.TextBox();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.txtSeguro = new System.Windows.Forms.TextBox();
            this.lblAbate = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblKm = new System.Windows.Forms.Label();
            this.lblInsp = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblSeguro = new System.Windows.Forms.Label();
            this.lblApolice = new System.Windows.Forms.Label();
            this.lblOBS = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblNovaViat = new System.Windows.Forms.Label();
            this.lbErros = new System.Windows.Forms.Label();
            this.fireStationDataSet8 = new QuartelBombeiros.FireStationDataSet8();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTableAdapter = new QuartelBombeiros.FireStationDataSet8TableAdapters.tipoTableAdapter();
            btnHome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinha)).BeginInit();
            this.lblMat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnHome.BackColor = System.Drawing.Color.Transparent;
            btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnHome.CausesValidation = false;
            btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnHome.Location = new System.Drawing.Point(887, 565);
            btnHome.Margin = new System.Windows.Forms.Padding(0);
            btnHome.Name = "btnHome";
            btnHome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            btnHome.Size = new System.Drawing.Size(50, 50);
            btnHome.TabIndex = 24;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // entrarToolStripMenuItem
            // 
            this.entrarToolStripMenuItem.Name = "entrarToolStripMenuItem";
            this.entrarToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.entrarToolStripMenuItem.Text = "entrar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.sairToolStripMenuItem.Text = "sair";
            // 
            // bombeiroToolStripMenuItem
            // 
            this.bombeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.novoToolStripMenuItem,
            this.velhoToolStripMenuItem});
            this.bombeiroToolStripMenuItem.Name = "bombeiroToolStripMenuItem";
            this.bombeiroToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bombeiroToolStripMenuItem.Text = "Bombeiro";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.novoToolStripMenuItem.Text = "novo";
            // 
            // velhoToolStripMenuItem
            // 
            this.velhoToolStripMenuItem.Name = "velhoToolStripMenuItem";
            this.velhoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.velhoToolStripMenuItem.Text = "velho";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.bombeiroToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnApagar
            // 
            this.btnApagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApagar.AutoSize = true;
            this.btnApagar.BackColor = System.Drawing.Color.Transparent;
            this.btnApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.White;
            this.btnApagar.Image = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnApagar.Location = new System.Drawing.Point(130, 565);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(112, 33);
            this.btnApagar.TabIndex = 28;
            this.btnApagar.Text = "APAGAR";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnGuardar.Location = new System.Drawing.Point(12, 565);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 33);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pbLinha
            // 
            this.pbLinha.BackColor = System.Drawing.Color.Transparent;
            this.pbLinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLinha.Image = ((System.Drawing.Image)(resources.GetObject("pbLinha.Image")));
            this.pbLinha.Location = new System.Drawing.Point(1, 88);
            this.pbLinha.Name = "pbLinha";
            this.pbLinha.Size = new System.Drawing.Size(485, 10);
            this.pbLinha.TabIndex = 26;
            this.pbLinha.TabStop = false;
            // 
            // lblMat
            // 
            this.lblMat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMat.BackColor = System.Drawing.Color.Transparent;
            this.lblMat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMat.Controls.Add(this.cmbAbateYYYY);
            this.lblMat.Controls.Add(this.cmbUltInspYYYY);
            this.lblMat.Controls.Add(this.cmbValYYYY);
            this.lblMat.Controls.Add(this.cmbUltInspDD);
            this.lblMat.Controls.Add(this.cmbUltInspMM);
            this.lblMat.Controls.Add(this.cmbAbateMM);
            this.lblMat.Controls.Add(this.cmbAbateDD);
            this.lblMat.Controls.Add(this.cmbValDD);
            this.lblMat.Controls.Add(this.cmbValMM);
            this.lblMat.Controls.Add(this.txtKil);
            this.lblMat.Controls.Add(this.cmbAno);
            this.lblMat.Controls.Add(this.lbETip);
            this.lblMat.Controls.Add(this.lbEMat);
            this.lblMat.Controls.Add(this.lbECod);
            this.lblMat.Controls.Add(this.txtOBS);
            this.lblMat.Controls.Add(this.cmbTipo);
            this.lblMat.Controls.Add(this.txtCod);
            this.lblMat.Controls.Add(this.txtApoice);
            this.lblMat.Controls.Add(this.txtMat);
            this.lblMat.Controls.Add(this.txtSeguro);
            this.lblMat.Controls.Add(this.lblAbate);
            this.lblMat.Controls.Add(this.lblCod);
            this.lblMat.Controls.Add(this.lblKm);
            this.lblMat.Controls.Add(this.lblInsp);
            this.lblMat.Controls.Add(this.lblTipo);
            this.lblMat.Controls.Add(this.lblValidade);
            this.lblMat.Controls.Add(this.lblSeguro);
            this.lblMat.Controls.Add(this.lblApolice);
            this.lblMat.Controls.Add(this.lblOBS);
            this.lblMat.Controls.Add(this.label7);
            this.lblMat.Controls.Add(this.lblAno);
            this.lblMat.Location = new System.Drawing.Point(12, 104);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(925, 455);
            this.lblMat.TabIndex = 25;
            // 
            // cmbAbateYYYY
            // 
            this.cmbAbateYYYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbateYYYY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAbateYYYY.FormattingEnabled = true;
            this.cmbAbateYYYY.IntegralHeight = false;
            this.cmbAbateYYYY.Location = new System.Drawing.Point(806, 101);
            this.cmbAbateYYYY.Name = "cmbAbateYYYY";
            this.cmbAbateYYYY.Size = new System.Drawing.Size(74, 30);
            this.cmbAbateYYYY.TabIndex = 147;
            this.cmbAbateYYYY.SelectedIndexChanged += new System.EventHandler(this.cmbAbateYYYY_SelectedIndexChanged);
            // 
            // cmbUltInspYYYY
            // 
            this.cmbUltInspYYYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUltInspYYYY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUltInspYYYY.FormattingEnabled = true;
            this.cmbUltInspYYYY.IntegralHeight = false;
            this.cmbUltInspYYYY.Location = new System.Drawing.Point(266, 101);
            this.cmbUltInspYYYY.Name = "cmbUltInspYYYY";
            this.cmbUltInspYYYY.Size = new System.Drawing.Size(74, 30);
            this.cmbUltInspYYYY.TabIndex = 146;
            this.cmbUltInspYYYY.SelectedIndexChanged += new System.EventHandler(this.cmbUltInspYYYY_SelectedIndexChanged);
            // 
            // cmbValYYYY
            // 
            this.cmbValYYYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValYYYY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValYYYY.FormattingEnabled = true;
            this.cmbValYYYY.IntegralHeight = false;
            this.cmbValYYYY.Location = new System.Drawing.Point(786, 64);
            this.cmbValYYYY.Name = "cmbValYYYY";
            this.cmbValYYYY.Size = new System.Drawing.Size(74, 30);
            this.cmbValYYYY.TabIndex = 145;
            this.cmbValYYYY.SelectedIndexChanged += new System.EventHandler(this.cmbValYYYY_SelectedIndexChanged);
            // 
            // cmbUltInspDD
            // 
            this.cmbUltInspDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUltInspDD.Enabled = false;
            this.cmbUltInspDD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUltInspDD.FormattingEnabled = true;
            this.cmbUltInspDD.IntegralHeight = false;
            this.cmbUltInspDD.Location = new System.Drawing.Point(168, 101);
            this.cmbUltInspDD.Name = "cmbUltInspDD";
            this.cmbUltInspDD.Size = new System.Drawing.Size(43, 30);
            this.cmbUltInspDD.TabIndex = 144;
            // 
            // cmbUltInspMM
            // 
            this.cmbUltInspMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUltInspMM.Enabled = false;
            this.cmbUltInspMM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUltInspMM.FormattingEnabled = true;
            this.cmbUltInspMM.IntegralHeight = false;
            this.cmbUltInspMM.Location = new System.Drawing.Point(217, 101);
            this.cmbUltInspMM.Name = "cmbUltInspMM";
            this.cmbUltInspMM.Size = new System.Drawing.Size(43, 30);
            this.cmbUltInspMM.TabIndex = 143;
            this.cmbUltInspMM.SelectedIndexChanged += new System.EventHandler(this.cmbUltInspMM_SelectedIndexChanged);
            // 
            // cmbAbateMM
            // 
            this.cmbAbateMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbateMM.Enabled = false;
            this.cmbAbateMM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAbateMM.FormattingEnabled = true;
            this.cmbAbateMM.IntegralHeight = false;
            this.cmbAbateMM.Location = new System.Drawing.Point(757, 101);
            this.cmbAbateMM.Name = "cmbAbateMM";
            this.cmbAbateMM.Size = new System.Drawing.Size(43, 30);
            this.cmbAbateMM.TabIndex = 142;
            this.cmbAbateMM.SelectedIndexChanged += new System.EventHandler(this.cmbAbateMM_SelectedIndexChanged);
            // 
            // cmbAbateDD
            // 
            this.cmbAbateDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAbateDD.Enabled = false;
            this.cmbAbateDD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAbateDD.FormattingEnabled = true;
            this.cmbAbateDD.IntegralHeight = false;
            this.cmbAbateDD.Location = new System.Drawing.Point(708, 101);
            this.cmbAbateDD.Name = "cmbAbateDD";
            this.cmbAbateDD.Size = new System.Drawing.Size(43, 30);
            this.cmbAbateDD.TabIndex = 141;
            // 
            // cmbValDD
            // 
            this.cmbValDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValDD.Enabled = false;
            this.cmbValDD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValDD.FormattingEnabled = true;
            this.cmbValDD.IntegralHeight = false;
            this.cmbValDD.Location = new System.Drawing.Point(688, 64);
            this.cmbValDD.Name = "cmbValDD";
            this.cmbValDD.Size = new System.Drawing.Size(43, 30);
            this.cmbValDD.TabIndex = 140;
            // 
            // cmbValMM
            // 
            this.cmbValMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbValMM.Enabled = false;
            this.cmbValMM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbValMM.FormattingEnabled = true;
            this.cmbValMM.IntegralHeight = false;
            this.cmbValMM.Location = new System.Drawing.Point(737, 64);
            this.cmbValMM.Name = "cmbValMM";
            this.cmbValMM.Size = new System.Drawing.Size(43, 30);
            this.cmbValMM.TabIndex = 139;
            this.cmbValMM.SelectedIndexChanged += new System.EventHandler(this.cmbValMM_SelectedIndexChanged);
            // 
            // txtKil
            // 
            this.txtKil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKil.Location = new System.Drawing.Point(508, 101);
            this.txtKil.Name = "txtKil";
            this.txtKil.Size = new System.Drawing.Size(111, 31);
            this.txtKil.TabIndex = 138;
            // 
            // cmbAno
            // 
            this.cmbAno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.IntegralHeight = false;
            this.cmbAno.Location = new System.Drawing.Point(642, 22);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(77, 30);
            this.cmbAno.TabIndex = 128;
            // 
            // lbETip
            // 
            this.lbETip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbETip.AutoSize = true;
            this.lbETip.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbETip.ForeColor = System.Drawing.Color.Red;
            this.lbETip.Location = new System.Drawing.Point(889, 24);
            this.lbETip.Name = "lbETip";
            this.lbETip.Size = new System.Drawing.Size(18, 23);
            this.lbETip.TabIndex = 126;
            this.lbETip.Text = "*";
            this.lbETip.Visible = false;
            // 
            // lbEMat
            // 
            this.lbEMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEMat.AutoSize = true;
            this.lbEMat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEMat.ForeColor = System.Drawing.Color.Red;
            this.lbEMat.Location = new System.Drawing.Point(565, 24);
            this.lbEMat.Name = "lbEMat";
            this.lbEMat.Size = new System.Drawing.Size(18, 23);
            this.lbEMat.TabIndex = 121;
            this.lbEMat.Text = "*";
            this.lbEMat.Visible = false;
            // 
            // lbECod
            // 
            this.lbECod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbECod.AutoSize = true;
            this.lbECod.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbECod.ForeColor = System.Drawing.Color.Red;
            this.lbECod.Location = new System.Drawing.Point(288, 24);
            this.lbECod.Name = "lbECod";
            this.lbECod.Size = new System.Drawing.Size(18, 23);
            this.lbECod.TabIndex = 118;
            this.lbECod.Text = "*";
            this.lbECod.Visible = false;
            // 
            // txtOBS
            // 
            this.txtOBS.AllowDrop = true;
            this.txtOBS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOBS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOBS.Location = new System.Drawing.Point(21, 168);
            this.txtOBS.Multiline = true;
            this.txtOBS.Name = "txtOBS";
            this.txtOBS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOBS.Size = new System.Drawing.Size(862, 260);
            this.txtOBS.TabIndex = 27;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipo.DataSource = this.tipoBindingSource;
            this.cmbTipo.DisplayMember = "nome";
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.IntegralHeight = false;
            this.cmbTipo.Location = new System.Drawing.Point(781, 22);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(102, 30);
            this.cmbTipo.TabIndex = 24;
            this.cmbTipo.ValueMember = "id_tipo";
            // 
            // txtCod
            // 
            this.txtCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCod.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(100, 22);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(182, 31);
            this.txtCod.TabIndex = 17;
            // 
            // txtApoice
            // 
            this.txtApoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApoice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApoice.Location = new System.Drawing.Point(422, 61);
            this.txtApoice.Name = "txtApoice";
            this.txtApoice.Size = new System.Drawing.Size(137, 31);
            this.txtApoice.TabIndex = 21;
            // 
            // txtMat
            // 
            this.txtMat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMat.Location = new System.Drawing.Point(422, 22);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(137, 31);
            this.txtMat.TabIndex = 20;
            // 
            // txtSeguro
            // 
            this.txtSeguro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSeguro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeguro.Location = new System.Drawing.Point(147, 61);
            this.txtSeguro.Name = "txtSeguro";
            this.txtSeguro.Size = new System.Drawing.Size(135, 31);
            this.txtSeguro.TabIndex = 18;
            // 
            // lblAbate
            // 
            this.lblAbate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAbate.AutoSize = true;
            this.lblAbate.BackColor = System.Drawing.Color.Transparent;
            this.lblAbate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAbate.Location = new System.Drawing.Point(635, 103);
            this.lblAbate.Name = "lblAbate";
            this.lblAbate.Size = new System.Drawing.Size(67, 23);
            this.lblAbate.TabIndex = 14;
            this.lblAbate.Text = "ABATE";
            // 
            // lblCod
            // 
            this.lblCod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCod.AutoSize = true;
            this.lblCod.BackColor = System.Drawing.Color.Transparent;
            this.lblCod.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCod.Location = new System.Drawing.Point(3, 24);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(91, 23);
            this.lblCod.TabIndex = 9;
            this.lblCod.Text = "CÓDIGO";
            // 
            // lblKm
            // 
            this.lblKm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKm.AutoSize = true;
            this.lblKm.BackColor = System.Drawing.Color.Transparent;
            this.lblKm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKm.Location = new System.Drawing.Point(348, 103);
            this.lblKm.Name = "lblKm";
            this.lblKm.Size = new System.Drawing.Size(154, 23);
            this.lblKm.TabIndex = 12;
            this.lblKm.Text = "KILOMETRAGEM";
            // 
            // lblInsp
            // 
            this.lblInsp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInsp.AutoSize = true;
            this.lblInsp.BackColor = System.Drawing.Color.Transparent;
            this.lblInsp.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInsp.Location = new System.Drawing.Point(3, 103);
            this.lblInsp.Name = "lblInsp";
            this.lblInsp.Size = new System.Drawing.Size(159, 23);
            this.lblInsp.TabIndex = 6;
            this.lblInsp.Text = "ÚLT. INSPECÇÃO";
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipo.Location = new System.Drawing.Point(725, 24);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(50, 23);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "TIPO";
            // 
            // lblValidade
            // 
            this.lblValidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidade.AutoSize = true;
            this.lblValidade.BackColor = System.Drawing.Color.Transparent;
            this.lblValidade.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValidade.Location = new System.Drawing.Point(582, 66);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(100, 23);
            this.lblValidade.TabIndex = 13;
            this.lblValidade.Text = "VALIDADE";
            // 
            // lblSeguro
            // 
            this.lblSeguro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeguro.AutoSize = true;
            this.lblSeguro.BackColor = System.Drawing.Color.Transparent;
            this.lblSeguro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeguro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeguro.Location = new System.Drawing.Point(3, 66);
            this.lblSeguro.Name = "lblSeguro";
            this.lblSeguro.Size = new System.Drawing.Size(138, 23);
            this.lblSeguro.TabIndex = 4;
            this.lblSeguro.Text = "SEGURADORA";
            // 
            // lblApolice
            // 
            this.lblApolice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblApolice.AutoSize = true;
            this.lblApolice.BackColor = System.Drawing.Color.Transparent;
            this.lblApolice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApolice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblApolice.Location = new System.Drawing.Point(303, 66);
            this.lblApolice.Name = "lblApolice";
            this.lblApolice.Size = new System.Drawing.Size(120, 23);
            this.lblApolice.TabIndex = 10;
            this.lblApolice.Text = "N.º APÓLICE";
            // 
            // lblOBS
            // 
            this.lblOBS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOBS.AutoSize = true;
            this.lblOBS.BackColor = System.Drawing.Color.Transparent;
            this.lblOBS.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOBS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOBS.Location = new System.Drawing.Point(3, 142);
            this.lblOBS.Name = "lblOBS";
            this.lblOBS.Size = new System.Drawing.Size(146, 23);
            this.lblOBS.TabIndex = 5;
            this.lblOBS.Text = "OBSERVAÇÕES";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(303, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "MATRÍCULA";
            // 
            // lblAno
            // 
            this.lblAno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAno.Location = new System.Drawing.Point(582, 24);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(54, 23);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "ANO";
            // 
            // lblNovaViat
            // 
            this.lblNovaViat.AutoSize = true;
            this.lblNovaViat.BackColor = System.Drawing.Color.Transparent;
            this.lblNovaViat.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaViat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNovaViat.Location = new System.Drawing.Point(13, 38);
            this.lblNovaViat.Name = "lblNovaViat";
            this.lblNovaViat.Size = new System.Drawing.Size(318, 47);
            this.lblNovaViat.TabIndex = 23;
            this.lblNovaViat.Text = "NOVA VIATURA";
            // 
            // lbErros
            // 
            this.lbErros.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbErros.AutoSize = true;
            this.lbErros.BackColor = System.Drawing.Color.Transparent;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbErros.Location = new System.Drawing.Point(943, 104);
            this.lbErros.MaximumSize = new System.Drawing.Size(300, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 21);
            this.lbErros.TabIndex = 29;
            // 
            // fireStationDataSet8
            // 
            this.fireStationDataSet8.DataSetName = "FireStationDataSet8";
            this.fireStationDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataMember = "tipo";
            this.tipoBindingSource.DataSource = this.fireStationDataSet8;
            // 
            // tipoTableAdapter
            // 
            this.tipoTableAdapter.ClearBeforeFill = true;
            // 
            // NovaViatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pbLinha);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(btnHome);
            this.Controls.Add(this.lblNovaViat);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NovaViatura";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Nova Viatura";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLinha)).EndInit();
            this.lblMat.ResumeLayout(false);
            this.lblMat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fireStationDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bombeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem velhoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pbLinha;
        private System.Windows.Forms.Panel lblMat;
        private System.Windows.Forms.TextBox txtOBS;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtApoice;
        private System.Windows.Forms.TextBox txtMat;
        private System.Windows.Forms.TextBox txtSeguro;
        private System.Windows.Forms.Label lblAbate;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblKm;
        private System.Windows.Forms.Label lblInsp;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblSeguro;
        private System.Windows.Forms.Label lblApolice;
        private System.Windows.Forms.Label lblOBS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblNovaViat;
        private System.Windows.Forms.Label lbETip;
        private System.Windows.Forms.Label lbEMat;
        private System.Windows.Forms.Label lbECod;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.TextBox txtKil;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.ComboBox cmbUltInspDD;
        private System.Windows.Forms.ComboBox cmbUltInspMM;
        private System.Windows.Forms.ComboBox cmbAbateMM;
        private System.Windows.Forms.ComboBox cmbAbateDD;
        private System.Windows.Forms.ComboBox cmbValDD;
        private System.Windows.Forms.ComboBox cmbValMM;
        private System.Windows.Forms.ComboBox cmbAbateYYYY;
        private System.Windows.Forms.ComboBox cmbUltInspYYYY;
        private System.Windows.Forms.ComboBox cmbValYYYY;
        private FireStationDataSet8 fireStationDataSet8;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private FireStationDataSet8TableAdapters.tipoTableAdapter tipoTableAdapter;

    }
}

