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
    public partial class Licencas : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        private String numB = "";
        private bool t = false;
        public Licencas()
        {
            InitializeComponent();
        }
        public Licencas(String num) : this()
        {
            this.numB = num;
        }

        public Licencas(String num, bool t) : this()
        {
            this.numB = num;
            this.t = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbEbomb.Visible = false;
            lbEDataFim.Visible = false;
            lbEDatInic.Visible = false;
            lbEtipo.Visible = false;
            lbErros.Text = "";

            String bomb = "", dataFim = "", dataInic = "", tipo = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            bool erro = false;
     
            if (cmbBomb.SelectedItem != null)
                bomb = cmbBomb.SelectedValue.ToString();
            if (cmbTipo.SelectedItem != null)
                tipo = cmbTipo.SelectedItem.ToString();
            if (cmbDatInicYYYY.SelectedItem != null && cmbDatInicMM.SelectedItem != null && cmbDatInicDD.SelectedItem != null)
                dataInic = cmbDatInicYYYY.SelectedItem.ToString() + "-" + cmbDatInicMM.SelectedItem.ToString() + "-" + cmbDatInicDD.SelectedItem.ToString();
            if (cmbDatFimYYYY.SelectedItem != null && cmbDatFimMM.SelectedItem != null && cmbDatInicDD.SelectedItem != null)
                dataFim = cmbDatFimYYYY.SelectedItem.ToString() + "-" + cmbDatFimMM.SelectedItem.ToString() + "-" + cmbDatFimDD.SelectedItem.ToString();

            if (bomb == "")
            {
                lbEbomb.Visible = true;
                erro = true;
                lbErros.Text += "Tem de seleccionar um bombeiro. \n";
            }
            if ( tipo == "")
            {
                lbEtipo.Visible = true;
                erro = true;
                lbErros.Text += "Tem de seleccionar um tipo. \n";
            }
            if (dataFim == "" || dataInic == "")
            {
                lbErros.Text += "Tem de seleccionar ambas as datas.\n";
                lbEDataFim.Visible = true;
                lbEDatInic.Visible = true;
                erro = true;
            }
            else
            {
                DateTime di, df;
                di = DateTime.Parse(dataInic);
                df = DateTime.Parse(dataFim);

                if (di > df)
                {
                    lbErros.Text += "Data do início tem de ser menor que a data do fim.\n";
                    lbEDataFim.Visible = true;
                    lbEDatInic.Visible = true;
                    erro = true;
                }
            }
            if (erro == true)
            {
                MessageBox.Show("Existem campos incorectos");
                return;
            }
            con.Open();
            if (numB != "")
            {
                cmd.CommandText = "UPDATE licenca SET data_inicio='" + dataInic + "', data_fim='" + dataFim + "', tipo = '" + tipo + "' WHERE id_licenca='"+numB+"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizou uma licença com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            else
            {
                cmd.CommandText = "INSERT INTO licenca (data_inicio, data_fim, tipo, bombeiro_numero_bombeiro) VALUES ('" + dataInic + "', '" + dataFim + "', '" + tipo + "', '" + bomb + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inseriu uma licença com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void Licencas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet.bombeiro' table. You can move, or remove it, as needed.
            this.bombeiroTableAdapter.Fill(this.fireStationDataSet.bombeiro);
            cmbBomb.SelectedIndex = -1;
            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbDatInicYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbDatInicMM.Items.Add(i);

            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbDatFimYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbDatFimMM.Items.Add(i);

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            con.Open();
            if(t)
            {
                cmbBomb.SelectedItem = numB;
                cmbBomb.Enabled = false;
            }else
            if (numB != "")
            {
                cmd.CommandText = "SELECT * FROM licencas WHERE id_licenca=" + numB + "'";
                
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                        cmbBomb.SelectedItem = reader["bombeiro_numero_bombeiro"];
                    cmbDatInicYYYY.SelectedItem = reader["data_inicio"].ToString().Split('/')[2].Split(' ')[0];
                    cmbDatInicMM.SelectedItem = reader["data_inicio"].ToString().Split('/')[1];
                    cmbDatInicDD.SelectedItem = reader["data_inicio"].ToString().Split('/')[0];
                    cmbDatFimYYYY.SelectedItem = reader["data_fim"].ToString().Split('/')[2].Split(' ')[0];
                    cmbDatFimMM.SelectedItem = reader["data_fim"].ToString().Split('/')[1];
                    cmbDatFimDD.SelectedItem = reader["data_fim"].ToString().Split('/')[0];
                    cmbTipo.SelectedItem = reader["tipo"];


                }
                reader.Close();
            }
            con.Close();
        }

        private void cmbDatInicYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDatInicMM.Enabled = true;
        }

        private void cmbDatFimYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDatFimMM.Enabled = true;
        }

        private void cmbDatInicMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDatInicDD.Items.Clear();
            if (cmbDatInicMM.SelectedIndex != -1)
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbDatInicYYYY.SelectedIndex), Convert.ToInt32(cmbDatInicMM.SelectedIndex) + 1); i++)
                cmbDatInicDD.Items.Add(i);
            cmbDatInicDD.Enabled = true;
        }

        private void cmbDatFimMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDatFimDD.Items.Clear();
        if (cmbDatFimMM.SelectedIndex != -1)
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbDatFimYYYY.SelectedIndex), Convert.ToInt32(cmbDatFimMM.SelectedIndex) + 1); i++)
                cmbDatFimDD.Items.Add(i);
            cmbDatFimDD.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            cmbBomb.SelectedIndex = -1; 
            cmbDatFimYYYY.SelectedIndex = -1; 
            cmbDatFimMM.SelectedIndex = -1;
            cmbDatFimDD.SelectedIndex = -1;
            cmbDatInicYYYY.SelectedIndex = -1;
            cmbDatInicMM.SelectedIndex = -1;
            cmbDatInicDD.SelectedIndex = -1;     
            cmbTipo.SelectedIndex = -1;
            lbEbomb.Visible = false;
            lbEDataFim.Visible = false;
            lbEDatInic.Visible = false;
            lbEtipo.Visible = false;
            lbErros.Text = "";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                this.Close();
            }
        }
    }
}
