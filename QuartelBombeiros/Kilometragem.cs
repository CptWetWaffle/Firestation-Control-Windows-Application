using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuartelBombeiros
{
    public partial class Kilometragem : Form
    {
        public Kilometragem()
        {
            InitializeComponent();
        }

        private void Kilometragem_Load(object sender, EventArgs e)
        {
            TextBox t;
            Label l;
            for (int i = 0; i < 10;i++ )
            {
                l = new Label();
                l.Name = "quilometragem" + i.ToString();
                l.Visible = true;
                l.Text = "quilometragem" + i.ToString();
                l.Location = new Point(0, 50 * i);
                l.Font = new Font("Century Gothic", 14.25f);
                l.Size = new Size(165,50);
                t = new TextBox();
                t.Name = "Teste";
                t.Visible = true;
                t.Location = new Point(175,  50*i);
                t.Font = new Font("Century Gothic", 12.25f);
                this.panel1.Controls.Add(l);
                this.panel1.Controls.Add(t);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
