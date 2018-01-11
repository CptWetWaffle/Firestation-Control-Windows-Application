using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Drawing.Imaging;

namespace QuartelBombeiros
{
    public partial class FichaBombeiro : Form
    {
        private byte[] fByte;
        private String numeroB = "";
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        private bool first = false;
        public FichaBombeiro(String num)
            : this()
        {
            this.numeroB = num;
        }

        public FichaBombeiro(String num, bool first)
            : this()
        {
            this.numeroB = num;
            this.first = true;
        }

        public FichaBombeiro()
        {
            InitializeComponent();
        }
        private ImageFormat Format(String path)
        {
            String[] aux = path.Split('.');
            switch (aux.Last<String>().ToString().ToLower())
            {
                case "gif": return ImageFormat.Gif;
                case "png": return ImageFormat.Png;
                case "jpg": return ImageFormat.Jpeg;
                case "jpeg": return ImageFormat.Jpeg;
                case "bmp": return ImageFormat.Bmp;
                default: return null;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtFoto.Text = "";
            lbErros.Text = "";
            pcTeste.Image = null;
            Browse.ShowDialog();
            txtFoto.Text = Browse.FileName;
            if (txtFoto.Text.ToString() != "" && Format(txtFoto.Text) != null)
            {


                Image teste = Image.FromFile(Browse.FileName);
                MemoryStream ms = new MemoryStream();

                teste.Save(ms, Format(Browse.FileName));
                fByte = ms.ToArray();

                if (fByte.Length > 256000)
                {
                    Browse.FileName = txtFoto.Text = "";
                    MessageBox.Show("A foto não pode ultrapassar os 250kb", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbEFoto.Visible = true;
                    lbErros.Text += "A foto não pode ultrapassar os 250kb";
                    return;
                }

                pcTeste.Image = teste;
                Browse.FileName = "";


            }
            else
            {
                pcTeste.Image = null;
                Browse.FileName = txtFoto.Text = "";
                MessageBox.Show("Tem de inserir uma foto com o formato correcto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbEFoto.Visible = true;
                lbErros.Text += "Tem de inserir uma imagem com o formato .Png, .Jpg ou .Gif";
                return;
            }




        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtCodPos.Text = "";
            txtDist.Text = "";
            txtEmail.Text = "";
            txtFoto.Text = "";
            txtMorada.Text = "";
            txtNac.Text = "";
            txtNat.Text = "";
            txtNif.Text = "";
            txtNome.Text = "";
            txtNSegSoc.Text = "";
            txtNUtente.Text = "";
            txtServMil.Text = "";
            txtTele.Text = "";
            lbECodPost.Visible = false;
            lbECons.Visible = false;
            lbEData.Visible = false;
            lbEDist.Visible = false;
            lbEEmail.Visible = false;
            lbEEstCiv.Visible = false;
            lbEFoto.Visible = false;
            lbEFreg.Visible = false;
            lbEGrupSang.Visible = false;
            lbEMor.Visible = false;
            lbENac.Visible = false;
            lbENat.Visible = false;
            lbENBICC.Visible = false;
            lbENIF.Visible = false;
            lbENome.Visible = false;
            lbENSegSoc.Visible = false;
            lbENumBomb.Visible = false;
            lbENUtente.Visible = false;
            lbEPat.Visible = false;
            lbEServMil.Visible = false;
            lbETele.Visible = false;
            lbErros.Text = "";
            cmbCons.SelectedIndex = -1;
            cmbDD.SelectedIndex = -1;
            cmbEstCiv.SelectedIndex = -1;
            cmbFreg.SelectedIndex = -1;
            cmbGrupSang.SelectedIndex = -1;
            cmbMM.SelectedIndex = -1;
            cmbPat.SelectedIndex = -1;
            cmbYYYY.SelectedIndex = -1;
           
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbECodPost.Visible = false;
            lbECons.Visible = false;
            lbEData.Visible = false;
            lbEDist.Visible = false;
            lbEEmail.Visible = false;
            lbEEstCiv.Visible = false;
            lbEFoto.Visible = false;
            lbEFreg.Visible = false;
            lbEGrupSang.Visible = false;
            lbEMor.Visible = false;
            lbENac.Visible = false;
            lbENat.Visible = false;
            lbENBICC.Visible = false;
            lbENIF.Visible = false;
            lbENome.Visible = false;
            lbENSegSoc.Visible = false;
            lbENumBomb.Visible = false;
            lbENUtente.Visible = false;
            lbEPat.Visible = false;
            lbEServMil.Visible = false;
            lbETele.Visible = false;
            lbErros.Text = "";


            String nome = "", naturalidade = "", morada = "", nacionalidade = "", codigoPostal = "", conselho = "", email = "", telefone = "", nSegSocial = "", nBICC = "", estadoCivil = "", patente = "", nUtente = "", nServMilitar = "", observacoes = "", grupoSangue = "", dataNasc = "", freguesia = "", numBomb = "", distrito = "", foto = "", NIF = "";
            Char vacinacao;

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            bool erro = false;
            nome = txtNome.Text;
            naturalidade = txtNat.Text;
            morada = txtMorada.Text;
            nacionalidade = txtNac.Text;
            codigoPostal = txtCodPos.Text;
            if (cmbCons.SelectedItem != null)
                conselho = cmbCons.SelectedItem.ToString();
            email = txtEmail.Text;
            telefone = txtTele.Text;
            nSegSocial = txtNSegSoc.Text;
            nBICC = txtNBICC.Text + txtNBICC2.Text;
            if (cmbEstCiv.SelectedItem != null)
                estadoCivil = cmbEstCiv.SelectedItem.ToString();
            if (cmbPat.SelectedItem != null)
                patente = cmbPat.SelectedItem.ToString();
            nUtente = txtNUtente.Text;
            nServMilitar = txtServMil.Text;
            observacoes = txtObs.Text;
            if (cmbGrupSang.SelectedItem != null)
                grupoSangue = cmbGrupSang.SelectedItem.ToString();
            if (cmbYYYY.SelectedItem != null && cmbMM.SelectedItem != null && cmbDD.SelectedItem != null)
                dataNasc = cmbYYYY.SelectedItem.ToString() + "-" + cmbMM.SelectedItem.ToString() + "-" + cmbDD.SelectedItem.ToString();
            if (cmbFreg.SelectedItem != null)
                freguesia = cmbFreg.SelectedItem.ToString();
            numBomb = txtNumBomb.Text;
            distrito = txtDist.Text;
            foto = txtFoto.Text;
            NIF = txtNif.Text;


            if (!Validator.isNumeric(numBomb) || numBomb == "")
            {
                erro = true;
                lbENumBomb.Visible = true;

            }

            if (rbVacSim.Checked)
                vacinacao = 'S';
            else
                vacinacao = 'N';

            if (!Validator.isName(nome) || nome == "")
            {
                lbENome.Visible = true;
                erro = true;
                lbErros.Text += "O nome não pode conter caracteres especiais nem números.\n";
            }
            if (Validator.hasSpecialChars(morada))
            {
                lbEMor.Visible = true;
                erro = true;
                lbErros.Text += "A morada não pode conter caraceres especiais.\n";
            }
            if (!Validator.isBI(nBICC) || nBICC == "")
            {
                lbENBICC.Visible = true;
                erro = true;
                lbErros.Text += "O número do BI está incorrecto.\n";
            }
            if (!Validator.isEmail(email) || email == "")
            {
                lbEEmail.Visible = true;
                erro = true;
                lbErros.Text += "O email está incorrecto.\n";
            }
            if (!Validator.isNIF(NIF) || NIF == "")
            {
                lbENIF.Visible = true;
                erro = true;
                lbErros.Text += "O NIF está incorrecto.\n";
            }
            if (!Validator.isPostCode(codigoPostal))
            {
                lbECodPost.Visible = true;
                erro = true;
                lbErros.Text += "O código postal está incorrecto.\n";
            }

            if (foto == "")
            {
                lbEFoto.Visible = true;
                erro = true;
                lbErros.Text += "Tem de inserir uma foto.\n";
            }

            if (!Validator.isNumeric(nSegSocial, 5))
            {
                lbENSegSoc.Visible = true;
                erro = true;
                lbErros.Text += "O número de segurança social só permite números.\n";
            }

            if (!Validator.isNumeric(nServMilitar, 5))
            {
                lbEServMil.Visible = true;
                erro = true;
                lbErros.Text += "O número de serviço militar só permite números.\n";
            }
            if (!Validator.isNumeric(nUtente) || nUtente == "")
            {
                lbENUtente.Visible = true;
                erro = true;
                lbErros.Text += "O número de utente só permite números.\n";
            }
            if (!Validator.isNumeric(telefone) || telefone == "")
            {
                lbETele.Visible = true;
                erro = true;
                lbErros.Text += "O número de telefone só permite números.\n";
            }
            if (!Validator.isName(naturalidade))
            {
                lbENat.Visible = true;
                erro = true;
                lbErros.Text += "A naturalidade não permite caracteres especiais nem números.\n";
            }
            if (!Validator.isName(nacionalidade) && !nacionalidade.Contains(' '))
            {
                lbENac.Visible = true;
                erro = true;
                lbErros.Text += "A nacionalidade não permite caracteres especiais nem números.\n";
            }
            if (!Validator.isName(distrito))
            {
                lbEDist.Visible = true;
                erro = true;
                lbErros.Text += "O distrito não permite caracteres especiais nem números.\n";
            }
            if (Validator.hasAge(dataNasc))
            {
                lbEData.Visible = true;
                erro = true;
                lbErros.Text += "Não tem idade para estar nos bombeiros.\n";
            }


            if (patente == "")
            {
                lbEPat.Visible = true;
                erro = true;
                lbErros.Text += "Tem de inserir uma patente.\n";
            }

            if (grupoSangue == "")
            {
                lbEGrupSang.Visible = true;
                erro = true;
                lbErros.Text += "Tem de inserir o seu grupo de sangue.\n";
            }

            if (erro == true)
            {
                MessageBox.Show("Existem campos incorrectos.");
                return;
            }
            con.Open();
            if (first)
            {
                cmd.CommandText = " INSERT INTO ficha_bombeiro ( BI, email, observacoes, data_nascimento, foto, patente, bombeiro_num_bombeiro, naturalidade, nacionalidade, morada, conselho, freguesia, distrito, codigo_postal, num_seg_social, estado_civil, num_utente, num_serv_militar, vacina_act, grupo_sang, nome, NIF ) VALUES ('" + nBICC + "', '" + email + "', '" + observacoes + "', '" + dataNasc + "', @foto, '" + patente + "', '" + numBomb + "', '" + naturalidade + "', '" + nacionalidade + "', '" + morada + "', '" + conselho + "', '" + freguesia + "', '" + distrito + "', '" + codigoPostal + "', '" + nSegSocial + "', '" + estadoCivil + "', '" + nUtente + "', '" + nServMilitar + "', '" + vacinacao + "', '" + grupoSangue + "', '" + nome + "', '" + NIF + "' )  ";
                cmd.Parameters.AddWithValue("@foto", fByte);
                cmd.ExecuteNonQuery();


                cmd.CommandText = "INSERT INTO telefone (ficha_bombeiro_BI, numero) VALUES('" + nBICC + "','" + telefone + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inseriu a ficha do bombeiro com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (!txtNumBomb.Enabled)
                {
                    cmd.CommandText = "UPDATE utilizador SET login='1' WHERE bombeiro_num_bombeiro='" + txtNumBomb.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Login form = (Login)Application.OpenForms[0];
                    form.Show();
                    this.Close();

                }
            }
            else
            {
                if (fByte != null)
                    foto = "foto=@foto,";

                cmd.CommandText = " UPDATE ficha_bombeiro SET email= '" + email + "', observacoes='" + observacoes + "', data_nascimento='" + dataNasc + "', " + foto + " patente = '" + patente + "',  naturalidade ='" + naturalidade + "', nacionalidade ='" + nacionalidade + "', morada='" + morada + "', conselho='" + conselho + "', freguesia ='" + freguesia + "', distrito='" + distrito + "', codigo_postal='" + codigoPostal + "', num_seg_social='" + nSegSocial + "', estado_civil='" + estadoCivil + "', num_utente ='" + nUtente + "', num_serv_militar='" + nServMilitar + "', vacina_act='" + vacinacao + "', grupo_sang ='" + grupoSangue + "', nome= '" + nome + "', NIF='" + NIF + "' WHERE (BI='" + nBICC + "')";

                if (foto != "")
                    cmd.Parameters.AddWithValue("@foto", fByte);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizou a ficha do bombeiro com sucesso!","Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
        }

        private void FichaBombeiro_Load(object sender, EventArgs e)
        {
            if (numeroB != "")
            {
                txtNumBomb.Text = numeroB;
                txtNumBomb.Enabled = false;
            }


            for (int i = Convert.ToInt32(DateTime.Now.Year.ToString()); i >= 1900; i--)
                cmbYYYY.Items.Add(i);

            for (int i = 1; i <= 12; i++)
                cmbMM.Items.Add(i);




            SqlConnection con = new SqlConnection(connectionString);

            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand("SELECT * FROM conselho", con);

            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    cmbCons.Items.Insert(i, reader["nome"]);
                    i++;
                }
            }

            reader.Close();
            if (this.numeroB != "")
            {
                cmd.CommandText = "SELECT * FROM ficha_bombeiro WHERE bombeiro_num_bombeiro='" + numeroB + "'";
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    first = false;
                    reader.Read();
                    txtCodPos.Text = reader["codigo_postal"].ToString();
                    txtDist.Text = reader["distrito"].ToString();
                    txtEmail.Text = reader["email"].ToString();
                    txtMorada.Text = reader["morada"].ToString();
                    txtNac.Text = reader["nacionalidade"].ToString();
                    txtNat.Text = reader["naturalidade"].ToString();
                    txtNBICC.Text = reader["BI"].ToString().Substring(0, 8);
                    txtNBICC2.Text = reader["BI"].ToString().Substring(8, 1);
                    txtNif.Text = reader["NIF"].ToString();
                    txtNome.Text = reader["nome"].ToString();
                    txtNSegSoc.Text = reader["num_seg_social"].ToString();
                    txtNUtente.Text = reader["num_utente"].ToString();
                    txtObs.Text = reader["observacoes"].ToString();
                    txtServMil.Text = reader["num_serv_militar"].ToString();
                    cmbCons.SelectedIndex = cmbCons.Items.IndexOf(reader["conselho"]);
                    cmbFreg.SelectedIndex = cmbFreg.Items.IndexOf(reader["freguesia"]);
                    cmbPat.SelectedIndex = cmbPat.Items.IndexOf(reader["patente"]);
                    cmbEstCiv.SelectedIndex = cmbEstCiv.Items.IndexOf(reader["estado_civil"]);
                    cmbGrupSang.SelectedIndex = cmbGrupSang.Items.IndexOf(reader["grupo_sang"].ToString().TrimEnd());
                    String[] auxDN = reader["data_nascimento"].ToString().Split('/');
                    if (auxDN[0] != "")
                    {
                        String[] auxDNY = auxDN[2].Split(' ');
                        cmbYYYY.SelectedIndex = 2014 - Convert.ToInt32(auxDNY[0]);
                        cmbMM.SelectedIndex = Convert.ToInt32(auxDN[1]);
                        cmbDD.SelectedIndex = Convert.ToInt32(auxDN[0]);
                    }
                    Char vac = reader["vacina_act"].ToString()[0];
                    if (vac == 'S')
                        rbVacSim.Checked = true;
                    else
                        rbVacNao.Checked = true;
                    txtNBICC.Enabled = false;
                    txtNBICC2.Enabled = false;

                }
            }


            con.Close();


        }

        private void cmbDD_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbMM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMM.SelectedIndex == -1)
                return;
            cmbDD.Items.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(2013 - Convert.ToInt32(cmbYYYY.SelectedIndex), Convert.ToInt32(cmbMM.SelectedIndex) + 1); i++)
                cmbDD.Items.Add(i);
            cmbDD.Enabled = true;
        }

        private void cmbYYYY_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMM.Enabled = true;
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

        private void Browse_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (numeroB != "")
                    Application.OpenForms[0].Show();
                this.Close();
            }
        }

        private void pnlBomb_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
