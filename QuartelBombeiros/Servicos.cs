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
    public partial class Servicos : Form
    {
        private String numB;
        public Servicos()
        {
            InitializeComponent();
        }
        public Servicos(String num) : this()
        {
            this.numB = num;
        }

        private void dGVServ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Servicos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sServicos.occorencia' table. You can move, or remove it, as needed.
            this.occorenciaTableAdapter1.Fill(this.sServicos.occorencia);
            //// TODO: This line of code loads data into the 'servico.occorencia' table. You can move, or remove it, as needed.
            //this.occorenciaTableAdapter.Fill(this.servico.occorencia);
            if (numB != "")
            {
                bombToolStripTextBox1.Text = numB;
                fillByToolStripButton1.PerformClick();
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.occorenciaTableAdapter.FillBy(this.servico.occorencia, ((int)(System.Convert.ChangeType(bombToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.occorenciaTableAdapter1.FillBy(this.sServicos.occorencia, ((int)(System.Convert.ChangeType(bombToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
