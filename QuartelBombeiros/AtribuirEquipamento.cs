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
    public partial class AtribuirEquipamento : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        public AtribuirEquipamento()
        {
            InitializeComponent();
        }

        private void AtribuicaoEquipamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipDS.equipamento' table. You can move, or remove it, as needed.
            this.equipamentoTableAdapter.Fill(this.equipDS.equipamento);
            cmbEquip.SelectedIndex = -1;
            txtQuant.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbBomb_CheckedChanged(object sender, EventArgs e)
        {
            txtQuant.Enabled = true;
            paramToolStripTextBox.Text = "B";
            fillByToolStripButton.PerformClick();
            cmbEquip.SelectedIndex = -1;
            lbBombViat.Visible = true;
            cmbBombViat.Visible = true;
            lbBombViat.Text = "BOMBEIRO";
            cmbEquip.Enabled = true;
            cmbBombViat.Items.Clear();

            lbQuantTotal.Text = "";

            SqlConnection con = new SqlConnection(connectionString);

            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SELECT * FROM bombeiro", con);

            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    cmbBombViat.Items.Insert(i, reader["numero_bombeiro"]);
                    i++;
                }
            }

            reader.Close();



            con.Close();
        }

        private void rbViat_CheckedChanged(object sender, EventArgs e)
        {
            txtQuant.Enabled = true;
            paramToolStripTextBox.Text = "V";
            fillByToolStripButton.PerformClick();
            cmbEquip.SelectedIndex = -1;
            lbBombViat.Visible = true;
            cmbBombViat.Visible = true;
            lbBombViat.Text = "VIATURA";
            cmbEquip.Enabled = true;

            lbQuantTotal.Text = "";

            SqlConnection con = new SqlConnection(connectionString);

            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SELECT * FROM viatura", con);

            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    cmbBombViat.Items.Insert(i, reader["codigo"]);
                    i++;
                }
            }

            reader.Close();



            con.Close();
        }

        private void cmbEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEquip.SelectedIndex == -1)
                return;
            lbQuantTotal.Visible = true;
            txtQuant.Enabled = true;
            SqlConnection con = new SqlConnection(connectionString);

            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SELECT quantidade_disponivel FROM equipamento WHERE id_equipamento = '" + cmbEquip.SelectedValue.ToString() + "'", con);

            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                lbQuantTotal.Text = "/" + reader["quantidade_disponivel"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            lbErros.Text = "";
            lbEBombViat.Visible = false;
            lbEQuant.Visible = false;
            lbEBV.Visible = false;
            lbEEquip.Visible = false;

            String equipamento = "", bombViatura = "", quantidade = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            bool erro = false;

            if (cmbEquip.SelectedItem != null)
                equipamento = cmbEquip.SelectedValue.ToString();
            if (cmbBombViat.SelectedItem != null)
                bombViatura = cmbBombViat.SelectedItem.ToString();
            quantidade = txtQuant.Text;




            if (equipamento == "")
            {
                lbEEquip.Visible = true;
                erro = true;
                lbErros.Text += "Tem de seleccionar um equipamento. \n";
            }

            if (bombViatura == "")
            {
                lbEBV.Visible = true;
                erro = true;
                lbErros.Text += "Tem de seleccionar um(a) Bombeiro/Viatura. \n";
            }

            String[] aux = lbQuantTotal.Text.ToString().Split('/');
            if (!Validator.isNumeric(quantidade) || quantidade == "" || Convert.ToInt32(quantidade) > Convert.ToInt32(aux[1]) || Convert.ToInt32(quantidade) < 0)
            {
                lbEQuant.Visible = true;
                erro = true;
                lbErros.Text += "A quantidade só permite números.\n";
            }

            if (!rbBomb.Checked && !rbViat.Checked)
            {
                lbEBombViat.Visible = true;
                erro = true;
                lbErros.Text = "Tem de seleccionar um destino para o equipamento.";
            }

            if (erro == true)
            {
                MessageBox.Show("Existem campos incorrectos.");
                return;
            }
            int qtSobra =  Convert.ToInt32(aux[1]) - Convert.ToInt32(quantidade);
            con.Open();

            cmd.CommandText = "UPDATE equipamento SET quantidade_disponivel='" + qtSobra.ToString() + "' WHERE (id_equipamento='" + equipamento + "')";
            cmd.ExecuteNonQuery();
            String tipo = "", query = "";

            if (rbViat.Checked == true)
            {
                tipo = "viatura";
                query = "viatura_codigo_viatura";
            }
            else
            {
                tipo = "bombeiro";
                query = "bombeiro_numero_bombeiro";
            }
            cmd.CommandText = "INSERT INTO equipamento_" + tipo + " (equipamento_id_equipamento, " + query+ ", quantidade) VALUES ('" + equipamento + "', '" + cmbBombViat.SelectedItem.ToString() + "', " + qtSobra.ToString() + " )";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Atribuiu um equipamento com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmd.CommandText = "SELECT quantidade_disponivel FROM equipamento WHERE (id_equipamento = '" + cmbEquip.SelectedValue.ToString() + "')";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                lbQuantTotal.Text = "/" + reader["quantidade_disponivel"].ToString();
            }

            reader.Close();
            con.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.equipamentoTableAdapter.FillBy(this.equipDS.equipamento, paramToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            cmbBombViat.SelectedIndex = -1;
            cmbEquip.SelectedIndex = -1;
            rbBomb.Checked = false;
            rbViat.Checked = false;
            txtQuant.Text = "";
            lbQuantTotal.Text = "";
            txtQuant.Enabled = false;
            cmbEquip.Enabled = false;
            cmbBombViat.Enabled = false;

        }
    }
}
