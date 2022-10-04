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
            }catch(Exception e)
            {
                Console.WriteLine("Error al borrar el archivo, se creara el archivo igualmente");
            }
            using (StreamWriter escritor= new StreamWriter("Usuario.txt"))
            {
                escritor.WriteLine(s);
            }
        }
    }
}
