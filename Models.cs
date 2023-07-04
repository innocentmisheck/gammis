using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Gammis
{
    internal class Models
    {
         readonly ServerConnection Connection = new ServerConnection();
        
        public bool GetBranches(string code, string name, string city, string address)
        {
            MySqlCommand command = new MySqlCommand("SELECT b.branch_code, b.branch_name, c.city_name, b.address_line_1 FROM tbl_branches b JOIN tbl_cities c ON b.city = c.id;", Connection.GetConnection);
            command.Parameters.Add("@b.branch_code", MySqlDbType.VarChar).Value = code;
            command.Parameters.Add("@b.branch_name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@c.city_name", MySqlDbType.VarChar).Value = city;
            command.Parameters.Add("@b.address_line_1", MySqlDbType.VarChar).Value = address;



            Connection.OpenConnect();
            MySqlDataReader reader = command.ExecuteReader();

            int result = 0;
            while (reader.Read())
            {
                result++;
            }
            if (result == 1)
            {
                Connection.CloseConnect();
                return true;
            }
            else
            {
                Connection.CloseConnect();
                return false;
            }
        }


        public bool GetCodeBranchesAssign(string code, string staff_id)
        {
            MySqlCommand command = new MySqlCommand("SELECT tbl_staff.ref_code, tbl_staff_branch_assignment.branch_id FROM tbl_staff JOIN tbl_staff_branch_assignment ON tbl_staff.staff_id = tbl_staff_branch_assignment.staff_id JOIN tbl_staff_access ON tbl_staff.staff_id = tbl_staff_access.staff_id WHERE tbl_staff.ref_code = @staff_id AND tbl_staff_branch_assignment.branch_id= @branch_id;", Connection.GetConnection);
            command.Parameters.Add("@branch_id", MySqlDbType.String).Value = code;
            command.Parameters.Add("@staff_id", MySqlDbType.String).Value = staff_id;



            Connection.OpenConnect();
            MySqlDataReader reader = command.ExecuteReader();

            int result = 0;
            while (reader.Read())
            {
                result++;
            }
            if (result == 1)
            {
                Connection.CloseConnect();
                return true;
            }
            else
            {
                Connection.CloseConnect();
                return false;
            }
        }


        public bool GetGameTypeID(string code)
        {
            MySqlCommand command = new MySqlCommand("SELECT gl_code FROM tbl_chart_of_gaming_types WHERE gl_code = @gaming_code;", Connection.GetConnection);
            command.Parameters.Add("@gaming_code", MySqlDbType.String).Value = code;
         
            Connection.OpenConnect();
            MySqlDataReader reader = command.ExecuteReader();

            int result = 0;
            while (reader.Read())
            {
                result++;
            }
            if (result == 1)
            {
                Connection.CloseConnect();
                return true;
            }
            else
            {
                Connection.CloseConnect();
                return false;
            }
        }


        public bool GetAllBranchesDetails(string code, string name, string address, string city)
        {
            MySqlCommand command = new MySqlCommand("SELECT tbl_branches.branch_code, tbl_branches.branch_name,tbl_branches.address_line_1, tbl_cities.city_name FROM tbl_cities JOIN tbl_branches ON tbl_cities.id = tbl_branches.city WHERE tbl_branches.branch_code = @code AND  tbl_branches.branch_name = @name AND  tbl_branches.address_line_1 = @address AND  tbl_branches.city = @city;", Connection.GetConnection);
            command.Parameters.Add("@code", MySqlDbType.String).Value = code;
            command.Parameters.Add("@name", MySqlDbType.String).Value = name;
            command.Parameters.Add("@address", MySqlDbType.String).Value = address;
            command.Parameters.Add("@city", MySqlDbType.String).Value = city;


            Connection.OpenConnect();
            MySqlDataReader reader = command.ExecuteReader();

            int result = 0;
            while (reader.Read())
            {
                result++;
            }
            if (result == 1)
            {
                Connection.CloseConnect();
                return true;
            }
            else
            {
                Connection.CloseConnect();
                return false;
            }
        }
    }
}
