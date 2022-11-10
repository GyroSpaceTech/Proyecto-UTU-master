using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    internal class Class1
    {
        public MySqlCommand Obtener(String opciones, String tabla, MySqlConnection conect)
        {
            MySqlCommand com = new MySqlCommand("Select " + opciones + " from " + tabla + ";", conect);
            return com;
        }
        
        public MySqlCommand Buscar(String opciones, String tabla,String opcion , MySqlConnection conect)
        {
            MySqlCommand com = new MySqlCommand("Select "+opciones+" from "+ tabla +" where "+opcion+";",conect);
            return com;
        }
        

    }

   
}
