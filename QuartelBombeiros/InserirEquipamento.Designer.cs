namespace QuartelBombeiros
{
    partial class InserirEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirEquipamento));
            this.lbInsEquip = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lbEBombViat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbViat = new System.Windows.Forms.RadioButton();
            this.rbBomb = new System.Windows.Forms.RadioButton();
            this.lbEQuant = new System.Windows.Forms.Label();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.lbENome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lbErros = new System.Windows.Forms.Label();
            this.lbQuant = new System.Windows.Forms.Label();
            this.lbNQuant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInsEquip
            // 
            this.lbInsEquip.AutoSize = true;
            this.lbInsEquip.BackColor = System.Drawing.Color.Transparent;
            this.lbInsEquip.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.lbInsEquip.Location = new System.Drawing.Point(3, 23);
            this.lbInsEquip.Margin = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.lbInsEquip.Name = "lbInsEquip";
            this.lbInsEquip.Size = new System.Drawing.Size(453, 47);
            this.lbInsEquip.TabIndex = 2;
            this.lbInsEquip.Text = "INSERIR EQUIPAMENTO";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 3);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbNQuant);
            this.panel1.Controls.Add(this.lbQuant);
            this.panel1.Controls.Add(this.lbDesc);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.lbEBombViat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbEQuant);
            this.panel1.Controls.Add(this.txtQuant);
            this.panel1.Controls.Add(this.lbENome);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Location = new System.Drawing.Point(13, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 488);
            this.panel1.TabIndex = 41;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesc.Location = new System.Drawing.Point(13, 126);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(119, 23);
            this.lbDesc.TabIndex = 134;
            this.lbDesc.Text = "DESCRIÇÃO";
            // 
            // txtDesc
            // 
            this.txtDesc.AllowDrop = true;
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(17, 152);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(848, 159);
            this.txtDesc.TabIndex = 133;
            // 
            // lbEBombViat
            // 
            this.lbEBombViat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEBombViat.AutoSize = true;
            this.lbEBombViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEBombViat.ForeColor = System.Drawing.Color.Red;
            this.lbEBombViat.Location = new System.Drawing.Point(273, 89);
            this.lbEBombViat.Name = "lbEBombViat";
            this.lbEBombViat.Size = new System.Drawing.Size(18, 23);
            this.lbEBombViat.TabIndex = 132;
            this.lbEBombViat.Text = "*";
            this.lbEBombViat.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.rbViat);
            this.panel2.Controls.Add(this.rbBomb);
            this.panel2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(13, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 25);
            this.panel2.TabIndex = 131;
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
            // lbEQuant
            // 
            this.lbEQuant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEQuant.AutoSize = true;
            this.lbEQuant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEQuant.ForeColor = System.Drawing.Color.Red;
            this.lbEQuant.Location = new System.Drawing.Point(297, 52);
            this.lbEQuant.Name = "lbEQuant";
            this.lbEQuant.Size = new System.Drawing.Size(18, 23);
            this.lbEQuant.TabIndex = 130;
            this.lbEQuant.Text = "*";
            this.lbEQuant.Visible = false;
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(149, 50);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(142, 31);
            this.txtQuant.TabIndex = 129;
            // 
            // lbENome
            // 
            this.lbENome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbENome.AutoSize = true;
            this.lbENome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbENome.ForeColor = System.Drawing.Color.Red;
            this.lbENome.Location = new System.Drawing.Point(297, 15);
            this.lbENome.Name = "lbENome";
            this.lbENome.Size = new System.Drawing.Size(18, 23);
            this.lbENome.TabIndex = 127;
            this.lbENome.Text = "*";
            this.lbENome.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(86, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(205, 31);
            this.txtNome.TabIndex = 43;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(13, 15);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(67, 23);
            this.lbNome.TabIndex = 39;
            this.lbNome.Text = "NOME";
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
            this.btnGuardar.Location = new System.Drawing.Point(13, 604);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 42;
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
            this.btnApagar.Location = new System.Drawing.Point(124, 604);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 30);
            this.btnApagar.TabIndex = 43;
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
            this.btnHome.Location = new System.Drawing.Point(845, 594);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 44;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.BackColor = System.Drawing.Color.Transparent;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(901, 83);
            this.lbErros.MaximumSize = new System.Drawing.Size(200, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 21);
            this.lbErros.TabIndex = 45;
            // 
            // lbQuant
            // 
            this.lbQuant.AutoSize = true;
            this.lbQuant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuant.Location = new System.Drawing.Point(321, 52);
            this.lbQuant.Name = "lbQuant";
            this.lbQuant.Size = new System.Drawing.Size(0, 23);
            this.lbQuant.TabIndex = 135;
            // 
            // lbNQuant
            // 
            this.lbNQuant.AutoSize = true;
            this.lbNQuant.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNQuant.Location = new System.Drawing.Point(13, 52);
            this.lbNQuant.Name = "lbNQuant";
            this.lbNQuant.Size = new System.Drawing.Size(130, 23);
            this.lbNQuant.TabIndex = 136;
            this.lbNQuant.Text = "QUANTIDADE";
            // 
            // InserirEquipamento
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
            this.Controls.Add(this.lbInsEquip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirEquipamento";
            this.Text = "Inserir Equipamento";
            this.Load += new System.EventHandler(this.InserirEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInsEquip;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbENome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEQuant;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbViat;
        private System.Windows.Forms.RadioButton rbBomb;
        private System.Windows.Forms.Label lbEBombViat;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lbNQuant;
        private System.Windows.Forms.Label lbQuant;
    }
}