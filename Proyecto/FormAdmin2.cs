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
    public partial class FormAdmin2 : Form
    {
        private MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database=CorePoint; Uid=Admin; Pwd=hello;");
        private MySqlDataReader lector;
        private string idE1;
        private string idE2;
        public FormAdmin2()
        {
            InitializeComponent();
            cBxTipoDep.Items.Add("puntos");
            cBxTipoDep.Items.Add("sets");
            cBxTipoDep.Items.Add("tiempos");
        }

        private void cbxLenguaje_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cBxTipoDep_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cBxTipoDep.SelectedItem.ToString())
            {
                default:
                    pnlPuntos.Visible = false;
                    pnlSets.Visible = false;
                    pnlTiempo.Visible = false;
                    break;
                case "puntos":
                    pnlPuntos.Visible = true;
                    pnlSets.Visible = false;
                    pnlTiempo.Visible = false;
                    try
                    {
                        con.Open();
                        MySqlDataReader lector;
                        MySqlCommand comando = new MySqlCommand("Select * from deportes where tipPuntaje='puntos';", con);
                        lector = comando.ExecuteReader();
                        if (lector.HasRows)
                        {
                            while (lector.Read())
                            {
                                cBxDep1.Items.Add(lector["NomDep"].ToString());
                            }
                        }
                        lector.Close();
                        con.Close();


                    }
                    catch (Exception p1)
                    {

                    }
                    break;
                case "sets":
                    pnlPuntos.Visible = false;
                    pnlSets.Visible = true;
                    pnlTiempo.Visible = false;
                    try
                    {
                        con.Open();
                        MySqlDataReader lector;
                        MySqlCommand comando = new MySqlCommand("Select * from deportes where tipPuntaje='sets';", con);
                        lector = comando.ExecuteReader();
                        if (lector.HasRows)
                        {
                            while (lector.Read())
                            {
                                cBxDep2.Items.Add(lector["NomDep"].ToString());
                            }
                        }

                        lector.Close();
                        con.Close();
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case "tiempos":
                    pnlPuntos.Visible = false;
                    pnlSets.Visible = false;
                    pnlTiempo.Visible = true;
                    try
                    {
                        con.Open();
                        MySqlDataReader lector;
                        MySqlCommand comando = new MySqlCommand("Select * from deportes where tipPuntaje='tiempos';", con);
                        lector = comando.ExecuteReader();
                        if (lector.HasRows)
                        {
                            while (lector.Read())
                            {
                                cBxDep3.Items.Add(lector["NomDep"].ToString());
                            }
                        }

                        lector.Close();
                        con.Close();
                    }
                    catch (Exception)
                    {
                    }
                    break;
            }
        }

        private void cBxDep1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataReader lector;
                MySqlCommand comando = new MySqlCommand("Select * from equipo, deportes where nomDep='" + cBxDep1.SelectedItem.ToString() + "' and IdDeporteJuega=IdDep", con); ;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        cBxE1p.Items.Add(lector["IdEquipo"].ToString());
                    }
                }
                lector.Close();
                con.Close();
                con.Open();
                comando = new MySqlCommand("Select * from eventos, deportes where nomDep='" + cBxDep1.SelectedItem.ToString() + "' and IdDeporte=IdDep", con); ;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        comboBox1.Items.Add(lector["IdEvento"].ToString());
                    }
                }
                lector.Close();
                con.Close();
            }
            catch (Exception p1)
            {

            }
        }

        private void cBxE1p_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int contador = -1;
                MySqlDataReader lector;
                MySqlCommand comando = new MySqlCommand("Select * from equipo, deportes where nomDep='" + cBxDep1.SelectedItem.ToString() + "' and IdDeporteJuega=IdDep and IdEquipo!='" + cBxE1p.SelectedItem.ToString() + "'", con); ;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        contador++;
                        cBxE2p.Items.Add(lector["IdEquipo"].ToString());
                    }
                }
                lector.Close();
                con.Close();
            }
            catch (Exception p1)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtInstEv.Text != "")
            {
                try
                {
                    con.Open();
                    MySqlCommand agregar = new MySqlCommand("Insert into partidos (IdEquipo1,IdEquipo2,InstanciaDeEvento,PuntosE1,PuntosE2,IdEvento) values( '" + cBxE1p.SelectedItem.ToString() + "', '" + cBxE2p.SelectedItem.ToString() + "', '" + txtInstEv.Text + "', '" + numericUpDown1.Value.ToString() + "', '" + numericUpDown2.Value.ToString() + "', '" + comboBox1.SelectedItem.ToString() + "') ", con);
                    agregar.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception h)
                {
                    MessageBox.Show(h.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                }
            }
        }

        private void cBxE2p_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBxDep2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataReader lector;
                MySqlCommand comando = new MySqlCommand("Select * from equipo, deportes where nomDep='" + cBxDep2.SelectedItem.ToString() + "' and IdDeporteJuega=IdDep", con); ;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        cBxE1s.Items.Add(lector["IdEquipo"].ToString());
                    }
                }
                lector.Close();
                con.Close();
                con.Open();
                comando = new MySqlCommand("Select * from eventos, deportes where nomDep='" + cBxDep2.SelectedItem.ToString() + "' and IdDeporte=IdDep", con); ;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        comboBox2.Items.Add(lector["IdEvento"].ToString());
                    }
                }
                lector.Close();
                con.Close();
            }
            catch (Exception p1)
            {

            }
        }

        private void cBxE1s_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlDataReader lector;
                MySqlCommand comando = new MySqlCommand("Select * from equipo, deportes where nomDep='" + cBxDep2.SelectedItem.ToString() + "' and IdDeporteJuega=IdDep and IdEquipo!='" + cBxE1s.SelectedItem.ToString() + "'", con); ;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        cBxE2s.Items.Add(lector["IdEquipo"].ToString());
                    }
                }
                lector.Close();
                con.Close();
            }
            catch (Exception p1)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand agregar = new MySqlCommand("Insert into partidos (IdEquipo1,IdEquipo2,InstanciaDeEvento,SetE1,SetE2,IdEvento) values( '" + cBxE1s.SelectedItem.ToString() + "', '" + cBxE2s.SelectedItem.ToString() + "', '" + txtInstEv2.Text + "', '" + numericUpDown3.Value.ToString() + "', '" + numericUpDown4.Value.ToString() + "', '" + comboBox2.SelectedItem.ToString() + "') ", con);
                agregar.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand agregar = new MySqlCommand("Insert into partidos (IdEquipo1,IdEquipo2,InstanciaDeEvento,TiempoOro,TiempoPlata,TiempoBronce,IdEvento) values( '" + cBxE1t.SelectedItem.ToString() + "', '" + cBxE2t.SelectedItem.ToString() + "', '" + txtInstEv3.Text + "', '" +textBox2.Text + "', '" +textBox3.Text + "','"+textBox4.Text+"' ,'" + comboBox3.SelectedItem.ToString() + "') ", con);
                agregar.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception h)
            {
                MessageBox.Show(h.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void cBxDep3_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                MySqlDataReader lector;
                MySqlCommand comando = new MySqlCommand("Select * from equipo, deportes where nomDep='" + cBxDep3.SelectedItem.ToString() + "' and IdDeporteJuega=IdDep", con); ;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        cBxE1t.Items.Add(lector["IdEquipo"].ToString());
                    }
                }
                lector.Close();
                con.Close();
                con.Open();
                comando = new MySqlCommand("Select * from eventos, deportes where nomDep='" + cBxDep3.SelectedItem.ToString() + "' and IdDeporte=IdDep", con); ;
                lector = comando.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        comboBox3.Items.Add(lector["IdEvento"].ToString());
                    }
                }
                lector.Close();
                con.Close();
            }
            catch (Exception p1)
            {

            }
        }

        private void cBxE1t_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    con.Open();
                    MySqlDataReader lector;
                    MySqlCommand comando = new MySqlCommand("Select * from equipo, deportes where nomDep='" + cBxDep3.SelectedItem.ToString() + "' and IdDeporteJuega=IdDep and IdEquipo!='" + cBxE1t.SelectedItem.ToString() + "'", con); ;
                    lector = comando.ExecuteReader();
                    if (lector.HasRows)
                    {
                        while (lector.Read())
                        {
                            cBxE2t.Items.Add(lector["IdEquipo"].ToString());
                        }
                    }
                    lector.Close();
                    con.Close();
                }
                catch (Exception p1)
                {

                }
            }
        }
    }
}

