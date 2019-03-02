using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class BaseConnection
    {
        public string GetConection()
        {
            //string cadenaConexion = "Server=S000-00;DataBase=ChinookSabado;User ID=sa; Password=sql;";
            string cadenaConexion = "Server=DANIEL-RAMOS\SQLEXPRESS;DataBase=ChinookSabado;User ID=DANIEL-RAMOS; Password=;";
            return cadenaConexion;
        }
    }
}
