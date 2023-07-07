using MySql.Data.MySqlClient;
using static Gammis.ServerConnection;

namespace Gammis
{
    public  class ServerConnection
    {
        private readonly MySqlConnection server = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=db_gammis");

        public  MySqlConnection GetConnection
        {
            get { return server; }
        }

        public  void OpenConnect()
        {
            if (server.State == System.Data.ConnectionState.Closed)
            {
                GetConnection.Open();
            }
        }

        public  void CloseConnect()
        {
            if (server.State == System.Data.ConnectionState.Open)
            {
                GetConnection.Close();
            }
        }

    }
}
