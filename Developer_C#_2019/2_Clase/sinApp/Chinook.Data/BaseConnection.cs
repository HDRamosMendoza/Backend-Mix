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
            //return "Server=S000-00;DataBase=ChinookSabado;User ID=sa; Password=sql;";
            return "Server=DANIEL-RAMOS\\SQLEXPRESS;DataBase=ChinookSabado;" +
                    "Password=administradorSQL; User ID=sa;";
        }
    }
}
