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

    public partial class Bombeiro : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        public Bombeiro()
        {
            InitializeComponent();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbENbomb.Visible = false;
            lbEpass.Visible = false;
            lbEtipo.Visible = false;
            lbEuser.Visible = false;
            lbErros.Text = "";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand() ;
            String numBomb = "", username = "", password = "", tipo = "";
            numBomb = txtNumBomb.Text.ToString();
            username = txtUser.Text.ToString();
            password = txtPass.Text.ToString();
            if (cmbTipo.SelectedItem != null)
                tipo = cmbTipo.SelectedItem.ToString();
            String bomCod = "", aux = "";
            bool erro = false;
           

            if (Validator.hasSpecialChars(username) || username.Contains(' ') || username == "")
            {
                lbEuser.Visible = true;
                erro = true;
                lbErros.Text += "Username não pode conter caracteres especiais, excepto '_'.\n";
            }

            if (password.Length < 6 || password.Length > 20)
            {
                erro = true;
                lbEpass.Visible = true;
                lbErros.Text += "A password tem de estar entre 6-20 caracteres.\n";
            }

            if (tipo == "")
            {
                erro = true;
                lbEtipo.Visible = true;
                lbErros.Text += "Tem de seleccionar um tipo.\n";

            }

           
            con.Open();

            if (rbNao.Checked)
                numBomb = "";
            else
            {
                if (!(Validator.isNumeric(numBomb)) || numBomb == "")
                {
                    lbENbomb.Visible = true;
                    erro = true;
                    lbErros.Text += "Tem de inserir números.\n";
                }
                SqlDataReader reader;
                cmd = new SqlCommand("SELECT numero_bombeiro FROM bombeiro", con);
                reader = cmd.ExecuteReader();
                
                while (reader.HasRows && reader.Read())
                    if (reader["numero_bombeiro"].ToString() == numBomb) {
                        lbErros.Text += "O número de bombeiro já existe\n";
                        lbENbomb.Visible = true;
                        erro = true;
                        break;
                    }
                reader.Close();
             
                cmd = new SqlCommand("SELECT username FROM utilizador", con);
                reader = cmd.ExecuteReader();

                while (reader.HasRows && reader.Read())
                    if (reader["username"].ToString() == username)
                    {
                        lbErros.Text += "O utilizador já existe\n";
                        lbEuser.Visible = true;
                        erro = true;
                        break;
                    }
                reader.Close();

                if (erro == true)
                {
                    con.Close();
                    MessageBox.Show("Existem campos incorrectos.");
                    return;
                }
                cmd.CommandText = "INSERT INTO bombeiro (numero_bombeiro) VALUES ('" + numBomb + "')";
                cmd.ExecuteNonQuery();


                aux = "'" + numBomb + "',";
                bomCod = "bombeiro_num_bombeiro,";
            }
            if (erro == true)
            {
                con.Close();
                MessageBox.Show("Existem campos incorrectos.");
                return;
            }
            cmd.CommandText = "INSERT INTO utilizador (username, password, "+ bomCod +" login, tipo) VALUES ('" + username + "','" + password + "'," + aux + "'0', '"+cmbTipo.SelectedItem.ToString()[0]+"')";
            cmd.ExecuteNonQuery();

            if (numBomb != "")
            {
                cmd.CommandText = "UPDATE bombeiro SET utilizador_username = '" + username + "' WHERE (numero_bombeiro = '" + numBomb + "')";
                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Inseriu com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtNumBomb.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
            lbErros.Text = "";
            lbEuser.Visible = false;
            lbEtipo.Visible = false;
            lbEpass.Visible = false;
            lbENbomb.Visible = false;
            cmbTipo.SelectedIndex = -1;
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            txtNumBomb.Enabled = true;
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            txtNumBomb.Enabled = false;
        }

        private void Bombeiro_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }


    }
}
