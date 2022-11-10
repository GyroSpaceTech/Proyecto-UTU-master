using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    public partial class Form5 : Form
    {
        private MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database=CorePoint; Uid=Admin; Pwd=hello;");
        private int coin;
        private Random ran = new Random();
        private String user;
        private Logica log = new Logica();
        public Form5()
        {
            InitializeComponent();
            Class1 Comandos = new Class1();
            MySqlDataReader lector;
            Class1 c1 = new Class1();
            MySqlCommand comando;
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
            Console.WriteLine(user);
            Console.WriteLine(a);
            if (user == "normal")
            {
                if (coin == 1)
                {
                    pnlAnuncio.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                }
                else
                {
                    pnlAnuncio.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                }
                tmrAnuncios.Interval = 120000;
                tmrAnuncios.Tick += new EventHandler(timer_Tick);
                this.idle();
            }
            con.Open();
            comando = Comandos.Obtener("NomDep", "deportes", con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    comboBox1.Items.Add(lector["NomDep"]);
                }
            }
            lector.Close();
            con.Close();
        }
        private void idle()
        {

            tmrAnuncios.Interval = 120000;
            tmrAnuncios.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            coin = ran.Next(1, 3);
            switch (coin)// Switch que cambia el fondo de panel que mestra los anuncios. los miskmospueden ser aumntados en cantidad, agregados en variedad y más en u n futuro pero del momento solo quería saber sie mismo funciona 
            {
                case 1:
                    pnlAnuncio.BackgroundImage = Proyecto.Properties.Resources.Anuncio1;
                    break;
                case 2:
                    pnlAnuncio.BackgroundImage = Proyecto.Properties.Resources.Anuncio2;
                    break;

            }
            this.idle();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "") { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pnlAnuncio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataReader lector;
            MySqlCommand comm = new MySqlCommand("Select * from equipo, deportes where NomDep='" + comboBox1.SelectedItem.ToString() + "' and IdDeporteJuega=IdDep", con); ;
            lector = comm.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    comboBox2.Items.Add(lector["NomEquipo"]);
                }
            }
            lector.Close();
            con.Close();
        }
    }
}
