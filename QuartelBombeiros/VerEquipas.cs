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
    public partial class VerEquipas : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        private AtribuirEquipas eq;
        public VerEquipas()
        {
            InitializeComponent();
        }

        private void VerEquipas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet12.ficha_bombeiro' table. You can move, or remove it, as needed.
            this.ficha_bombeiroTableAdapter1.Fill(this.fireStationDataSet12.ficha_bombeiro);
            //// TODO: This line of code loads data into the 'fireStationDataSet11.ficha_bombeiro' table. You can move, or remove it, as needed.
            //this.ficha_bombeiroTableAdapter.Fill(this.fireStationDataSet11.ficha_bombeiro);
            // TODO: This line of code loads data into the 'fireStationDataSet10.bombeiro' table. You can move, or remove it, as needed.
            this.bombeiroTableAdapter.Fill(this.fireStationDataSet10.bombeiro);
            // TODO: This line of code loads data into the 'fireStationDataSet9.equipa_bombeiro' table. You can move, or remove it, as needed.
            this.equipa_bombeiroTableAdapter.Fill(this.fireStationDataSet9.equipa_bombeiro);
            // TODO: This line of code loads data into the 'fireStationDataSet2.equipa' table. You can move, or remove it, as needed.
            this.equipaTableAdapter.Fill(this.fireStationDataSet2.equipa);

            equipToolStripTextBox1.Text = "0";
            fillByToolStripButton1.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == eq)
                {
                    open = true;
                }
            if (!open)
            {
                eq = new AtribuirEquipas();
                eq.Show();
            }
            else
                eq.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (MessageBox.Show("Tem a certeza que deseja eleminar esta equipa?", "Apagar Equipa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                String idEquip = dGVEquipas.SelectedRows[0].Cells[0].FormattedValue.ToString();
                cmd.CommandText = "DELETE FROM equipa WHERE id_equipa='" + idEquip + "'";
                cmd.ExecuteNonQuery();
                dGVEquipas.Refresh();
                con.Close();
            }
            else
                return;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == eq)
                {
                    open = true;
                }
            if (!open)
            {
                eq = new AtribuirEquipas(dGVEquipas.SelectedRows[0].Cells[0].FormattedValue.ToString());
                eq.Show();
            }
            else
                eq.Focus();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ficha_bombeiroTableAdapter.FillBy(this.fireStationDataSet11.ficha_bombeiro, ((int)(System.Convert.ChangeType(equipToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dGVEquipas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            equipToolStripTextBox1.Text = dGVEquipas.SelectedRows[0].Cells[0].FormattedValue.ToString();
            fillByToolStripButton1.PerformClick();
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.ficha_bombeiroTableAdapter1.FillBy(this.fireStationDataSet12.ficha_bombeiro, ((int)(System.Convert.ChangeType(equipToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
