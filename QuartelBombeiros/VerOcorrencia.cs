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
    public partial class VerOcorrencia : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        private Ocorrencia o;
        public VerOcorrencia()
        {
            InitializeComponent();
        }

        private void VerOcorrencia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet4.occorencia' table. You can move, or remove it, as needed.
            this.occorenciaTableAdapter1.Fill(this.fireStationDataSet4.occorencia);
            // TODO: This line of code loads data into the 'fireStationDataSet3.registo_comunicacoes' table. You can move, or remove it, as needed.
            this.registo_comunicacoesTableAdapter1.Fill(this.fireStationDataSet3.registo_comunicacoes);
            // TODO: This line of code loads data into the 'fireStationDataSet.ficha_viatura' table. You can move, or remove it, as needed.
            this.ficha_viaturaTableAdapter.Fill(this.fireStationDataSet.ficha_viatura);
            paramToolStripTextBox.Text = "0";
            fillByToolStripButton.PerformClick();
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == o)
                {
                    open = true;
                }
            if (!open)
            {
                o = new Ocorrencia();
                o.Show();
            }
            else
                o.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (MessageBox.Show("Tem a certeza que deseja eleminar esta ocorrência?", "Apagar Ocorrência", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                String idOco = dGVOco.SelectedRows[0].Cells[0].FormattedValue.ToString();
                cmd.CommandText = "DELETE FROM occorencia WHERE id_occorencia='" + idOco + "'";
                cmd.ExecuteNonQuery();
                dGVOco.Refresh();
                con.Close();
            }
            else
                return;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.registo_comunicacoesTableAdapter1.FillBy(this.fireStationDataSet3.registo_comunicacoes, new System.Nullable<int>(((int)(System.Convert.ChangeType(paramToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void paramToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void dGVOco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            paramToolStripTextBox.Text = dGVOco.SelectedRows[0].Cells[0].FormattedValue.ToString();
            fillByToolStripButton.PerformClick();
            
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
                if (f == o)
                {
                    open = true;
                }
            if (!open)
            {
                o = new Ocorrencia(dGVOco.SelectedRows[0].Cells[0].FormattedValue.ToString());
                o.Show();
            }
            else
                o.Focus();
        }
    }
}
