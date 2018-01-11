namespace QuartelBombeiros
{
    partial class Bombeiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bombeiro));
            this.lbTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEtipo = new System.Windows.Forms.Label();
            this.lbEpass = new System.Windows.Forms.Label();
            this.lbEuser = new System.Windows.Forms.Label();
            this.lbENbomb = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbVerBomb = new System.Windows.Forms.Label();
            this.pnlRadiobuttons = new System.Windows.Forms.Panel();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtNumBomb = new System.Windows.Forms.TextBox();
            this.lbPass = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbNumBomb = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbErros = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlRadiobuttons.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbTitulo.Location = new System.Drawing.Point(12, 22);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(354, 47);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "CRIAR BOMBEIRO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbEtipo);
            this.panel1.Controls.Add(this.lbEpass);
            this.panel1.Controls.Add(this.lbEuser);
            this.panel1.Controls.Add(this.lbENbomb);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.lbTipo);
            this.panel1.Controls.Add(this.lbVerBomb);
            this.panel1.Controls.Add(this.pnlRadiobuttons);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.txtNumBomb);
            this.panel1.Controls.Add(this.lbPass);
            this.panel1.Controls.Add(this.lbUser);
            this.panel1.Controls.Add(this.lbNumBomb);
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 471);
            this.panel1.TabIndex = 1;
            // 
            // lbEtipo
            // 
            this.lbEtipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEtipo.AutoSize = true;
            this.lbEtipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEtipo.ForeColor = System.Drawing.Color.Red;
            this.lbEtipo.Location = new System.Drawing.Point(324, 165);
            this.lbEtipo.Name = "lbEtipo";
            this.lbEtipo.Size = new System.Drawing.Size(18, 23);
            this.lbEtipo.TabIndex = 121;
            this.lbEtipo.Text = "*";
            this.lbEtipo.Visible = false;
            // 
            // lbEpass
            // 
            this.lbEpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEpass.AutoSize = true;
            this.lbEpass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEpass.ForeColor = System.Drawing.Color.Red;
            this.lbEpass.Location = new System.Drawing.Point(324, 91);
            this.lbEpass.Name = "lbEpass";
            this.lbEpass.Size = new System.Drawing.Size(18, 23);
            this.lbEpass.TabIndex = 120;
            this.lbEpass.Text = "*";
            this.lbEpass.Visible = false;
            // 
            // lbEuser
            // 
            this.lbEuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEuser.AutoSize = true;
            this.lbEuser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEuser.ForeColor = System.Drawing.Color.Red;
            this.lbEuser.Location = new System.Drawing.Point(324, 54);
            this.lbEuser.Name = "lbEuser";
            this.lbEuser.Size = new System.Drawing.Size(18, 23);
            this.lbEuser.TabIndex = 119;
            this.lbEuser.Text = "*";
            this.lbEuser.Visible = false;
            // 
            // lbENbomb
            // 
            this.lbENbomb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbENbomb.AutoSize = true;
            this.lbENbomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbENbomb.ForeColor = System.Drawing.Color.Red;
            this.lbENbomb.Location = new System.Drawing.Point(324, 17);
            this.lbENbomb.Name = "lbENbomb";
            this.lbENbomb.Size = new System.Drawing.Size(18, 23);
            this.lbENbomb.TabIndex = 118;
            this.lbENbomb.Text = "*";
            this.lbENbomb.Visible = false;
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Administrador",
            "Bombeiro",
            "Operador"});
            this.cmbTipo.Location = new System.Drawing.Point(73, 163);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(245, 30);
            this.cmbTipo.TabIndex = 94;
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(17, 165);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(50, 23);
            this.lbTipo.TabIndex = 11;
            this.lbTipo.Text = "TIPO";
            // 
            // lbVerBomb
            // 
            this.lbVerBomb.AutoSize = true;
            this.lbVerBomb.Location = new System.Drawing.Point(17, 128);
            this.lbVerBomb.Name = "lbVerBomb";
            this.lbVerBomb.Size = new System.Drawing.Size(107, 23);
            this.lbVerBomb.TabIndex = 8;
            this.lbVerBomb.Text = "BOMBEIRO";
            // 
            // pnlRadiobuttons
            // 
            this.pnlRadiobuttons.Controls.Add(this.rbNao);
            this.pnlRadiobuttons.Controls.Add(this.rbSim);
            this.pnlRadiobuttons.Location = new System.Drawing.Point(132, 125);
            this.pnlRadiobuttons.Name = "pnlRadiobuttons";
            this.pnlRadiobuttons.Size = new System.Drawing.Size(186, 31);
            this.pnlRadiobuttons.TabIndex = 7;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(111, 1);
            this.rbNao.Name = "rbNao";
            this.rbNao.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbNao.Size = new System.Drawing.Size(72, 27);
            this.rbNao.TabIndex = 1;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "NÃO";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Checked = true;
            this.rbSim.Location = new System.Drawing.Point(3, 1);
            this.rbSim.Name = "rbSim";
            this.rbSim.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbSim.Size = new System.Drawing.Size(60, 27);
            this.rbSim.TabIndex = 0;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "SIM";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(132, 88);
            this.txtPass.MaxLength = 12;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(186, 31);
            this.txtPass.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtUser.Location = new System.Drawing.Point(132, 51);
            this.txtUser.MaxLength = 20;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(186, 31);
            this.txtUser.TabIndex = 5;
            // 
            // txtNumBomb
            // 
            this.txtNumBomb.Location = new System.Drawing.Point(161, 14);
            this.txtNumBomb.MaxLength = 11;
            this.txtNumBomb.Name = "txtNumBomb";
            this.txtNumBomb.Size = new System.Drawing.Size(157, 31);
            this.txtNumBomb.TabIndex = 4;
            this.txtNumBomb.Tag = "";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(17, 91);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(112, 23);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "PASSWORD";
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(17, 54);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(109, 23);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "USERNAME";
            // 
            // lbNumBomb
            // 
            this.lbNumBomb.AutoSize = true;
            this.lbNumBomb.Location = new System.Drawing.Point(17, 17);
            this.lbNumBomb.Name = "lbNumBomb";
            this.lbNumBomb.Size = new System.Drawing.Size(138, 23);
            this.lbNumBomb.TabIndex = 0;
            this.lbNumBomb.Text = "Nº. BOMBEIRO";
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
            this.btnGuardar.Location = new System.Drawing.Point(12, 600);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 5;
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
            this.btnApagar.Location = new System.Drawing.Point(145, 600);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 30);
            this.btnApagar.TabIndex = 6;
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
            this.btnHome.Location = new System.Drawing.Point(908, 590);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 7;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 10);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.BackColor = System.Drawing.Color.Transparent;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(964, 105);
            this.lbErros.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 21);
            this.lbErros.TabIndex = 23;
            // 
            // Bombeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lbErros);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Bombeiro";
            this.Text = "Cria Bombeiro";
            this.Load += new System.EventHandler(this.Bombeiro_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRadiobuttons.ResumeLayout(false);
            this.pnlRadiobuttons.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNumBomb;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtNumBomb;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbVerBomb;
        private System.Windows.Forms.Panel pnlRadiobuttons;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lbEtipo;
        private System.Windows.Forms.Label lbEpass;
        private System.Windows.Forms.Label lbEuser;
        private System.Windows.Forms.Label lbENbomb;
        private System.Windows.Forms.Label lbErros;
    }
}