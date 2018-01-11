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
    public partial class Turno : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        private InserirTurno t;
        private String tipo = "";
        public Turno()
        {
            InitializeComponent();
        }

        public Turno(String tipo)
            : this()
        {
            this.tipo = tipo;
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Turno_Load(object sender, EventArgs e)
        {

            this.turnoTableAdapter.Fill(this.fireStationDataSet.turno);
            DataTable table = new DataTable();
            table.Columns.Add("Número de Bombeiro", typeof(int));
            table.Columns.Add("Nome", typeof(String));
            dGVBomb.DataSource = table;
            table = new DataTable();
            table.Columns.Add("Código da Viatura", typeof(int));
            table.Columns.Add("Matricula", typeof(String));
            dGVViat.DataSource = table;
            if (tipo.ToLower() != "a")
            {
                btnAdd.Hide();
                btnEdit.Hide();
                btnDelete.Hide();
            }
        }

        private void dGVTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "SELECT bombeiro_num_bombeiro, nome FROM ficha_bombeiro, turno_bombeiro WHERE (bombeiro_num_bombeiro=bombeiro_numero_bombeiro AND turno_id_turno ='" + dGVTurno.SelectedRows[0].Cells[0].FormattedValue.ToString() + "')";
            SqlDataReader reader;
            DataTable table = (DataTable)dGVBomb.DataSource;
            DataRow newRow = table.NewRow();
            table.Rows.Clear();
            dGVBomb.Show();
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newRow = table.NewRow();
                    newRow["Número de Bombeiro"] = reader["bombeiro_num_bombeiro"].ToString();
                    newRow["Nome"] = reader["nome"].ToString();
                    table.Rows.Add(newRow);
                }
            }
            reader.Close();
            DataTable table2 = (DataTable)dGVViat.DataSource;
            DataRow newe = table2.NewRow();
            table2.Rows.Clear();
            cmd.CommandText = "SELECT codigo, matricula FROM viatura, ficha_viatura, turno_viatura WHERE matricula=ficha_viatura_matricula AND codigo=turno_viatura.viatura_codigo_viatura AND turno_id_turno='" + dGVTurno.SelectedRows[0].Cells[0].FormattedValue.ToString() + "'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newe["Código da Viatura"] = Convert.ToInt32(reader["codigo"].ToString());
                    newe["Matricula"] = reader["matricula"].ToString();
                    table2.Rows.Add(newe);
                }
            }
            reader.Close();
            dGVViat.Show();
            con.Close();

        }

        private void fichabombeiroBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == t)
                {
                    open = true;
                }
            if (!open)
            {
                t = new InserirTurno();
                t.Show();
            }
            else
                t.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String idTurno;
            idTurno = dGVTurno.SelectedRows[0].Cells[0].FormattedValue.ToString();
            InserirTurno f = new InserirTurno(idTurno);
            f.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (MessageBox.Show("Tem a certeza que deseja eleminar esse turno?", "Apagar Turno", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                String idTurno = dGVTurno.SelectedRows[0].Cells[0].FormattedValue.ToString();
                cmd.CommandText = "DELETE FROM turno WHERE id_turno='" + idTurno + "'";
                cmd.ExecuteNonQuery();
                dGVBomb.Refresh();
                con.Close();
            }
            else
                return;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
