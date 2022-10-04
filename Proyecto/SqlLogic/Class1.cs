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
        
        
    }
   
}
