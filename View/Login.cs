using Bunifu.UI.WinForms;
using gammis;
using gammis.Routes;
using Gammis.Helpers;
using ServiceStack;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gammis
{
    public partial class Login : Form
    {
        private readonly AuthenticationHelper authHelper;

        [Obsolete]
        public Login()
        {
            InitializeComponent();
            timer1.Start();
            authHelper = new AuthenticationHelper();
            bunifuSnackbar1.Show(this, "Server connection initialized successfully!",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2000, "",
                Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [Obsolete]
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OnlineID.Text) || string.IsNullOrEmpty(Passcode.Text))
            {
                bunifuSnackbar1.Show(this, "Please fill all REQUIRED fields!",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 1000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                    Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
               
                return;
            }

        }

        [Obsolete]

        private void Login_Load(object sender, EventArgs e)
        {
            // Your code for the Login_Load event
            // This will be executed after the delay in LoginLoadTiming
        }

        private void Passcode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Passcode.Text))
            {
                SetPlaceholderText();
            }
        }

        private void SetPlaceholderText()
        {
            // Replace this placeholder text with whatever you want to show as a prompt.
            Passcode.PlaceholderText = "Enter Passcode";
            Passcode.PasswordChar = '\0'; // Reset PasswordChar to show the actual characters.

        }

        private void Passcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Password masking for added security
            Passcode.ForeColor = Color.White;
            Passcode.PasswordChar = '*';
        }

        private void OnlineID_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                string refcode = "";
                refcode = OnlineID.Text;
                bool isRefCodeAuthenticated = authHelper.RefCodeAuthenticate(refcode);
                if (isRefCodeAuthenticated)
                {
                    bunifuSnackbar1.Show(this, "Valid Online ID!",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 1000, "",
                        Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter,
                        Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);

                    WaitingMessage.ForeColor = Color.LightYellow;
                    WaitingMessage.Text = "Authentication Inprocess!";
                    LoginFailed.Visible = false;
                    LoginSuccess.Visible = true;
                    LoginSuccess.ForeColor = Color.LightYellow;
                }

                else
                {
                    WaitingMessage.ForeColor = Color.Red;
                    WaitingMessage.Text = "Something went wrong!";
                    SubmitAccount.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.ToString());
            }

        }
    }
}

