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
    public partial class Login : Form
    {
        private InserirConcFreg concFreg;
        private Servicos serv;
        private InserirCodOcorrencia codOc;
        private bool log = false;
        private String numB = "";
        private String t = "";
        private FichaBombeiro f;
        private VerBombeiro vb;
        private Turno turno;
        private MarcarFaltas mar;
        private Viatura via;
        private VerOcorrencia ocor;
        private VerEquipamento equip;
        private VerLicencas lic;
        private String connectionString = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\John Sousa\\Desktop\\QuartelBombeirosx\\QuartelBombeiros\\QuartelBombeiros\\App_Data\\FireStation.mdf;Integrated Security=True";
        private VerAgendamento verAgend;
        private PedidoAltHor ped;
        private VerExtras ext;
        private VerEquipas equipa;
        public Login()
        {
            InitializeComponent();
        }

        public Login(bool log, String numB)
            : this()
        {
            this.log = log;
            this.numB = numB;

        }

        private void pnlMenuAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = con.CreateCommand();
            SqlDataReader reader;

            String user = "", password = "", tipo = "", numeroB = "", login = "";
            user = txtUser.Text;
            password = txtPass.Text;
            con.Open();

            cmd.CommandText = "SELECT bombeiro_num_bombeiro,tipo,login FROM utilizador WHERE username='" + user + "' AND password='" + password + "'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tipo = reader["tipo"].ToString();
                t = tipo;
                numB = numeroB = reader["bombeiro_num_bombeiro"].ToString();
                login = reader["login"].ToString();
            }
            else
                MessageBox.Show("Esse Username ou Password está incorrecto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            reader.Close();
            if (numeroB != "" && login == "0")
            {
                con.Close();
                FichaBombeiro f = new FichaBombeiro(numeroB, true);
                f.Show();
                this.Hide();

            }



            if (tipo != "")
            {
                btnOc.Show();
                btnAgend.Show();
                btnViat.Show();
                btnInsCodOco.Show();
                btnEquipas.Show();
                btnInsConcFreg.Show();
                btnOc.Show();
                btnViat.Show();
                btnAgend.Show();
                pnlLogin.Visible = false;
                pnlMenu.Visible = true;
                Text = "Home";
                txtPass.Text = "";
                txtUser.Text = "";
                if (tipo.ToLower() == "b")
                {
                    btnInsCodOco.Visible = false;
                    btnEquipas.Hide();
                    btnInsConcFreg.Hide();
                    btnOc.Hide();
                    btnViat.Hide();
                    btnAgend.Hide();
                    btnFaltas.Hide();
                }else if(tipo.ToLower() == "o")
                {
                    btnFaltas.Hide();
                }
            }
            con.Close();
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            pnlLogin.Visible = true;
            pnlMenu.Visible = false;
            Text = "Login";
            for (int i = Application.OpenForms.Count - 1; i > 0; i--)
                Application.OpenForms[i].Close();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtUser.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                Application.OpenForms[i].Close();
        }

        private void btnBomb_Click(object sender, EventArgs e)
        {
            if (t.ToUpper() == "B" || t.ToUpper() == "O")
            {
                bool open = false;
                foreach (Form form in Application.OpenForms)
                    if (form == f)
                    {
                        open = true;
                    }
                if (!open)
                {
                    f = new FichaBombeiro(numB);
                    f.Show();
                }
                else
                    f.Focus();
            }
            else
            {
                bool open = false;
                foreach (Form f in Application.OpenForms)
                    if (f == vb)
                    {
                        open = true;
                    }
                if (!open)
                {
                    vb = new VerBombeiro();
                    vb.Show();
                }
                else
                    vb.Focus();

            }
        }

        private void btnHor_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == turno)
                {
                    open = true;
                }
            if (!open)
            {
                turno = new Turno(t);
                turno.Show();
            }
            else
                turno.Focus();
        }

        private void btnOc_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == ocor)
                {
                    open = true;
                }
            if (!open)
            {
                ocor = new VerOcorrencia();
                ocor.Show();
            }
            else
                ocor.Focus();
        }

        private void btnViat_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == via)
                {
                    open = true;
                }
            if (!open)
            {
                via = new Viatura();
                via.Show();
            }
            else
                via.Focus();
        }



        private void btnEquip_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == equip)
                {
                    open = true;
                }
            if (!open)
            {
                equip = new VerEquipamento(t,numB);
                equip.Show();
            }
            else
                equip.Focus();
        }

        private void btnLic_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == lic)
                {
                    open = true;
                }
            if (!open)
            {
                lic = new VerLicencas(t, numB);
                lic.Show();
            }
            else
                lic.Focus();
        }

        private void btnAgend_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == verAgend)
                {
                    open = true;
                }
            if (!open)
            {
                verAgend = new VerAgendamento();
                verAgend.Show();
            }
            else
                verAgend.Focus();
        }

        private void btnInsConcFreg_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == concFreg)
                {
                    open = true;
                }
            if (!open)
            {
                concFreg = new InserirConcFreg();
                concFreg.Show();
            }
            else
                concFreg.Focus();
        }

        private void btnInsCodOco_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == codOc)
                {
                    open = true;
                }
            if (!open)
            {
                codOc = new InserirCodOcorrencia();
                codOc.Show();
            }
            else
                codOc.Focus();
        }

        private void btnAltHor_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == ped)
                {
                    open = true;
                }
            if (!open)
            {
                if (t.ToLower() == "a")
                    ped = new PedidoAltHor(true);
                else
                    ped = new PedidoAltHor(numB);
                ped.Show();
            }
            else
                ped.Focus();
        }

        private void btnExtra_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == ext)
                {
                    open = true;
                }
            if (!open)
            {
                if (t.ToLower() == "b")
                    ext = new VerExtras(t, numB);
                else
                    ext = new VerExtras(numB);
                ext.Show();
            }
            else
                ext.Focus();
        }

        private void btnServ_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == serv)
                {
                    open = true;
                }
            if (!open)
            {
                serv = new Servicos(numB);
                serv.Show();
            }
            else
                serv.Focus();
        }

        private void btnEquipas_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == equipa)
                {
                    open = true;
                }
            if (!open)
            {
                equipa = new VerEquipas() ;
                equipa.Show();
            }
            else
                equipa.Focus();
        }

        private void btnFaltas_Click(object sender, EventArgs e)
        {
            bool open = false;
            foreach (Form f in Application.OpenForms)
                if (f == mar)
                {
                    open = true;
                }
            if (!open)
            {
                mar = new MarcarFaltas();
                mar.Show();
            }
            else
                mar.Focus();
        }


    }
}
