namespace QuartelBombeiros
{
    partial class Kilometragem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kilometragem));
            this.btnGuardarOcc = new System.Windows.Forms.Button();
            this.btnApagarOcc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnGuardarOcc
            // 
            this.btnGuardarOcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardarOcc.AutoSize = true;
            this.btnGuardarOcc.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarOcc.BackgroundImage = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnGuardarOcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarOcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarOcc.FlatAppearance.BorderSize = 0;
            this.btnGuardarOcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarOcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardarOcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarOcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarOcc.ForeColor = System.Drawing.Color.White;
            this.btnGuardarOcc.Location = new System.Drawing.Point(12, 373);
            this.btnGuardarOcc.Name = "btnGuardarOcc";
            this.btnGuardarOcc.Size = new System.Drawing.Size(105, 30);
            this.btnGuardarOcc.TabIndex = 6;
            this.btnGuardarOcc.Text = "GUARDAR";
            this.btnGuardarOcc.UseVisualStyleBackColor = false;
            // 
            // btnApagarOcc
            // 
            this.btnApagarOcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApagarOcc.AutoSize = true;
            this.btnApagarOcc.BackColor = System.Drawing.Color.Transparent;
            this.btnApagarOcc.BackgroundImage = global::QuartelBombeiros.Properties.Resources.butao;
            this.btnApagarOcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApagarOcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApagarOcc.FlatAppearance.BorderSize = 0;
            this.btnApagarOcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnApagarOcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnApagarOcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarOcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarOcc.ForeColor = System.Drawing.Color.White;
            this.btnApagarOcc.Location = new System.Drawing.Point(123, 373);
            this.btnApagarOcc.Name = "btnApagarOcc";
            this.btnApagarOcc.Size = new System.Drawing.Size(105, 30);
            this.btnApagarOcc.TabIndex = 8;
            this.btnApagarOcc.Text = "APAGAR";
            this.btnApagarOcc.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 355);
            this.panel1.TabIndex = 9;
            // 
            // Kilometragem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuartelBombeiros.Properties.Resources.fundo1;
            this.ClientSize = new System.Drawing.Size(362, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnApagarOcc);
            this.Controls.Add(this.btnGuardarOcc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kilometragem";
            this.Text = "Quilometragem";
            this.Load += new System.EventHandler(this.Kilometragem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardarOcc;
        public System.Windows.Forms.Button btnApagarOcc;
        private System.Windows.Forms.Panel panel1;
    }
}