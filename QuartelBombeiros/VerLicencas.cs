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
    public partial class VerLicencas : Form
    {
        private Licencas l;
        private String id = "";
        private String num = "";
        private const String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";

        public VerLicencas()
        {
            InitializeComponent();
        }
        public VerLicencas(String id, String num) : this()
        {
            this.id = id;
            this.num = num;
        }

        private void VerLicencas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fireStationDataSet1.licenca' table. You can move, or remove it, as needed.
            this.licencaTableAdapter1.Fill(this.fireStationDataSet1.licenca);
            if (id.ToLower() != "a")
            {
                btnAdd.Hide();
                btnEdit.Hide();
                btnDelete.Hide();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == l)
                {
                    open = true;
                }
            if (!open)
            {
                if (id.ToLower() == "a")
                    l = new Licencas();
                else
                {
                    l = new Licencas(num, true);
                }
                l.Show();
            }
            else
                l.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (MessageBox.Show("Tem a certeza que deseja eleminar esta licença?", "Apagar Licença", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                String idLic = dGVLicenc.SelectedRows[0].Cells[0].FormattedValue.ToString();
                cmd.CommandText = "DELETE FROM licenca WHERE id_licenca='" + idLic + "'";
                cmd.ExecuteNonQuery();
                dGVLicenc.Refresh();
                con.Close();
            }
            else
                return;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == l)
                {
                    open = true;
                }
            if (!open)
            {
                l = new Licencas(dGVLicenc.SelectedRows[0].Cells[0].FormattedValue.ToString());
                l.Show();
            }
            else
                l.Focus();
        }
    }
}
