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
    public partial class NovoAgendamento : Form
    {
        private String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        private String id = "";
        private bool update = false;
        public NovoAgendamento()
        {
            InitializeComponent();
        }

        public NovoAgendamento(String id)
            : this()
        {
            this.id = id;
            update = true;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void NovoAgendamento_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 24; i++)
            {
                cmbH.Items.Add(i);
            }

            for (int i = 1; i <= 60; i++)
            {
                cmbM.Items.Add(i);
            }

            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbMM.Items.Add(i);

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM bombeiro", con);
            SqlDataReader reader;

            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cblBombeiros.Items.Add(reader["numero_bombeiro"]);
            reader.Close();
            cmd.CommandText = "SELECT * FROM viatura";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cblViatura.Items.Add(reader["codigo"]);
            reader.Close();
            if (id != "" && update == true)
            {
                cmd.CommandText = "SELECT * FROM agendamento WHERE id_agendamento='" + id + "'";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    cmbH.SelectedIndex = Convert.ToInt32(reader["hora"].ToString().Split(':')[0])-1;

                    cmbM.SelectedItem = Convert.ToInt32(reader["hora"].ToString().Split(':')[1])-1;
                    txtDesc.Text = reader["descricao"].ToString();
                    cmbYYYY.SelectedIndex = DateTime.Today.Year - Convert.ToInt32(reader["data"].ToString().Split('/')[2].Split(' ')[0]);
                    cmbMM.SelectedIndex = Convert.ToInt32(reader["data"].ToString().Split('/')[1]);
                    cmbDD.SelectedIndex = Convert.ToInt32(reader["data"].ToString().Split('/')[0]);
                }
                reader.Close();
                cmd.CommandText = "SELECT * FROM agendamento_bombeiro WHERE agendamento_id_agendamento='"+id+"'";
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        cblBombeiros.SetItemChecked(cblBombeiros.Items.IndexOf(reader["bombeiro_numero_bombeiro"]), true);
                    }

                }
                reader.Close();
                cmd.CommandText = "SELECT * FROM agendamento_viatura WHERE agendamento_id_agendamento='" + id + "'";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cblViatura.SetItemChecked(cblViatura.Items.IndexOf(reader["viatura_codigo"]), true);
                    }

                }
                reader.Close();

            }
            con.Close();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbEbomb.Visible = false;
            lbEData.Visible = false;
            lbEHora.Visible = false;
            lbEviat.Visible = false;
            lbErros.Text = "";

            String hora = "", data = "", descricao = "", numBomb = "", idAgendamento = "", codigoViat = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            bool erro = false;
            SqlDataReader reader;

            if (cmbH.SelectedItem != null && cmbM.SelectedItem != null)
                hora = cmbH.SelectedItem.ToString() + ":" + cmbM.SelectedItem.ToString();
            if (cmbYYYY.SelectedItem != null && cmbMM.SelectedItem != null && cmbDD.SelectedItem != null)
                data = cmbYYYY.SelectedItem.ToString() + "-" + cmbMM.SelectedItem.ToString() + "-" + cmbDD.SelectedItem.ToString();
            descricao = txtDesc.Text;

            if (hora == "")
            {
                erro = true;
                lbEHora.Visible = true;
                lbErros.Text += "Tem de inserir uma hora.\n";
            }

            if (data == "")
            {
                erro = true;
                lbEData.Visible = true;
                lbErros.Text += "Tem de inserir uma data.\n";
            }

            if (cblBombeiros.CheckedItems.Count <= 0)
            {
                erro = true;
                lbEbomb.Visible = true;
                lbErros.Text += "Tem de seleccionar um Bombeiro.\n";
            }

            if (cblViatura.CheckedItems.Count <= 0)
            {
                erro = true;
                lbEviat.Visible = true;
                lbErros.Text += "Tem de seleccionar uma Viatura.\n";
            }
            if (erro == true)
            {
                MessageBox.Show("Existem campos incorrectos.");
                return;
            }

            con.Open();
            if (!update)
            {
                cmd.CommandText = "INSERT INTO agendamento (hora, data, descricao) VALUES('" + hora + "','" + data + "', '" + descricao + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT TOP 1 id_agendamento FROM agendamento ORDER BY id_agendamento DESC ";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        idAgendamento = reader["id_agendamento"].ToString();
                reader.Close();
                MessageBox.Show("Inseriu um agendamento com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                cmd.CommandText = "DELETE FROM agendamento_bombeiro WHERE agendamento_id_agendamento='"+id+"'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM agendamento_bombeiro WHERE agendamento_id_agendamento='" + id + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "UPDATE agendamento SET hora='" + hora + "', data='" + data + "', descricao='" + descricao + "' WHERE id_agendamento='"+id+"'";
                cmd.ExecuteNonQuery();
                idAgendamento = id;
            }
            String[] aux = new String[cblBombeiros.CheckedItems.Count];
            for (int i = 0; i < cblBombeiros.CheckedItems.Count; i++)
                aux[i] = cblBombeiros.CheckedItems[i].ToString();
            for (int i = 0; i < cblBombeiros.CheckedItems.Count; i++)
            {
                numBomb = aux[i];
                cmd.CommandText = "INSERT INTO agendamento_bombeiro (bombeiro_numero_bombeiro, agendamento_id_agendamento) VALUES ('" + numBomb + "', '" + idAgendamento + "')";
                cmd.ExecuteNonQuery();
            }
            aux = new String[cblViatura.CheckedItems.Count];
            for (int i = 0; i < cblViatura.CheckedItems.Count; i++)
                aux[i] = cblViatura.CheckedItems[i].ToString();
            for (int i = 0; i < cblViatura.CheckedItems.Count; i++)
            {
                codigoViat = aux[i];
                cmd.CommandText = "INSERT INTO agendamento_viatura (viatura_codigo, agendamento_id_agendamento) VALUES ('" + codigoViat + "', '" + idAgendamento + "')";
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void cmbDD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDD.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbYYYY.SelectedIndex), Convert.ToInt32(cmbMM.SelectedIndex) + 1); i++)
                cmbDD.Items.Add(i);
            cmbDD.Enabled = true;
        }

        private void cmbYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMM.Enabled = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}
