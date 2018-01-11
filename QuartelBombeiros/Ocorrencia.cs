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
    public partial class Ocorrencia : Form
    {
        private String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        private Quilometragem quilo;
        private String idOco = "";
        private String state = "";
        private bool aO = false;
        public Ocorrencia()
        {
            InitializeComponent();
        }
        public Ocorrencia(String id)
            : this()
        {
            this.idOco = id;
            aO = true;
        }

        private void Ocorrencia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet.bombeiro' table. You can move, or remove it, as needed.
            this.bombeiroTableAdapter.Fill(this.fireStationDataSet.bombeiro);
            // TODO: This line of code loads data into the 'fireStationDataSet.viatura' table. You can move, or remove it, as needed.
            this.viaturaTableAdapter.Fill(this.fireStationDataSet.viatura);
            // TODO: This line of code loads data into the 'fireStationDataSet.codigo_occorencia' table. You can move, or remove it, as needed.
            this.codigo_occorenciaTableAdapter.Fill(this.fireStationDataSet.codigo_occorencia);
            String aux;
            cmbBomb.SelectedIndex = -1;
            cmbViat.SelectedIndex = -1;
            for (int i = 1; i <= 24; i++)
            {
                if (i < 10)
                    aux = "0" + i.ToString();
                else
                    aux = i.ToString();

                cmbHdQuartelHH.Items.Add(aux);
                cmbHcQuartelHH.Items.Add(aux);
                cmbHlocalHH.Items.Add(aux);
                cmbHorAlertaHH.Items.Add(aux);
                cmbComHH.Items.Add(aux);

            }

            for (int i = 1; i <= 60; i++)
            {
                if (i < 10)
                    aux = "0" + i.ToString();
                else
                    aux = i.ToString();

                cmbHdQuartelMM.Items.Add(aux);
                cmbHcQuartelMM.Items.Add(aux);
                cmbHlocalMM.Items.Add(aux);
                cmbHorAlertaMM.Items.Add(aux);
                cmbComMM.Items.Add(aux);
            }

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd;
            SqlDataReader reader;
            con.Open();
            cblViat.Items.Clear();
            cmd = new SqlCommand("SELECT codigo FROM viatura ", con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cblViat.Items.Add(reader["codigo"]);
            reader.Close();
            cmd = new SqlCommand("SELECT nome FROM conselho ", con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
                while (reader.Read())
                    cmbCons.Items.Add(reader["nome"]);
            reader.Close();



            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbDatInicioYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbDataInicioMM.Items.Add(i);

            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbDataFimYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbDataFimMM.Items.Add(i);

            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbDataYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbDataMM.Items.Add(i);
            cmbCod.SelectedIndex = -1;

            if (aO)
            {
                cmd.CommandText = "SELECT * FROM occorencia WHERE id_occorencia='" + idOco + "'";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    txtCodProtCivil.Text = reader["codigo_proteccao_civil"].ToString();
                    txtDesc.Text = reader["descricao"].ToString();
                    txtLocal.Text = reader["local"].ToString();
                    cmbCod.SelectedValue = reader["codigo_occorencia_id_codigo_occorencia"];
                    cmbCons.SelectedItem = reader["conselho"];
                    cmbFreg.SelectedItem = reader["freguesia"];
                    cmbDatInicioYYYY.SelectedIndex = Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(reader["data_inicio"].ToString().Split('/')[2].Split(' ')[0]);
                    cmbDataInicioMM.SelectedIndex = Convert.ToInt32(reader["data_inicio"].ToString().Split('/')[1]);
                    cmbDataInicoDD.SelectedIndex = Convert.ToInt32(reader["data_inicio"].ToString().Split('/')[0]);
                    cmbDataFimYYYY.SelectedIndex = Convert.ToInt32(DateTime.Today.Year) - Convert.ToInt32(reader["data_fim"].ToString().Split('/')[2].Split(' ')[0]);
                    cmbDataFimMM.SelectedIndex = Convert.ToInt32(reader["data_fim"].ToString().Split('/')[1]);
                    cmbDataFimDD.SelectedIndex = Convert.ToInt32(reader["data_fim"].ToString().Split('/')[0]);
                    cmbHcQuartelHH.SelectedItem = reader["hora_chegada_quartel"].ToString().Split(':')[0];
                    cmbHcQuartelMM.SelectedItem = reader["hora_chegada_quartel"].ToString().Split(':')[1];
                    cmbHdQuartelHH.SelectedItem = reader["hora_despacho_quartel"].ToString().Split(':')[0];
                    cmbHdQuartelMM.SelectedItem = reader["hora_despacho_quartel"].ToString().Split(':')[1];
                    cmbHlocalHH.SelectedItem = reader["hora_chegada_local"].ToString().Split(':')[0];
                    cmbHlocalMM.SelectedItem = reader["hora_chegada_local"].ToString().Split(':')[1];
                    cmbHorAlertaHH.SelectedItem = reader["hora_alerta"].ToString().Split(':')[0];
                    cmbHorAlertaMM.SelectedItem = reader["hora_alerta"].ToString().Split(':')[1];

                }
                reader.Close();
                cmd.CommandText = "SELECT viatura_codigo_viatura FROM viatura_occorencia WHERE occorencia_id_occorencia='" + idOco + "'";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                        cblViat.SetItemChecked(cblViat.Items.IndexOf(reader[0]), true);
                }
                reader.Close();
                cblViat.Enabled = false;
            }

            con.Close();
        }

        private void cmbFreg_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarOcc_Click(object sender, EventArgs e)
        {
            lbEBomb.Hide();
            lbECod.Hide();
            lbECodProt.Hide();
            lbECom.Hide();
            lbECons.Hide();
            lbEData.Hide();
            lbEDes.Hide();
            lbEDFim.Hide();
            lbEDIni.Hide();
            lbEFreg.Hide();
            lbEHA.Hide();
            lbEHCL.Hide();
            lbEHCQ.Hide();
            lbEHDQ.Hide();
            lbEHora.Hide();
            lbELocal.Hide();
            lbErros.Text = "";
            lbEVia.Hide();
            lbEViat.Hide();

            String idOc = "", hDQuartel = "", des = "", hCLocal = "", hAlerta = "", dIni = "", dFim = "", cPCivil = "", hCQuartel = "", local = "", codOcorrencia = "", cons = "", freg = "";
            String[] codV = null;
            bool erro = false;
            if (cblViat.CheckedItems.Count > 0)
            {
                codV = new String[cblViat.CheckedItems.Count];
                for (int i = 0; i > cblViat.CheckedItems.Count; i++)
                    codV[i] = cblViat.CheckedItems[i].ToString();
            }

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd;
            SqlDataReader reader;
            cmd = con.CreateCommand();
            des = txtDesc.Text;
            if (cmbHlocalHH.SelectedItem != null && cmbHlocalMM.SelectedItem != null)
                if (cmbHlocalMM.SelectedItem.ToString().Length > 1)
                    hCLocal = cmbHlocalHH.SelectedItem.ToString() + ":" + cmbHlocalMM.SelectedItem.ToString();
                else
                    hCLocal = cmbHlocalHH.SelectedItem.ToString() + ":0" + cmbHlocalMM.SelectedItem.ToString();

            if (cmbHdQuartelHH.SelectedItem != null && cmbHdQuartelMM.SelectedItem != null)
                if (cmbHdQuartelMM.SelectedItem.ToString().Length > 1)
                    hDQuartel = cmbHdQuartelHH.SelectedItem.ToString() + ":" + cmbHdQuartelMM.SelectedItem.ToString();
                else
                    hDQuartel = cmbHdQuartelHH.SelectedItem.ToString() + ":0" + cmbHdQuartelMM.SelectedItem.ToString();


            if (cmbHorAlertaHH.SelectedItem != null && cmbHorAlertaMM.SelectedItem != null)
                if (cmbHorAlertaMM.SelectedItem.ToString().Length > 1)
                    hAlerta = cmbHorAlertaHH.SelectedItem.ToString() + ":" + cmbHorAlertaMM.SelectedItem.ToString();
                else
                    hAlerta = cmbHorAlertaHH.SelectedItem.ToString() + ":0" + cmbHorAlertaMM.SelectedItem.ToString();


            if (cmbHcQuartelHH.SelectedItem != null && cmbHcQuartelMM.SelectedItem != null)
                if (cmbHcQuartelMM.SelectedItem.ToString().Length > 1)
                    hCQuartel = cmbHcQuartelHH.SelectedItem.ToString() + ":" + cmbHcQuartelMM.SelectedItem.ToString();
                else
                    hCQuartel = cmbHcQuartelHH.SelectedItem.ToString() + ":" + cmbHcQuartelMM.SelectedItem.ToString();

            if (cmbDatInicioYYYY.SelectedItem != null && cmbDataInicioMM.SelectedItem != null && cmbDataInicoDD.SelectedItem != null)
                dIni = cmbDatInicioYYYY.SelectedItem.ToString() + "-" + cmbDataInicioMM.SelectedItem.ToString() + "-" + cmbDataInicoDD.SelectedItem.ToString();
            if (cmbDataFimYYYY.SelectedItem != null && cmbDataFimMM.SelectedItem != null && cmbDataFimDD.SelectedItem != null)
                dFim = cmbDataFimYYYY.SelectedItem.ToString() + "-" + cmbDataFimMM.SelectedItem.ToString() + "-" + cmbDataInicoDD.SelectedItem.ToString();
            cPCivil = txtCodProtCivil.Text;
            local = txtLocal.Text;
            if (cmbCod.SelectedIndex != -1)
                codOcorrencia = cmbCod.SelectedValue.ToString();
            if (cmbCons.SelectedItem != null)
                cons = cmbCons.SelectedItem.ToString();
            if (cmbFreg.SelectedItem != null)
                freg = cmbFreg.SelectedItem.ToString();

            if (cPCivil == "" || !Validator.isNumeric(cPCivil))
            {
                lbECodProt.Show();
                erro = true;
                lbErros.Text += "Tem de inserir o código de protecção civil. \n";
            }

            if (!Validator.isHora(hDQuartel) || hDQuartel == "")
            {
                lbEHDQ.Show();
                erro = true;
                lbErros.Text += "Tem de inserir uma hora de despacho do quartel. \n";
            }

            if (!Validator.isHora(hCQuartel))
            {
                lbEHCQ.Show();
                erro = true;
                lbErros.Text += "Tem de inserir uma hora de chegada ao quartel";
            }

            if (!Validator.isHora(hCLocal))
            {
                lbEHCL.Show();
                erro = true;
                lbErros.Text += "Tem de inserir uma hora de chegada ao local";
            }

            if (!Validator.isHora(hAlerta) || hAlerta == "")
            {
                lbEHA.Show();
                erro = true;
                lbErros.Text += "Tem de inserir uma hora de alerta";
            }

            if (dIni == "")
            {
                lbEDIni.Show();
                lbErros.Text += "Tem de seleccionar a data de inicio.\n";
                erro = true;
            }
            else if (dFim != "")
            {
                DateTime di, df;
                di = DateTime.Parse(dIni);
                df = DateTime.Parse(dFim);

                if (di > df)
                {
                    lbEDIni.Show();
                    lbEDFim.Show();
                    lbErros.Text += "Data do início tem de ser menor que a data do fim.\n";
                    erro = true;
                }
            }

            if (des == "")
            {
                lbEDes.Show();
                lbErros.Text += "Tem de inserir uma descrição da ocorrencia.\n";
                erro = true;
            }

            if (local == "")
            {
                lbELocal.Show();
                lbErros.Text += "Tem de inserir a localidade da ocorrencia.\n";
                erro = true;
            }

            if (codOcorrencia == "")
            {
                lbECod.Show();
                lbErros.Text += "Tem de seleccionar um código de ocorrencia. \n";
                erro = true;
            }

            if (cons == "")
            {
                lbECons.Show();
                lbErros.Text += "Tem de seleccionar um conselho.\n";
                erro = true;
            }

            if (freg == "")
            {
                lbEFreg.Show();
                lbErros.Text += "Tem de seleccionar uma freguesia.\n";
                erro = true;
            }

            if (cblViat.CheckedItems.Count <= 0)
            {
                lbEViat.Show();
                lbErros.Text += "Tem de seleccionar pelo menos um.\n";
                erro = true;
            }

            if (erro)
            {
                MessageBox.Show("Exitem campos incorrectos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            con.Open();
            if (aO)
            {
                cmd.CommandText = "UPDATE occorencia SET descricao='" + des + "', hora_chegada_local='" + hCLocal + "', hora_alerta='" + hAlerta + "', data_inicio='" + dIni + "', data_fim='" + dFim + "', codigo_proteccao_civil='" + codOcorrencia + "', hora_chegada_quartel='" + hCQuartel + "', local='" + local + "', codigo_occorencia_id_codigo_occorencia='" + codOcorrencia + "', conselho='" + cons + "', freguesia='" + freg + "' WHERE id_occorencia='" + idOc + "'";
                cmd.ExecuteNonQuery();
                //for (int i = 0; i < cblViat.CheckedItems.Count; i++)
                //{
                //    int au = 0;
                //    cmd.CommandText = "DELTE FROM bombeiro_occorencia WHERE occorencia_id_occorencia='" + idOco + "'";
                //    cmd.ExecuteNonQuery();
                //    cmd.CommandText = "DELTE FROM viatura_occorencia WHERE occorencia_id_occorencia='" + idOco + "'";
                //    cmd.ExecuteNonQuery();
                //    cmd.CommandText = "INSERT INTO viatura_occorencia (viatura_codigo_viatura, occorencia_id_occorencia) VALUES ('" + cblViat.CheckedItems[i].ToString() + "', '" + idOco + "')";
                //    cmd.ExecuteNonQuery();
                //    cmd.CommandText = "SELECT COUNT(bombeiro_numero_bombeiro) FROM equipa WHERE viatura_codigo_viatura='" + cblViat.CheckedItems[i].ToString() + "'";
                //    reader = cmd.ExecuteReader();
                //    if (reader.HasRows)
                //    {
                //        au = Convert.ToInt32(reader[0]);
                //    }
                //    reader.Close();
                //    String bombs = "";
                //    cmd.CommandText = "SELECT bombeiro_numero_bombeiro FROM equipa WHERE viatura_codigo_viatura='" + cblViat.CheckedItems[i].ToString() + "'";
                //    reader = cmd.ExecuteReader();
                //    if (reader.HasRows)
                //    {
                //        reader.Read();
                //        for (int j = 0; j < au; j++)
                //        {
                //            bombs += reader[0].ToString() + ",";
                //        }
                //    }
                //    reader.Close();
                //    String[] bmb = bombs.Split(',');
                //    for (int j = 0; j < bmb.Length; j++)
                //    {
                //        cmd.CommandText = "INSERT INTO bombeiro_occorencia (bombeiro_numero_bombeiro, occornecia_id_occorencia) VALUES ('" + bmb[j] + "', '" + idOco + "')";
                //        cmd.ExecuteNonQuery();
                //    }
                //}

                MessageBox.Show("Actualizou uma ocorrencia com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (idOco == "")
                {
                    cmd.CommandText = "INSERT INTO occorencia (hora_despacho_quartel, descricao, hora_chegada_local, hora_alerta, data_inicio, data_fim, codigo_proteccao_civil, hora_chegada_quartel, local, codigo_occorencia_id_codigo_occorencia, conselho, freguesia, estado) VALUES ('" + hDQuartel + "', '" + des + "','" + hCLocal + "', '" + hAlerta + "', '" + dIni + "', '" + dFim + "', '" + cPCivil + "', '" + hCQuartel + "', '" + local + "', '" + codOcorrencia + "', '" + cons + "', '" + freg + "', 'Activo')";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "SELECT TOP 1 id_occorencia,estado FROM occorencia ORDER BY id_occorencia DESC";
                    reader = cmd.ExecuteReader();
                    int au = 0;
                    if (reader.HasRows)
                        reader.Read();
                    idOco = reader["id_occorencia"].ToString();
                    state = reader["estado"].ToString();
                    reader.Close();
                    for (int i = 0; i < cblViat.CheckedItems.Count; i++)
                    {
                        cmd.CommandText = "INSERT INTO viatura_occorencia (viatura_codigo_viatura, occorencia_id_occorencia) VALUES ('" + cblViat.CheckedItems[i].ToString() + "', '" + idOco + "')";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "UPDATE viatura SET estado ='1' WHERE codigo='" + cblViat.CheckedItems[i].ToString() + "'";
                        cmd.ExecuteNonQuery();
                        //cmd.CommandText = "SELECT COUNT(bombeiro_numero_bombeiro) as num FROM equipa, equipa_bombeiro WHERE equipa_id_equipa = id_equipa AND viatura_codigo_viatura='" + cblViat.CheckedItems[i].ToString() + "'";
                        //reader = cmd.ExecuteReader();
                        //if (reader.HasRows)
                        //{
                        //    au = Convert.ToInt32(reader["num"].ToString());
                        //}
                        //reader.Close();
                        String bombs = "";
                        cmd.CommandText = "SELECT bombeiro_numero_bombeiro FROM equipa, equipa_bombeiro WHERE equipa_id_equipa = id_equipa AND viatura_codigo_viatura='" + cblViat.CheckedItems[i].ToString() + "'";
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while(reader.Read())
                                bombs += reader[0].ToString() + ",";
                        }
                        reader.Close();
                        String[] bmb = bombs.Split(',');
                        for (int j = 0; j < bmb.Length-1; j++)
                        {
                            cmd.CommandText = "INSERT INTO bombeiro_occorencia (bombeiro_numero_bombeiro, occornecia_id_occorencia) VALUES ('" + bmb[j] + "', '" + idOco + "')";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = "UPDATE bombeiro SET estado='1' WHERE numero_bombeiro='" + bmb[j] + "'";
                            cmd.ExecuteNonQuery();
                        }
                    }
                    bool open = false;
                    foreach (Form f in Application.OpenForms)
                        if (f == quilo)
                        {
                            open = true;
                        }
                    if (!open)
                    {
                        quilo = new Quilometragem(idOco);
                        quilo.Show();
                    }
                    else
                        quilo.Focus();
                }
                else if (state.TrimEnd() == "Activo")
                {

                    cmd.CommandText = "SELECT estado FROM occorencia WHERE (id_occorencia='" + idOco + "')";
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        state = reader["estado"].ToString();
                        reader.Close();
                    }
                    if (state.TrimEnd() == "Activo")
                    {
                        bool open = false;
                        foreach (Form f in Application.OpenForms)
                            if (f == quilo)
                            {
                                open = true;
                            }
                        if (!open)
                        {
                            quilo = new Quilometragem(idOco);
                            quilo.Show();
                        }
                        else
                            quilo.Focus();
                        cmd.CommandText = "UPDATE occorencia SET descricao='" + des + "', hora_chegada_local='" + hCLocal + "', hora_alerta='" + hAlerta + "', data_inicio='" + dIni + "', data_fim='" + dFim + "', codigo_proteccao_civil='" + codOcorrencia + "', hora_chegada_quartel='" + hCQuartel + "', local='" + local + "', codigo_occorencia_id_codigo_occorencia='" + codOcorrencia + "', conselho='" + cons + "', freguesia='" + freg + "' WHERE id_occorencia='" + idOc + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Actualizou uma ocorrencia com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (hDQuartel == "")
                        {
                            lbEHDQ.Show();
                            erro = true;
                            lbErros.Text = "Tem de inserir uma hora de despacho. \n";
                        }
                        if (hCLocal == "")
                        {
                            lbEHCL.Show();
                            erro = true;
                            lbErros.Text = "Tem de inserir uma hora de despacho. \n";
                        }
                        if (dFim == "")
                        {
                            lbEDFim.Show();
                            erro = true;
                            lbErros.Text = "Tem de inserir uma hora de despacho. \n";
                        }
                        cmd.CommandText = "UPDATE occorencia SET descricao='" + des + "', hora_chegada_local='" + hCLocal + "', hora_alerta='" + hAlerta + "', data_inicio='" + dIni + "', data_fim='" + dFim + "', codigo_proteccao_civil='" + codOcorrencia + "', hora_chegada_quartel='" + hCQuartel + "', local='" + local + "', codigo_occorencia_id_codigo_occorencia='" + codOcorrencia + "', conselho='" + cons + "', freguesia='" + freg + "' WHERE id_occorencia='" + idOc + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Inseriu uma ocorrencia com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        idOco = "";
                    }
                }
            }
            con.Close();


        }

        private void cmbDataInicioMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDataInicoDD.Items.Clear();
            if (cmbDataInicioMM.SelectedIndex == -1)
                return;
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbDatInicioYYYY.SelectedIndex), Convert.ToInt32(cmbDataInicioMM.SelectedIndex) + 1); i++)
                cmbDataInicoDD.Items.Add(i);
            cmbDataInicoDD.Enabled = true;
        }

        private void cmbDataFimMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDataFimDD.Items.Clear();
            if (cmbDataFimMM.SelectedIndex == -1)
                return;
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbDataFimYYYY.SelectedIndex), Convert.ToInt32(cmbDataFimMM.SelectedIndex) + 1); i++)
                cmbDataFimDD.Items.Add(i);
            cmbDataFimDD.Enabled = true;
        }

        private void cmbDatInicioYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDataInicioMM.Enabled = true;
        }

        private void cmbDataFimYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDataFimMM.Enabled = true;
        }

        private void cmbDataYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDataMM.Enabled = true;
        }

        private void cmbDataMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDataMM.SelectedIndex == -1)
                return;
            cmbDataFimDD.Items.Clear();

            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbDataYYYY.SelectedIndex), Convert.ToInt32(cmbDataMM.SelectedIndex) + 1); i++)
                cmbDataDD.Items.Add(i);
            cmbDataDD.Enabled = true;
        }

        private void cmbCons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCons.SelectedIndex == -1)
                return;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd;
            String cons;
            SqlDataReader reader;
            cmbFreg.Items.Clear();
            con.Open();
            cmd = new SqlCommand("SELECT id_conselho FROM conselho WHERE nome='" + cmbCons.SelectedItem.ToString() + "'", con);
            reader = cmd.ExecuteReader();
            reader.Read();
            cons = reader[0].ToString();
            reader.Close();
            cmd = new SqlCommand("SELECT * FROM freguesia WHERE conselho_id_conselho=" + cons, con);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;

                while (reader.Read())
                {

                    cmbFreg.Items.Insert(i, reader["nome"]);
                    i++;
                }
            }

            reader.Close();

            con.Close();
        }

        private void btnGuardarReg_Click(object sender, EventArgs e)
        {
            lbEBomb.Hide();
            lbEVia.Hide();
            lbECom.Hide();
            lbEData.Hide();
            lbEHora.Hide();
            lbErros.Text = "";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            bool erro = false;
            String data = "", hora = "", desc = "", bomb = "", viat = "", idReg = "";
            if (cmbDataYYYY.SelectedItem != null && cmbDataMM.SelectedItem != null && cmbDataDD.SelectedItem != null)
                data = cmbDataYYYY.SelectedItem.ToString() + "-" + cmbDataMM.SelectedItem.ToString() + "-" + cmbDataDD.SelectedItem.ToString();
            if (cmbComHH.SelectedItem != null && cmbComMM.SelectedItem != null)
                hora = cmbComHH.SelectedItem.ToString() + ":" + cmbComMM.SelectedItem.ToString();
            desc = txtDesc.Text;
            if (cmbBomb.SelectedItem != null)
                bomb = cmbBomb.SelectedValue.ToString();
            if (cmbViat.SelectedItem != null)
                viat = cmbViat.SelectedValue.ToString();
            desc = txtCom.Text;

            if (desc == "")
            {
                lbECom.Show();
                erro = true;
                lbErros.Text += "Tem de escrever a comunicação.\n";
            }

            if (data == "")
            {
                lbEData.Show();
                erro = true;
                lbErros.Text += "Tem de seleccionar uma data uma data.\n";
            }

            if (hora == "")
            {
                lbEHora.Show();
                erro = true;
                lbErros.Text += "Tem de seleccionar uma hora. \n";
            }

            if (bomb == "")
            {
                lbEBomb.Show();
                lbErros.Text += "Tem de seleccionar um bombeiro.\n";
                erro = true;
            }

            if (viat == "")
            {
                lbEVia.Show();
                lbErros.Text += "Tem de seleccionar uma viatura.\n";
                erro = true;
            }

            if (idOco == "")
            {
                lbErros.Text += "Tem de estar atribuido a uma ocorrencia.\n";
                erro = true;
            }

            if (erro)
            {
                MessageBox.Show("Existem campos incorrectos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Open();
            cmd.CommandText = "INSERT INTO registo_comunicacoes (data,hora,descricao,occorencia_id_occorencia) VALUES ('" + data + "', '" + hora + "', '" + desc + "', '" + idOco + "')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "SELECT TOP 1 id_registo_comunicacoes FROM registo_comunicacoes ORDER BY id_registo_comunicacoes DESC";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                idReg = reader[0].ToString();
            }
            reader.Close();
            cmd.CommandText = "INSERT INTO registoComunicacoes_bombeiro (registo_comunicacoes_id_registo_comunicacoes, bombeiro_numero_bombeiro) VALUES('" + idReg + "', '" + bomb + "')";
            cmd.ExecuteNonQuery();

            cmd.CommandText = "INSERT INTO registoComunicacoes_viatura (registo_comunicacoes_id_registo_comunicacoes, viatura_codigo_viatura) VALUES('" + idReg + "', '" + viat + "')";
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Inseriu um registo de comunicações com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnApagarOcc_Click(object sender, EventArgs e)
        {
            txtCodProtCivil.Text = "";
            cmbHorAlertaHH.SelectedIndex = -1;
            cmbHorAlertaMM.SelectedIndex = -1;
            cmbHcQuartelHH.SelectedIndex = -1;
            cmbHcQuartelMM.SelectedIndex = -1;
            cmbHdQuartelHH.SelectedIndex = -1;
            cmbHdQuartelMM.SelectedIndex = -1;
            cmbHlocalHH.SelectedIndex = -1;
            cmbHlocalMM.SelectedIndex = -1;
            cmbDataFimDD.SelectedIndex = -1;
            cmbDataFimMM.SelectedIndex = -1;
            cmbDataFimYYYY.SelectedIndex = -1;
            cmbDataInicoDD.SelectedIndex = -1;
            cmbDataInicioMM.SelectedIndex = -1;
            cmbDatInicioYYYY.SelectedIndex = -1;
            cmbCons.SelectedIndex = -1;
            cmbFreg.SelectedIndex = -1;
            txtLocal.Text = "";
            txtDesc.Text = "";
            if (!aO)
                for (int i = 0; i < cblViat.Items.Count; i++)
                    cblViat.SetItemChecked(i, false);
        }

        private void btnApagarReg_Click(object sender, EventArgs e)
        {
            txtCom.Text = "";
            cmbComMM.SelectedIndex = -1;
            cmbComHH.SelectedIndex = -1;
            cmbDataDD.SelectedIndex = -1;
            cmbDataMM.SelectedIndex = -1;
            cmbDataYYYY.SelectedIndex = -1;
            cmbBomb.SelectedIndex = -1;
            cmbViat.SelectedIndex = -1;
        }



    }
}
