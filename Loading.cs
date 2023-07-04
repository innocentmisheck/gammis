using Bunifu.UI.WinForms;
using Gammis;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gammis
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();


        }



        public void Timer1_Tick(object sender, EventArgs e)
        {
            if(timer1.Interval <= 5000)
            {

                string ServerConnection = "datasource = 127.0.0.1; port=3306; username = root; password = ; database = db_gammis";

                try
                {
                    MySqlConnection connection = new MySqlConnection(ServerConnection);
                    connection.Open();
                    Login page = new Login();
                    page.Show();
                    this.Hide();
                    connection.Close();
                }

             

                catch (Exception)
                {
                    bunifuSnackbar1.Show(this, "Server connection initialization failed!",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 2000, "",
                        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                        Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);

                    bunifuSnackbar1.Show(this, "Check your internet connection!",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 2000, "",
                        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                        Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                }
                timer1.Enabled = false;
                timer1.Stop();
            }
            return;
        }
    }
}
