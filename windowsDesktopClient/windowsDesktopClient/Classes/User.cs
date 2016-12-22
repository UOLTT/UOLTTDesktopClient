using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsDesktopClient.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? OrganisationId { get; set; }
        public int? FleedId { get; set; }
        public int? SquadId { get; set; }
        public int? StationId { get; set; }
        public int? ShipUserId { get; set; }
    }
}
