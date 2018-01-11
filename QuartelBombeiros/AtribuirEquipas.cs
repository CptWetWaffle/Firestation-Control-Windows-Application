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
    public partial class AtribuirEquipas : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        private String id = "";
        private bool up = false;
        public AtribuirEquipas()
        {
            InitializeComponent();
        }

        public AtribuirEquipas(String id)
        {
            this.id = id;
            up = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbEbomb.Visible = false;
            lbEViat.Visible = false;
            lbErros.Text = "";

            String viat = "", id = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            bool erro = false;
            if (cmbViat.SelectedItem != null)
                viat = cmbViat.SelectedValue.ToString();

            if (viat == "")
            {
                lbEViat.Visible = true;
                erro = true;
                lbErros.Text += "Tem de seleccionar uma viatura. \n";
            }
            if (cblBombeiros.CheckedItems.Count == 0)
            {
                lbEbomb.Visible = true;
                erro = true;
                lbErros.Text += "Tem de seleccionar pelo menos um bombeiro. \n";
            }
            if (erro == true)
            {
                MessageBox.Show("Existem campos incorectos");
                return;
            }

            con.Open();
            if (up)
            {
                cmd.CommandText = "DELETE FROM equipa_bombeiro WHERE equipa_id_equipa='" + id + "'";
                cmd.ExecuteNonQuery();
                for (int i = 0; i < cblBombeiros.CheckedItems.Count; i++)
                {
                    cmd.CommandText = "INSERT INTO equipa_bombeiro (equipa_id_equipa, bombeiro_numero_bombeiro) VALUES ('" + id + "', '" + cblBombeiros.CheckedItems[i].ToString() + "')";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Actualizou uma equipa com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < cblBombeiros.CheckedItems.Count; i++)
                {
                    cmd.CommandText = "SELECT * FROM equipa, equipa_bombeiro WHERE viatura_codigo_viatura='" + viat + "' AND id_equipa=equipa_id_equipa AND bombeiro_numero_bombeiro='" + cblBombeiros.CheckedItems[i].ToString() + "'";
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Esse bombeiro já está nessa equipa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    reader.Close();
                }
                cmd.CommandText = "INSERT INTO equipa (viatura_codigo_viatura) VALUES ('" + viat + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT TOP 1 id_equipa FROM equipa ORDER BY id_equipa DESC";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = reader[0].ToString();
                }
                reader.Close();
                for (int i = 0; i < cblBombeiros.CheckedItems.Count; i++)
                {
                    cmd.CommandText = "INSERT INTO equipa_bombeiro (bombeiro_numero_bombeiro, equipa_id_equipa) VALUES ('" + cblBombeiros.CheckedItems[i].ToString() + "', '" + id + "')";
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Inseriu uma equipa com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void AtribuirEquipas_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'fireStationDataSet.viatura' table. You can move, or remove it, as needed.
            this.viaturaTableAdapter.Fill(this.fireStationDataSet.viatura);
            SqlConnection con = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM ficha_bombeiro", con);
            SqlDataReader reader;
            cmbViat.SelectedIndex = -1;
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cblBombeiros.Items.Add(reader["bombeiro_num_bombeiro"]);
            reader.Close();

            if (up)
            {
                cmd.CommandText = "SELECT * FROM equipa WHERE id_equipa='" + id + "'";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    cmbViat.SelectedItem = reader["viatura_codigo_viatura"];
                }
                reader.Close();
                cmd.CommandText = "SELECT * FROM equipa_bombeiro WHERE equipa_id_equipa='" + id + "'";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cblBombeiros.SetItemChecked(cblBombeiros.Items.IndexOf(reader["bombeiro_numero_bombeiro"]), true);
                    }

                }
                reader.Close();
            }
            con.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            cmbViat.SelectedIndex = -1;
            for (int i = 0; i < cblBombeiros.Items.Count; i++)
            {
                cblBombeiros.SetItemChecked(i, false);
            }
            lbEbomb.Visible = false;
            lbEViat.Visible = false;
            lbErros.Text = "";
        }

        private void cblBombeiros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
