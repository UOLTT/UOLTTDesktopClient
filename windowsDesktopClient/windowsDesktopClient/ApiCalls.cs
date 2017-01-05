using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsDesktopClient
{
    /// <summary>
    /// Enum used for stored API Calls
    /// </summary>
    public static class ApiCalls
    {
        public const string
            ShipList = "http://api.uoltt.org/api/v4/ships",
            ShipIndividual = "http://api.uoltt.org/api/v4/ships/",
            OrgList = "http://api.uoltt.org/api/v4/organizations",
            OrgIndividual = "http://api.uoltt.org/api/v4/organizations/",
            UserList = "http://api.uoltt.org/api/v4/users";
    }
}
