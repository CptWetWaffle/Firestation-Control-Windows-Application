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
using System.IO;
using System.Reflection;

namespace QuartelBombeiros
{
    public partial class NovaViatura : Form
    {
        private String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        private String cod = "";
        public NovaViatura()
        {
            InitializeComponent();
        }

        public NovaViatura(String cod)
            : this()
        {
            this.cod = cod;
        }

        private void pBBMF_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet8.tipo' table. You can move, or remove it, as needed.
            this.tipoTableAdapter.Fill(this.fireStationDataSet8.tipo);
            cmbTipo.SelectedIndex = -1;
            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbUltInspYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbUltInspMM.Items.Add(i);

            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbValYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbValMM.Items.Add(i);

            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbAbateYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbAbateMM.Items.Add(i);

            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbAno.Items.Add(i);

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd;
            SqlDataReader reader;
            con.Open();

            if (cod != "")
            {
                cmd = new SqlCommand("SELECT * FROM viatura, ficha_viatura WHERE (ficha_viatura_matricula = matricula AND codigo='" + cod + "')", con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtCod.Text = cod;
                    txtCod.Enabled = false;
                    txtKil.Text = reader["kilometragem"].ToString();
                    txtApoice.Text = reader["apolice"].ToString();
                    txtMat.Text = reader["matricula"].ToString();
                    txtMat.Enabled = false;
                    txtOBS.Text = reader["observacoes"].ToString();
                    txtSeguro.Text = reader["seguradora"].ToString();
                    cmbAbateYYYY.SelectedIndex = DateTime.Today.Year - Convert.ToInt32(reader["data_abate"].ToString().Split('/')[2].Split(' ')[0]);
                    cmbAbateMM.SelectedIndex = Convert.ToInt32(reader["data_abate"].ToString().Split('/')[1]);
                    cmbAbateDD.SelectedIndex = Convert.ToInt32(reader["data_abate"].ToString().Split('/')[0]);
                    cmbAno.SelectedIndex = DateTime.Today.Year - Convert.ToInt32(reader["ano"].ToString().Split('/')[2].Split(' ')[0]);
                    cmbUltInspDD.SelectedItem = reader["inspeccao"].ToString().Split('/')[0];
                    cmbUltInspMM.SelectedItem = reader["inspeccao"].ToString().Split('/')[1];
                    cmbUltInspYYYY.SelectedItem = reader["inspeccao"].ToString().Split('/')[2].Split(' ')[0];
                    cmbValYYYY.SelectedIndex = DateTime.Today.Year - Convert.ToInt32(reader["data_seguro"].ToString().Split('/')[2].Split(' ')[0]);
                    cmbValMM.SelectedIndex = Convert.ToInt32(reader["data_seguro"].ToString().Split('/')[1]);
                    cmbValDD.SelectedIndex = Convert.ToInt32(reader["data_seguro"].ToString().Split('/')[0]);
                    cmbTipo.SelectedValue = reader["tipo_id_tipo"];
                   

                }
                reader.Close();
            }
            con.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbECod.Visible = false;
            lbEMat.Visible = false;
            lbETip.Visible = false;
            lbErros.Text = "";

            String codigo = "", matricula = "", ano = "", tipo = "", seguradora = "", nApolice = "", validade = "", ultInsp = "", km = "", abate = "", obs = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            bool erro = false;
            SqlDataReader reader;
            codigo = txtCod.Text;
            matricula = txtMat.Text;
            if (cmbAno.SelectedItem != null)
                ano = cmbAno.SelectedItem.ToString();
            if (cmbTipo.SelectedItem != null)
                tipo = cmbTipo.SelectedValue.ToString();
            seguradora = txtSeguro.Text;
            nApolice = txtApoice.Text;
            if (cmbValYYYY.SelectedItem != null && cmbValMM.SelectedItem != null && cmbValDD.SelectedItem != null)
                validade = cmbValYYYY.SelectedItem.ToString() + "-" + cmbValMM.SelectedItem.ToString() + "-" + cmbValDD.SelectedItem.ToString();
            if (cmbUltInspYYYY.SelectedItem != null && cmbUltInspMM.SelectedItem != null && cmbUltInspDD.SelectedItem != null)
                ultInsp = cmbUltInspYYYY.SelectedItem.ToString() + "-" + cmbUltInspMM.SelectedItem.ToString() + "-" + cmbUltInspDD.SelectedItem.ToString();
            km = txtKil.Text;
            if (cmbAbateYYYY.SelectedItem != null && cmbAbateMM.SelectedItem != null && cmbAbateDD.SelectedItem != null)
                abate = cmbAbateYYYY.SelectedItem.ToString() + "-" + cmbAbateMM.SelectedItem.ToString() + "-" + cmbAbateDD.SelectedItem.ToString();
            obs = txtOBS.Text;



            if (!Validator.isNumeric(codigo) || codigo == "")
            {
                lbECod.Visible = true;
                erro = true;
                lbErros.Text += "O código só números.\n";

            }

            if (!Validator.isMatricula(matricula))
            {
                lbEMat.Visible = true;
                erro = true;
                lbErros.Text += "A matricula está incorrecta.\n";
            }

            if (!Validator.isNumeric(tipo) || tipo == "")
            {
                lbETip.Visible = true;
                erro = true;
                lbErros.Text += "Tem de inserir um tipo.\n";
            }

            if (erro == true)
            {
                MessageBox.Show("Existem campos incorectos");
                return;
            }

            con.Open();
            if (cod == "")
            {
                cmd = new SqlCommand("SELECT id_tipo FROM tipo WHERE nome = '" + tipo + "'", con);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        tipo = reader["id_tipo"].ToString();
                reader.Close();
                cmd.CommandText = "INSERT INTO viatura ( kilometragem, codigo) VALUES ('" + km + "', '" + codigo + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO ficha_viatura (matricula, tipo_id_tipo, ano, data_abate, observacoes, viatura_codigo_viatura, seguradora, apolice, data_seguro, inspeccao) VALUES ('" + matricula + "', '" + tipo + "', '" + ano + "', '" + abate + "', '" + obs + "', '" + codigo + "', '" + seguradora + "', '" + nApolice + "', '" + validade + "', '" + ultInsp + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE viatura SET ficha_viatura_matricula = '" + matricula + "' WHERE codigo='" + codigo + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inseriu uma viatura com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd.CommandText = "UPDATE viatura SET  kilometragem='" + km + "' WHERE codigo='" + codigo + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE ficha_viatura SET tipo_id_tipo='" + tipo + "', ano='" + ano + "', data_abate='" + abate + "', observacoes='" + obs + "', seguradora='" + seguradora + "', apolice='" + nApolice + "', data_seguro='" + validade + "', inspeccao='" + ultInsp + "' WHERE (viatura_codigo_viatura= '" + codigo + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizou uma viatura com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            con.Close();
        }

        private void cmbValYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbValMM.Enabled = true;
        }

        private void cmbAbateYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAbateMM.Enabled = true;
        }

        private void cmbUltInspYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbUltInspMM.Enabled = true;
        }

        private void cmbValMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbValMM.SelectedIndex == -1)
                return;
            cmbValDD.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbValYYYY.SelectedIndex), Convert.ToInt32(cmbValMM.SelectedIndex) + 1); i++)
                cmbValDD.Items.Add(i);
            cmbValDD.Enabled = true;
        }

        private void cmbAbateMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAbateMM.SelectedIndex == -1)
                return;
            cmbAbateDD.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbAbateYYYY.SelectedIndex), Convert.ToInt32(cmbAbateMM.SelectedIndex) + 1); i++)
                cmbAbateDD.Items.Add(i);
            cmbAbateDD.Enabled = true;
        }

        private void cmbUltInspMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUltInspMM.SelectedIndex == -1)
                return;
            cmbUltInspDD.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbUltInspYYYY.SelectedIndex), Convert.ToInt32(cmbUltInspMM.SelectedIndex) + 1); i++)
                cmbUltInspDD.Items.Add(i);
            cmbUltInspDD.Enabled = true;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            lbECod.Visible = false;
            lbEMat.Visible = false;
            lbETip.Visible = false;
            lbErros.Text = "";
            txtApoice.Text = "";
            txtCod.Text = "";
            txtKil.Text = "";
            txtMat.Text = "";
            txtOBS.Text = "";
            txtSeguro.Text = "";
            cmbAbateDD.SelectedIndex = -1;
            cmbAbateMM.SelectedIndex = -1;
            cmbAbateYYYY.SelectedIndex = -1;
            cmbAno.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;
            cmbUltInspDD.SelectedIndex = -1;
            cmbUltInspMM.SelectedIndex = -1;
            cmbUltInspYYYY.SelectedIndex = -1;
            cmbValDD.SelectedIndex = -1;
            cmbValMM.SelectedIndex = -1;
            cmbValYYYY.SelectedIndex = -1;
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
