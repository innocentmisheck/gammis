using Gammis;
using Gammis.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace gammis.Routes
{
    internal class GetDashboardRoute
    {
        private readonly AuthenticationHelper authHelper;
        private readonly Form currentForm;

        [Obsolete]
        public GetDashboardRoute(Form form)
        {
            currentForm = form;
            authHelper = new AuthenticationHelper(); // Initialize the authHelper field
        }

        public void ShowDashboard()
        {
            // Show the Dashboard form
#pragma warning disable CS0618 // Type or member is obsolete
            Dashboard dashboard = authHelper.GetDashboard();
#pragma warning restore CS0618 // Type or member is obsolete
            dashboard.Show();

            // Close the current form
            CloseForm();
        }

        private void CloseForm()
        {
            currentForm.Close();
        }
    }
}
