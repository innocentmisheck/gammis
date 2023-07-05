using gammis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gammis
{
    public partial class Login : Form
    {
        readonly Authentication  security = new Authentication();
        public Login()
        {
            InitializeComponent();
            Validation.Start();
            bunifuSnackbar1.Show(this, "Server connection initialized successfully!",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);

        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OnlineID.Text)||(string.IsNullOrEmpty(Passcode.Text)))
            {
                  bunifuSnackbar1.Show(this, "Please fill all REQUIRED fields!",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information,1000,"",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                    Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                    return;

            }
            else
            {
                try
                {
                    
                   
                        string username = OnlineID.Text;
                        string password = Passcode.Text;
                        if (security.IDAuthentication(username, password))
                        {
                            bunifuSnackbar1.Show(this, "Please wait for validation!",
                            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 1000, "",
                            Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter,
                            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                            WaitingMessage.ForeColor = Color.White;
                            WaitingMessage.Text = "Authentication Inprocess!";
                            SubmitAccount.Visible = false;
                            LoginFailed.Visible = false;
                            LoginSuccess.IconColor = Color.DarkGreen;
                        }
                    
                        else
                        {
                            bunifuSnackbar1.Show(this, "Check the Password OR Online ID !",
                            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 1000, "",
                            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                            WaitingMessage.ForeColor = Color.White;
                            IDLoader.ForeColor = Color.White;
                            WaitingMessage.Text = "Something went wrong!";
                            SubmitAccount.Visible= false;
                            return; 
                        }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(this, "" + ex);
                }
                finally
                {
                    

                }


            }
          
        }

        private void Passcode_KeyPress(object sender, KeyPressEventArgs e)
        {
                // Password masking for added security
                Passcode.ForeColor = Color.White;
                Passcode.PasswordChar = '*';
        
        }

        private void Passcode_Leave(object sender, EventArgs e)
        {
            if (Passcode.Text.Length == 0)
            {
                SetPlaceholderText();
            }
        }
        private void SetPlaceholderText()
        {
            // Replace this placeholder text with whatever you want to show as a prompt.
            Passcode.PlaceholderText= "Enter Passcode";
            Passcode.PasswordChar = '\0'; // Reset PasswordChar to show the actual characters.
        }

        private void Validation_Tick(object sender, EventArgs e)
        {

            Validation.Interval = 1000;

            
                // Stop the timer
                Validation.Stop();

                // Show the Dashboard form
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                // Close the current form
                this.Close();

            // Start the timer
            Validation.Start();
        }
    }
}
