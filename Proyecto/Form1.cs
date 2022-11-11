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
using System.IO;

namespace Proyecto
{
    public partial class Menu1 : Form
    {
        private MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database=CorePoint; Uid=Admin; Pwd=hello;");
        private Form2 form2;
        private int coin;
        private Random ran = new Random();
        private String user;
        private Class1 c1 = new Class1();
        private Logica log = new Logica();
        private MySqlDataReader lector;
        private MySqlCommand comando = new MySqlCommand();
        public Menu1()
        {
            InitializeComponent();
            coin = ran.Next(0, 2);
            form2 = new Form2();
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
                this.idle();
            }


        }

 
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void idle()
        {

            tmrAnuncios.Interval = 120000;
            tmrAnuncios.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void pnlAnuncio1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void timer_Tick(object sender, EventArgs e)
        {
            coin = ran.Next(1, 3);
            switch (coin)// Switch que cambia el fondo de panel que mestra los anuncios. los miskmospueden ser aumntados en cantidad, agregados en variedad y más en u n futuro pero del momento solo quería saber sie mismo funciona 
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
            this.idle();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e) //Partidos
        {
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)//Registros
        {

            Form4 form4 = new Form4();
            try
            {
                con.Open();
                con.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            form4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void cbxLenguaje_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
