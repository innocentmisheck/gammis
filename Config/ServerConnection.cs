using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gammis
{
    internal class ServerConnection
    {
        readonly MySqlConnection server = new MySqlConnection("datasource = 127.0.0.1; port=3306; username = root; password = ; database = db_gammis");
        public MySqlConnection GetConnection
        {
            get { return server; }

        }
        public void OpenConnect()
        {
            if (server.State == System.Data.ConnectionState.Closed)
            {
                GetConnection.Open();
            }
           
        }
        public void CloseConnect()
        {
            if (server.State == System.Data.ConnectionState.Open)
            {
                GetConnection.Close();
            }
        }
    }
}
