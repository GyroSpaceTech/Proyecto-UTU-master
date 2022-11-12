using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace Proyecto
{
    public partial class Form4 : Form
    {
        private MySqlDataReader lector;
        private MySqlCommand comando = new MySqlCommand();
        private MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database=CorePoint; Uid=Admin; Pwd=hello;");
        private int coin;
        private Random ran = new Random();
        private String user;
        private Class1 c1 = new Class1();
        private Logica log = new Logica();
        public Form4()
        {
            InitializeComponent();
            coin = ran.Next(0, 2);
            con.Open();
            string a = log.Recibir();
            comando = c1.Buscar("TipoUsuario", "usuarios", "correo='" + a + "'", con);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                user = lector["TipoUsuario"].ToString();
            }
            con.Close();
            if (user != "normal")
            {
            }
            else
            {
                if (coin == 1)
                {
                    pnlAnuncio2.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                }
                else
                {
                    pnlAnuncio2.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                }
                tmrAnuncios.Interval = 120000;
                tmrAnuncios.Tick += new EventHandler(timer_Tick);
                this.tmrStart();
            }
            this.ComandoCategorías();

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            coin = ran.Next(1, 3);
            switch (coin)
            {
                case 1:
                    pnlAnuncio2.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                    break;
                case 2:
                    pnlAnuncio2.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                    break;

            }
            this.tmrStart();
        }


        private void ComandoCategorías()
        {
            Class1 Comandos = new Class1();
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            //Definir un  Mysql Command para correr esto 
            comando = Comandos.Obtener("NomEquipo", "equipo", con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ChkdEquipos.Items.Add(lector["NomEquipo"]);
                }
            }
            lector.Close();
            comando = Comandos.Obtener("NomDep", "deportes", con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ChkdDeportes.Items.Add(lector["NomDep"]);
                }
            }
            lector.Close();
            comando = Comandos.Obtener("NomEvent , Edicion", "eventos", con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ChkdEventos.Items.Add(lector["NomEvent"] + ":" + lector["Edicion"]);
                }

            }
            lector.Close();
            if (ChkdEquipos.Items.Count == 0 && ChkdEventos.Items.Count == 0 && ChkdDeportes.Items.Count == 0)
            {
                ChkdEquipos.Items.Add("ERROR, NO HEMOS PODIDO RECOPILAR LAS TABLAS");
            }
        }
        private void tmrStart()
        {
            tmrAnuncios.Interval = 120000;
            tmrAnuncios.Start(); // restablece el tiempo una vez cumplida la primer vuelta del cambio de anuncios
        }

        private void lblGuardar_Click(object sender, EventArgs e)
        {

        }

        private void ChkdEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void cbxLenguaje_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLenguaje.Checked == true)
            {
                label1.Text = "Sports";
                lblEquipos.Text = "Teams";
                lblEvento.Text = "Events";
                button1.Text = "Exit";
            }
            else //Cambiar a español
            {
                label1.Text = "Deportes";
                lblEquipos.Text = "Equipos";
                lblEvento.Text = "Eventos";
                button1.Text = "Salida";
            }
        }
    } } 