using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
namespace Proyecto
{
    public partial class Form2 : Form
    {
        private MySqlConnection con = new MySqlConnection("Server=192.168.5.50; Database=spacetechnology; Uid=jose.laco; Pwd=55383035;");
        private int coin;
        private MySqlDataReader lector;
        private MySqlCommand comando = new MySqlCommand();
        private Random ran = new Random();
        private String user;
        private Class1 c1 = new Class1();
        private Logica log = new Logica();
        public Form2()
        {
            InitializeComponent();
            //El siguiente código usa un switch y un valor random entre 2 valores para mostrar los 2 posibles anuncios de forma aleatoria
            //El mismo código es escalable y puede expandirse para otros anuncios.
            coin = ran.Next(1, 3);
            con.Open();
            string a = log.Recibir();
            comando = c1.Buscar("TipoUsuario", "usuarios", "correo='" + a + "'", con);
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                user = lector["TipoUsuario"].ToString();
            }
            con.Close();
            if (user == "normal")
            {
                if (coin == 1)
                {
                    pnlAnuncio.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                }
                else
                {
                    pnlAnuncio.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                }
                tmrAnuncios.Interval = 120000;
                tmrAnuncios.Tick += new EventHandler(timer_Tick);
                this.tmrStart();
            }
            this.CargarBarras();
        }

        public void CargarBarras()
        {

            Class1 Comandos = new Class1();
            con.Open();
            MySqlDataReader lector;
            MySqlCommand comando;
            comando = Comandos.Obtener("NomDep", "deportes", con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    CBDeporte.Items.Add(lector["NomDep"]);
                }
            }
            lector.Close();
            con.Close();
        }
        private void Actualization()
        {
            con.Open();
            String tipDep = null;
            MySqlCommand comm = new MySqlCommand("Select * from deportes where NomDep='" + CBDeporte.SelectedItem.ToString() + "';", con);
            MySqlDataReader lector = comm.ExecuteReader();
            while (lector.Read())
            {
                tipDep = lector["TipPuntaje"].ToString();
            }
            lector.Close();
            switch (tipDep)
            {
                default:
                    lstBxResultados.Visible = false;
                    lstBxEvento.Visible = false;
                    lstBxPuntoE1.Visible = false;
                    lstBxPuntoE2.Visible = false;
                    lstBxE1.Visible = false;
                    lstBxE2.Visible = false;
                    lstBxSetE1.Visible = false;
                    lstBxSet2.Visible = false;
                    lstBxTiempoOro.Visible = false;
                    lstBxTiempoPlata.Visible = false;
                    lstBxTimempoBron.Visible = false;
                    break;
                case "puntos":
                    pnlResultados.Visible = true;
                    try
                    {
                        using (con)
                        {
                            this.Clear();
                            lstBxSetE1.Visible = false;
                            lstBxSet2.Visible = false;
                            lstBxTiempoOro.Visible = false;
                            lstBxTiempoPlata.Visible = false;
                            lstBxTimempoBron.Visible = false;
                            lstBxResultados.Items.Add("Id");
                            lstBxEvento.Items.Add("Evnt");
                            lstBxE1.Items.Add("Team");
                            lstBxE2.Items.Add("Team");
                            lstBxPuntoE1.Items.Add("Pnts");
                            lstBxPuntoE2.Items.Add("Pnts");
                            MySqlCommand com = new MySqlCommand("Select IdResultados ResultadoNº, NomEvent,Edicion, e.NomEquipo 'Equipo 1', n.NomEquipo 'Equipo 2', puntosE1 , PuntosE2 from partidos, eventos, deportes, equipo e, equipo n  where eventos.IdEvento = partidos.IdEvento and eventos.IdDeporte = deportes.IdDep and deportes.NomDep = '" + CBDeporte.SelectedItem.ToString() + "' and IdEquipo1 = e.IdEquipo and IdEquipo2 = n.IdEquipo  ;", con);
                            lector = com.ExecuteReader();
                            while (lector.Read())
                            {
                                lstBxResultados.Items.Add(lector["ResultadoNº"].ToString());
                                lstBxResultados.Visible = true;
                                lstBxEvento.Items.Add(lector["NomEvent"].ToString());
                                lstBxEvento.Visible = true;
                                lstBxE1.Items.Add(lector["Equipo 1"].ToString());
                                lstBxE1.Visible = true;
                                lstBxE2.Items.Add(lector["Equipo 2"].ToString());
                                lstBxE2.Visible = true;
                                lstBxPuntoE1.Items.Add(lector["PuntosE1"].ToString());
                                lstBxPuntoE1.Visible = true;
                                lstBxPuntoE2.Items.Add(lector["PuntosE2"].ToString());
                                lstBxPuntoE2.Visible = true;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case "sets":
                    pnlResultados.Visible = true;
                    try
                    {
                        using (con)
                        {
                            this.Clear();
                            lstBxPuntoE1.Visible = false;
                            lstBxPuntoE2.Visible = false;
                            lstBxTiempoOro.Visible = false;
                            lstBxTiempoPlata.Visible = false;
                            lstBxTimempoBron.Visible = false;
                            lstBxResultados.Items.Add("Id");
                            lstBxEvento.Items.Add("Evnt");
                            lstBxE1.Items.Add("Team");
                            lstBxE2.Items.Add("Team");
                            lstBxSetE1.Items.Add("Set");
                            lstBxSet2.Items.Add("Set");
                            MySqlCommand com = new MySqlCommand("Select IdResultados ResultadoNº, NomEvent, e.NomEquipo 'Equipo 1', n.NomEquipo 'Equipo 2', setE1 , SetE2 from partidos, eventos, deportes, equipo e, equipo n  where eventos.IdEvento = partidos.IdEvento and eventos.IdDeporte = deportes.IdDep and deportes.NomDep = '" + CBDeporte.SelectedItem.ToString() + "' and IdEquipo1 = e.IdEquipo and IdEquipo2 = n.IdEquipo  ;", con);
                            lector = com.ExecuteReader();
                            while (lector.Read())
                            {

                                lstBxResultados.Items.Add(lector["ResultadoNº"].ToString());
                                lstBxResultados.Visible = true;
                                lstBxEvento.Items.Add(lector["NomEvent"].ToString());
                                lstBxEvento.Visible = true;
                                lstBxE1.Items.Add(lector["Equipo 1"].ToString());
                                lstBxE1.Visible = true;
                                lstBxE2.Items.Add(lector["Equipo 2"].ToString());
                                lstBxE2.Visible = true;
                                lstBxSetE1.Items.Add(lector["setE1"].ToString());
                                lstBxSetE1.Visible = true;
                                lstBxSet2.Items.Add(lector["setE2"].ToString());
                                lstBxSet2.Visible = true;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
                case "tiempos":
                    pnlResultados.Visible = true;
                    try
                    {
                        using (con)
                        {
                            this.Clear();
                            lstBxE2.Visible = false;
                            lstBxSetE1.Visible = false;
                            lstBxSet2.Visible = false;
                            lstBxPuntoE1.Visible = false;
                            lstBxPuntoE2.Visible = false;

                            lstBxResultados.Items.Add("Id");
                            lstBxEvento.Items.Add("Evnt");
                            lstBxE1.Items.Add("Team");
                            lstBxTiempoOro.Items.Add("1st");
                            lstBxTiempoPlata.Items.Add("2nd");
                            lstBxTimempoBron.Items.Add("3rd");
                            MySqlCommand com = new MySqlCommand("Select IdResultados ResultadoNº,NomEvent, e.NomEquipo 'Ganador', tiempoOro, tiempoPlata, tiempoBronce from partidos, eventos, deportes, equipo e, equipo n  where eventos.IdEvento = partidos.IdEvento and eventos.IdDeporte = deportes.IdDep and deportes.NomDep = '" + CBDeporte.SelectedItem.ToString() + "' and IdEquipo1 = e.IdEquipo  and IdEquipo2 =n.IdEquipo  ;  ", con); ;
                            lector = com.ExecuteReader();
                            while (lector.Read())
                            {

                                lstBxResultados.Items.Add(lector["ResultadoNº"].ToString());
                                lstBxResultados.Visible = true;
                                lstBxEvento.Items.Add(lector["NomEvent"].ToString());
                                lstBxEvento.Visible = true;
                                lstBxE1.Items.Add(lector["Ganador"].ToString());
                                lstBxE1.Visible = true;
                                lstBxTiempoOro.Items.Add(lector["tiempoOro"].ToString());
                                lstBxTiempoOro.Visible = true;
                                lstBxTiempoPlata.Items.Add(lector["tiempoPlata"].ToString());
                                lstBxTiempoPlata.Visible = true;
                                lstBxTimempoBron.Items.Add(lector["tiempoBronce"].ToString());
                                lstBxTimempoBron.Visible = true;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                    break;
            }
            con.Close();
        }


        private void Clear()
        {
            lstBxResultados.Items.Clear();
            lstBxEvento.Items.Clear();
            lstBxPuntoE1.Items.Clear();
            lstBxPuntoE2.Items.Clear();
            lstBxE1.Items.Clear();
            lstBxE2.Items.Clear();
            lstBxSetE1.Items.Clear();
            lstBxSet2.Items.Clear();
            lstBxTiempoOro.Items.Clear();
            lstBxTiempoPlata.Items.Clear();
            lstBxTimempoBron.Items.Clear();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Conectar()
        {
            MySqlConnection con = new MySqlConnection("Server=192.168.5.50; Database=spacetechnology; Uid=jose.laco; Pwd=55383035;");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            InicioRegistro ir = new InicioRegistro();
            ir.Dispose();
            this.Dispose();
        }

        private void pnlAnuncio1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tmrStart()
        {
            tmrAnuncios.Interval = 120000;
            tmrAnuncios.Start(); // restablece el tiempo una vez cumplida la primer vuelta del cambio de anuncios

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            coin = ran.Next(1, 3);
            switch (coin)
            {
                case 1:
                    pnlAnuncio.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                    break;
                case 2:
                    pnlAnuncio.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                    pnlAnuncio1.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                    break;

            }
            this.tmrStart();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CBDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(CBDeporte.SelectedItem.ToString());
            this.Actualization();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxLenguaje_CheckedChanged(object sender, EventArgs e)
        {

            if (cbxLenguaje.Checked == true)
            {
                button1.Text = "Exit";
            }
            else //Cambiar a español
            {
                button1.Text = "Salir";
            }
        }
    }
}
