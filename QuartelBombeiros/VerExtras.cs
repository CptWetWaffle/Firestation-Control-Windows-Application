using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuartelBombeiros
{
    
    public partial class VerExtras : Form
    {
        private String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        private String num = "";
        private Extras ex;
        private String tipo = "";
        public VerExtras()
        {
            InitializeComponent();
        }
        public VerExtras(String tipo) : this()
        {
            this.tipo = tipo;
        }
        public VerExtras(String tipo, String num)
            : this()
        {
            this.num = num;
        }

        private void VerExtras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet.extra' table. You can move, or remove it, as needed.
            this.extraTableAdapter.Fill(this.fireStationDataSet.extra);
            if (tipo != "" )
            {
                bombToolStripTextBox.Text = tipo;
                fillByToolStripButton.PerformClick();
            }
            else if(num != "")
            {
                bombToolStripTextBox.Text = num;
                fillByToolStripButton.PerformClick();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == ex)
                {
                    open = true;
                }
            if (!open)
            {
                if (num == "")
                    ex = new Extras();
                else if(num != "")
                    ex = new Extras(num, true);
                ex.Show();
            }
            else
                ex.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (MessageBox.Show("Tem a certeza que deseja eleminar este extra?", "Apagar Extra", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                String idExtra = dGVBomb.SelectedRows[0].Cells[0].FormattedValue.ToString();
                cmd.CommandText = "DELETE FROM extra WHERE id_extra='" + idExtra + "'";
                cmd.ExecuteNonQuery();
                dGVBomb.Refresh();
                con.Close();
            }
            else
                return;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == ex)
                {
                    open = true;
                }
            if (!open)
            {
                ex = new Extras(dGVBomb.SelectedRows[0].Cells[0].FormattedValue.ToString());
                ex.Show();
            }
            else
                ex.Focus();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.extraTableAdapter.FillBy(this.fireStationDataSet.extra, ((int)(System.Convert.ChangeType(bombToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
