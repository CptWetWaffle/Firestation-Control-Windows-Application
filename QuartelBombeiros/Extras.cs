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
    public partial class Extras : Form
    {
        private String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        private String id = "";
        private bool t;
        public Extras()
        {
            InitializeComponent();
        }
        public Extras(String num)
            : this()
        {
            id = num;
        }
        public Extras(String num, bool t)
            : this()
        {
            id = num;
            this.t = true;
        }

        private void lbTipo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbEbomb.Visible = false;
            lbEtipo.Visible = false;
            lbEDesc.Visible = false;
            lbErros.Text = "";

            String bomb = "", tipo = "", descricao = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            bool erro = false;

            if (cmbBomb.SelectedItem != null)
                bomb = cmbBomb.SelectedValue.ToString();
            if (cmbTipo.SelectedItem != null)
                tipo = cmbTipo.SelectedItem.ToString();
            descricao = txtDesc.Text;

            if (bomb == "")
            {
                lbEbomb.Visible = true;
                lbErros.Text += "Tem de seleccionar um bombeiro. \n";
                erro = true;
            }
            if (tipo == "")
            {
                lbEtipo.Visible = true;
                lbErros.Text += "Tem de seleccionar um tipo. \n";
                erro = true;
            }
            if (descricao == "")
            {
                lbEDesc.Visible = true;
                lbErros.Text += "Tem de inserir uma descrição. \n";
                erro = true;
            }
            if (erro == true)
            {
                MessageBox.Show("Existem campos incorrectos.");
                return;
            }

            con.Open();
            if (id != "")
            {
                cmd.CommandText = "UPDATE extra SET descricao='" + descricao + "' WHERE (id_extra ='" + id + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizou um extra com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd.CommandText = "INSERT INTO extra (descricao, tipo, bombeiro_numero_bombeiro) VALUES ('" + descricao + "', '" + tipo + "', '" + bomb + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inseriu um extra com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtDesc.Text = "";
            lbErros.Text = "";

            lbEbomb.Visible = false;
            lbEtipo.Visible = false;
            lbEDesc.Visible = false;
            if (id == "")
            {
                cmbBomb.SelectedIndex = -1;
                cmbTipo.SelectedIndex = -1;
            }
        }

        private void Extras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet.bombeiro' table. You can move, or remove it, as needed.
            this.bombeiroTableAdapter.Fill(this.fireStationDataSet.bombeiro);
            cmbBomb.SelectedIndex = -1;
            if (t)
            {
                cmbBomb.SelectedValue = id;
                cmbBomb.Enabled = false;
            }
            else if (id != "" && t == false)
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = con.CreateCommand();
                SqlDataReader reader;
                cmd.CommandText = "SELECT * FROM extra WHERE id_extra='" + id + "'";
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    cmbBomb.SelectedValue = reader["bombeiro_numero_bombeiro"];
                    cmbBomb.Enabled = false;
                    cmbTipo.SelectedItem = reader["tipo"];
                    cmbTipo.Enabled = false;
                    txtDesc.Text = reader["descricao"].ToString();
                    reader.Close();
                }
                con.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
