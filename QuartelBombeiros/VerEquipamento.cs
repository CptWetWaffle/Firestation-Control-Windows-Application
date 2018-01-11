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
    public partial class VerEquipamento : Form
    {
        private InserirEquipamento equip;
        private AtribuirEquipamento atr;
        private String ti = "", num = "";
        public VerEquipamento()
        {
            InitializeComponent();
        }



        public VerEquipamento(String t, String num):this()
        {
            this.ti = t;
            this.num = num;

        }

        private void VerEquipamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipB.equipamento' table. You can move, or remove it, as needed.
            this.equipamentoTableAdapter1.Fill(this.equipB.equipamento);
            // TODO: This line of code loads data into the 'fireStationDataSet.equipamento' table. You can move, or remove it, as needed.
            this.equipamentoTableAdapter.Fill(this.fireStationDataSet.equipamento);
            // TODO: This line of code loads data into the 'fireStationDataSet.codigo_occorencia' table. You can move, or remove it, as needed.
            this.codigo_occorenciaTableAdapter.Fill(this.fireStationDataSet.codigo_occorencia);
            if(ti.ToLower() == "o")
            {
                btnAdd.Hide();
                btnDelete.Hide();
                btnEdit.Hide();
            }else if(ti.ToLower() == "b")
            {
                btnAdd.Hide();
                btnDelete.Hide();
                btnEdit.Hide();
                Atrib.Hide();
            }
            if(num !="")
            {
                bombToolStripTextBox.Text = num;
                fillByToolStripButton.PerformClick();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == equip)
                {
                    open = true;
                }
            if (!open)
            {
                equip = new InserirEquipamento();
                equip.Show();
            }
            else
                equip.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Mariana\\Desktop\\Quartel\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            if (MessageBox.Show("Tem a certeza que deseja eleminar este equipamento?", "Apagar Equipamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                con.Open();
                String idEquip = dGVEquip.SelectedRows[0].Cells[5].FormattedValue.ToString();
                cmd.CommandText = "DELETE FROM equipamento WHERE id_equipamento='" + idEquip + "'";
                cmd.ExecuteNonQuery();
                dGVEquip.Refresh();
                con.Close();
            }
            else
                return;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == equip)
                {
                    open = true;
                }
            if (!open)
            {
                equip = new InserirEquipamento(dGVEquip.SelectedRows[0].Cells[0].FormattedValue.ToString());
                equip.Show();
            }
            else
                equip.Focus();
        }

        private void Atrib_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == atr)
                {
                    open = true;
                }
            if (!open)
            {
                atr = new AtribuirEquipamento();
                atr.Show();
            }
            else
                atr.Focus();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair desta página?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.equipamentoTableAdapter.FillBy(this.fireStationDataSet.equipamento, ((int)(System.Convert.ChangeType(bombToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.equipamentoTableAdapter1.FillBy(this.equipB.equipamento, ((int)(System.Convert.ChangeType(bombToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
