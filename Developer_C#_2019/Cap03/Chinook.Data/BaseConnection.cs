using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data
{
    public class BaseConnection
    {
        // Atributos
        private string server;
        private string database;
        private string password;
        private string user;

        // Constructor 1 - 2
        //public BaseConnection(
        //    string server, string database,
        //    string password, string user)
        //{
        //    Server = server;
        //    Database = database;
        //    Password = password;
        //    User = user;
        //}

        // Constructor 1 - 2
        //public BaseConnection()
        //{
        //    Server = "DANIEL-RAMOS\\SQLEXPRESS";
        //    Database = "ChinookSabado";
        //    Password = "administradorSQL";
        //    User = "sa";
        //}

        public string GetConection()
        {
            return  "Server=DANIEL-RAMOS\\SQLEXPRESS;DataBase=ChinookSabado;" +
                    "Password=administradorSQL; User ID=sa;";
        }

        //Propiedades
        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Password { get => password; set => password = value; }
        public string User { get => user; set => user = value; }
    }
}
