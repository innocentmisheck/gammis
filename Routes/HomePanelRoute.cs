using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammis.Routes
{
    internal class HomePanelRoute
    {
        public static void GoToHomePanel(Bunifu.UI.WinForms.BunifuPages bunifuPages)
        {
            // Implement the logic to navigate to the Gaming Panel here
            // For example, you can set the desired page in the BunifuPages control

            // Example: Set the page name in BunifuPages control to "tabPage5"
            bunifuPages.PageName = "tabPage1";
        }
    }
}
