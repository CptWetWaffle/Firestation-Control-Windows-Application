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

namespace QuartelBombeiros
{
    public partial class VerBombeiro : Form
    {
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        private Bombeiro b;
        public VerBombeiro()
        {
            InitializeComponent();
        }

        private void VerBombeiro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ficha.ficha_bombeiro' table. You can move, or remove it, as needed.
            this.ficha_bombeiroTableAdapter1.Fill(this.ficha.ficha_bombeiro);
            //// TODO: This line of code loads data into the 'fireStationDataSet.ficha_bombeiro' table. You can move, or remove it, as needed.
            //this.ficha_bombeiroTableAdapter.Fill(this.fireStationDataSet.ficha_bombeiro);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ficha_bombeiroTableAdapter.FillBy(this.fireStationDataSet.ficha_bombeiro);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;
            con.Open();

            String aux = dGVBomb.SelectedRows[0].Cells[1].FormattedValue.ToString();
           
            cmd.CommandText = "SELECT foto FROM ficha_bombeiro WHERE BI='" + aux + "'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                byte[] img;

                if (!DBNull.Value.Equals(reader["foto"]))
                     img = (byte[])reader["foto"];
                else
                     img = null;
                if (img == null)
                    pcFoto.Image = null;
                else
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream(img);
                        Image returnImage = Image.FromStream(ms);
                        ms.Close();
                        ms.Dispose();
                        pcFoto.Image = returnImage;
                        int newWidth = 0;
                        if (returnImage.Height > 132)
                        {
                            pcFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                            newWidth = (returnImage.Width * returnImage.Height) / 132;
                            pcFoto.Width = newWidth;
                            pcFoto.Height = 132;
                        }
                        else
                        {
                            pcFoto.SizeMode = PictureBoxSizeMode.Normal;
                            pcFoto.Height = returnImage.Height;
                            pcFoto.Width = returnImage.Width;
                        }
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

            }
            else
                pcFoto.Image = null;
            con.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == b)
                {
                    open = true;
                }
            if (!open)
            {
                b = new Bombeiro();
                b.Show();
            }
            else
                b.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            String nBomb;
            nBomb = dGVBomb.SelectedRows[0].Cells[5].FormattedValue.ToString();
            FichaBombeiro f = new FichaBombeiro(nBomb);
            f.Show();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (MessageBox.Show("Tem a certeza que deseja eleminar esse bombeiro?", "Apagar Bombeiro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                String nBomb = dGVBomb.SelectedRows[0].Cells[5].FormattedValue.ToString();
                cmd.CommandText = "DELETE FROM BOMBEIRO WHERE numero_bombeiro='" + nBomb + "'";
                cmd.ExecuteNonQuery();
                dGVBomb.Refresh();
                con.Close();
            }
            else
                return;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();

        }
    }
}
