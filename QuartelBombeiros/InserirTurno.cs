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
    public partial class InserirTurno : Form
    {
        private String id = "";
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        public InserirTurno()
        {
            InitializeComponent();
        }

        public InserirTurno(String id)
            : this()
        {
            this.id = id;
        }

        private void Turno_Load(object sender, EventArgs e)
        {
            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()) + 1; i >= 1900; i--)
            {
                cmbDatInicYYYY.Items.Add(i);
                cmbDatFimYYYY.Items.Add(i);

            }


            for (int i = 1; i <= 12; i++)
            {
                cmbDatInicMM.Items.Add(i);
                cmbDatFimMM.Items.Add(i);
            }

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM bombeiro", con);
            SqlDataReader reader;

            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cblBombeiros.Items.Add(reader["numero_bombeiro"]);
            reader.Close();
            cmd.CommandText = "SELECT viatura_codigo_viatura FROM ficha_viatura";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cblViat.Items.Add(reader[0]);
            reader.Close();


            if (this.id != "")
            {
                cmd.CommandText = "SELECT * FROM turno WHERE (id_turno='" + id + "')";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtHor.Text = reader["horario"].ToString();
                    txtPosto.Text = reader["posto"].ToString();
                    String dIni = reader["data_inicio"].ToString();
                    String[] auxDIni = dIni.Split('/');
                    String auxDIniY = auxDIni[2].Split(' ')[0];
                    cmbDatInicYYYY.SelectedIndex = DateTime.Now.Year + 1 - Convert.ToInt32(auxDIniY);
                    cmbDatInicMM.SelectedIndex = Convert.ToInt32(auxDIni[1]);
                    cmbDatInicDD.SelectedIndex = Convert.ToInt32(auxDIni[0]);
                    String dFim = reader["data_fim"].ToString();
                    String[] auxFim = dFim.Split('/');
                    String auxDFimY = auxFim[2].Split(' ')[0];
                    cmbDatFimYYYY.SelectedIndex = DateTime.Now.Year + 1 - Convert.ToInt32(auxDFimY);
                    cmbDatFimMM.SelectedIndex = Convert.ToInt32(auxFim[1]);
                    cmbDatFimDD.SelectedIndex = Convert.ToInt32(auxFim[0]);

                }
                reader.Close();
                cmd.CommandText = "SELECT * FROM turno_bombeiro WHERE (turno_id_turno='" + id + "')";
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        for(int i = 0; i < cblBombeiros.Items.Count; i++)
                            if(reader["bombeiro_numero_bombeiro"].ToString() == cblBombeiros.Items[i].ToString())
                            {
                                cblBombeiros.SetItemChecked(i,true);
                            }
                    }
                }
                reader.Close();
                cmd.CommandText = "SELECT * FROM turno_viatura WHERE (turno_id_turno='" + id + "')";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < cblViat.Items.Count; i++)
                            if (reader["viatura_codigo_viatura"].ToString() == cblViat.Items[i].ToString())
                            {
                                cblViat.SetItemChecked(i, true);
                            }
                    }
                }
                reader.Close();

            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbEDataFim.Visible = false;
            lbEDatInic.Visible = false;
            lbEHorario.Visible = false;
            lbEDataFim.Visible = false;
            lbEPosto.Visible = false;
            lbErros.Text = "";


            String horario = "", posto = "", dataInicio = "", dataFim = "",  idTurno = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;

            bool erro = false;

            horario = txtHor.Text;
            posto = txtPosto.Text;
            if (cmbDatInicYYYY.SelectedItem != null && cmbDatInicMM.SelectedItem != null && cmbDatInicDD.SelectedItem != null)
                dataInicio = cmbDatInicYYYY.SelectedItem.ToString() + "-" + cmbDatInicMM.SelectedItem.ToString() + "-" + cmbDatInicDD.SelectedItem.ToString();
            if (cmbDatFimYYYY.SelectedItem != null && cmbDatFimMM.SelectedItem != null && cmbDatFimDD.SelectedItem != null)
                dataFim = cmbDatFimYYYY.SelectedItem.ToString() + "-" + cmbDatFimMM.SelectedItem.ToString() + "-" + cmbDatFimDD.SelectedItem.ToString();

            if (!Validator.isName(horario) || horario == "")
            {
                lbEHorario.Visible = true;
                lbErros.Text += "Tem de inserir o horário.\n";
                erro = true;

            }

            if (!Validator.isName(posto) || posto == "")
            {
                lbEPosto.Visible = true;
                lbErros.Text += "Tem de inserir o posto.\n";
                erro = true;
            }

            if (dataFim == "")
            {
                lbEDataFim.Visible = true;
                lbErros.Text += "Tem de inserir uma data de fim.\n";
                erro = true;
            }

            if (dataInicio == "")
            {
                lbEDatInic.Visible = true;
                lbErros.Text += "Tem de inserir uma data de início.\n";
                erro = true;
            }

            if (cblBombeiros.CheckedItems.Count == 0)
            {
                lbErros.Text += "Tem de escolher pelo menos um bombeiro.\n";
                erro = true;
            }

            if (cblViat.CheckedItems.Count == 0)
            {
                lbErros.Text += "Tem de escolher pelo menos uma viatura.\n";
                erro = true;
            }

            if (dataFim == "" || dataInicio == "")
            {
                lbErros.Text += "Tem de seleccionar ambas as datas.\n";
                erro = true;
            }
            else
            {
                DateTime di, df;
                di = DateTime.Parse(dataInicio);
                df = DateTime.Parse(dataFim);

                if (di > df)
                {
                    lbErros.Text += "Data do início tem de ser menor que a data do fim.\n";
                    erro = true;
                }
            }
            if (erro == true)
            {
                MessageBox.Show("Existem campos incorrectos.");
                return;
            }

            con.Open();
            if (this.id == "")
            {
                cmd.CommandText = "INSERT INTO turno (horario, posto, data_inicio, data_fim) VALUES ('" + horario + "', '" + posto + "', '" + dataInicio + "', '" + dataFim + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT TOP 1 id_turno FROM turno ORDER BY id_turno DESC ";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                    while (reader.Read())
                        idTurno = reader["id_turno"].ToString();
                reader.Close();

                MessageBox.Show("Inseriu um turno com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                cmd.CommandText = "UPDATE turno SET horario = '" + horario + "', posto ='" + posto + "', data_inicio = '" + dataInicio + "', data_fim =  '" + dataFim + "' WHERE (id_turno='" + this.id + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "DELETE FROM turno_bombeiro WHERE turno_id_turno='" + this.id + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "DELETE FROM turno_viatura WHERE turno_id_turno='" + this.id + "'";
                cmd.ExecuteNonQuery();
                idTurno = this.id;
                MessageBox.Show("Actualizou o turno com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            String[] numB = new String[cblBombeiros.CheckedItems.Count];
            for (int i = 0; i < cblBombeiros.CheckedItems.Count; i++)
            {
                numB[i] = cblBombeiros.CheckedItems[i].ToString();
                cmd.CommandText = "INSERT INTO turno_bombeiro (bombeiro_numero_bombeiro, turno_id_turno) VALUES ('" + numB[i] + "', '" + idTurno + "')";
                cmd.ExecuteNonQuery();

            }
            String[] viat = new String[cblViat.CheckedItems.Count];
            for (int i = 0; i < cblViat.CheckedItems.Count; i++)
            {
                viat[i] = cblViat.CheckedItems[i].ToString();
                cmd.CommandText = "INSERT INTO turno_viatura (viatura_codigo_viatura , turno_id_turno) VALUES ('" + viat[i] + "', '" + idTurno + "')";
                cmd.ExecuteNonQuery();

            }
            con.Close();
        }

        private void cmbDatInicMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatInicMM.SelectedIndex == -1)
                return;
            cmbDatInicDD.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbDatInicYYYY.SelectedIndex), Convert.ToInt32(cmbDatInicMM.SelectedIndex) + 1); i++)
                cmbDatInicDD.Items.Add(i);
            cmbDatInicDD.Enabled = true;
        }

        private void cmbDatFimMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatFimMM.SelectedIndex == -1)
                return;
            cmbDatFimDD.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbDatFimYYYY.SelectedIndex), Convert.ToInt32(cmbDatFimMM.SelectedIndex) + 1); i++)
                cmbDatFimDD.Items.Add(i);
            cmbDatFimDD.Enabled = true;
        }

        private void cmbDatInicYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDatInicMM.Enabled = true;
        }

        private void cmbDatFimYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDatFimMM.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtHor.Text = "";
            txtPosto.Text = "";
            cmbDatFimDD.SelectedIndex = -1;
            cmbDatFimMM.SelectedIndex = -1;
            cmbDatFimYYYY.SelectedIndex = -1;

            cmbDatInicDD.SelectedIndex = -1;
            cmbDatInicMM.SelectedIndex = -1;
            cmbDatInicYYYY.SelectedIndex = -1;

            for (int i = 0; i < cblBombeiros.Items.Count; i++)
                cblBombeiros.SetItemChecked(i, false);
            for (int i = 0; i < cblViat.Items.Count; i++)
                cblViat.SetItemChecked(i, false);
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


