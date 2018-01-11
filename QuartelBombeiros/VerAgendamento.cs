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
    public partial class VerAgendamento : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        private NovoAgendamento a;
        public VerAgendamento()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VerAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet.agendamento' table. You can move, or remove it, as needed.
            this.agendamentoTableAdapter.Fill(this.fireStationDataSet.agendamento);
            DataTable table = new DataTable();
            table.Columns.Add("ID Equipa", typeof(String));
            table.Columns.Add("Viatura", typeof(String));
            
            dGVEquip.DataSource = table;
        }

        private void dGVAgend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT * FROM equipa, agendamento_viatura WHERE (equipa.viatura_codigo_viatura = agendamento_viatura.viatura_codigo AND agendamento_id_agendamento = '" + dGVAgend.SelectedRows[0].Cells[0].FormattedValue.ToString() + "')";
            SqlDataReader reader;
            DataTable table = (DataTable)dGVEquip.DataSource;
            DataRow newRow = table.NewRow();
            table.Rows.Clear();
            dGVEquip.Show();
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newRow = table.NewRow();
                    newRow["ID Equipa"] = reader["id_equipa"].ToString();
                    newRow["Viatura"] = reader["viatura_codigo_viatura"].ToString();
                    table.Rows.Add(newRow);
                }
            }
            reader.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == a)
                {
                    open = true;
                }
            if (!open)
            {
                a = new NovoAgendamento();
                a.Show();
            }
            else
                a.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (MessageBox.Show("Tem a certeza que deseja eleminar este agendamento?", "Apagar Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                String idAgend = dGVAgend.SelectedRows[0].Cells[0].FormattedValue.ToString();
                cmd.CommandText = "DELETE FROM agendamento WHERE id_agendamento='" + idAgend + "'";
                cmd.ExecuteNonQuery();
                dGVAgend.Refresh();
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
                if (f == a)
                {
                    open = true;
                }
            if (!open)
            {
                a = new NovoAgendamento(dGVAgend.SelectedRows[0].Cells[0].FormattedValue.ToString());
                a.Show();
            }
            else
                a.Focus();
        }
    }
}
