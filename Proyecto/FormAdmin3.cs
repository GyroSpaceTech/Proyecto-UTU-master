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
    public partial class FormAdmin3 : Form
    {
        private MySqlDataReader lector;
        private MySqlCommand comando = new MySqlCommand();
        private MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database=CorePoint; Uid=Admin; Pwd=hello;");

        public FormAdmin3()
        {
            InitializeComponent();
            this.actualizar();
        }
        private void actualizar()
        {
            con.Open();
            Class1 Comandos = new Class1();
            cBxDeporte.Items.Clear();
            cBxId.Items.Clear();
            cBxDeporte.Items.Clear();
            comando = Comandos.Obtener("IdDep", "deportes", con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    cBxDeporte.Items.Add(lector["IdDep"]);
                    cBxId.Items.Add(lector["IdDep"]);
                    cBxDepBaja.Items.Add(lector["IdDep"]);
                }
            }
            lector.Close();
            cBxEquiposBaja.Items.Clear();
            comando = new MySqlCommand("Select IdEquipo from equipo",con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    cBxEquiposBaja.Items.Add(lector["IdEquipo"].ToString());
                }
            }
            lector.Close();
            cBxEventoBaja.Items.Clear();
            comando = new MySqlCommand("Select IdEvento from eventos", con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    cBxEventoBaja.Items.Add(lector["IdEvento"].ToString());
                }
            }
            lector.Close();
            con.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand coman = new MySqlCommand("insert into eventos (IdDeporte, NomEvent,Edicion,Pais,Ubicacion) values ('"+cBxDeporte.SelectedItem.ToString()+"','"+txtNomEv.Text+"','"+txtEdicion.Text+"','"+txtPais.Text+"','"+txtEstadio.Text+"');",con);
                coman.ExecuteNonQuery();
                con.Close();
                this.actualizar();
            }catch(Exception g)
            {
                MessageBox.Show(g.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                MySqlCommand coman = new MySqlCommand("insert into Deportes (NomDep, Modalidad,TipPuntaje) values ('" + txtDeporte.Text + "','" + cBxMod.SelectedItem.ToString() + "','" + cBxPunt.SelectedItem.ToString() + "');", con); ;
                coman.ExecuteNonQuery();
                con.Close();
                this.actualizar();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                MySqlCommand coman = new MySqlCommand("insert into equipo (NomEquipo,ClubORSeleccion,IdDeporteJuega) values ('" + txtEquipo.Text + "','" + cBxCOS.SelectedItem.ToString() + "','" + cBxId.SelectedItem.ToString() + "');", con); ;
                coman.ExecuteNonQuery();
                con.Close();
                this.actualizar();
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void cBxEventoBaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand comando = new MySqlCommand("Select NomEvent from eventos where IdEvento='"+cBxEventoBaja.SelectedItem.ToString()+"'",con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    label21.Text= lector["NomEvent"].ToString();
                }
            }
            lector.Close();
            con.Close();

        }

        private void cBxDepBaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand comando = new MySqlCommand("Select NomDep from deportes where IdDep='" + cBxDepBaja.SelectedItem.ToString() + "'", con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    label23.Text = lector["NomDep"].ToString();
                }
            }
            lector.Close();
            con.Close();

        }

        private void cBxEquiposBaja_SelectedIndexChanged(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand comando = new MySqlCommand("Select NomEquipo from equipo where IdEquipo='" + cBxEquiposBaja.SelectedItem.ToString() + "'", con);
            lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    label23.Text = lector["NomEquipo"].ToString();
                }
            }
            lector.Close();
            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand baja = new MySqlCommand("DELETE FROM eventos WHERE (`IdEvento` = '" + cBxEventoBaja.SelectedItem.ToString() + "');", con); ;
            baja.ExecuteNonQuery();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand baja = new MySqlCommand("DELETE FROM deportes WHERE (`IdDep` = '" + cBxDepBaja.SelectedItem.ToString() + "');", con); ;
            baja.ExecuteNonQuery();
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
    }
    }

