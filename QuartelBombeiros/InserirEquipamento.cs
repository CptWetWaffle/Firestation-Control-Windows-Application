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
    public partial class InserirEquipamento : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        private String id = "";
        public InserirEquipamento()
        {
            InitializeComponent();
        }

        public InserirEquipamento(String id):this()
        {
            this.id = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lbEBombViat.Visible = false;
            lbENome.Visible = false;
            lbEQuant.Visible = false;
            lbErros.Text = "";
            String nome = "", quantidade = "", descricao = "", tipo = "";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            bool erro = false;

            nome = txtNome.Text;
            quantidade = txtQuant.Text;
            descricao = txtDesc.Text;

            if (!Validator.isName(nome) || nome == "")
            {
                lbENome.Visible = true;
                erro = true;
                lbErros.Text += "O nome não pode conter caracteres especiais nem números.\n";
            }


            if (!Validator.isNumeric(quantidade) || quantidade == "")
            {
                lbEQuant.Visible = true;
                erro = true;
                lbErros.Text += "Quantidade só permite números.\n";
            }

            if (rbBomb.Checked)
                tipo = "B";
            else if (rbViat.Checked)
                tipo = "V";
            else
            {
                lbErros.Text += "Tem de seleccionar o tipo de equipamento. \n";
                erro = true;
                lbEBombViat.Visible = true;
            }

            if (erro == true)
            {
                MessageBox.Show("Existem campos incorrectos.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            con.Open();
            if (id == "")
            {
                cmd.CommandText = " INSERT INTO equipamento ( nome, quantidade_total, quantidade_disponivel, descricao, tipo ) VALUES ('" + nome + "', '" + quantidade + "', '" + quantidade + "', '" + descricao + "', '" + tipo + "') ";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inseriu o novo equipamento com sucesso!", "Sucesso!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cmd.CommandText = " UPDATE equipamento SET nome = '" + nome + "', quantidade_total = quantidade_total +'" + quantidade + "', quantidade_disponivel= quantidade_disponivel +'" + quantidade + "', descricao='" + descricao + "', tipo='" + tipo + "' WHERE id_equipamento ='" + id + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Actualizou o novo equipamento com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rbViat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbBomb_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtQuant.Text = "";
            txtDesc.Text = "";
        }

        private void InserirEquipamento_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            if(id!="")
            {
                con.Open();
                cmd.CommandText = "SELECT * from equipamento WHERE id_equipamento='"+id+"'";
                reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    reader.Read();
                    String aux = reader[5].ToString().ToLower();
                    if (aux == "b")
                        rbBomb.Checked = true;
                    else
                        rbViat.Checked = true;
                    txtNome.Text = reader["nome"].ToString();
                    txtQuant.Text = reader["quantidade_disponivel"].ToString();
                    txtDesc.Text = reader["descricao"].ToString();
                    lbQuant.Text = "/" + reader["quantidade_total"].ToString();

                   
                }
                reader.Close();
                con.Close();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        
    }
}
