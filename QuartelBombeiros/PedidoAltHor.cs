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
    public partial class PedidoAltHor : Form
    {
        private bool admin = false;
        private String numBomb = "";
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        public PedidoAltHor()
        {
            InitializeComponent();
        }

        public PedidoAltHor(String numBomb)
            : this()
        {
            this.numBomb = numBomb;
        }

        public PedidoAltHor(bool admin)
            : this()
        {
            this.admin = true;
            this.numBomb = "0";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbEHorario.Hide();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            bool erro = false;
            if (cmbHor.SelectedIndex == -1)
            {
                erro = true;
                lbErros.Text += "Tem de seleccionar um horario. \n";
                lbEHorario.Show();
            }

            if (erro)
            {
                MessageBox.Show("Existem campos incorrectos!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            con.Open();
            if (!admin)
            {
                cmd.CommandText = "SELECT * FROM pedido_alt WHERE (turno_id_turno='" + cmbHor.SelectedValue.ToString() + "' AND bombeiro_numero_bombeiro='" + numBomb + "')";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Já realizou esse pedido anteriormente!\nPor favor aguarde a resposta do administrador.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                reader.Close();
                cmd.CommandText = "INSERT INTO pedido_alt (turno_id_turno, bombeiro_numero_bombeiro) VALUES ('" + cmbHor.SelectedValue.ToString() + "','" + numBomb + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inseriu o pedido com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd.CommandText = "DELETE FROM turno_bombeiro WHERE bombeiro_numero_bombeiro='" + cmbBomb.SelectedValue.ToString() + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO turno_bombeiro (turno_id_turno, bombeiro_numero_bombeiro) VALUES ('" + cmbHor.SelectedValue.ToString() + "', '" + cmbBomb.SelectedValue.ToString() + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM pedido_alt WHERE bombeiro_numero_bombeiro='"+cmbBomb.SelectedValue.ToString()+"'";
                cmd.ExecuteNonQuery();
                btnApagar.PerformClick();
                MessageBox.Show("Efectuou a alteração de horario com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            con.Close();
        }

        private void PedidoAltHor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet7.pedido_alt' table. You can move, or remove it, as needed.
            this.pedido_altTableAdapter.Fill(this.fireStationDataSet7.pedido_alt);
            // TODO: This line of code loads data into the 'fireStationDataSet5.turno' table. You can move, or remove it, as needed.
            this.turnoTableAdapter.Fill(this.fireStationDataSet5.turno);
            paramToolStripTextBox.Text = numBomb;
            fillByToolStripButton.PerformClick();
            cmbHor.SelectedIndex = -1;
            lbEHorario.Hide();
            cmbBomb.SelectedIndex = -1;
            if (admin)
            {
                lbBomb.Show();
                cmbHor.Enabled = false;
                cmbBomb.Show();
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.turnoTableAdapter.FillBy(this.fireStationDataSet5.turno, ((int)(System.Convert.ChangeType(paramToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmbHor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHor.SelectedIndex == -1)
                return;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            String turnoDataIni = "", turnoDataFim = "", posto = "";
            con.Open();

            cmd.CommandText = "SELECT * FROM turno WHERE(id_turno='" + cmbHor.SelectedValue.ToString() + "')";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                turnoDataIni = reader["data_inicio"].ToString();
                turnoDataFim = reader["data_fim"].ToString();
                posto = reader["posto"].ToString();
            }
            txtDIni.Text = turnoDataIni.Split(' ')[0];
            txtDFim.Text = turnoDataFim.Split(' ')[0];
            txtPosto.Text = posto;
            reader.Close();
            con.Close();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            cmbHor.SelectedIndex = -1;
            txtPosto.Text = "";
            txtDIni.Text = "";
            txtDFim.Text = "";
            if (admin)
                cmbBomb.SelectedIndex = -1;
        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.turnoTableAdapter.FillBy1(this.fireStationDataSet5.turno, ((int)(System.Convert.ChangeType(paramToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmbBomb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBomb.SelectedIndex == -1)
                return;
            paramToolStripTextBox1.Text = cmbBomb.SelectedValue.ToString();
            fillBy1ToolStripButton.PerformClick();
            cmbHor.Enabled = true;
            cmbHor.SelectedIndex = -1;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
