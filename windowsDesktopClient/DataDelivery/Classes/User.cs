using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windowsDesktopClient.Classes
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Game_Handle { get; set; }
        public int? Organization_Id { get; set; }
        public int? Fleet_Id { get; set; }
        public int? Squad_Id { get; set; }
        public int? Station_Id { get; set; }
        public int? Active_Ship { get; set; }
        public Organization Organization { get; set; }
        public string Fleet { get; set; }
        public string Squad { get; set; }
        public List<Ship> Ships { get; set; }
    }
}
