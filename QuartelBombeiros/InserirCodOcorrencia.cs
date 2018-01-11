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
    public partial class InserirCodOcorrencia : Form
    {
        private String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        public InserirCodOcorrencia()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbEnome.Visible = false;
            lbEcod.Visible = false;
            lbErros.Text = "";

            String nome = "", codigo = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            bool erro = false;

            nome = txtNome.Text;
            codigo = txtCod.Text;

            if (!Validator.isName(nome) || nome == "")
            {
                lbEnome.Visible = true;
                erro = true;
                lbErros.Text += "Tem de inserir um nome que não contenha caracteres especiais nem números. \n";
            }
            if (!Validator.isNumeric(codigo) || codigo == "")
            {
                lbEcod.Visible = true;
                erro = true;
                lbErros.Text += "Tem de inserir um código que contenha apenas números. \n";
            }
            if (erro == true)
            {
                MessageBox.Show("Existem campos incorrectos");
                return;
            }
            con.Open();
            cmd.CommandText = "SELECT * FROM codigo_occorencia WHERE id_codigo_occorencia='" + codigo + "'";
            reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                MessageBox.Show("Esse código já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reader.Close();
            cmd.CommandText = "INSERT INTO codigo_occorencia (id_codigo_occorencia, nome) VALUES ('" + codigo + "', '" + nome + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inseriu um código de ocorrência com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNome.Text = "";
            lbEnome.Visible = false;
            lbEcod.Visible = false;
            lbErros.Text = "";
        }

        private void InserirCodOcorrencia_Load(object sender, EventArgs e)
        {

        }
    }
}
