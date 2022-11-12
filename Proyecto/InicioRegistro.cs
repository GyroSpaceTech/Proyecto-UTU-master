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
        private MySqlConnection con = new MySqlConnection("Server=192.168.5.50; Database=spacetechnology; Uid=jose.laco; Pwd=55383035;");
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
            try
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
                        if (cbxDominio.SelectedItem.ToString() != "Otro/Other" && cbxDominio.SelectedItem.ToString()!= null)
                        {
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
            }catch (Exception f)
            {
                MessageBox.Show(f.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
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

        private void label8_Click(object sender, EventArgs e) 
        {
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
            try
            {
                logic.Registro("NormalUser@gmail.com");
                Menu1 f1 = new Menu1();
                f1.Show();
            }
            catch(Exception g) { }
           
        }

        private void cbxLenguaje_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLenguaje.Checked == true)
            {
                lblCorr.Text = "Email";
                lblCorreo.Text = "Email";
                lblContr.Text = "Password";
                lblCOnt.Text = "Password";
                lblConfCOnt.Text = "Confirm Password";
                txtError2.Text = "*Error passwords don't match*";
                txtRegistrarme.Text = "Sign Up";
                lblInicio.Text = "Log In";
                lblInvitado.Text = "Log in as temporary user";
            }
            else //Cambiar a español
            {
                lblCorr.Text = "Correo electronico";
                lblCorreo.Text = "Correo electronico";
                lblContr.Text = "Contraseña";
                lblCOnt.Text = "Contraseña";
                lblConfCOnt.Text = "Confirmar Contraseña";
                txtError2.Text = "*Error, las contraseñas no coinciden*";
                txtRegistrarme.Text = "Registrarme";
                lblInicio.Text = "Iniciar";
                lblInvitado.Text = "Iniciar sesión como invitado";
            }
        }

        private void lblInicio_Click(object sender, EventArgs e)
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

                            logic.Registro(txtMail.Text);
                            Menu1 f1 = new Menu1();
                            f1.Show();
                            break;
                        case "pro":
                            lector.Close();
                            con.Close();
                            logic.Registro(txtMail.Text);
                            Menu1 f2 = new Menu1();
                            f2.Show();
                            break;
                        case "Admin":
                            lector.Close();
                            con.Close();
                            FormAdmin1 formAd = new FormAdmin1();
                            formAd.Show();
                            break;
                    }
                }
            }
            else
            {


            }

            con.Close();
        }
    }
}