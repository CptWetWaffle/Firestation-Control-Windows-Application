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
    public partial class MarcarFaltas : Form
    {
        private String idF = "";
        private bool update = false;
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        public MarcarFaltas()
        {
            InitializeComponent();
        }

        public MarcarFaltas(String idF)
            : this()
        {
            this.idF = idF;
            update = true;
        }

        private void MarcarFaltas_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'fireStationDataSet.turno' table. You can move, or remove it, as needed.
            this.turnoTableAdapter.Fill(this.fireStationDataSet.turno);
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()) + 1; i >= 1900; i--)
            {
                cmbDataYYYY.Items.Add(i);

            }


            for (int i = 1; i <= 12; i++)
            {
                cmbDataMM.Items.Add(i);
            }
            if (!update)
                cmbTurno.SelectedIndex = -1;
            else
            {
                cmbDataYYYY.Enabled = false;
                cmbTurno.Enabled = false;
                con.Open();
                cmd.CommandText = "SELECT * from faltas WHERE (id_falta='" + idF + "')";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    String dFal;
                    dFal = reader["data"].ToString();
                    cmbDataYYYY.SelectedIndex = Convert.ToInt32(DateTime.Now.Year) + 1 - Convert.ToInt32(dFal.Split('/')[2].Split(' ')[0]);
                    cmbDataMM.SelectedIndex = Convert.ToInt32(dFal.Split('/')[1]);
                    cmbDataDD.SelectedIndex = Convert.ToInt32(dFal.Split('/')[0]);
                    cmbDataMM.Enabled = false;
                    cmbDataDD.Enabled = false;
                    cmbTurno.SelectedValue = Convert.ToInt32(reader["turno_id_turno"]);
                }
                reader.Close();
                cmd.CommandText = "SELECT * FROM faltas_bombeiro WHERE (faltas_id_faltas='" + idF + "')";
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                {
                    cblBombeiro.SetItemChecked(cblBombeiro.Items.IndexOf(reader["bombeiro_numero_bombeiro"]), true);
                }
                reader.Close();
                con.Close();
            }


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbErros.Text = "";
            lbETurno.Hide();
            lbEData.Hide();
            lbEBomb.Hide();
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            String data = "", turno = "", turnoDataIni = "", turnoDataFim = "";
            DateTime dataF = DateTime.Today;
            turnoDataIni = txtDatIniT.Text;
            turnoDataFim = txtDFimT.Text;
            bool erro = false;
            String[] bombeiros;
            if (cmbDataYYYY.SelectedItem != null && cmbDataMM.SelectedItem != null && cmbDataDD.SelectedItem != null)
                data = cmbDataYYYY.SelectedItem.ToString() + "-" + cmbDataMM.SelectedItem.ToString() + "-" + cmbDataDD.SelectedItem.ToString();
            else
            {
                erro = true;
                lbEData.Show();
                lbErros.Text += "Tem de seleccionar uma data. \n";
            }

            if (cmbTurno.SelectedItem != null)
                turno = cmbTurno.SelectedValue.ToString();
            else
            {
                erro = true;
                lbETurno.Show();
                lbErros.Text += "Tem de seleccionar um turno. \n";
            }

            if (cblBombeiro.CheckedItems.Count > 0)
            {
                bombeiros = new String[cblBombeiro.CheckedItems.Count];
                for (int i = 0; i < cblBombeiro.CheckedItems.Count; i++)
                    bombeiros[i] = cblBombeiro.CheckedItems[i].ToString();
            }
            else
            {
                erro = true;
                lbEBomb.Show();
                lbErros.Text += "Tem de seleccionar pelo menos um bombeiro. \n";
            }


            if (data != "")
            {
                DateTime tDIni, tDFim, dFalta;
                tDIni = Convert.ToDateTime(turnoDataIni);
                tDFim = Convert.ToDateTime(turnoDataFim);
                dFalta = Convert.ToDateTime(data);
                dataF = dFalta;
                if (dFalta < tDIni || dFalta > tDFim)
                {
                    erro = true;
                    lbEData.Show();
                    lbErros.Text += "Tem de seleccionar uma data que esteja dentro do invervalo de datas do turno. \n";
                }
            }

            if (erro)
            {
                MessageBox.Show("Existem campos incorrectos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            con.Open();
            if (!update)
            {
                cmd.CommandText = "SELECT * FROM faltas WHERE (data='" + data + "' AND turno_id_turno='" + turno + "')";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    con.Close();
                    MessageBox.Show("Já marcou as faltas desse turno nesse dia", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                reader.Close();
                cmd.CommandText = "INSERT INTO faltas (data,turno_id_turno) VALUES('" + data + "', '" + turno + "')";
                cmd.ExecuteNonQuery();


                cmd.CommandText = "SELECT TOP 1 id_falta FROM faltas ORDER BY id_falta DESC";
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    idF = reader["id_falta"].ToString();
                }
                reader.Close();
            }
            else
            {
                cmd.CommandText = "DELETE FROM faltas_bombeiro WHERE (faltas_id_faltas='" + idF + "')";
                cmd.ExecuteNonQuery();
            }


            for (int i = 0; i < cblBombeiro.CheckedItems.Count; i++)
            {
                cmd.CommandText = "INSERT INTO faltas_bombeiro (faltas_id_faltas, bombeiro_numero_bombeiro) VALUES ('" + idF + "','" + cblBombeiro.CheckedItems[i].ToString() + "')";
                cmd.ExecuteNonQuery();
            }

            if (update)
                MessageBox.Show("Actualizou as faltas com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Marcou as faltas com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lbErros.Text = "";
            lbETurno.Hide();
            lbEData.Hide();
            lbEBomb.Hide();
            if (!update)
            {
                cblBombeiro.Items.Clear();
                cmbTurno.SelectedIndex = -1;
                cmbDataYYYY.SelectedIndex = -1;
                cmbDataMM.SelectedIndex = -1;
                cmbDataDD.SelectedIndex = -1;
                txtDatIniT.Hide();
                txtDFimT.Hide();
                lbDFimT.Hide();
                lbdIniT.Hide();
            }
            else
                for (int i = 0; i < cblBombeiro.Items.Count; i++)
                    cblBombeiro.SetItemChecked(i, false);
        }

        private void cmbDataYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDataMM.Enabled = true;
        }

        private void cmbDataMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDataMM.SelectedIndex == -1)
                return;
            cmbDataDD.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbDataYYYY.SelectedIndex), Convert.ToInt32(cmbDataMM.SelectedIndex) + 1); i++)
                cmbDataDD.Items.Add(i);
            cmbDataDD.Enabled = true;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.turnoTableAdapter.FillBy(this.fireStationDataSet.turno);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.turnoTableAdapter.FillBy1(this.fireStationDataSet.turno);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmbTurno_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            String turnoDataIni = "", turnoDataFim = "", idTurn = "";
            if (cmbTurno.SelectedIndex == -1)
                return;
            cblBombeiro.Items.Clear();
            con.Open();
            cmd.CommandText = "SELECT * FROM turno WHERE(id_turno='" + cmbTurno.SelectedValue.ToString() + "')";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                idTurn = reader["id_turno"].ToString();
                turnoDataIni = reader["data_inicio"].ToString();
                turnoDataFim = reader["data_fim"].ToString();
            }
            reader.Close();
            cmd.CommandText = "SELECT bombeiro_numero_bombeiro FROM turno_bombeiro WHERE (turno_id_turno ='" + idTurn + "')";
            reader = cmd.ExecuteReader();
            while (reader.Read() && reader.HasRows)
                cblBombeiro.Items.Add(reader["bombeiro_numero_bombeiro"]);
            reader.Close();
            txtDatIniT.Text = turnoDataIni.Split(' ')[0];
            txtDFimT.Text = turnoDataFim.Split(' ')[0];
            txtDatIniT.Visible = true;
            txtDFimT.Visible = true;
            lbDFimT.Show();
            lbdIniT.Show();
            reader.Close();
            con.Close();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }
    }
}
