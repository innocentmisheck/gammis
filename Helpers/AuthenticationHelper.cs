using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gammis.Helpers
{
    internal class AuthenticationHelper
    {
        private readonly Authentication security = new Authentication();

        [Obsolete("Use newMethod instead", false)]

        public bool Authenticate(string username, string password)
        {
            return security.IDAuthentication(username, password);
        }
        [Obsolete("Use newMethod instead", false)]

        public Dashboard GetDashboard()
        {
            return new Dashboard();
        }

        public bool RefCodeAuthenticate(string refCode)
        {
            return security.RefCodeAuthentication(refCode);
        }
    }
}
