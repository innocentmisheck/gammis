using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammis
{
    internal class Authentication
    {
        readonly ServerConnection IDconnection = new ServerConnection();


        public bool IDAuthentication(string username, string password)
        {
            MySqlCommand command = new MySqlCommand("SELECT s.ref_code,sa.password FROM tbl_staff s JOIN tbl_staff_access sa ON s.staff_id = sa.staff_id WHERE s.ref_code = @username AND sa.password=@password", IDconnection.GetConnection);
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

            IDconnection.OpenConnect();
            MySqlDataReader reader = command.ExecuteReader();

            int result = 0;
            while(reader.Read()) 
            {
                result++;
            }
            if (result == 1)
            {
                IDconnection.CloseConnect();
                return true;
            }
            else
            {
                IDconnection.CloseConnect();
                return false;
            }
        }


    }
}
