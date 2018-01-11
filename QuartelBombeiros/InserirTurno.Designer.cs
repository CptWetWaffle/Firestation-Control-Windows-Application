namespace QuartelBombeiros
{
    partial class InserirTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirTurno));
            this.lbTurno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cblViat = new System.Windows.Forms.CheckedListBox();
            this.cblBombeiros = new System.Windows.Forms.CheckedListBox();
            this.lbEDataFim = new System.Windows.Forms.Label();
            this.lbEDatInic = new System.Windows.Forms.Label();
            this.lbEPosto = new System.Windows.Forms.Label();
            this.lbEHorario = new System.Windows.Forms.Label();
            this.cmbDatFimDD = new System.Windows.Forms.ComboBox();
            this.cmbDatFimMM = new System.Windows.Forms.ComboBox();
            this.cmbDatFimYYYY = new System.Windows.Forms.ComboBox();
            this.cmbDatInicDD = new System.Windows.Forms.ComboBox();
            this.cmbDatInicMM = new System.Windows.Forms.ComboBox();
            this.cmbDatInicYYYY = new System.Windows.Forms.ComboBox();
            this.txtPosto = new System.Windows.Forms.TextBox();
            this.txtHor = new System.Windows.Forms.TextBox();
            this.lbDataFim = new System.Windows.Forms.Label();
            this.lbDatIni = new System.Windows.Forms.Label();
            this.lbPosto = new System.Windows.Forms.Label();
            this.lbHor = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbErros = new System.Windows.Forms.Label();
            this.lblBomb = new System.Windows.Forms.Label();
            this.lblViat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTurno
            // 
            this.lbTurno.AutoSize = true;
            this.lbTurno.BackColor = System.Drawing.Color.Transparent;
            this.lbTurno.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTurno.Location = new System.Drawing.Point(1, 23);
            this.lbTurno.Name = "lbTurno";
            this.lbTurno.Size = new System.Drawing.Size(301, 47);
            this.lbTurno.TabIndex = 24;
            this.lbTurno.Text = "INSERIR TURNO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblViat);
            this.panel1.Controls.Add(this.lblBomb);
            this.panel1.Controls.Add(this.cblViat);
            this.panel1.Controls.Add(this.cblBombeiros);
            this.panel1.Controls.Add(this.lbEDataFim);
            this.panel1.Controls.Add(this.lbEDatInic);
            this.panel1.Controls.Add(this.lbEPosto);
            this.panel1.Controls.Add(this.lbEHorario);
            this.panel1.Controls.Add(this.cmbDatFimDD);
            this.panel1.Controls.Add(this.cmbDatFimMM);
            this.panel1.Controls.Add(this.cmbDatFimYYYY);
            this.panel1.Controls.Add(this.cmbDatInicDD);
            this.panel1.Controls.Add(this.cmbDatInicMM);
            this.panel1.Controls.Add(this.cmbDatInicYYYY);
            this.panel1.Controls.Add(this.txtPosto);
            this.panel1.Controls.Add(this.txtHor);
            this.panel1.Controls.Add(this.lbDataFim);
            this.panel1.Controls.Add(this.lbDatIni);
            this.panel1.Controls.Add(this.lbPosto);
            this.panel1.Controls.Add(this.lbHor);
            this.panel1.Location = new System.Drawing.Point(13, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 488);
            this.panel1.TabIndex = 30;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cblViat
            // 
            this.cblViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblViat.FormattingEnabled = true;
            this.cblViat.IntegralHeight = false;
            this.cblViat.Location = new System.Drawing.Point(297, 193);
            this.cblViat.Name = "cblViat";
            this.cblViat.Size = new System.Drawing.Size(176, 281);
            this.cblViat.Sorted = true;
            this.cblViat.TabIndex = 132;
            // 
            // cblBombeiros
            // 
            this.cblBombeiros.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblBombeiros.FormattingEnabled = true;
            this.cblBombeiros.IntegralHeight = false;
            this.cblBombeiros.Location = new System.Drawing.Point(113, 193);
            this.cblBombeiros.Name = "cblBombeiros";
            this.cblBombeiros.Size = new System.Drawing.Size(176, 281);
            this.cblBombeiros.Sorted = true;
            this.cblBombeiros.TabIndex = 131;
            // 
            // lbEDataFim
            // 
            this.lbEDataFim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEDataFim.AutoSize = true;
            this.lbEDataFim.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEDataFim.ForeColor = System.Drawing.Color.Red;
            this.lbEDataFim.Location = new System.Drawing.Point(326, 126);
            this.lbEDataFim.Name = "lbEDataFim";
            this.lbEDataFim.Size = new System.Drawing.Size(18, 23);
            this.lbEDataFim.TabIndex = 130;
            this.lbEDataFim.Text = "*";
            this.lbEDataFim.Visible = false;
            // 
            // lbEDatInic
            // 
            this.lbEDatInic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEDatInic.AutoSize = true;
            this.lbEDatInic.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEDatInic.ForeColor = System.Drawing.Color.Red;
            this.lbEDatInic.Location = new System.Drawing.Point(326, 89);
            this.lbEDatInic.Name = "lbEDatInic";
            this.lbEDatInic.Size = new System.Drawing.Size(18, 23);
            this.lbEDatInic.TabIndex = 129;
            this.lbEDatInic.Text = "*";
            this.lbEDatInic.Visible = false;
            // 
            // lbEPosto
            // 
            this.lbEPosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEPosto.AutoSize = true;
            this.lbEPosto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEPosto.ForeColor = System.Drawing.Color.Red;
            this.lbEPosto.Location = new System.Drawing.Point(326, 52);
            this.lbEPosto.Name = "lbEPosto";
            this.lbEPosto.Size = new System.Drawing.Size(18, 23);
            this.lbEPosto.TabIndex = 128;
            this.lbEPosto.Text = "*";
            this.lbEPosto.Visible = false;
            // 
            // lbEHorario
            // 
            this.lbEHorario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbEHorario.AutoSize = true;
            this.lbEHorario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEHorario.ForeColor = System.Drawing.Color.Red;
            this.lbEHorario.Location = new System.Drawing.Point(326, 15);
            this.lbEHorario.Name = "lbEHorario";
            this.lbEHorario.Size = new System.Drawing.Size(18, 23);
            this.lbEHorario.TabIndex = 127;
            this.lbEHorario.Text = "*";
            this.lbEHorario.Visible = false;
            // 
            // cmbDatFimDD
            // 
            this.cmbDatFimDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatFimDD.Enabled = false;
            this.cmbDatFimDD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatFimDD.FormattingEnabled = true;
            this.cmbDatFimDD.IntegralHeight = false;
            this.cmbDatFimDD.Location = new System.Drawing.Point(114, 124);
            this.cmbDatFimDD.Name = "cmbDatFimDD";
            this.cmbDatFimDD.Size = new System.Drawing.Size(43, 30);
            this.cmbDatFimDD.TabIndex = 50;
            // 
            // cmbDatFimMM
            // 
            this.cmbDatFimMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatFimMM.Enabled = false;
            this.cmbDatFimMM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatFimMM.FormattingEnabled = true;
            this.cmbDatFimMM.IntegralHeight = false;
            this.cmbDatFimMM.Location = new System.Drawing.Point(163, 124);
            this.cmbDatFimMM.Name = "cmbDatFimMM";
            this.cmbDatFimMM.Size = new System.Drawing.Size(43, 30);
            this.cmbDatFimMM.TabIndex = 49;
            this.cmbDatFimMM.SelectedIndexChanged += new System.EventHandler(this.cmbDatFimMM_SelectedIndexChanged);
            // 
            // cmbDatFimYYYY
            // 
            this.cmbDatFimYYYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatFimYYYY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatFimYYYY.FormattingEnabled = true;
            this.cmbDatFimYYYY.IntegralHeight = false;
            this.cmbDatFimYYYY.Location = new System.Drawing.Point(212, 124);
            this.cmbDatFimYYYY.Name = "cmbDatFimYYYY";
            this.cmbDatFimYYYY.Size = new System.Drawing.Size(74, 30);
            this.cmbDatFimYYYY.TabIndex = 48;
            this.cmbDatFimYYYY.SelectedIndexChanged += new System.EventHandler(this.cmbDatFimYYYY_SelectedIndexChanged);
            // 
            // cmbDatInicDD
            // 
            this.cmbDatInicDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatInicDD.Enabled = false;
            this.cmbDatInicDD.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatInicDD.FormattingEnabled = true;
            this.cmbDatInicDD.IntegralHeight = false;
            this.cmbDatInicDD.Location = new System.Drawing.Point(143, 87);
            this.cmbDatInicDD.Name = "cmbDatInicDD";
            this.cmbDatInicDD.Size = new System.Drawing.Size(43, 30);
            this.cmbDatInicDD.TabIndex = 47;
            // 
            // cmbDatInicMM
            // 
            this.cmbDatInicMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatInicMM.Enabled = false;
            this.cmbDatInicMM.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatInicMM.FormattingEnabled = true;
            this.cmbDatInicMM.IntegralHeight = false;
            this.cmbDatInicMM.Location = new System.Drawing.Point(192, 87);
            this.cmbDatInicMM.Name = "cmbDatInicMM";
            this.cmbDatInicMM.Size = new System.Drawing.Size(43, 30);
            this.cmbDatInicMM.TabIndex = 46;
            this.cmbDatInicMM.SelectedIndexChanged += new System.EventHandler(this.cmbDatInicMM_SelectedIndexChanged);
            // 
            // cmbDatInicYYYY
            // 
            this.cmbDatInicYYYY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatInicYYYY.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDatInicYYYY.FormattingEnabled = true;
            this.cmbDatInicYYYY.IntegralHeight = false;
            this.cmbDatInicYYYY.Location = new System.Drawing.Point(241, 87);
            this.cmbDatInicYYYY.Name = "cmbDatInicYYYY";
            this.cmbDatInicYYYY.Size = new System.Drawing.Size(74, 30);
            this.cmbDatInicYYYY.TabIndex = 45;
            this.cmbDatInicYYYY.SelectedIndexChanged += new System.EventHandler(this.cmbDatInicYYYY_SelectedIndexChanged);
            // 
            // txtPosto
            // 
            this.txtPosto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosto.Location = new System.Drawing.Point(90, 50);
            this.txtPosto.Name = "txtPosto";
            this.txtPosto.Size = new System.Drawing.Size(230, 31);
            this.txtPosto.TabIndex = 44;
            // 
            // txtHor
            // 
            this.txtHor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHor.Location = new System.Drawing.Point(115, 13);
            this.txtHor.Name = "txtHor";
            this.txtHor.Size = new System.Drawing.Size(205, 31);
            this.txtHor.TabIndex = 43;
            // 
            // lbDataFim
            // 
            this.lbDataFim.AutoSize = true;
            this.lbDataFim.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataFim.Location = new System.Drawing.Point(13, 126);
            this.lbDataFim.Name = "lbDataFim";
            this.lbDataFim.Size = new System.Drawing.Size(95, 23);
            this.lbDataFim.TabIndex = 42;
            this.lbDataFim.Text = "DATA FIM";
            // 
            // lbDatIni
            // 
            this.lbDatIni.AutoSize = true;
            this.lbDatIni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatIni.Location = new System.Drawing.Point(13, 89);
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
            this.btnHome.Location = new System.Drawing.Point(845, 577);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 50);
            this.btnHome.TabIndex = 47;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            this.btnApagar.Location = new System.Drawing.Point(124, 587);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(105, 30);
            this.btnApagar.TabIndex = 32;
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
            this.btnGuardar.Location = new System.Drawing.Point(13, 587);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::QuartelBombeiros.Properties.Resources.linha;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(485, 3);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // lbErros
            // 
            this.lbErros.AutoSize = true;
            this.lbErros.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErros.Location = new System.Drawing.Point(901, 83);
            this.lbErros.MaximumSize = new System.Drawing.Size(350, 0);
            this.lbErros.Name = "lbErros";
            this.lbErros.Size = new System.Drawing.Size(0, 24);
            this.lbErros.TabIndex = 48;
            this.lbErros.UseCompatibleTextRendering = true;
            // 
            // lblBomb
            // 
            this.lblBomb.AutoSize = true;
            this.lblBomb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomb.Location = new System.Drawing.Point(140, 167);
            this.lblBomb.Name = "lblBomb";
            this.lblBomb.Size = new System.Drawing.Size(117, 23);
            this.lblBomb.TabIndex = 133;
            this.lblBomb.Text = "BOMBEIROS";
            // 
            // lblViat
            // 
            this.lblViat.AutoSize = true;
            this.lblViat.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViat.Location = new System.Drawing.Point(334, 167);
            this.lblViat.Name = "lblViat";
            this.lblViat.Size = new System.Drawing.Size(98, 23);
            this.lblViat.TabIndex = 134;
            this.lblViat.Text = "VIATURAS";
            // 
            // InserirTurno
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
            this.Controls.Add(this.lbTurno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirTurno";
            this.Text = "Inserir Turno";
            this.Load += new System.EventHandler(this.Turno_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTurno;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPosto;
        private System.Windows.Forms.TextBox txtHor;
        private System.Windows.Forms.Label lbDataFim;
        private System.Windows.Forms.Label lbDatIni;
        private System.Windows.Forms.Label lbPosto;
        private System.Windows.Forms.Label lbHor;
        public System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnApagar;
        public System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.ComboBox cmbDatFimDD;
        private System.Windows.Forms.ComboBox cmbDatFimMM;
        private System.Windows.Forms.ComboBox cmbDatFimYYYY;
        private System.Windows.Forms.ComboBox cmbDatInicDD;
        private System.Windows.Forms.ComboBox cmbDatInicMM;
        private System.Windows.Forms.ComboBox cmbDatInicYYYY;
        private System.Windows.Forms.Label lbEDataFim;
        private System.Windows.Forms.Label lbEDatInic;
        private System.Windows.Forms.Label lbEPosto;
        private System.Windows.Forms.Label lbEHorario;
        private System.Windows.Forms.Label lbErros;
        private System.Windows.Forms.CheckedListBox cblBombeiros;
        private System.Windows.Forms.CheckedListBox cblViat;
        private System.Windows.Forms.Label lblViat;
        private System.Windows.Forms.Label lblBomb;
    }
}