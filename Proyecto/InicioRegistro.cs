using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using static Proyecto.Logica;

namespace Proyecto
{
    public partial class InicioRegistro : Form
    {
        private MySqlConnection con = new MySqlConnection("Server=127.0.0.1; Database=CorePoint; Uid=Admin; Pwd=hello;");
        private MySqlDataReader lector;
        private Logica logic = new Logica();
        public InicioRegistro()
        {
            InitializeComponent();
            Console.WriteLine("Open");
        }

        private void pnlInicioSesion_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtMail.Text.Equals(null) || txtCont.Text.Equals(null) || txtContConf.Text.Equals(null))
            {
                txtError2.Visible = true;
                txtError2.Text = "*Error espacio/os sin llenar*";
            }
            else
            {
                if (txtContRegistro.Text.Equals(txtContConf.Text))
                {
                    if (cbxDominio.SelectedItem.ToString() != "Otro/Other") { 
                    Console.WriteLine(txtCorreoRegistro.Text + cbxDominio.SelectedItem);
                    con.Open();
                    MySqlCommand crn = new MySqlCommand("insert into usuarios values('" + txtCorreoRegistro.Text + cbxDominio.SelectedItem + "','" + txtContRegistro.Text + "','normal') ", con);
                    crn.ExecuteNonQuery();
                    con.Close();
                    }
                    else
                    {
                        Console.WriteLine(txtCorreoRegistro.Text + cbxDominio.SelectedItem);
                        con.Open();
                        MySqlCommand crn = new MySqlCommand("insert into usuarios values('" + txtCorreoRegistro.Text + txtElectronico.Text + "','" + txtContRegistro.Text + "','normal') ", con);
                        crn.ExecuteNonQuery();
                        con.Close();
                    }
                }
                else
                {
                    txtError2.Visible = true;
                    txtError2.Text = "*Error contrseñas no coinciden*";
                }
            }
        }

        private void txtError2_Click(object sender, EventArgs e)
        {

        }

        private void pnlRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtRegistrarme_Click(object sender, EventArgs e)
        {
            pnlRegistro.Visible = true;
        }

        private void cbxDominio_SelectedIndexChanged(object sender, EventArgs e)
        {
            String selectedIt = Convert.ToString(cbxDominio.SelectedItem);
            switch (selectedIt)
            {
                case "Otro/Other":
                    pnlOtro.Visible = true;
                    break;
                default:
                    pnlOtro.Visible = false;
                    break;
            }
        }

        private void label8_Click(object sender, EventArgs e) //al precionar iniciar:
        {
            String nombre = null;
            String password = null;
            int test = 0;
            int confirm = 0;
            char[] caracteres;
            caracteres = txtMail.Text.ToCharArray();

            foreach (char s in caracteres)
            {
                test = test + 1;
                if (s == '@')
                {
                    confirm = test + 1;
                }
                else
                {
                    test = test + 1;
                }
            }
            Console.WriteLine(confirm);

            if (txtMail.Text != "" && txtCont.Text != "")
            {
                con.Open();
                MySqlCommand crn = new MySqlCommand("Select Contra, TipoUsuario from usuarios where correo='" + txtMail.Text + "';", con);
                lector = crn.ExecuteReader();
                password = txtCont.Text;
                String tipoUsr = null;
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        switch (password == lector["Contra"].ToString())
                        {
                            case true:
                                tipoUsr = lector["TipoUsuario"].ToString();
                                break;
                        }
                    }
                }
                if (password == txtCont.Text)
                {
                    switch (tipoUsr)
                    {
                        case "normal":
                            lector.Close();
                            con.Close();
                            Menu1 f1 = new Menu1();
                            f1.Show();
                            logic.Registro(txtMail.Text);
                            break;
                        case "pro":
                            lector.Close();
                            con.Close();
                            Menu1 f2 = new Menu1();
                            f2.Show();
                            logic.Registro(txtMail.Text);
                            break;
                        case "Admin":
                            break;
                    }
                }
            }
            else
            {


            }

            con.Close();
        }

        private void lblCOnt_Click(object sender, EventArgs e)
        {

        }

        private void pnlOtro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int test = 0;
            char[] caracteres;
            caracteres = txtElectronico.Text.ToCharArray();

            foreach (char s in caracteres)
            {
                test = test + 1;
            }
            Console.WriteLine(test);
            if (txtElectronico.Text != null && caracteres[0].Equals('@') && caracteres[test - 4].Equals('.'))
            {
                cbxDominio.Items.Add(txtElectronico.Text);
            }
            else
            {
                txtError2.Visible = true;
                txtError2.Text = "*Error Dominio erroneo*";
            }
            pnlOtro.Visible = false;
        }

        private void lblInvitado_Click(object sender, EventArgs e)
        {

        }
    }
}