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
    public partial class Quilometragem : Form
    {
        private String id;
        private TextBox[] Kilometros;
        private String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        private String[] codigos;
        public Quilometragem()
        {
            InitializeComponent();
        }

        public Quilometragem(String id)
            : this()
        {
            this.id = id;

        }



        private void Quilometragem_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;

            con.Open();
            cmd.CommandText = "SELECT COUNT(viatura.codigo)FROM viatura, viatura_occorencia WHERE (codigo = viatura_codigo_viatura AND occorencia_id_occorencia='" + id + "')";
            reader = cmd.ExecuteReader();
            reader.Read();
            codigos = new String[Convert.ToInt32(reader[0].ToString())];
            reader.Close();
            cmd.CommandText = "SELECT viatura.codigo FROM viatura, viatura_occorencia WHERE (codigo = viatura_codigo_viatura AND occorencia_id_occorencia='" + id + "')";
            reader = cmd.ExecuteReader(); int i = 0;
            if (reader.HasRows)
            {

                while (reader.Read())
                {
                    codigos[i] = reader["codigo"].ToString();
                    i++;

                }
                Kilometros = new TextBox[i];

            }
            reader.Close();
            con.Close();
            TextBox t;
            for (int j = 0; j < i; j++)
            {
                Label l = new Label();

                l.Name = "";
                l.Text = codigos[j];
                l.Size = new Size(100, 50);
                l.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                l.Location = new Point(0, j * 50);
                t = new TextBox();
                t.Name = "txtKil" + j.ToString();
                t.Text = "";
                t.Size = new Size(150, 50);
                t.Font = new Font("Century Gothic", 14);
                t.Location = new Point(100, j * 50);
                Kilometros[j] = t;
                this.panel1.Controls.Add(l);
                this.panel1.Controls.Add(t);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            con.Open();
            int j = 0;
            for (int i = 0; i < Kilometros.Length; i++)
                if (!Validator.isNumeric(Kilometros[i].Text))
                {
                    MessageBox.Show("Apenas pode inserir valores numericos nas quilometragens!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            for (int i = 0; i < Kilometros.Length; i++)
                if (Kilometros[i].Text == "")
                    j++;
                else
                    Kilometros[i].Enabled = false;

                
            if (j == 0)
            {

                for (int i = 0; i < Kilometros.Length; i++)
                {

                    cmd.CommandText = "UPDATE viatura SET kilometragem='" + Kilometros[i].Text + "' WHERE (codigo ='" + codigos[i] + "')";
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = "UPDATE occorencia SET estado='Inactivo' WHERE (id_occorencia='" + this.id + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Todas as quilometragens foram inseridas com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Close();
            }
            con.Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Kilometros.Length; i++)
            {
                Kilometros[i].Enabled = true;
                Kilometros[i].Text = "";
            }
        }

    }
}
