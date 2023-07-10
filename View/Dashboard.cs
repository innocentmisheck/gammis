using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Security;


namespace Gammis
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            bunifuSnackbar1.Show(this, "Welcome back at GAMMIS",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
            bunifuSnackbar1.Show(this, "Session manager initialized successfully!",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
            GameSessionTimer.Start();

            // Sample data
            for (int i = 0; i < 250; i++)
            {
                bunifuContentDataGridView2.Rows.Add(new object[]
                {
                    imageList1.Images[0]
                }); 
            }
        }
  
        private void LogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
  
        }

        private void ServerTimer_Tick(object sender, EventArgs e)
        {
            this.ServerTime.Text = DateTime.Now.ToString("HH:mm:ss");
            this.DateAndTime.Text = DateTime.Now.ToString("dddd | dd MMMM, yyyy");



        }

        private void GameSessionTimer_Tick(object sender, EventArgs e)
        {
            if (GameSessionTimer.Interval == 600000)
            {
                bunifuSnackbar1.Show(this, "Alert! Please check all gamers.",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Warning, 5000, "",
                Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                bunifuSnackbar1.Show(this, "Time out check-up!",
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 5000, "",
                Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                return;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Routes.HomePanelRoute.GoToHomePanel(bunifuPages1);
            AdsPanel.Visible = true;
            OperationsBar.Visible = false;
        }

        private void Gaming_Click(object sender, EventArgs e)
        {
            AdsPanel.Visible = false;
            OperationsBar.Visible = true;
            Routes.GamingPanelRoute.GoToGamingPanel(bunifuPages1);
            return;

        }

        private void Perfomance_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageName = "tabPage3";

        }

        private void FinacialControl_Click(object sender, EventArgs e)
        {
            bunifuPages1.PageName = "tabPage4";

        }

        private void GamersPanel_Click(object sender, EventArgs e)
        {
            Routes.GamingPanelRoute.GoToGamingPanel(bunifuPages1);

        }

        private void PayToPlay_Click(object sender, EventArgs e)
        {
            bunifuSnackbar1.Show(this, "Ready to handle the payment!",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
            bunifuPages1.PageName = "tabPage6";
            AdsPanel.Visible = true;
            OperationsBar.Visible = false;

        }

        private void PayToGame_Click(object sender, EventArgs e)
        {
            bunifuSnackbar1.Show(this, "Ready to handle the payment!",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 2000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
            bunifuPages1.PageName = "tabPage6";
        }

        private void PayToGame_MouseClick(object sender, MouseEventArgs e)
        {
            PayToGame.ForeColor = Color.FromArgb(0, 177, 64);
            return;
            
        }

        private void PayToGame_MouseHover(object sender, EventArgs e)
        {
            PayToGame.ForeColor = Color.FromArgb(0, 177, 64);
            return;
        }

        private void PayToGame_MouseLeave(object sender, EventArgs e)
        {

            PayToGame.ForeColor = Color.White;
            return;
        }


        private void SubmitToPreview_Click_1(object sender, EventArgs e)
        {

            Models Validation = new Models();
            Models Paymentslip = new Models();

            if (string.IsNullOrEmpty(GamerCenterIDTextBox.Text) || (string.IsNullOrEmpty(CashierID.Text)) || (string.IsNullOrEmpty(GameToPlayType.Text)) || (string.IsNullOrEmpty(BranchCode.Text)) || (string.IsNullOrEmpty(AuthenticationBox.Text)))
            {
                bunifuSnackbar1.Show(this, "Please fill all REQUIRED fields!",
                  Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 2000, "",
                  Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                  Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                return;

            }
            try
            {
                string gl_code = GameToPlayType.Text;

                if (Validation.GetGameTypeID(gl_code))
                {

                    bunifuSnackbar1.Show(this, "Gaming shift type FOUND, make payment immediately!",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                    Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Please check the Gaming shift type and try again!",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                    Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                }
            }
            catch (Exception err)
            {
                bunifuSnackbar1.Show(this, "Error" + err,
               Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 2000, "",
               Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
               Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
            }

            try
            {
                string code = BranchCode.Text;
                string staff_id = CashierID.Text;


                if (Validation.GetCodeBranchesAssign(code, staff_id))
                {

                    bunifuSnackbar1.Show(this, "Check the preview and make payment immediately!",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                    Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                }
                else
                {
                    bunifuSnackbar1.Show(this, "Please check the ONLINE IDs' and try again!",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 2000, "",
                    Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                    Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                }

            }
            catch (Exception err)
            {
                bunifuSnackbar1.Show(this, "Error =" + err,
                Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 2000, "",
                Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
                Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
            }
            finally
            {
               
                try
                {

                    string name = ""+CenterName.Text;
                    string code = CenterCode.Text;
                    string address = GamingType.Text;
                    string city = GamerID.Text;

                    if (Paymentslip.GetAllBranchesDetails(name, code, address, city))
                    {
                        bunifuSnackbar1.Show(this, "Paymentslip inprocess",
                        Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 6000, "",
                        Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomCenter,
                        Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                    }
                    else
                    {
                        bunifuSnackbar1.Show(this, "Failed to produce Paymentslip!",
                       Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 6000, "",
                       Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomCenter,
                       Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show("Error:" +err);
                }
                finally
                {
                    HideViewPaymentReview.Visible = false;
                    SubmitToPreview.Visible = false;
                    ResetForm.Visible = true;
                    MoneyPay.Visible = true;
                    SubmitIcon.IconChar = FontAwesome.Sharp.IconChar.Rotate;
                }

            }
        }


        private void ResetForm_Click(object sender, EventArgs e)
        {
            SetPlaceholderText();
            GameToPlayType.ResetText();
            GamerID.ResetText();
            BranchCode.ResetText();
            CashierID.ResetText();
            GamerCenterIDTextBox.ResetText();

            bunifuSnackbar1.Show(this, "Resetting form successfully!",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information, 2000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.BottomLeft,
            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner);
            HideViewPaymentReview.Visible = true;
            SubmitToPreview.Visible = true;
            ResetForm.Visible = false;
            MoneyPay.Visible = false;
            bunifuPages1.PageName = "tabPage6";
        }

      

        private void AuthenticationBox_Leave(object sender, EventArgs e)
        {
            if (AuthenticationBox.Text.Length == 0)
            {
                SetPlaceholderText();
            }
        }
        private void SetPlaceholderText()
        {
            // Replace this placeholder text with whatever you want to show as a prompt.
            AuthenticationBox.PlaceholderText = "Enter Passcode";
            AuthenticationBox.PasswordChar = '\0'; 
            // Reset PasswordChar to show the actual characters.
        }

        private void AuthenticationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Password masking for added security
            AuthenticationBox.ForeColor = Color.White;
            AuthenticationBox.PasswordChar = '*';
        }

        private void AddContent_Click(object sender, EventArgs e)
        {

        }

        private void AddContent2_Click(object sender, EventArgs e)
        {

        }

        private void Gaming2_Click(object sender, EventArgs e)
        {
            AdsPanel.Visible = false;
            OperationsBar.Visible = true;
            Routes.GamingPanelRoute.GoToGamingPanel(bunifuPages1);
            return;
        }

        private void Gaming2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
