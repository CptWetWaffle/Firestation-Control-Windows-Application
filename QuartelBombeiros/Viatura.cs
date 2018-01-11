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
    public partial class Viatura : Form
    {
        private String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True;MultipleActiveResultSets=True";
        private NovaViatura t;
        public Viatura()
        {
            InitializeComponent();
        }

        private void Viatura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet.ficha_viatura' table. You can move, or remove it, as needed.
            this.ficha_viaturaTableAdapter.Fill(this.fireStationDataSet.ficha_viatura);
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand(), cmd2 = con.CreateCommand() ;
            SqlDataReader reader, reader2;
            DataTable table = new DataTable();
            table.Columns.Add("Código da Viatura", typeof(String));
            table.Columns.Add("Matricula", typeof(String));
            table.Columns.Add("Ano", typeof(String));
            table.Columns.Add("Tipo", typeof(String));
            table.Columns.Add("Data de abate", typeof(String));
            table.Columns.Add("Observações", typeof(String));
            table.Columns.Add("Seguradora", typeof(String));
            table.Columns.Add("Apolice", typeof(String));
            table.Columns.Add("Data de Seguro", typeof(String));
            table.Columns.Add("Data de Inspecção", typeof(String));
            DataRow newRow = table.NewRow();
            table.Rows.Clear();
            con.Open();
            
            cmd.CommandText = "SELECT * FROM ficha_viatura";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    newRow = table.NewRow();
                    newRow["Código da Viatura"] = reader["viatura_codigo_viatura"].ToString();
                    newRow["Matricula"] = reader["matricula"].ToString();
                    newRow["Ano"] = reader["ano"].ToString();
                    newRow["Data de abate"] = reader["data_abate"].ToString().Split(' ')[0];
                    newRow["Observações"] = reader["observacoes"].ToString();
                    newRow["Seguradora"] = reader["seguradora"].ToString();
                    newRow["Apolice"] = reader["apolice"].ToString();
                    newRow["Data de Seguro"] = reader["data_seguro"].ToString().Split(' ')[0];
                    newRow["Data de Inspecção"] = reader["inspeccao"].ToString().Split(' ')[0];
                    cmd2.CommandText = "SELECT nome FROM tipo WHERE (id_tipo='" + reader["tipo_id_tipo"].ToString() + "')";
                    reader2 = cmd2.ExecuteReader();
                    reader2.Read();
                    newRow["Tipo"] = reader2["nome"].ToString();
                    reader2.Close();
                    table.Rows.Add(newRow);
                }
            }
            reader.Close();
            dGVViat.DataSource = table;

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
                t = new NovaViatura();
                t.Show();
            }
            else
                t.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == t)
                {
                    open = true;
                }
            if (!open)
            {
                t = new NovaViatura(dGVViat.SelectedRows[0].Cells[0].FormattedValue.ToString());
                t.Show();
            }
            else
                t.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (MessageBox.Show("Tem a certeza que deseja eleminar essa viatura?", "Apagar viatura", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                String idViat = dGVViat.SelectedRows[0].Cells[0].FormattedValue.ToString();
                cmd.CommandText = "DELETE FROM viatura WHERE codigo='" + idViat + "'";
                cmd.ExecuteNonQuery();
                dGVViat.Refresh();
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
    }
}
