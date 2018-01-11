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
    public partial class InserirConcFreg : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        public InserirConcFreg()
        {
            InitializeComponent();
        }

        private void btnGuardarConc_Click(object sender, EventArgs e)
        {
            lbErros.Text = "";
            lbEConc.Visible = false;
            lbESiglaConc.Visible = false;

            String concelho = "", sigla = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            bool erro = false;

            concelho = txtInsConc.Text;
            sigla = txtSiglaConc.Text;

            if (!Validator.isName(concelho) || concelho == "")
            {
                lbEConc.Visible = true;
                lbErros.Text += "Tem de inserir um concelho que contenha apenas letras. \n";
                erro = true;
            }
            if (!Validator.isName(sigla) || sigla == "")
            {
                lbESiglaConc.Visible = true;
                lbErros.Text += "Tem de inserir um concelho que contenha apenas letras. \n";
                erro = true;
            }
            if (erro == true)
            {
                MessageBox.Show("Existem campos incorrectos");
                return;
            }
            con.Open();
            cmd.CommandText = "INSERT INTO conselho (nome, sigla) VALUES ('" + concelho + "', '" + sigla + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inseriu um concelho com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        private void btnGuardarFreg_Click(object sender, EventArgs e)
        {
            lbErros.Text = "";
            lbEfreg.Visible = false;
            lbESiglaFreg.Visible = false;
            lbECmbConc.Visible = false;

            String concelho = "", sigla = "", freguesia = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            bool erro = false;


            freguesia = txtInsFreg.Text;
            sigla = txtSiglaFreg.Text;
            if (cmbConc.SelectedItem != null)
                concelho = cmbConc.SelectedValue.ToString();

            if (!Validator.isName(freguesia) || freguesia == "")
            {
                lbEfreg.Visible = true;
                lbErros.Text += "Tem de inserir uma freguesia que só contenha letras. \n";
                erro = true;
            }
            if(!Validator.isName(sigla) || sigla == "")
            {
                lbESiglaFreg.Visible = true;
                lbErros.Text += "Tem de inserir uma sigla que só contenha letras. \n";
                erro = true;
            }
            if (concelho == "")
            {
                lbECmbConc.Visible = true;
                lbErros.Text += "Tem de seleccionar um concelho. \n";
            }
            if (erro == true)
            {
                MessageBox.Show("Existem campos incorrectos");
                return;
            }
            con.Open();
            cmd.CommandText = "INSERT INTO freguesia (nome, sigla, conselho_id_conselho) VALUES ('" + freguesia + "', '" + sigla + "', '" + concelho + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inseriu uma freguesia com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        private void InserirConcFreg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet.conselho' table. You can move, or remove it, as needed.
            this.conselhoTableAdapter.Fill(this.fireStationDataSet.conselho);
            cmbConc.SelectedIndex = -1;

        }

        private void btnApagarConc_Click(object sender, EventArgs e)
        {
            txtInsConc.Text = "";
            txtSiglaConc.Text = "";
            lbErros.Text = "";
            lbEConc.Visible = false;
            lbESiglaConc.Visible = false;
        }

        private void btnApagarFreg_Click(object sender, EventArgs e)
        {
            cmbConc.SelectedIndex = -1;
            txtInsFreg.Text = "";
            txtSiglaFreg.Text = "";
            lbErros.Text = "";
            lbEfreg.Visible = false;
            lbESiglaFreg.Visible = false;
            lbECmbConc.Visible = false;
        }
    }
}
