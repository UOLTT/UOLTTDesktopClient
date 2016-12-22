using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsDesktopClient.Classes
{
    public class Organisation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public int AdminUserId { get; set; }
        public int StatusId { get; set; }
        public string Manifesto { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public int UserCount { get; set; }
    }
}
