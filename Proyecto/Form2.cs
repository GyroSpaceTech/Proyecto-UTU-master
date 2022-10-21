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
    public partial class Form2 : Form
    {
        private MySqlConnection con = new MySqlConnection("Server=192.168.5.50; Database='UTU database'; Uid='jose.laco'; Pwd='55383035';");
        private int coin;
        private Random ran = new Random();
        public Form2()
        {
            InitializeComponent();
            //El siguiente código usa un switch y un valor random entre 2 valores para mostrar los 2 posibles anuncios de forma aleatoria
            //El mismo código es escalable y puede expandirse para otros anuncios.
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

        private void Conectar()
        {
            MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database=CorePoint; Uid=Admin; Pwd=hello;");
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
            switch (coin) { 
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
    }
}
