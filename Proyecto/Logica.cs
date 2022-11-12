using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proyecto
{
    class Logica
    {
        public void Registro(string s)
        {
            try
            {
                File.Delete("Usuario.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al borrar el archivo, se creara el archivo igualmente");
            }
            using (StreamWriter escritor = new StreamWriter("Usuario.txt"))
            {
                escritor.WriteLine(s);
            }
        }
        public String Recibir()
        {
            String correo = null;
            using (StreamReader lector = new StreamReader("Usuario.txt"))
            {
                correo = lector.ReadLine();
            }
            return correo;
        }
       public void preferencias(String[] s)
        {

            try
            {
                File.Delete("Preferencias.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al borrar el archivo, se creara el archivo igualmente");
            }
            using (StreamWriter escritor = new StreamWriter("Preferencias.txt"))
            {
                foreach (String a in s)
                {
                    escritor.WriteLine(a);
                }
            }
        }
    }
    }
